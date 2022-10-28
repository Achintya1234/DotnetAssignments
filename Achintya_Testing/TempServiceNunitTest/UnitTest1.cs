using Achintya_Testing;
using NUnit;
namespace TempServiceNunitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CTFTest1()
        {
            double expected = 32;
            double actual = TempService.CTF(0);
            Assert.True(Math.Abs(actual - expected) <= 0.0001);
        }

        [Test]
        public void CTFTest2()
        {
            double expected = -40;
            double actual = TempService.CTF(-30);
            Assert.False(Math.Abs(actual - expected) <= 0.0001);
        }

        [Test]
        public void FTCTest1()
        {
            double expected = 0;
            double actual = TempService.FTC(32);
            Assert.True(Math.Abs(actual - expected) <= 0.0001);
        }

        [Test]
        public void FTCTest2()
        {
            double expected = -40;
            double actual = TempService.FTC(-30);
            Assert.False(Math.Abs(actual - expected) <= 0.0001);
        }
    }
}