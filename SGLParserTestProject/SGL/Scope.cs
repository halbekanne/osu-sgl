using System;
using System.Collections.Generic;
using System.Text;
using SGL.Types;

namespace SGL
{
    public class Scope
    {
        private Scope parent;
        private Dictionary<String, Value> variables;// = new Dictionary<String, SGLValue>();
        private int offset = 0;
        //private List<SpriteObject> spriteObjects = null;

        public Scope()
        {
            // only for the global scope, the parent is null  
            parent = null;
            variables = new Dictionary<String, Value>();
        }

        public int GetOffset() {
            return offset;
        }

        public void AddOffset(int offset)
        {
            //this.offset = parent.GetOffset();
            //Console.WriteLine("parent offset: " + parent.GetOffset());
            this.offset = parent.GetOffset();
            this.offset += offset;
            //Console.WriteLine("Set offset in scope " + getParentNumber() + " to " + this.offset);
        }

        public void ClearOffset()
        {
            this.offset = 0;
        }

        public Scope(Scope p)
        {
            parent = p;
            variables = new Dictionary<String, Value>();
            //offset = p.GetOffset();
            //Console.WriteLine("Create new scope " + getParentNumber() + " with offset " + this.offset + " parent offset " + p.GetOffset());
            //Console.WriteLine("Parent offset in " + getParentNumber() + " was " + offset);
        }

        public void Assign(String var, Value value)
        {
            if (Resolve(var) != null)
            {
                // There is already such a variable, re-assign it
                this.ReAssign(var, value);
            }
            else
            {
                //if (IsGlobalScope()) Console.WriteLine("This is the global scope year!");
                // A newly declared variable  
                variables.Add(var, value);
            }
        }

        public Scope Copy()
        {
            // Create a shallow copy of this scope. Used in case functions are  
            // recursively called. If we wouldn't create a copy in such cases,  
            // changing the variables would result in changes to the Maps from  
            // other "recursive scopes".  
            Scope s = new Scope();
            s.variables = new Dictionary<String, Value>(this.variables);
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

        private void ReAssign(String identifier, Value value)
        {
            if (variables.ContainsKey(identifier))
            {
                variables[identifier] = value;

                // The variable is declared in this scope
                /*SGLValue oldValue;
                variables.TryGetValue(identifier, out oldValue);
                String type = oldValue.GetVarType();
                if (type.Equals("int"))
                {
                    if (value.IsInteger())
                    {
                        variables[identifier] = value;
                    }
                    else if (value.IsFloat())
                    {
                        // Convert float expression to int
                        variables[identifier] = new SGLValue((int)Math.Floor(value.AsFloat()));
                    }
                    else
                    {
                        throw new SGLCompilerException(-1, "type mismatch", "You can't assign an expression of type " + value.GetVarType() + " to an integer variable");
                    }
                }
                else if (type.Equals("float"))
                {
                    if (value.IsNumber())
                    {
                        variables[identifier] = value;
                    }
                    else
                    {
                        throw new SGLCompilerException(-1, "type mismatch", "You can't assign an expression of type " + value.GetVarType() + " to a float variable");
                    }
                }
                else if (type.Equals("boolean"))
                {
                    if (value.IsBoolean())
                    {
                        variables[identifier] = value;
                    }
                    else
                    {
                        throw new SGLCompilerException(-1, "type mismatch", "You can't assign an expression of type " + value.GetVarType() + " to a boolean variable");
                    }
                }
                else if (type.Equals("string"))
                {
                    if (value.IsString())
                    {
                        variables[identifier] = value;
                    }
                    else
                    {
                        throw new SGLCompilerException(-1, "type mismatch", "You can't assign an expression of type " + value.GetVarType() + " to a string variable");
                    }
                }
                else if (type.Equals("Object"))
                {
                    if (value.IsObject())
                    {
                        // Add this object to the spriteObjects before the reassignment, so it don't get lost
                        spriteObjects.Add(variables[identifier].AsObject());
                        variables[identifier] = value;
                    }
                    else
                    {
                        throw new SGLCompilerException(-1, "type mismatch", "You can't assign an expression of type " + value.GetVarType() + " to an object variable");
                    }
                }
                else
                {
                    throw new SGLCompilerException(-1, "unknown type", "Unknown variable type (" + type + ")");
                }*/
                
            }
            else if (parent != null)
            {
                // The variable was not declared in this scope, so let  
                // the parent scope re-assign it  
                parent.ReAssign(identifier, value);
            }
        }


        public Value Resolve(String var)
        {
            Value value;
            variables.TryGetValue(var, out value);
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
            variables = new Dictionary<String, Value>();
        }


        public List<SpriteObject> GetObjects()
        {
            List<SpriteObject> objects = new List<SpriteObject>();
            foreach (KeyValuePair<String,Value> pair in variables)
            {
                //Console.WriteLine("1: " + pair.Key);
                if (pair.Value.GetType().Equals("Object"))
                {
                    try
                    {
                        //Console.WriteLine(2);
                        objects.Add(pair.Value.AsObject());
                    }
                    catch (CompilerException sce)
                    {
                        if (sce.ErrorType.Equals("undeclared object"))
                        {
                            sce.Message = pair.Key;
                            throw sce;
                        }
                    }
                }
                else if (pair.Value.GetType().Equals("list"))
                {
                    // checks if objects are in that list or in nested lists
                    objects.AddRange(getObjectsFromList(pair.Value));
                }
            }

            return objects;

        }


        private List<SpriteObject> getObjectsFromList(Value listPointer)
        {
            // recursively checks if any object is in the list or any nested lists
            List<SpriteObject> objects = new List<SpriteObject>();
            foreach (Value item in listPointer.AsList())
            {
                if (item.GetType().Equals("Object"))
                {
                    objects.Add(item.AsObject());
                }
                else if (item.GetType().Equals("list"))
                {
                    objects.AddRange(getObjectsFromList(item));
                }
            }
            return objects;
        }


        /*
        public void SetSpriteObjects(List<SpriteObject> spriteObjects)
        {
            this.spriteObjects = spriteObjects;
        }*/
    }
}
