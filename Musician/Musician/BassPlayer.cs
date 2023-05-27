using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musician
{
    internal class BassPlayer : Musician
    {
        public Bass Bass { get; set; }
        public override void MusicianInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} is kicking it on his " +
                $"{Bass.Manufacturer} {Bass.Model} from {Bass.YearOfProduction}\n");

        }
    }
}
