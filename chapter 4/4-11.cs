//using System;
//class StaticConstructor
//{
//    static int staticWithInitializer = 100; // 선언과 동시에 초기화
//    static int staticWithNoInitializer; // static 생성자로 초기화 -> 디폴트 초기값 = 0
//    static StaticConstructor() //정적 생성자: Main()함수보다 먼저 실행
//    { // 매개변수와 접근 수정자를 가질 수 없다.
//        staticWithNoInitializer = staticWithInitializer + 100; // staticWithNoInitializer 초기화
//    }
//    public static void PrintStaticVariable()
//    {
//        Console.WriteLine("field 1 = {0}, field 2 = {1}",staticWithInitializer, staticWithNoInitializer);
//    }
//}
//class StaticConstructorApp
//{
//    public static void Main()//static 메소드
//    {
//        StaticConstructor.PrintStaticVariable();// static메소드이기때문에 바로 접근 가능
//    }
//}