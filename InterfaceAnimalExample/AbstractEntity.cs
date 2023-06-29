using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAnimalExample
{
    //Klassen könen mehrere Interfaces erben und müssen as abstract deklariert werden
    public abstract class AbstractEntity : IEntity, IDisposable
    {
        //base Constructor, default Wert ist 10
        protected AbstractEntity(int health = 10)
        {
            this.health = health;
        }

        //deklarieren von Variablen
        private int health;

        //Methode aus dem Interface
        public int GetHealth()
        {
            return health;
        }
        //Methode aus dem inteface wird via abstract weiter nach oben gegeben
        public abstract string GetName();

        //Überschreiben der Equalsmethode
        public override bool Equals(object? obj)
        {
            //obj darf nicht null sein und muss den gleichen type wie die biden zu vergleichenden objekte besitzen
            if (obj != null && this.GetType() == obj.GetType())
            {
                //vergleicht nun noch ob die beiden objekte sich nicht nur von der Struktur gleich sein sonder ob diese ebenso die gleichen werte besitzen
                return this.health == ((AbstractEntity)obj).health;
            }
            
            return false;
        }

        //Überschreiben der hashcode methode damit sowohl Equals als auch die hashcode methode nach dem gleichen Prinzip funktionieren
        public override int GetHashCode()
        {
            Console.WriteLine(this.GetType());
            Console.WriteLine(this.GetType().GetHashCode());
            return HashCode.Combine(this.GetType(), health);
        }

        //Dispose ist eine Methode zum aufräumen von instanzen
        public void Dispose()
        {
            
        }
    }
}
