using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EATMProjectOne
{
    class Eatm
    {
        readonly int[] cardNumbers = new int[] { 1, 2, 3 };
        readonly int[] pinNumbers = new int[] { 123, 234, 456 };
        int[] balances = new int[] { 500, 200, 800 };
        private int cardInput;
        private int pinNumber;
        private int withdrow;
        private int checkBalance;
        private int options;


        public void EATMMachine()
        {
            Console.WriteLine(" *** Welcome to our EATM service *** ");
            Console.Write("what is your card number : " );
            cardInput = Convert.ToInt32(Console.ReadLine());

            CheckCardNumber(cardInput);
            

        }

        public void CheckCardNumber(int cardInput)
        {
            if (cardNumbers[0] == cardInput)
            {
                Console.Write("Enter your valid pin number : ");
                pinNumber = Convert.ToInt32(Console.ReadLine());
                CheckPinNumber(pinNumber);

            }
            else if (cardNumbers[1] == cardInput)
            {
                Console.WriteLine("Enter your valid pin number ");
            }

            else if (cardNumbers[2] == cardInput)
            {
                Console.WriteLine("Enter your valid pin number ");
            }

            else
            {
                Console.WriteLine("Invalid card number.Please try again !");
            }
        }


        public void CheckPinNumber(int pinNumber)
        {
            if (pinNumber == pinNumbers[0])
            {
                Console.WriteLine("1.Check account balance \t 2.Cash withdrawal \t 3.Exit");
                
                MenuOptions();
            }
            else
            {
                Console.WriteLine("Invalid Pin number ");
            }
        }

        public void MenuOptions()
        {
            bool flag = true;
            do
            {
                Console.Write("What you want to do ? Enter option numbre : ");
                int getOption = Convert.ToInt32(Console.ReadLine());
                if (getOption == 1)
                {
                    Console.WriteLine("Your total balance is : " + balances[0]);
                }
                else if (getOption == 2)
                {
                    Console.Write("Enter Amount : ");
                    withdrow = Convert.ToInt32(Console.ReadLine());
                    if (withdrow < balances[0])
                    {
                        balances[0] -= withdrow;
                        Console.WriteLine("Cash withdrawal successful. Your account balance is " + balances[0]);
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Insufficient balance.Thank You !");
                    }

                }
                else if (getOption == 3)
                {
                    flag = false;
                }
                else
                {
                    Console.WriteLine("You enter invalid option number ! Enter valid option");
                }
            } while (flag);
            
        }
    }
}
