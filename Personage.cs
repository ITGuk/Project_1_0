using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1_0
{
    class Personage
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }
        public int Critical { get; set; }

        public Personage() { }

        public virtual int Attack()
        {
            return Health -= Damage;
        }

        public int Critical_Attack()
        {    
            return Health -= 50;
        }

        public Personage(string Name_Person, int Health_Person, int Attack_Damage, int Critical)
        {
            this.Name = Name_Person;
            this.Health = Health_Person;
            this.Damage = Attack_Damage;
            this.Critical = Critical;
        }

        public virtual void ToPrint()
        {
            Console.WriteLine($"\t\t\t\t\t\tName: {Name}");
            Console.WriteLine($"\t\t\t\t\t\tHealth: {Health}");
            Console.WriteLine($"\t\t\t\t\t\tDamage: {Damage}");
            Console.WriteLine($"\t\t\t\t\t\tCritical Hit Chance: {Critical}");
            //Thread.Sleep(1000);
        }

    }

}
