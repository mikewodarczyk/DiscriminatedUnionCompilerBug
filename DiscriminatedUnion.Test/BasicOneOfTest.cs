using Microsoft.VisualStudio.TestTools.UnitTesting;

#nullable enable

namespace DiscriminatedUnion.Test
{
    [TestClass]
    public class BasicOneOfTest
    {
        [TestMethod]
        public void TestClassAOrClassB()
        {
            ClassA obja = new ClassA(1);
            ClassB objb = new ClassB("xyzzy");           
            Assert.AreNotEqual(obja, objb);

            OneOf<ClassA, ClassB> var = new OneOf<ClassA, ClassB>(obja);

            Assert.IsNotNull((ClassA?)var is ClassA);
            Assert.IsFalse((ClassB?)var is ClassB);

            ClassA? avar = var;
            Assert.IsNotNull(avar);

            ClassB? bvar = var;
            Assert.IsNull(bvar);
        }
    }
}
