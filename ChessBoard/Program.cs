using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace ChessBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            string black = "◼︎";
            string white = "◻︎";

            Console.WriteLine("Hej!\nHur stor vill du att Schackbrädan ska vara?\nSkriv ett nummer: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            int color = 0;

            int n = userInput, a = 0;
            for (int i = 1; i <= n; i++)//checks if userInput is a prime number or not
            {
                if (n % i == 0)
                {
                    a++;
                }
            }
            if (a == 2) //prime
            {

                for (int x = 1; x <= userInput;)//loop for Y axis
                {
                    for (int i = 1; i <= userInput;)//loop for X axis
                    {


                        if (color == 1)
                        {
                            Console.Write(black);

                            color = 0;

                        }
                        else if (color == 0)
                        {
                            Console.Write(white);

                            color = 1;

                        }
                        i++;
                    }
                    Console.WriteLine("");
                    x++;

                }
            }
            else //not prime
            {

                for (int x = 1; x <= userInput;)//loop for Y axis
                {
                    for (int i = 1; i <= userInput;)//loop for X axis
                    {


                        if (color == 1)
                        {
                            Console.Write(black);

                            color = 0;

                        }
                        else if (color == 0)
                        {
                            Console.Write(white);

                            color = 1;

                        }
                        i++;
                    }
                    Console.WriteLine("");

                    if (color == 1)
                    {
                        color = 0;
                    }
                    else
                    {
                        color = 1;
                    }
                    x++;
                }
            }



        }
    }
}