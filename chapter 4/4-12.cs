//using System;
//class Destructor
//{
//    public Destructor()
//    { // 생성자
//        Console.WriteLine("In the constructor ...");
//    }
//    ~Destructor()
//    { // 소멸자 -> 프로그램 종료시 호출
//        Console.WriteLine("In the destructor ...");
//    }
//}
//class DestructorApp
//{
//    public static void Main()
//    {
//        Console.WriteLine("Start of Main");
//        Destructor d = new Destructor(); //객체 생성 -> 생성자 호출
//        Console.WriteLine("End of Main"); // 소멸자 호출
//    }
//}