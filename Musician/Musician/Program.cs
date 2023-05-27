using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Musician
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Musician> listOfMusicians = new List<Musician>();

            bool newEntry = true;
            
            while(newEntry)
            {
                Console.Clear();
                Console.WriteLine("Do you wish to add info about a: guitar player, drummer or a bass player?)");
                string musician = Console.ReadLine();

                if (musician.ToLower() == "guitar player")
                {
                    GuitarPlayer guitarPlayer = new GuitarPlayer();

                    Console.WriteLine("What is his first name?");
                    guitarPlayer.FirstName = Console.ReadLine();

                    Console.WriteLine("What is his last name?");
                    guitarPlayer.LastName = Console.ReadLine();

                    Console.WriteLine("When was he born? (DD.MM.YYYY)");
                    guitarPlayer.DOB = DateOnly.ParseExact(Console.ReadLine(), "dd.MM.yyyy");

                    Console.WriteLine("Who made his guitar?");
                    guitarPlayer.Guitar = new Guitar() { Manufacturer = Console.ReadLine() };

                    Console.WriteLine("What model is it?");
                    guitarPlayer.Guitar.Model = Console.ReadLine();

                    Console.WriteLine("When was it made?");
                    guitarPlayer.Guitar.YearOfProduction = Convert.ToInt32(Console.ReadLine());

                    listOfMusicians.Add(guitarPlayer);
                }

                else if (musician.ToLower() == "drummer")
                {
                    DrumPlayer drumPlayer = new DrumPlayer();

                    Console.WriteLine("What is his first name?");
                    drumPlayer.FirstName = Console.ReadLine();

                    Console.WriteLine("What is his last name?");
                    drumPlayer.LastName = Console.ReadLine();

                    Console.WriteLine("When was he born? (DD.MM.YYYY)");
                    drumPlayer.DOB = DateOnly.ParseExact(Console.ReadLine(), "dd.MM.yyyy");

                    Console.WriteLine("Who made his drum?");
                    drumPlayer.Drum = new Drum() { Manufacturer = Console.ReadLine() };

                    Console.WriteLine("What model is it?");
                    drumPlayer.Drum.Model = Console.ReadLine();

                    Console.WriteLine("When was it made?");
                    drumPlayer.Drum.YearOfProduction = Convert.ToInt32(Console.ReadLine());

                    listOfMusicians.Add(drumPlayer);

                }

                else if (musician.ToLower() == "bass player")
                {
                    BassPlayer bassPlayer = new BassPlayer();

                    Console.WriteLine("What is his first name?");
                    bassPlayer.FirstName = Console.ReadLine();

                    Console.WriteLine("What is his last name?");
                    bassPlayer.LastName = Console.ReadLine();

                    Console.WriteLine("When was he born? (DD.MM.YYYY)");
                    bassPlayer.DOB = DateOnly.ParseExact(Console.ReadLine(), "dd.MM.yyyy");

                    Console.WriteLine("Who made his bass guitar?");
                    bassPlayer.Bass = new Bass() { Manufacturer = Console.ReadLine() };

                    Console.WriteLine("What model is it?");
                    bassPlayer.Bass.Model = Console.ReadLine();

                    Console.WriteLine("When was it made?");
                    bassPlayer.Bass.YearOfProduction = Convert.ToInt32(Console.ReadLine());

                    listOfMusicians.Add(bassPlayer);
                }

                else 
                {
                    Console.WriteLine("Sorry... didn't quite get that...did you say GUITAR PLAYER or DRUMMER or BASS PLAYER??");
                }

                Console.WriteLine("Do you wish to add another musician? (y/n)");
                string choice = Console.ReadLine().ToLower();

                if (choice != "y")
                {newEntry = false;}
            }
            Console.Clear();
            Console.WriteLine("Do you wish to see info about your idols and what instruments they are playing? (y/n)");
            string answer = Console.ReadLine();

            if (answer.ToLower() == "y")
            {
                foreach (Musician item in listOfMusicians)
                {
                    item.MusicianInfo();
                };
            }
            else
            {
                Console.WriteLine("Thank you and Have a Nice Day!!");
            };

            Console.ReadLine();
        }
    }
}
