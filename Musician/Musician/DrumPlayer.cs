using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musician
{
    internal class DrumPlayer : Musician
    {
        public Drum Drum { get; set; }
        public override void MusicianInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} is kicking it on his " +
                $"{Drum.Manufacturer} {Drum.Model} from {Drum.YearOfProduction}\n");

        }
    }
}
