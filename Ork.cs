using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1_0
{
    class Ork : Personage
    {
        private int Jump_Shot;
        public int J_Shot
        {
            get { return Jump_Shot; }
            set { this.Jump_Shot = value; }
        }

        public Ork() { }

        public Ork(string Name_Person, int Health_Person, int Attack_Damage, int Critical, int Jump_Shot)
            : base(Name_Person, Health_Person, Attack_Damage, Critical)
        {
            this.Jump_Shot = J_Shot;
        }

        public override int Attack()
        {
            if (Jump_Shot > 30)
            {
                Critical_Attack();
                Console.WriteLine("CRITICAL HIT!");
            }
            return base.Attack();
        }

        public override void ToPrint()
        {
            base.ToPrint();
            Console.WriteLine($"Defence: {Jump_Shot}");
            Thread.Sleep(1000);
        }
    }
}
