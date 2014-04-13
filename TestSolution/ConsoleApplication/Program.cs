using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using CommonLib;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ImplementationClass class1 = new ImplementationClass();
            ImplementationClass2 class2 = new ImplementationClass2();

            ISampleInterface obj;
            obj = class1 as ISampleInterface;
            obj.SampleMethod();
            obj = class2 as ISampleInterface;
            obj.SampleMethod();

            Console.Read();
        }
    }
}
