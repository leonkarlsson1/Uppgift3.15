using System;

namespace uppgift_3._15
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("hur länge vill du hyra bilen? (timmar)");
            Console.Write("svara här:"); int timmar = int.Parse(Console.ReadLine());

            if(timmar > 11)
            {
                Console.WriteLine("du får max hyra bilen i 11 timmar");    
            }
            if(timmar <12)
            {
                Console.WriteLine("det kommer kosta" + timmar * 80 + " kronor");
            }
        }
    }
}
