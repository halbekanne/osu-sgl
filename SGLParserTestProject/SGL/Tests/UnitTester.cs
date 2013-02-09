//  Storyboard Generation Language
//  Copyright (C) 2013 Dominik Halfkann
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
using System;
using System.Collections.Generic;

namespace SGL.Tests
{
    public class UnitTester
    {
        private readonly List<Unit> units = new List<Unit>();

        private void InitUnits()
        {
            // Sprite initialisation tests
            /*units.Add(new Unit("Sprite initialisation #1", "var o = new Sprite(\"test.png\");", "Sprite,Foreground,Centre,\"test.png\",320,240", true));
            units.Add(new Unit("Sprite initialisation #2", "var o = new Sprite(0, \"test.png\");", "Sprite,Foreground,Centre,\"test.png\",320,240", true));
            units.Add(new Unit("Sprite initialisation #3", "var o = new Sprite(0, \"test.png\", Background);", "Sprite,Background,Centre,\"test.png\",320,240", true));
            units.Add(new Unit("Sprite initialisation #4", "var o = new Sprite(0, \"test.png\", Fail, TopLeft);", "Sprite,Fail,TopLeft,\"test.png\",320,240", true));*/

            // Expression testing
            units.Add(new Unit("Expressions - Addition", "println(7+5);", "12", true));
            units.Add(new Unit("Expressions - Adding Strings", "println(\"test \" + 3.5);", "test 3.5", true));
            units.Add(new Unit("Expressions - Subtraction", "println(7-5);", "2", true));
            units.Add(new Unit("Expressions - Multiplication", "println(7*5);", "35", true));
            units.Add(new Unit("Expressions - Division (Int)", "println(7/5);", "1", true));
            units.Add(new Unit("Expressions - Division (Float)", "println(7/5.0);", "1.4", true));
            units.Add(new Unit("Expressions - Negate #1", "println(-5);", "-5", true));
            units.Add(new Unit("Expressions - Negate #2", "println(-(5+4));", "-9", true));
            units.Add(new Unit("Expressions - Comparison <", "println(1<2);", "True", true));
            units.Add(new Unit("Expressions - Comparison <=", "println(2<=2);", "True", true));
            units.Add(new Unit("Expressions - Comparison >", "println(2>2);", "False", true));
            units.Add(new Unit("Expressions - Comparison >=", "println(2>=2);", "True", true));
            units.Add(new Unit("Expressions - Comparison !=", "println(1!=2);", "True", true));
            units.Add(new Unit("Expressions - Comparison ==", "println(2==2);", "True", true));
            units.Add(new Unit("Expressions - Comparison ||", "println(false || true);", "True", true));
            units.Add(new Unit("Expressions - Comparison &&", "println(true && false);", "False", true));
            units.Add(new Unit("Expressions - Short If ( ? : )", "println(3 > 4 ? 1 : 2);", "2", true));
            units.Add(new Unit("Expressions - Complex Case", "println(3 > 4 ? 1 : 3*(5+4)%6/-(8-1.0));",
                               "-0.428571428571429", true));

            // Variable handling
            units.Add(new Unit("Variable - null", "var a; \r\n println(a);", "null", true));
            units.Add(new Unit("Variable - Integer #1", "var a = 2; \r\n println(a);", "2", true));
            units.Add(new Unit("Variable - Integer #3", "var a; \r\n a = 2; \r\n println(a);", "2", true));
            units.Add(new Unit("Variable - Float #1", "var a = 1.5; \r\n println(a);", "1.5", true));
            units.Add(new Unit("Variable - Float #3", "var a; \r\n a = 1.5; \r\n println(a);", "1.5", true));
            units.Add(new Unit("Variable - Boolean #1", "var a = true; \r\n println(a);", "True", true));
            units.Add(new Unit("Variable - Boolean #3", "var a; \r\n a = true; \r\n println(a);", "True", true));
            units.Add(new Unit("Variable - String #1", "var a = \"test\"; \r\n println(a);", "test", true));
            units.Add(new Unit("Variable - String #3", "var a; \r\n a = \"test\"; \r\n println(a);", "test", true));

            // IF-Statements
            units.Add(new Unit("If-Statements & Blocks #1 ", "if (3 > 2) println(2);", "2", true));
            units.Add(new Unit("If-Statements & Blocks #2", "if (3 > 2) { \r\n println(2); \r\n println(1); \r\n }",
                               "2\r\n1", true));
            units.Add(new Unit("If-Statements & Blocks #3", "if (3 < 2) println(1); \r\n else if (3 > 2) println(2);",
                               "2", true));
            units.Add(new Unit("If-Statements & Blocks #4",
                               "if (3 < 2) { \r\n println(1); \r\n } \r\n else if (3 > 2) { \r\n println(2); \r\n println(1); \r\n }",
                               "2\r\n1", true));
            units.Add(new Unit("If-Statements & Blocks #5",
                               "if (3 < 2) println(1); \r\n else if (3 == 2) println(2); \r\n else println(3); ", "3",
                               true));
            units.Add(new Unit("If-Statements & Blocks #6",
                               "if (3 < 2) { \r\n println(1); \r\n } \r\n else if (3 == 2) { \r\n println(2); \r\n println(1); \r\n } \r\n else { \r\n println(3); \r\n println(4); \r\n }",
                               "3\r\n4", true));
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
                    Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=~> Test " +
                                      unit.GetName() + ": Ok <~=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                    passed++;
                }
                else
                {
                    Console.WriteLine("X=X=X=X=X=X=X=X=X=X=X=X=X=X=X=X=X=X=X=X=X=X=X=X=X=X=X=X=~> Test " +
                                      unit.GetName() +
                                      ": FAILED!!! <~=X=X=X=X=X=X=X=X=X=X=X=X=X=X=X=X=X=X=X=X=X=X=X=X=X=X=X=X");
                    Console.WriteLine("Input:" + unit.GetInput());
                    Console.WriteLine("Expected: " + unit.GetOutput());
                    Console.WriteLine("But was: " + unit.GetRealOutput());
                    failed++;
                }
            }

            Console.WriteLine("Testing finished: " + units.Count + " tests done, " + passed + " passed, " + failed +
                              " failed.");
        }
    }
}