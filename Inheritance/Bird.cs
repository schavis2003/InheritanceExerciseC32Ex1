using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal // I set the Bird class to inherit from my Animal class (: Animal)---DONE
    {
        public Bird() //I created a Class called Bird ---------DONE
        {
            IsAlive= true;
            LegCount = 2;
            LandSeaAir = "Air";
            Age = 0;
        }

        public string WingColor { get; set; }   
        public bool CanFly { get; set; }
        public bool WillMigrate { get; set; }
        public double BeakLength { get; set; }
    }
}
