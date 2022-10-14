//using System;
//class Integer
//{
//    public int i;//변수필드
//    public Integer(int i) //생성자
//    {
//        this.i = i;
//    }
//}
//class CallByObjectReferenceApp
//{
//    static void Swap(Integer x, Integer y) //참조형 변수이기 때문에 ref불필요
//    {
//        int temp = x.i; x.i = y.i; y.i = temp;
//        Console.WriteLine(" Swap: x = {0}, y = {1}", x.i, y.i);
//    }
//    public static void Main()
//    {
//        Integer x = new Integer(1); //객체생성과 동시에 초기화 값선언
//        Integer y = new Integer(2); //객체생성과 동시에 초기화 값선언
//        Console.WriteLine("Before: x = {0}, y = {1}", x.i, y.i);
//        Swap(x, y); //x,y는 참조형 변수(객체) - 객체에 대한 주소 저장
//        Console.WriteLine(" After: x = {0}, y = {1}", x.i, y.i);
//    }
//}