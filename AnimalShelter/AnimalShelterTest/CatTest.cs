using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalShelter;

namespace AnimalShelterTest
{
    [TestClass]
    public class CatTest
    {
        SimpleDate date = new SimpleDate(12, 12, 1999);
        [TestMethod]
        public void NullBadHabitsMeansNoBadHabits()
        {
            Cat cat = new Cat(38, date, "Henk", null);
            Assert.AreEqual("", cat.BadHabits);
        }

        [TestMethod]
        public void ToStringCheck()
        {
            Cat cat = new Cat(38, date, "Henk", "flopt 'em kooi");
            Assert.AreEqual("Cat: Henk, 12-12-1999, 38, flopt 'em kooi.", cat.ToString());
        }

        [TestMethod]
        public void ConstructorTest()
        {
            Cat cat = new Cat(38, date, "Henk", "flopt 'em kooi");
            Assert.AreEqual(38, cat.ChipRegistrationNumber);
            Assert.AreEqual(date, cat.DateOfBirth);
            Assert.AreEqual("Henk", cat.Name);
            Assert.AreEqual("flopt 'em kooi", cat.BadHabits);
        }
    }
}

