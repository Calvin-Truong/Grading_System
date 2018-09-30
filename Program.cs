using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grading_System
{
    class Program
    {
        static void Main(string[] args)
        {
            string score = "", letter = "A", yn = "";
            int grade = -1, i = 1;
            double avg = 0;
            const int size = 5;
            bool valid = true;
            for (i = 1; i <= size; i++)
            {
                do
                {
                    Console.Write("Enter the score (between 0 and 100):");
                    score = Console.ReadLine();
                    valid = Int32.TryParse(score, out grade);
                    if (!valid)
                        Console.WriteLine("\nIt is not an integer. Re-enter");
                    else if (grade > 100)
                        Console.WriteLine("\nIt cannot be over 100. Re-enter");
                    else if (grade < 0)
                        Console.WriteLine("\nIt cannot be negative. Re-enter");
                    else
                    {
                        switch (grade / 10)
                        {
                            case 10:
                            case 9:
                                letter = "A";
                                break;
                            case 8:
                                letter = "B";
                                break;
                            case 7:
                                letter = "C";
                                break;
                            case 6:
                                letter = "D";
                                break;
                            default:
                                letter = "F";
                                break;
                        }
                    }
                } while (!valid || grade > 100 || grade < 0);
                avg += grade;
                Console.WriteLine("Score : {0}\t\t Grade: {1}", grade, letter);
                Console.WriteLine("Enter another score now(Y/N)?");
                yn = Console.ReadLine();
                if (yn == "y" || yn == "Y")
                    continue;
                else
                    break;
            }
            Console.WriteLine("{0} score(s) have been entered and the average is {1}.", i, Math.Round(avg / i, 1));
            Console.Read();
        }
    }
}
