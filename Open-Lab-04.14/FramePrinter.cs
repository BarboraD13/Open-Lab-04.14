using System;

namespace Open_Lab_04._14
{
    public class FramePrinter
    {
        public void Print(string[] strings)
        {
            string frame = "";
            int a = 0;

            foreach (string b in strings)
            {
                if (a < b.Length)
                    a = b.Length;
            }

            for (int i = 0; i < a + 4; i++)
            {
                frame += "*";
            }

            Console.WriteLine(frame);

            foreach (string b in strings)
            {
                if (b.Length < a)
                {
                    string str = "";
                    for (int i = 0; i < a - b.Length; i++)
                    {
                        str += " ";
                    }
                    Console.WriteLine("* " + b + str + " *");
                }
                else
                    Console.WriteLine("* " + b + " *");
            }

            Console.WriteLine(frame);
        }
    }
}
