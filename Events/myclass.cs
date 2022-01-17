using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Events
{
    public class Myclass
    {

        public void Space(string str)
        {
            string t="";
            for (int i = 0; i < str.Length; i++)
            {
                t+=(str[i]+"_");
            }
            t=t.Remove(t.Length - 1, 1);
            Console.WriteLine(t);
        }
        public void Reverse(string str)
        {
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            str = new string(chars);
            Console.WriteLine(str);
        }
    }
    public class Run
    {

        public void runFunc(Func t,string t1)
        {
            t.Invoke(t1);
        }
    }
}
