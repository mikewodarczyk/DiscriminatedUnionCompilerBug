using Microsoft.VisualStudio.TestTools.UnitTesting;

#nullable enable

namespace DiscriminatedUnion.Test
{
    [TestClass]
    public class SuclassOneOfTest
    {
        [TestMethod]
        public void TestClassAOrClassB()
        {
            ClassA obja = new ClassA(1);
            ClassB objb = new ClassB("xyzzy");           
            Assert.AreNotEqual(obja, objb);

            ClassAOrClassB var = new ClassAOrClassB(obja);

            Assert.IsNotNull((ClassA?)var is ClassA);
            Assert.IsFalse((ClassB?)var is ClassB);

            ClassA? avar = var;
            Assert.IsNotNull(avar);

            ClassB? bvar = var;
            Assert.IsNull(bvar);
        }

        [TestMethod]
        public void TestClassCOrClassD()
        {
            ClassC objc = new ClassC(1);
            ClassD objd = new ClassD("xyzzy");
            Assert.AreNotEqual(objc, objd);

            ClassCOrClassD var = new ClassCOrClassD(objc);

            Assert.IsNotNull((ClassC?)var is ClassC);
            Assert.IsFalse((ClassD?)var is ClassD);

            ClassC? avar = var;
            Assert.IsNotNull(avar);

            ClassD? bvar = var;
            Assert.IsNull(bvar);
        }
    }
}
