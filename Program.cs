using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Checking for equality");
            int sumOne = 22 + 15;
            int sumTwo = 83 + 34;
            int sumThree = 3 + 77;
            if(sumOne < 100 ){
                Console.WriteLine("True,The sum is" + sumThree);
            }
            else{
                Console.WriteLine("False");
            }
            if(sumTwo < 100){
                Console.WriteLine("True, the sum is" + sumTwo);
            }
            else{
                Console.WriteLine("False");
            }
            if(sumThree < 100){
                Console.WriteLine("True, the Sum is" + sumThree);
            }
            else{
                Console.WriteLine("False");
            }


        }
    }
}
