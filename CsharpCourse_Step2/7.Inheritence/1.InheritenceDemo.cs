using System;

namespace Family{

    public class Parent
    {
        public string ParentName {  get; set; }

        public Parent(string name, int age)

        {
            Console.WriteLine("This is Parent Class Constructor");

            Console.WriteLine($"Child name i.e is {name} age is {age}");
        }
        public void ParentMessage()
        {
            Console.WriteLine($"Hello im Parent : {ParentName}");
        }

        
    }

    public class Child : Parent
    {
        public string ChildName { get; set; }

        public Child(string name, int age) : base(name, age)
        {
            Console.WriteLine("This is Child Class Constructor");
        }

        public void ChildMessage()
        {
            var thisChild = this;

            Console.WriteLine($"Hello im Parent with this Keyword : {thisChild.ParentName}");
            Console.WriteLine($"Hello im Child with this Keyword : {thisChild.ChildName}");


            //Console.WriteLine($"Hello im Parent with this Keyword : {this.ParentName}");
            //Console.WriteLine($"Hello im Child with this Keyword : {this.ChildName}");

            Console.WriteLine($"Hello im Parent with Base : {base.ParentName}");
            Console.WriteLine($"Hello im Child : {ChildName}");
        }

        
    }

    public class Program
    {
        static void Main()
        {
            Child child = new Child("Jr.John", 18);

            child.ChildName = "Jr.Bahu";
            child.ParentName = "Bahu";

            child.ChildMessage();
            child.ParentMessage();
        }
    }
}