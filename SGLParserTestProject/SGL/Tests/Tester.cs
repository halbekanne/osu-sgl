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
    internal class Tester
    {
        private List<AbstractTest> tests;

        public Tester()
        {
            RegisterTests();
        }

        private void RegisterTests()
        {
            // add tests here
        }

        public void RunTests()
        {
            int testNum = 0, passed = 0, failed = 0;
            foreach (AbstractTest test in tests)
            {
                Console.Write("Running test '" + test.Name + "'... ");
                bool result = test.Run();
                if (result)
                {
                    Console.WriteLine("passed.");
                    passed++;
                }
                else
                {
                    Console.WriteLine("failed!");
                    Console.WriteLine(test.Result);
                    failed++;
                }
                testNum++;
            }
            Console.WriteLine(testNum + " tests were done, " + passed + " passed, " + failed + " failed.");
        }
    }
}