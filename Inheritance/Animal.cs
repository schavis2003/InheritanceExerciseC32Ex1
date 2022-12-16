using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{   // TODO Be sure to follow best practice when creating your classes

    // give this class 4 members that all Animals have in common
    public class Animal  //I created a Class called Animal----------DONE
    {
        public Animal() // give this class 4 members that all Animals have in common--------DONE
        {
        }
        public bool IsAlive { get; set; }
        public int Age { get; set; }
        public int LegCount { get; set; }   
        public string LandSeaAir { get; set; }

    }
}
