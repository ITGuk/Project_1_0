using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1_0
{
    class Knight : Personage
    {
        private int Defence;
        public int Deff_G_S
        {
            get { return Defence; }
            set { this.Defence = value; }
        }

        public Knight() { }

        public Knight(string Name_Person, int Health_Person, int Attack_Damage, int Critical, int Defence_s)
            : base(Name_Person, Health_Person, Attack_Damage, Critical)
        {
            this.Defence = Deff_G_S;
        }

        public override int Attack()
        {
            if (Defence > 30)
            {
                Critical_Attack();
                Console.WriteLine("CRITICAL HIT!");
            }
            return base.Attack();
        }

        public override void ToPrint()
        {
            base.ToPrint();
            Console.WriteLine($"\t\t\t\t\t\tDefence: {Defence}");
            Thread.Sleep(1000);
        }
    }
}
