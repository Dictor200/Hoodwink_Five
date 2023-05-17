using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace hoodwink
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";
            Console.WriteLine(hello + " " + world);
            Console.ReadKey();
            int a = 9;
            int b = 5;
            int plus = a + b;
            int minus = a - b;
            int umnozhenie = a * b;
            int delenie = a / b;
            Console.WriteLine("a + b =" + plus);
            Console.WriteLine("a - b =" + minus);
            Console.WriteLine("a * b =" + umnozhenie);
            Console.WriteLine("a / b =" + delenie);
            Console.ReadKey();
            Console.WriteLine("Введите ваше имя");
            string imy = Console.ReadLine();
            Console.WriteLine("Введете вашу фамиию");
            string fam = Console.ReadLine();
            Console.WriteLine("Введите ваше оттчемтво");
            string och = Console.ReadLine();
            Console.WriteLine("Ваше полное имя - " + fam + " " + imy + " " + och);
            Console.ReadKey();
            int xp_hum = 100;
            int damage_hum = 40;
            int armor_hum = 60;

            int xp_mon = 200;
            int damage_mon = 20;
            int armor_mon = 1;

            double xp_mon1 = damage_hum / armor_mon;
            double xp_mon2 = xp_mon - xp_mon1;

            double xp_hum1 = damage_mon / armor_hum;
            double xp_hum2 = xp_hum - xp_hum1;

            Console.WriteLine("Здоровье человека: " + xp_hum2);
            Console.WriteLine("Человек нанёс монстру " + xp_hum1 + " урона.");

            Console.WriteLine("Здоровье монстра: " + xp_mon2);
            Console.WriteLine("Монстр нанёс человеку " + xp_mon1 + " урона.");
            Console.ReadKey();
        }
    }
}

        
