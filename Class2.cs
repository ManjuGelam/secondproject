using System;
using System.Collections.Generic;
using System.Text;
using oopsproject;

namespace secondproject
{
  public  class Class2
    {
       public static void Main()
        {
            CopyConDemo cd1 = new CopyConDemo(1005);
            cd1.Display();
            CopyConDemo cd2 = new CopyConDemo(cd1);
            cd2.Display();
            Console.WriteLine();
           
            cd1.Display();
            cd2.Display();
            Console.WriteLine();
           
            cd1.Display();
            cd2.Display();
            Console.ReadLine();
        }
    }
}
