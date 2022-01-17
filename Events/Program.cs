using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate void Func(string t);

namespace Events {
    public class Event
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");

            string str = Console.ReadLine();
            Events.Myclass cls = new();
            Func funcDell = new Func(cls.Space);
            funcDell+=cls.Reverse;
            Run run = new Run();
            run.runFunc(funcDell, str);
        }
    }
}