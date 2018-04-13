using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableChallange
{
    class Program
    {
        static void Main(string[] args)
        {
            //char A = 'A';
            //int A1 = 'A';
            //char a = 'a';
            //int a1 = 'a';
            //string valueA = "value A is";
            //string valuea = "value a is";
            //Console.WriteLine("value A is ={0}", A1);
            //Console.WriteLine("value a is ={0}", a1);
            //Console.WriteLine("this is my character A value = {0}\nthis is my character a value = {1}", A1, a1);
            //Console.ReadKey();

            ////طريقة أخرى
            //int x = 'a';
            //int y = 'a';
            //string z = "this is my character a value : ";
            //string w = " this is my character a value : ";
            //// الطريقة الأولى بطباعة النتائج
            //console.writeline("{0}{1}{2}{3}", z, x, w, y);

            //// الطريقة الثانية بطباعة النتائج
            ////console.write(z);
            ////console.write(x);
            ////console.write(w);
            ////console.write(y); 
            //Console.ReadKey();

            int num = 'A';
            char L = Convert.ToChar(num);
            Console.WriteLine("letter={0} value={1}",num,L);
            Console.ReadKey();




        }
    }
}
