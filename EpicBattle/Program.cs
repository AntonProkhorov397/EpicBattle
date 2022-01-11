using System;
using System.IO;
namespace EpicBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\Users\opilane\samples\";
            string[] heroes = GetDataFromFiles(rootPath + "heroes.txt");
            string[] villians = GetDataFromFiles(rootPath + "villians.txt");
            string[] weapons = GetDataFromFiles(rootPath + "weapons.txt");
            //string[] heroes = { "Travis Scotch", "Scooby-Doo", "Sponge Bob", "Patrick" };
            //string[] villians = { "Plankton", "Hitler", "Nigga from Ghetto", "Mall Security", "That guy" };

            Console.WriteLine($"Your random hero is {randomHero}");
            Console.WriteLine($"Your random hero weapon is {heroweapon}");
            Console.WriteLine($"Your random villian is {randomvillian}");
            Console.WriteLine($"Your random  villian weapon is {villiansweapon}");

        }

        public static string[] GetDataFromFiles(string filepath)
        {
            string[] datafromFile = File.ReadAllLines(filepath);
            return datafromFile;

        }
    }
}
