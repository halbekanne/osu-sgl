using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.SGLUnit
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
