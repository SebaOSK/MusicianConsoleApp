using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musician
{
    public abstract class Musician
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly DOB { get; set; }
        public string MusicGroup { get; set; }

        public abstract void MusicianInfo();

    }
}
