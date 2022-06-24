using System;

namespace Private_Constructor_SingletanDP
{
    class MyClass
    {
       private MyClass()
        {
            Console.WriteLine("Private Constructor :");
        }
     

        private static MyClass my;

        public static MyClass GetClass()
        {
            if (my==null)
            {
                my = new MyClass();
            }
                return my;
        } 
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = MyClass.GetClass();
            
           
        }
    }
}
