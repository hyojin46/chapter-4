//using System;
//class ParameterArrayApp
//{
//    static void ParameterArray(params object[] obj)// 배열은 참조형 변수 -> ref불필요
//    { //object형은 모든 자료형 혹은 클래스를 대입 가능
//        for (int i = 0; i < obj.Length; i++)
//            Console.WriteLine(obj[i]);
//    }
//    public static void Main()
//    {
//        ParameterArray(123, "Hello", true, 'A'); //배열선언과 동시에 초기화
//    }
//}