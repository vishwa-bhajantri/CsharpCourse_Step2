using System;

namespace AbstractionSystem
{

    abstract class AbstractClassDemo
    {

        //we can define normal and parameterized constructors
        public AbstractClassDemo()
        {

        }

        public AbstractClassDemo(int sid)
        {

        }

        //Abstract Properties
        public abstract int age { get; set; }
        public abstract int name { get; set; }

        //non-abstract properties
        public string location {  get; set; }

        //Abstract Methods
        public abstract void Message();
        public abstract int Message1();
        public abstract int Message2(int id);


        //we can define normal methods or non-abstract methods
        public void getMessage()
        {
            Console.WriteLine("Simple Message");
        }
    }
}