using System;
using System.Collections.Generic;
using System.Text;

namespace SGLOld.SGLUnit
{
    public class UnitTester
    {

        private List<Unit> units = new List<Unit>();

        private void InitUnits()
        {

            // Sprite initialisation tests
            units.Add(new Unit("Sprite initialisation #1", "Object o = new Sprite(\"test.png\");", "Sprite,Foreground,Centre,\"test.png\",320,240"));
            units.Add(new Unit("Sprite initialisation #2", "Object o = new Sprite(0, \"test.png\");", "Sprite,Foreground,Centre,\"test.png\",320,240"));
            units.Add(new Unit("Sprite initialisation #3", "Object o = new Sprite(0, \"test.png\", Background);", "Sprite,Background,Centre,\"test.png\",320,240"));
            units.Add(new Unit("Sprite initialisation #4", "Object o = new Sprite(0, \"test.png\", Fail, TopLeft);", "Sprite,Fail,TopLeft,\"test.png\",320,240"));

            // Expression testing
            units.Add(new Unit("Expressions - Addition", "println(7+5);", "12"));
            units.Add(new Unit("Expressions - Adding Strings", "println(\"test \" + 3.5);", "test 3.5"));
            units.Add(new Unit("Expressions - Subtraction", "println(7-5);", "2"));
            units.Add(new Unit("Expressions - Multiplication", "println(7*5);", "35"));
            units.Add(new Unit("Expressions - Division (Int)", "println(7/5);", "1"));
            units.Add(new Unit("Expressions - Division (Float)", "println(7/5.0);", "1.4"));
            units.Add(new Unit("Expressions - Negate #1", "println(-5);", "-5"));
            units.Add(new Unit("Expressions - Negate #2", "println(-(5+4));", "-9"));
            units.Add(new Unit("Expressions - Comparison <", "println(1<2);", "True"));
            units.Add(new Unit("Expressions - Comparison <=", "println(2<=2);", "True"));
            units.Add(new Unit("Expressions - Comparison >", "println(2>2);", "False"));
            units.Add(new Unit("Expressions - Comparison >=", "println(2>=2);", "True"));
            units.Add(new Unit("Expressions - Comparison !=", "println(1!=2);", "True"));
            units.Add(new Unit("Expressions - Comparison ==", "println(2==2);", "True"));
            units.Add(new Unit("Expressions - Comparison ||", "println(false || true);", "True"));
            units.Add(new Unit("Expressions - Comparison &&", "println(true && false);", "False"));
            units.Add(new Unit("Expressions - Short If ( ? : )", "println(3 > 4 ? 1 : 2);", "2"));
            units.Add(new Unit("Expressions - Complex Case", "println(3 > 4 ? 1 : 3*(5+4)%6/-(8-1.0));", "-0.428571428571429"));

            // Variable handling
            units.Add(new Unit("Variable - Integer #1", "int a = 2; \r\n println(a);", "2"));
            units.Add(new Unit("Variable - Integer #2", "int a; \r\n println(a);", "0"));
            units.Add(new Unit("Variable - Integer #3", "int a; \r\n a = 2; \r\n println(a);", "2"));
            units.Add(new Unit("Variable - Float #1", "float a = 1.5; \r\n println(a);", "1.5"));
            units.Add(new Unit("Variable - Float #2", "float a; \r\n println(a);", "0"));
            units.Add(new Unit("Variable - Float #3", "float a; \r\n a = 1.5; \r\n println(a);", "1.5"));
            units.Add(new Unit("Variable - Boolean #1", "boolean a = true; \r\n println(a);", "True"));
            units.Add(new Unit("Variable - Boolean #2", "boolean a; \r\n println(a);", "False"));
            units.Add(new Unit("Variable - Boolean #3", "boolean a; \r\n a = true; \r\n println(a);", "True"));
            units.Add(new Unit("Variable - String #1", "string a = \"test\"; \r\n println(a);", "test"));
            units.Add(new Unit("Variable - String #2", "string a; \r\n println(a);", ""));
            units.Add(new Unit("Variable - String #3", "string a; \r\n a = \"test\"; \r\n println(a);", "test"));

            // IF-Statements
            units.Add(new Unit("If-Statements & Blocks #1 ", "if (3 > 2) println(2);", "2"));
            units.Add(new Unit("If-Statements & Blocks #2", "if (3 > 2) { \r\n println(2); \r\n println(1); \r\n }", "2\r\n1"));
            units.Add(new Unit("If-Statements & Blocks #3", "if (3 < 2) println(1); \r\n else if (3 > 2) println(2);", "2"));
            units.Add(new Unit("If-Statements & Blocks #4", "if (3 < 2) { \r\n println(1); \r\n } \r\n else if (3 > 2) { \r\n println(2); \r\n println(1); \r\n }", "2\r\n1"));
            units.Add(new Unit("If-Statements & Blocks #5", "if (3 < 2) println(1); \r\n else if (3 == 2) println(2); \r\n else println(3); ", "3"));
            units.Add(new Unit("If-Statements & Blocks #6", "if (3 < 2) { \r\n println(1); \r\n } \r\n else if (3 == 2) { \r\n println(2); \r\n println(1); \r\n } \r\n else { \r\n println(3); \r\n println(4); \r\n }", "3\r\n4"));


        }
        
        public void RunTests()
        {
            InitUnits();

            int passed = 0;
            int failed = 0;

            foreach (Unit unit in units)
            {
                if (unit.RunTest())
                {
                    Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=~> Test " + unit.GetName() + ": Ok <~=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                    passed++;
                }
                else
                {
                    Console.WriteLine("X=X=X=X=X=X=X=X=X=X=X=X=X=X=X=X=X=X=X=X=X=X=X=X=X=X=X=X=~> Test " + unit.GetName() + ": FAILED!!! <~=X=X=X=X=X=X=X=X=X=X=X=X=X=X=X=X=X=X=X=X=X=X=X=X=X=X=X=X");
                    Console.WriteLine("Input:" + unit.GetInput());
                    Console.WriteLine("Expected: " + unit.GetOutput());
                    Console.WriteLine("But was: " + unit.GetRealOutput());
                    failed++;
                }

            }

            Console.WriteLine("Testing finished: " + units.Count + " tests done, " + passed + " passed, " + failed + " failed.");






        }


    }
}
