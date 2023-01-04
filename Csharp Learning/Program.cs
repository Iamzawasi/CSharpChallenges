using System;

namespace Csharp_Learning
{
    class Program
    {
        public static int topR = 100;
        public static int bottomR = 0;
        static void Main(string[] args)
        {
            int num= 100;
            Console.WriteLine("Hello I hope you are doing well!");
            Console.WriteLine("Please choose a number between 1-100,  I will ask you a few question and find out the choosen number");
            Console.WriteLine("please enter Y for 'yes' and N for 'no'");

            string ans="";
            while (num!=9001) {
                num = validateAndAsk(num, ans );
                int found = ((topR - bottomR) == 1) ? topR : num;
                string message = num == 9001 ? $"found it your choosen {topR - bottomR}, {topR} number is {found}": $"Is your number greater {num} then  y/n? ";
                Console.Write(message);
                ans = Console.ReadLine();
            }
        }

   
        public static int  validateAndAsk( int number, string ans = "y") {
            ans = ans.ToString().ToLower();
            // Validaating user input
            string y = "y";
            string n = "n";
            if (ans.Contains(y))
            {
                ans = "yes";
            }
            else if (ans.Contains(n))
            {
                ans = "no";
            }
            else
            {
                ans = "NoYes";
            }

            // analysing the number
            int origNum = number;

            int checkfloat = number;
            number = number / 2;

            checkfloat = checkfloat - number;
            number = checkfloat > number ? checkfloat : number;////// if check float is greater then number then change the value of number to checkfloat;

            switch (ans)
            {
                case "yes":
                    bottomR = origNum;
                    number = origNum + ((topR-origNum ) / 2);
                    break;
                case "no":
                    number = origNum-((origNum - bottomR) / 2);
                    topR = origNum;
                    break;
                default:
                    Console.WriteLine("Wrong entry! please enter either y for yes or n for no");
                    break;
            }
            return (topR- bottomR==1) ?  9001 :  number;
            //return number;   
         }   
    }
}
