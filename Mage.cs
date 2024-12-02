using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1_0
{
    class Mage : Personage
    {

        private int Spell;
        public int Spell_G_S
        {
            get { return Spell; }
            set { this.Spell = value; }
        }
        public Mage() { }

        public Mage(string Name_Person, int Health_Person, int Attack_Damage,int Critical, int Defence_Spell) : base(Name_Person, Health_Person, Attack_Damage, Critical)
        {
            this.Spell = Defence_Spell;
        }

        public override int Attack()
        {
            if (Spell > 30)
            {
                Critical_Attack();
                Console.WriteLine("CRITICAL HIT!");
            }
            return base.Attack();
        }

        public override void ToPrint()
        {
            base.ToPrint();
            Console.WriteLine($"\t\t\t\t\t\tSpell: {Spell}");
            Thread.Sleep(1000);
        }
    }
}
