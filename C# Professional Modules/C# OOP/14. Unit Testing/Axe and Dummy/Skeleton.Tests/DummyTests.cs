using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        private Dummy dummy;
        [SetUp]
        public void SetUp()
        {
            dummy = new Dummy(5, 2);
        }
        [Test]
        public void NewDummy_SouldSetDataCorrectly()
        {
            Assert.AreEqual(dummy.Health, 5);
        }
        [Test]
        public void TakeAttack_ShouldLowerHelath()
        {
            dummy.TakeAttack(3);
            Assert.AreEqual(dummy.Health, 2);
        }
        [Test]
        public void TakeAttack_WhenDead()
        {
            dummy.TakeAttack(6);
            Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(7));
        }
        [Test]
        public void GiveExperience_WhenNotDead()
        {
            Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
        }
        [Test]
        public void GiveExperience_WhenDead_ShouldWork()
        {
            dummy.TakeAttack(5);
            Assert.AreEqual(dummy.GiveExperience(),2);
        }
    }
}