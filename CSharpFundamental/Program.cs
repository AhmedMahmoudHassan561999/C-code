using CSharpFundamental;
using System.IO;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System;
using System.Reflection;
using System.Text;

namespace CSharpFundamental
{
    public class Ytubevideos
    {
        public string id { get; set; }

        public string title { get; set; }

        public TimeSpan duration { get; set; }
        public override string ToString()
        {
            return $"{title} ({duration}) \n \t https://www.youtube.com/watch?v={id}";
        }
        

    }
    internal class Program
    {
        public static void print  ( 10 , 10)
        {

           bool equel= n1.Equals(n2);
            if (equel)
            {
                Console.WriteLine("EEEEQUEL");
            }
            else
            {
                Console.WriteLine("NOT EQUEL");
            }
          
        }
      
        public static void Main(string[] args)
        {
           
            print <T> (T n1, T n2);
        
        }

        


    }
}