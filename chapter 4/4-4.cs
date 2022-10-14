//using System;
//class CallByValueApp
//{
//    static void Swap(int x, int y)
//    {
//        int temp;
//        temp = x; x = y; y = temp; //x와 y의 값 exchange
//        Console.WriteLine(" Swap: x = {0}, y = {1}", x, y); // x = 2, y=1
//    }
//    public static void Main()
//    {
//        int x = 1, y = 2;
//        Console.WriteLine("Before: x = {0}, y = {1}", x, y); // x = 2, y=1
//        Swap(x, y); //값에 의한 호출
//        Console.WriteLine(" After: x = {0}, y = {1}", x, y); // x = 1, y=2
//    }
//}