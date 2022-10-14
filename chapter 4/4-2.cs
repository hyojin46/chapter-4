//using System;
//public class StaticVsInstanceApp
//{
//    int instanceVariable; // private : default
//    static int staticVariable; //static
//    public static void Main() //static메소드-> static멤버만 바로 접근 가능
//    {
//        StaticVsInstanceApp obj = new StaticVsInstanceApp(); //객체 생성

//        obj.instanceVariable = 10; // ok (non-static멤버는 객체생성후 접근 가능)
//                                   //StaticVsInstanceApp.instanceVariable = 10; // error
//        StaticVsInstanceApp.staticVariable = 20; // ok (static 멤버 접근)
//                                                 //obj.staticVariable = 20; // error
//        Console.WriteLine("instance variable={0}, static variable={1}",obj.instanceVariable, StaticVsInstanceApp.staticVariable);
//    }
//}