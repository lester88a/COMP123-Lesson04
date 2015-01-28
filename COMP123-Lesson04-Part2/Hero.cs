using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lesson04_Part2
{
    //Hero subclass or character super class
    class Hero:Character
    {
        //creat private properties+++++++++++++++++++++++++++++++++
        private bool bravery = true;
   


        //constructor++++++++++++++++++++++++++++++++++++++++++++
        public Hero(string name,int health, int smarts, string gender):base(name,health,smarts,gender)
        {
            this.showProfile();
        }

        //public methods
        public void doesGoodThings()
        {
            Console.WriteLine("Doin' good things....YEAH!");
        }
    }
}
