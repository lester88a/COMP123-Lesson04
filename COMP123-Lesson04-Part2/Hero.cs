using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lesson04_Part2
{
    class Hero
    {
        //creat private properties+++++++++++++++++++++++++++++++++
        private bool bravery = true;
        private int health;
        private int smarts;
        private string gender;


        //constructor++++++++++++++++++++++++++++++++++++++++++++
        public Hero(int health, int smarts, string gender)
        {
            this.health = health;
            this.smarts = smarts;
            this.gender = gender;
        }

        //public methods
        public void doesGoodThings()
        {
            Console.WriteLine("Doin' good things....YEAH!");
        }
    }
}
