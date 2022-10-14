//using System;
//class MethodOverloadingApp
//{
//    void SomeThing()//non-static 메소드
//    {
//        Console.WriteLine("SomeThing() is called.");
//    }
//    void SomeThing(int i)//non-static 메소드
//    {
//        Console.WriteLine("SomeThing(int) is called.");
//    }
//    void SomeThing(int i, int j)//non-static 메소드
//    {
//        Console.WriteLine("SomeThing(int,int) is called.");
//    }
//    void SomeThing(double d)//non-static 메소드
//    {
//        Console.WriteLine("SomeThing(double) is called.");
//    }
//    public static void Main() //static 메소드
//    {
//        MethodOverloadingApp obj = new MethodOverloadingApp();// 객체 생성후에 non-static메소드에 접근
//        obj.SomeThing();
//        obj.SomeThing(526); //매개변수가 1개짜리인 정수형 함수 호출
//        obj.SomeThing(54, 526); //매개변수가 2개짜리인 정수형 함수 호출
//        obj.SomeThing(5.26); //매개변수가 1개짜리인 실수형 함수 호출
//    }
//}