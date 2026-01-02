using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWithC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // char 2 byte...int 4....long 8....
            /*Console.WriteLine("my name is shakib mozumder");
            Console.WriteLine("my name is shakib mozumder");
            Console.Write("enter ta number: ");
            int number =int.Parse(Console.ReadLine());  //intiger value input ney
            Console.WriteLine("the number is: " + number);
            String sha= Console.ReadLine();  //full num dile oitai print kore dey.....
            Console.WriteLine(sha); *//*
            int a = 34;
            // float d=55.5   ....c# is a type save language.
            float c = 44.5F;
            double b = 44.4d;
            bool isGreat = true;
            char f = 'a';
            String e = "My name is shakib";
            Console.WriteLine(a);  //34
            Console.WriteLine(b);   //44.4
            Console.WriteLine(c);   //44.5
            Console.WriteLine(isGreat);
            Console.WriteLine(f);
            Console.WriteLine(e); // full name e asbe..*/
            //Type casting..........there are 2 types of type casting
            //1.implicit casting
            //char to int to long to float to double 
            //int a = 3;
            //double b = a;
            //int c = 'y';
            //Console.WriteLine(c);
            //Console.WriteLine(b);
            ////explicit casting
            //double d =(double)8.6;
            //Console.WriteLine(d);
            //float v = Convert.ToInt32(33.77);
            //Console.WriteLine(v);   //34
            Console.Write("Enter your name: ");
            String name=Console.ReadLine();  //name user inpur full
            Console.WriteLine("Hey " + name + " How are you!");
            String d=Console.ReadLine();
            Console.Write("how many candy we went: ");
            int c=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("add mone "+(c +3)+" candhy!");
            Console.ReadLine();
        }
    }
}
