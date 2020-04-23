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
                Fight.Attack(Player2,Player1);
                Fight.Attack(Player1,Player2);
            }
            if (Player1.Health > 0 && Player2.Health > 0)
            {
                Assert.True(true);
            }
        }
        [Fact]
        public void TestReturnToBasic()
        {
            var player = new Knight();
            var hp = player.Health;
            player.Health -= 20;
            player.ReturnToBasic();
            Assert.Equal(hp, player.Health);
        }
    }
}
