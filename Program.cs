using System;
using System.Linq;


namespace _16.LinqLast
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6 };
           // Console.WriteLine(numbers.Last());  //give us last element of the collection
           // Console.WriteLine(numbers.Last(x => x % 2 == 0)); // give us the last elemnt in the array that divided by 2 give us reminder =0
            // ie give us the last even number of the array numbers
           // Console.WriteLine(numbers.Last(x => x % 2 != 0)); //give me the last number of the array that is not even, that is odd !
            Console.WriteLine(numbers.Last(x => x < 4 )); //give me the last element that is < 4 ;
        
        }
    }
}
