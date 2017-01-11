using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RE_W
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean y_N = false;
            Console.WriteLine("please,enter any string :");
            string word = Console.ReadLine();
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = i + 1; j < word.Length; j++)
                {
                    if (word[i] == word[j])
                    {
                        y_N = true;
                        break;
                    }
                }
            }
            if (y_N)
            {
                Console.WriteLine($"the word [{word}] content char repetion");
            }
            else { Console.WriteLine($"the word [{word}] not content char repetion"); }
            Console.ReadKey();

        }
    }
    }

