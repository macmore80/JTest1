using System;

namespace jkghtest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Step 1. using github");

            Console.WriteLine("Step 2. commit, push, pull");

            Console.WriteLine("Step 2. checking a change after pullin from github to local pc");

            ////Console.ReadKey(); //developer-talk.tistory.com/320
            //Console.WriteLine("Push any key, please");
            //ConsoleKeyInfo keyInfo = Console.ReadKey();
            //Console.WriteLine("What is Key?: " + keyInfo.Key);

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"test.csv"))
            {
                // Define items
                file.WriteLine("name, grade, class, comparison");

                // fill in values.
                file.WriteLine("{0},{1},{2},{3}", "JK.Park", "99", "A", "PASS");

            }

            //ssabi.tistory.com/55 - CSV 파일 읽고 쓰기


        }
    }
}
