
//Accept any number from user and return the factors of that number
//     If user enters number 12 then the factors will be 1,2,3,4,6,12

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Enter Any Number");
//        int num = Convert.ToInt32(Console.ReadLine());
//        for (int i = 1; i <= num; ++i)
//        {
//            if (num % i == 0)
//            {
//                Console.WriteLine(i);
//            }
//        }
//    }
//}


//Q.Accept any number from user and return the factors of that number
//If user enters number 17
//Then the factors will be 1,17
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Enter Any Number");
//        int num = Convert.ToInt32(Console.ReadLine());
//        for (int i = 1; i <= num; ++i)
//        {
//            if (num % i == 0)
//            {
//                Console.WriteLine(i);
//            }
//        }
//    }
//}



//Question
//Accept any number from user and return the factors of that number
//If user enters number 10 then factors will be 
//1,2,5,10

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Any Number");
        int num = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= num; ++i)
        {
            if (num % i == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}