using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_ATM
{
    class Comand
    {
        public void Do()
        {
            int[] card_numbers = {1, 2, 3};
            int[] pin_numbers = {123, 234, 456};
            int[] balance = {500, 200, 800};
            while (true)
            {
                Console.WriteLine("-------------------<% Welcome to E-Atm %>-------------------");
                Console.WriteLine();
                Console.WriteLine("Sample progam behavior");
                Console.Write("What is your card number : ");
                int c_numb = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                   
                bool card_test = false, pin_test = false;
                int i;
                for (i = 0; i < card_numbers.Length; i++)
                {
                    if (card_numbers[i] == c_numb)
                    {
                        card_test = true;
                        break;
                    }
                }

                if (card_test == true)
                {
                    Console.Write("What is your pin code : ");
                    int pin = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    if (pin_numbers[i] == pin)
                    {
                        pin_test = true;
                     }

                    if (pin_test == true)
                    {
                        Console.WriteLine("For show your balance type 1\nFor withdraw money type 2\nFor exit type 3");
                        int num = Convert.ToInt32(Console.ReadLine());
                        if (num == 1)
                        {
                            Console.Write("Enter your amount : ");
                            int amnt = Convert.ToInt32(Console.ReadLine());
                            if (amnt > 1000)
                            {
                                Console.WriteLine("The amount is more than 1000");
                                amnt = Convert.ToInt32(Console.ReadLine());
                            }
                            else if (balance[i] < amnt && amnt>=1000)
                            {
                                Console.WriteLine("The amount is high try less");
                                amnt = Convert.ToInt32(Console.ReadLine());
                            }
                            else
                            {
                                balance[i] -= amnt;
                                Console.WriteLine("Cash withdrawal successful. Your account balance is {0}", balance[i]);
                                Console.WriteLine("If you want to try again then type true else type false");
                                bool trie = Convert.ToBoolean(Console.ReadLine());
                                if (trie == true)
                                    continue;
                                else
                                    break;
                            }
                        }
                        else if (num == 2)
                        {
                            Console.WriteLine("Your account balance is {0}", balance[i]);
                            Console.WriteLine("If you want to try again then type true else type false");
                            bool trie = Convert.ToBoolean(Console.ReadLine());
                            if (trie == true)
                                continue;
                            else
                                break;
                        }
                        else
                        {
                            Console.WriteLine("If you want to try again then type true else type false");
                            bool trie = Convert.ToBoolean(Console.ReadLine());
                            if (trie == true)
                                continue;
                            else
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("The pin number is not correct!! \nIf you want to try again then type true else type false");
                        bool trie = Convert.ToBoolean(Console.ReadLine());
                        if (trie == true)
                            continue;
                        else
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("The card number is not correct !!\nIf you want to try again then type true else type false");
                    bool trie = Convert.ToBoolean(Console.ReadLine());
                    if (trie == true)
                        continue;
                    else
                        break;
                }

            }
        }
    }
}
