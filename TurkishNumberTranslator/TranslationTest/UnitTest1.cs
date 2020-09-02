using NUnit.Framework;
using TurkishNumberTranslator;

namespace TranslationTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            int[] exampleInputs = new int[] { 1, 13, 27, 38, 77, 94 };
            string[] exampleOutputs = new string[] { "bir", "on üç", "yirmi yedi", "otuz sekiz", "yetmiş yedi", "doksan dört" };

            for (int i = 0; i < exampleInputs.Length; i++)
                Assert.AreEqual(exampleOutputs[i], Translator.GetTurkishNumber(exampleInputs[i]));
        }
    }
}