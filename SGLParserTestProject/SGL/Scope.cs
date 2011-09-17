using System;
using System.Collections.Generic;
using System.Text;

namespace SGL
{
    public class Scope
    {
        private Scope parent;
        private Dictionary<String, SGLValue> varValues;// = new Dictionary<String, SGLValue>();
        private Dictionary<String, String> varTypes;
        private int offset = 0;
        private List<SGLObject> spriteObjects = null;

        public Scope()
        {
            // only for the global scope, the parent is null  
            parent = null;
            varValues = new Dictionary<String, SGLValue>();
            varTypes = new Dictionary<String, String>();
        }

        public int GetOffset() {
            return offset;
        }

        public void AddOffset(int offset)
        {
            this.offset = parent.GetOffset();
            this.offset += offset;
            Console.WriteLine("Set offset in scope " + getParentNumber() + " to " + this.offset);
        }

        public Scope(Scope p)
        {
            parent = p;
            varValues = new Dictionary<String, SGLValue>();
            varTypes = new Dictionary<String, String>();
            Console.WriteLine("Parent offset in " + getParentNumber() + " was " + offset);
        }

        public void Assign(String var, SGLValue value, Boolean newVar, String type)
        {
            if (Resolve(var) != null)
            {
                if (newVar) throw new Exception("There is already such a variable");
                // There is already such a variable, re-assign it
                this.ReAssign(var, value);
            }
            else
            {
                if (!newVar) throw new Exception("The variable " + var + " doesn't exists.");
                if (IsGlobalScope()) Console.WriteLine("This is the global scope year!");
                // A newly declared variable  
                varValues.Add(var, value);
                varTypes.Add(var, type);
            }
        }

        public Scope Copy()
        {
            // Create a shallow copy of this scope. Used in case functions are  
            // recursively called. If we wouldn't create a copy in such cases,  
            // changing the variables would result in changes to the Maps from  
            // other "recursive scopes".  
            Scope s = new Scope();
            s.varValues = new Dictionary<String, SGLValue>(this.varValues);
            return s;
        }

        public Boolean IsGlobalScope()
        {
            return parent == null;
        }

        public Scope Parent()
        {
            return parent;
        }

        public int getParentNumber()
        {
            Scope current = this;
            int parentNum = 0;
            while (current.parent != null)
            {
                parentNum++;
                current = current.parent;
            }
            return parentNum;

        }

        private void ReAssign(String identifier, SGLValue value)
        {
            if (varValues.ContainsKey(identifier))
            {
                // The variable is declared in this scope
                String type = varTypes[identifier];
                if (type.Equals("int"))
                {
                    if (value.IsInteger())
                    {
                        varValues[identifier] = value;
                    }
                    else if (value.IsFloat())
                    {
                        // Convert float expression to int
                        varValues[identifier] = new SGLValue((int)Math.Floor(value.AsFloat()));
                    }
                    else
                    {
                        throw new Exception("Can't assign " + value.ToString() + " to an integer variable");
                    }
                }
                else if (type.Equals("float"))
                {
                    if (value.IsNumber())
                    {
                        varValues[identifier] = value;
                    }
                    else
                    {
                        throw new Exception("Can't assign " + value.ToString() + " to a float variable");
                    }
                }
                else if (type.Equals("boolean"))
                {
                    if (value.IsBoolean())
                    {
                        varValues[identifier] = value;
                    }
                    else
                    {
                        throw new Exception("Can't assign " + value.ToString() + " to a boolean variable");
                    }
                }
                else if (type.Equals("string"))
                {
                    if (value.IsString())
                    {
                        varValues[identifier] = value;
                    }
                    else
                    {
                        throw new Exception("Can't assign " + value.ToString() + " to a string variable");
                    }
                }
                else if (type.Equals("Object"))
                {
                    if (value.IsObject())
                    {
                        // Add this object to the spriteObjects before the reassignment, so it don't get lost
                        spriteObjects.Add(varValues[identifier].AsObject());
                        varValues[identifier] = value;
                    }
                    else
                    {
                        throw new Exception("Can't assign " + value.ToString() + " to a string variable");
                    }
                }
                
            }
            else if (parent != null)
            {
                // The variable was not declared in this scope, so let  
                // the parent scope re-assign it  
                parent.ReAssign(identifier, value);
            }
        }


        public SGLValue Resolve(String var)
        {
            SGLValue value;
            varValues.TryGetValue(var, out value);
            if (value != null)
            {
                // The variable resides in this scope  
                return value;
            }
            else if (!IsGlobalScope())
            {
                // Let the parent scope look for the variable  
                return parent.Resolve(var);
            }
            else
            {
                // Unknown variable  
                return null;
            }
        }


        public void ClearVariables()
        {
            varValues = new Dictionary<String, SGLValue>();
            varTypes = new Dictionary<String, String>();
        }


        public List<SGLObject> GetObjects()
        {
            List<SGLObject> objects = new List<SGLObject>();
            foreach (KeyValuePair<String,String> pair in varTypes)
            {
                if (pair.Value.Equals("Object"))
                {
                    try
                    {
                        objects.Add(varValues[pair.Key].AsObject());
                    }
                    catch (SGLCompilerException sce)
                    {
                        if (sce.ErrorType.Equals("undeclared object"))
                        {
                            sce.Message = pair.Key;
                            throw sce;
                        }
                    }
                }
            }

            return objects;

        }




        public void SetSpriteObjects(List<SGLObject> spriteObjects)
        {
            this.spriteObjects = spriteObjects;
        }
    }
}
