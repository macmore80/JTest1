using System;

namespace jkghtest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Start JK's Test for using github - 20230206");
                        
            //Console.WriteLine("Fill in test log");
            ////Console.ReadKey(); //developer-talk.tistory.com/320
            //Console.WriteLine("Push any key, please");
            //ConsoleKeyInfo keyInfo = Console.ReadKey();
            //Console.WriteLine("What is Key?: " + keyInfo.Key);

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"test.csv")) //ssabi.tistory.com/55 - CSV 파일 읽고 쓰기
            {
                if (args.Length == 0)
                {
                    file.Write($"This project does not have the application param in debug configuration.");
                }
                else if (args.Length > 0)
                {
                    // Project's properties >> debug > application parameter : Start Test
                    file.WriteLine("Exist the application parameters(in debug)");
                    file.WriteLine("{0}, {1}", args[0], args[1]);

                    //// Define items
                    //file.WriteLine("name, grade, class, comparison");
                    //// fill in values.
                    //file.WriteLine("{0},{1},{2},{3}", "JK.Park", "99", "A", "PASS");
                }
            }
            Console.WriteLine("End JK's Test for using github - 20230206");
        }
    }
}
