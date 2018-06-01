using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace vgp232_Assignment5
{
    [TestFixture]
    class UnitTest
    {
        [TestCase]
        void TakeDamage()
        {
            Character.Character c = new Character.Character(100, Character.Races.Dwarf, Character.Alignments.ChaoticEvil);
            c.TakeDamage(50);
            Assert.AreEqual(50, c.HealthPoints);
        }

        [TestCase]
        void RestoreHealth()
        {
            Character.Character c = new Character.Character(50, Character.Races.Dwarf, Character.Alignments.ChaoticEvil);
            c.RestoreHealth(50);
            Assert.AreEqual(100, c.HealthPoints);
        }
    }
}
