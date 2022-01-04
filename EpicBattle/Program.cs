using System;

namespace EpicBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] heroes = { "Dr.Strange", "Hog Rider", "Buster", "Leon" };
            string[] villains = { "Nekoglai", "Putin", "IvanZolo2004", "Spike", "SoloZola", "SergejSimonov" };

            

            
            string randomHero = GetRandomCharacter(heroes);
            string randomVillain = GetRandomCharacter(villains);
            string heroWeapon = GetWeapon();
            string villainWeapon = GetWeapon();
            Console.WriteLine($"Your random hero is {randomHero}");
            Console.WriteLine($"Your random villain is {randomVillain}");
            Console.WriteLine($"{randomHero} with {heroWeapon} will fight {randomVillain} with {villainWeapon}");
        }

        public static string GetRandomCharacter(string[] someArray)
        {
            return someArray[GetRandomIndexForArray(someArray)];
        }
        public static string GetWeapon()
        {
            string[] weapon = { "Big pencil", "Molot", "Arm", "Intelect" };
            return weapon[GetRandomIndexForArray(weapon)];
        }
        public static int GetRandomIndexForArray(string[] someArray)
        {
            Random rnd = new Random();
            return rnd.Next(0, someArray.Length);
        }
    }
}
