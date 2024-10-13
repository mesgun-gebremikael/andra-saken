using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace andra_saken
{
    internal class Animal
    {
        public int Weight { get; set; }

        public bool Noctural { get; set; }

        public Animal(int weight, bool noctural)
        {
            Weight = weight;
            Noctural = noctural;


        }
        public virtual void Move(bool day)
        {
            // inget händer ned den måste finnas
        }

    }

    class Owl : Animal
    {

        
        


        public int Wingspan { get; set; }

        public Owl(int weight, bool noctural, int wingspan) : base(weight, noctural)
        {


            Wingspan = wingspan;

        }
      
       public override void Move(bool day)
        {
            if (Noctural == true && day == false)
            {
                Console.WriteLine("Ugglan flyger blad träden!");
            }
            else
            {
                Console.WriteLine("Ugglan sover i trädet");
            }
        }

    }

    class Horse : Animal
    {
        public int HayPerDay { get; set; } 

         public Horse(int weight, bool nocturnal, int hayperDay) : base(weight, nocturnal)
         {
            HayPerDay = hayperDay;
         }
        public override void Move(bool day)
        {
            if (Noctural == false && day == true)
            {
                Console.WriteLine("Hästen galopperar.");
            }
            else
            {
                Console.WriteLine("Hästen sover under ett träd");
            }
        }
    }

    class Dolphin : Animal
    {
        public int DistancePerDay { get; set; }

        public Dolphin(int weight, bool norcturnal, int distancePerDay)
            : base(weight, norcturnal)
        {
            DistancePerDay = distancePerDay;

        }
 

        public virtual void Move(bool day)
        {
            // inget händer ned den måste finnas
        }

        
    }    
}