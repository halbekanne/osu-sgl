using SGL.Elements;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SGLTestProject
{
    
    
    /// <summary>
    ///Dies ist eine Testklasse für "ScopeTest" und soll
    ///alle ScopeTest Komponententests enthalten.
    ///</summary>
    [TestClass()]
    public class ScopeTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Ruft den Testkontext auf, der Informationen
        ///über und Funktionalität für den aktuellen Testlauf bietet, oder legt diesen fest.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Zusätzliche Testattribute
        // 
        //Sie können beim Verfassen Ihrer Tests die folgenden zusätzlichen Attribute verwenden:
        //
        //Mit ClassInitialize führen Sie Code aus, bevor Sie den ersten Test in der Klasse ausführen.
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Mit ClassCleanup führen Sie Code aus, nachdem alle Tests in einer Klasse ausgeführt wurden.
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Mit TestInitialize können Sie vor jedem einzelnen Test Code ausführen.
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Mit TestCleanup können Sie nach jedem einzelnen Test Code ausführen.
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion
        Scope main;
        Scope sub;
        Scope subsub;

        public ScopeTest()
        {
            main = new Scope();
            sub = new Scope(main);
            subsub = new Scope(sub);
        }

        /// <summary>
        ///Ein Test für "HasParent"
        ///</summary>
        [TestMethod()]
        public void HasParentTest()
        {
            Assert.IsFalse(main.HasParent());
            Assert.IsTrue(sub.HasParent());
            Assert.IsTrue(subsub.HasParent());
        }

        /// <summary>
        ///Ein Test für "Parent"
        ///</summary>
        [TestMethod()]
        public void ParentTest()
        {
            Assert.AreEqual(sub.Parent, main);
            Assert.AreEqual(subsub.Parent, sub);
            Assert.AreEqual(subsub.Parent.Parent, main);
            Assert.AreEqual(main.Parent, null);
        }

        /// <summary>
        ///Ein Test für "CountParents"
        ///</summary>
        [TestMethod()]
        public void CountParentsTest()
        {
            Assert.AreEqual(main.CountParents(), 0);
            Assert.AreEqual(sub.CountParents(), 1);
            Assert.AreEqual(subsub.CountParents(), 2);
        }

        /// <summary>
        ///Ein Test für "Clear"
        ///</summary>
        [TestMethod()]
        public void ClearTest()
        {
            Scope target = new Scope();
            target.Define("x");
            target.Assign("x", new Value(4, ValType.Integer));
            Scope targetSub = new Scope(target);
            target.Clear();
            Assert.AreEqual(target.Resolve("x"), null);
            Assert.AreEqual(targetSub.Resolve("x"), null);

            target.Define("a");
            target.Assign("a", new Value(5, ValType.Integer));
            targetSub.Define("b");
            targetSub.Assign("b", new Value(5, ValType.Integer));
            targetSub.Clear();
            Assert.AreEqual(targetSub.Resolve("b"), null);
            Assert.AreEqual(targetSub.Resolve("a"), new Value(5, ValType.Integer));
        }

        /// <summary>
        ///Ein Test für "Define"
        ///</summary>
        [TestMethod()]
        public void DefineTest()
        {
            Scope target = new Scope();
            target.Define("a");
            Scope targetSub = new Scope(target);
            targetSub.Define("b");
            Assert.AreEqual(target.Resolve("a"), Value.NULL);
            Assert.AreEqual(targetSub.Resolve("a"), Value.NULL);
            Assert.AreEqual(targetSub.Resolve("b"), Value.NULL);

            try
            {
                targetSub.Define("b");
                Assert.Fail("Not checked if was already defined in scope");
            }
            catch (CompilerException ex)
            {
                if (ex.ErrorCode != 219) Assert.Fail("Wrong error");
            }

            try
            {
                targetSub.Define("a");
                Assert.Fail("Not checked if was already defined in parent scope");
            }
            catch (CompilerException ex)
            {
                if (ex.ErrorCode != 219) Assert.Fail("Wrong error");
            }
        }

        /// <summary>
        ///Ein Test für "Assign"
        ///</summary>
        [TestMethod()]
        public void AssignTest()
        {
            Scope target = new Scope();
            Scope targetSub = new Scope(target);
            try
            {
                target.Assign("a", new Value(4,ValType.Integer));
                Assert.Fail("Not checked if variable was defined before assigning");
            }
            catch (CompilerException ex)
            {
                if (ex.ErrorCode != 218) Assert.Fail("Wrong error");
            }
            target.Define("a");
            target.Assign("a", new Value(4, ValType.Integer));
            Assert.AreEqual(target.Resolve("a"), new Value(4, ValType.Integer));
            Assert.AreEqual(targetSub.Resolve("a"), new Value(4, ValType.Integer));
            targetSub.Assign("a", new Value(5, ValType.Integer));
            Assert.AreEqual(target.Resolve("a"), new Value(5, ValType.Integer));
            Assert.AreEqual(targetSub.Resolve("a"), new Value(5, ValType.Integer));
            targetSub.Define("b");
            targetSub.Assign("b", new Value("hallo", ValType.String));
            Assert.AreEqual(targetSub.Resolve("b"), new Value("hallo", ValType.String));
            Scope targetSubSub = new Scope(targetSub);
            Assert.AreEqual(targetSubSub.Resolve("b"), new Value("hallo", ValType.String));
        }
    }
}
