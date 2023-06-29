using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;

namespace InterfaceAnimalExample
{
    public class Cat : AbstractEntity
    {
        //cat erbt von AbstractEntity und übergibt an desen base Construtor den Wert 7 als health.
        public Cat():base(7)
        {
        }

        //Möglichkeit variablen der instanzen zu deklarieren 
        //private int health = 7;
        //public int GetHealth()
        //{
        //    health--;
        //    return health;
        //}

        public override string GetName()
        {
            //name of Klasse
            return nameof(Cat);
        }


        //Möglichkeit zum Überschreiben der == & != Operatoren
        //public static bool operator ==(Cat o1, object? o2)
        //{
        //    //return health == 0;
        //    return true;
        //}
        //public static bool operator !=(Cat o1, object? o2)
        //{
        //    return true;
        //}
    }
}
