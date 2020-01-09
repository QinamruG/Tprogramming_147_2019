using System;
using Xunit;

namespace RPG.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void PlayerConstructorTest()
        {
            Player Play = new Wizard();
            Assert.Equal($"Чародей", Play.PClass);
        }

        [Fact]
        public void TestFight()
        {
            Player Player1 = new Knight();
            Player Player2 = new Archer();
            while (Player1.Health > 0 && Player2.Health > 0)
            {
                Player1.Attack(Player2);
                Player2.Attack(Player1);
            }
            if (Player1.Health > 0 && Player2.Health > 0)
            {
                Assert.True(true);
            }
        }

        [Fact]
        public void TestWizardSkill()
        {
            Player Wizard = new Wizard();
            Player Player2 = new Archer();
            Wizard.Skill(Player2);
            Assert.True(Player2.Euthanasia);
        }
        [Fact]
        public void TestArcherSkill()
        {
            Player Wizard = new Wizard();
            Player Archer = new Archer();
            Archer.Skill(Wizard);
            Assert.True(Wizard.Debuff);
        }

        [Fact]
        public void DamageTest()
        {
            Player Player1 = new Knight();
            Player Player2 = new Archer();
            int health = Player1.Health;
            Player2.Attack(Player1);
            Assert.True(health > Player1.Health);
        }
    }
}
