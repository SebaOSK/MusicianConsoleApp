using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musician
{
    internal class GuitarPlayer : Musician
    {
        public Guitar Guitar { get; set; }  
        public override void MusicianInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} is kicking it on his " +
                $"{Guitar.Manufacturer} {Guitar.Model} from {Guitar.YearOfProduction}\n");

        }
    }
}
