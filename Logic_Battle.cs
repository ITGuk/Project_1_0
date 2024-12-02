using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Project_1_0
{
    class Logic_Battle
    {
        public Logic_Battle() {}
        public void Battle()
        {
            Mage mage = new Mage("Mage", 100, 7, 6, 15);
            Ork ork = new Ork("Ork", 100, 3, 6, 4);
            Knight knight = new Knight();
            knight.Name = "Knight";
            knight.Health = 100;
            knight.Damage = 12;
            knight.Critical = 15;
            knight.Deff_G_S = 10;

            bool check_battle = true; //Поки true буде продовжуватись бій//



            while (check_battle)
            {
                TPrint.Welcome_To_Area_text();

                    Console.WriteLine($"\n\t\t\t\t\t\t\tChoose a hero: \n" +
                        $"\t\t\t\t\t1 - Knight.\n\t\t\t\t\t2 - Mage.\n\t\t\t\t\t3 - Ork.");


                ConsoleKeyInfo change_player = Console.ReadKey();
                if (change_player.KeyChar == '1')
                {
                    Console.WriteLine("\n\t\t\t\t\tYou Player: \n");
                    knight.ToPrint();
                    Console.WriteLine("\n");
                    Console.WriteLine($"\t\t\t\t\tYou Enemy: {mage.Name}\n");
                    mage.ToPrint();
                    Console.WriteLine("\n");
                    TPrint.Battle_text();
                    while (knight.Health >= 0 && mage.Health >= 0)
                    {
                        knight.Attack();
                        mage.Attack();

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"{knight.Name} Health: {knight.Health}");
                        Thread.Sleep(600);
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{mage.Name} Health: {mage.Health}\n");
                        Thread.Sleep(600);
                        Console.ResetColor();

                    }

                    check_battle = false;
                }

                if (change_player.KeyChar == '2')
                    {
                        Console.WriteLine("\n\t\t\t\t\tYou Player: \n");
                        mage.ToPrint();
                        Console.WriteLine("\n");
                        Console.WriteLine($"\t\t\t\t\tYou Enemy: {knight.Name}\n");
                        knight.ToPrint();
                        Console.WriteLine("\n");
                        TPrint.Battle_text();
                    while (knight.Health >= 0 && mage.Health >= 0)
                        {

                            mage.Attack();
                            knight.Attack();

                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine($"{mage.Name} Health: {mage.Health}");
                            Thread.Sleep(600);  
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"{knight.Name} Health: {knight.Health}\n");
                            Thread.Sleep(600);
                            Console.ResetColor();

                        }

                    check_battle = false;
                    }

                if (change_player.KeyChar == '3')
                {
                    Console.WriteLine("\n\t\t\t\t\tYou Player: \n");
                    ork.ToPrint();
                    Console.WriteLine("\n");
                    Console.WriteLine($"\t\t\t\t\tYou Enemy: {mage.Name}\n");
                    mage.ToPrint();
                    Console.WriteLine("\n");
                    TPrint.Battle_text();
                    while (ork.Health >= 0 && mage.Health >= 0)
                    {

                        ork.Attack();
                        mage.Attack();

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"{ork.Name} Health: {ork.Health}");
                        Thread.Sleep(600);
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{mage.Name} Health: {mage.Health}\n");
                        Thread.Sleep(600);
                        Console.ResetColor();

                    }

                    check_battle = false;
                }


            }
        }
    }
    
}

//Console.WriteLine("Press name you Hero: ");
//hero.Name = Console.ReadLine();