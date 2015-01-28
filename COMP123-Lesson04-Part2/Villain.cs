using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lesson04_Part2
{
    class Villain : Character
    {
        //private properties+++++++++++
        private bool greed = true;

        // constructor+++++++++++++++++++
        public Villain(string name, int health, int smarts, string gender):
            base(name,health,smarts,gender)
        {
            

        }

        //public method+++++++++++++++++++++
        public void doesBodThings()
        {
            Console.WriteLine("{0} Doin' bod things....YEAH!",this.name);
        }
    }
}
