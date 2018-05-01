using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace HammingCode
{
    class Program
    {
        static void Main()
        {
            //ประกาศตัวแปร
            string NrBinary;
            int m = 8, r = 4, number;
            // input ข้อมูล
            Console.WriteLine("Give binary value till 8 bit: ");
            NrBinary = Console.ReadLine();
            if (NrBinary.Length == 8)
            {
                //นำข้อมูลมาเก็บเป็น integer
                number = Convert.ToInt32(NrBinary);
                int[] data = new int[m];
                int[] parity = new int[r];

                data[0] = (number / 10000000) % 10;
                data[1] = (number / 1000000) % 10;
                data[2] = (number / 100000) % 10;
                data[3] = (number / 10000) % 10;
                data[4] = (number / 1000) % 10;
                data[5] = (number / 100) % 10;
                data[6] = (number / 10) % 10;
                data[7] = number % 10;

                //ทำการตรวจสอบข้อมูลด้วยการนำข้อมูลมา xor แล้วเก็บค่าใน parityต่างๆ
                parity[0] = data[0] ^ data[1] ^ data[3] ^ data[4] ^ data[6];
                parity[1] = data[0] ^ data[2] ^ data[3] ^ data[5] ^ data[6];
                parity[2] = data[1] ^ data[2] ^ data[3] ^ data[7];
                parity[3] = data[4] ^ data[5] ^ data[6] ^ data[7];

                //print
                Console.WriteLine("\nbit parity  = " + parity[0] + "" + parity[1] + "" + parity[2] + "" + parity[3] + "\n");
                Console.Write("Bit with Hamming code: ");
                Console.WriteLine(parity[0] + "" + parity[1] + "" + data[0] + "" + parity[2] + "" + data[1] + "" + data[2]
                + "" + data[3] + "" + parity[3] + "" + data[4] + "" + data[5] + "" + data[6] + "" + data[7]);
            }
            else
            {
                Console.WriteLine("\n\n 8 bit character only:)");
            }
        }
    }
}