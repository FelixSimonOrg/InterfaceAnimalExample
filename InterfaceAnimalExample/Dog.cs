using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAnimalExample
{
    public class Dog : AbstractEntity
    {
        //dog erbt von abstractEntity, über den Constructor wird über base(3) der Constructor von der AbstractEntity aufgerufen.
        public Dog():base(3)
        {
        }
        public override string GetName()
        {
            return nameof(Dog);
        }
    }
}
