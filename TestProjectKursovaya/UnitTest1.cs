using System.Diagnostics.Metrics;
using System.Security.Cryptography;
using ÊÓÐÑÀ×;

namespace TestProjectKursovaya
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void TestStandartDif()
        {
            int[] testarr = { 5, 3, 2, 4, 5 };
            HeapSort test = new HeapSort();
            int[,] actual = test.sort(testarr);
            int[,] expected = { { 5, 4, 2, 3, 5 }, { 4, 3, 2, 5, 5 }, { 3, 2, 4, 5, 5 }, { 2, 3, 4, 5, 5 }, { 2, 3, 4, 5, 5 }, };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestBestDif()
        {
            int[] testarr = { 1, 2, 3, 4, 5 };
            HeapSort test = new HeapSort();
            int[,] actual = test.sort(testarr);
            int[,] expected = { { 4, 2, 3, 1, 5 }, { 3, 2, 1, 4, 5 }, { 2, 1, 3, 4, 5 }, { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 } };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestMinus()
        {
            int[] testarr = { 5, -3, 2, 4, -5 };
            HeapSort test = new HeapSort();
            int[,] actual = test.sort(testarr);
            int[,] expected = { { 4, -3, 2, -5, 5 }, { 2, -3, -5, 4, 5 }, { -3, -5, 2, 4, 5 }, { -5, -3, 2, 4, 5 }, { -5, -3, 2, 4, 5 }, };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestZero()
        {
            int[] testarr = { };
            HeapSort test = new HeapSort();
            int[,] actual = test.sort(testarr);
            Assert.IsNull(actual);
        }

        [Test]
        public void RandGen()
        {
            int a = 5;
            int b = 0;
            int c = 100;
            RandGeneration RG = new RandGeneration();
            int[] arr = RG.RandGen(a, b, c);
            Assert.IsNotNull(arr);
        }
    }
}