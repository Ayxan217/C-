using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("ayi daxil edin: ");
            //string month = Console.ReadLine();
            //if(month=="yanvar" || month == "fevral" || month == "december")
            //{
            //    Console.WriteLine("Winter");
            //}
            //else if (month == "mart" || month == "aprel" || month == "may")
            //{
            //    Console.WriteLine("yaz");
            //}
            //else if (month == "iyun" || month == "iyul" || month == "avqust")
            //{
            //    Console.WriteLine("summer");
            //}
            //else if (month == "september" || month == "november" || month == "october")
            //{
            //    Console.WriteLine("fall");
            //}



            Console.WriteLine("heftenin gununu daxil edin: ");
            string day = Console.ReadLine();
            if(day == "Bazar ertesi")
            {
                Console.WriteLine("1");
            }
            else if (day == "cersembe axsami")
            {
                Console.WriteLine("2");
            }
            else if  (day == "cersembe")
            {
                Console.WriteLine("3");
            }
            else if (day == "cume axsami")
            {
                Console.WriteLine("4");
            }
            else if (day == "cume")
            {
                Console.WriteLine("5");
            }
            else if (day == "senbe")
            {
                Console.WriteLine("6");
            }
            else if (day == "Bazar ")
            {
                Console.WriteLine("7");
            }
            else
            {
                Console.WriteLine("duzgun daxil edin !!!");

            }

        }
    }
}
