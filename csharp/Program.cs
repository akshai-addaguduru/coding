using System;

namespace c_
{
    class Program
    {

        // method 1
        static void methodSample(string fname) {
            Console.WriteLine(fname + "Addaguduru");
        }

        //method 2
        static void multipleParameters (string fname, int age) {
            Console.WriteLine(fname + " is " + +age);
        }


        // main method
        static void Main(string[] args)
        {
            Console.WriteLine("Family members of Akshai are :");
            methodSample("Prabhakara Rao ");
            methodSample("Radha "); 
            methodSample("Ramya ");

            Console.WriteLine("Age of the following people are :");
            multipleParameters("Akshai", 25);
            multipleParameters("Rajesh", 25);
            multipleParameters("Jeethu", 26);
            
        }
    }
}
