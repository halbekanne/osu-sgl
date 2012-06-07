using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Tests
{
    class Tester
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
            foreach (AbstractTest test in tests) {
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
