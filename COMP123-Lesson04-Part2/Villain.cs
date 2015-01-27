using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lesson04_Part2
{
    class Villain : Hero
    {
        //private properties+++++++++++
        private string name;

        // constructor+++++++++++++++++++
        public Villain(string name, int health, int smarts, string gender):
            base(health,smarts,gender)
        {
            this.name = name;

        }

        //public method+++++++++++++++++++++
        public void doesBodThings()
        {
            Console.WriteLine("{0} Doin' bod things....YEAH!",this.name);
        }
    }
}
