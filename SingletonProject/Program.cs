using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton fromEmployee = Singleton.GetInstance;
            fromEmployee.PrintDetails("FromEmployee");

            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("FromStudent");
            Console.ReadLine();
        }
    }
}
