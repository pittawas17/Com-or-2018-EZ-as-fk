using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string binary;
            long number;
            binary = Console.ReadLine();
            number = Convert.ToInt64(binary);
            long[] codeword = new long[12];
            long[] check = new long[4];
            long position = 0;
            int i;

            codeword[0] = (number / 100000000000) % 10;
            codeword[1] = (number / 10000000000) % 10;
            codeword[2] = (number / 1000000000) % 10;
            codeword[3] = (number / 100000000) % 10;
            codeword[4] = (number / 10000000) % 10;
            codeword[5] = (number / 1000000) % 10;
            codeword[6] = (number / 100000) % 10;
            codeword[7] = (number / 10000) % 10;
            codeword[8] = (number / 1000) % 10;
            codeword[9] = (number / 100) % 10;
            codeword[10] = (number / 10) % 10;
            codeword[11] = number % 10;

            check[0] = codeword[0] ^ codeword[2] ^ codeword[4] ^ codeword[6] ^ codeword[8] ^ codeword[10];
            check[1] = codeword[1] ^ codeword[2] ^ codeword[5] ^ codeword[6] ^ codeword[9] ^ codeword[10];
            check[2] = codeword[3] ^ codeword[4] ^ codeword[5] ^ codeword[6] ^ codeword[11];
            check[3] = codeword[7] ^ codeword[8] ^ codeword[9] ^ codeword[10] ^ codeword[11];

            for(i = 0; i < 4; i++)
            {
                position = position + Convert.ToInt32(Math.Pow(2, i)) * check[i];
            }
            Console.WriteLine(position);
            if (position != 0)
            {
                if (codeword[position - 1] == 0)
                {
                    codeword[position - 1] = 1;
                }
                else
                {
                    codeword[position - 1] = 0;
                }
            }
            for(i=0;i < 12; i++)
            {
                if(i != 0 && i != 1 && i != 3 && i != 7)
                {
                    Console.Write(codeword[i]);
                }
            }
            Console.WriteLine();
        }
    }
}
