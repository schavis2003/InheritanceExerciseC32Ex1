using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal // I set the Repile class to inherit from the Animal Class (: Animal)
    {
        public Reptile() // I create a new class call Reptile ---------DONE
        {
            IsAlive = true;
            LegCount = 4;
            LandSeaAir = "Land";
            Age = 0;

        }
        public bool IsColdBlooded { get; set; }  // give this class 4 members that all Reptiles have in common--------DONE
        public bool IsScaly { get; set; }
        public string Habitat { get; set; }
        public bool CanGrowTail { get; set; }

    }
}
