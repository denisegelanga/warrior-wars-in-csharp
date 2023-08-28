using WarriorWars.Enum;

namespace WarriorWars
{
    class EntryPoint
    {
        static Random rnd = new Random();
        static void Main()
        {
            Warrior goodGuy = new Warrior("Pre", Faction.GoodGuy);
            Warrior badGuy = new Warrior("Joel", Faction.BadGuy);

            while (goodGuy.IsAlive && badGuy.IsAlive)
            {
                if (rnd.Next(0,10) < 5)
                {
                    goodGuy.Attack(badGuy);

                }
                else
                {
                    badGuy.Attack(goodGuy);
                }

                Thread.Sleep(100);
            }
        }
    }
}