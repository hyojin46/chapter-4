//using System;
//delegate void MultiDelegate();//인자와 반환형이 없는 메소드를 가리키는 델리게이트 선언
//class DelegateClass
//{
//    public void MethodA() //델리게이트 할 대상이 되는 메소드(인자0개) -> instance메소드(객체생성 필요)
//    {
//        Console.WriteLine("In the DelegateClass.MethodA ...");
//    }
//    public void MethodB() //델리게이트 할 대상이 되는 메소드(인자0개) -> instance메소드(객체생성 필요)
//    {
//        Console.WriteLine("In the DelegateClass.MethodB ...");
//    }
//    public void MethodC() //델리게이트 할 대상이 되는 메소드(인자0개) -> instance메소드(객체생성 필요)
//    {
//        Console.WriteLine("In the DelegateClass.MethodC ...");
//    }
//}
//class DelegateOperation
//{
//    public static void Main() 
//    {
//        DelegateClass obj = new DelegateClass(); // 클래스 객체 생성
//        MultiDelegate dg1, dg2, dg3; // 델리게이트 선언: 참조 변수 선언
//        dg1 = new MultiDelegate(obj.MethodA); // 델리게이트 객체 생성
//        dg2 = new MultiDelegate(obj.MethodB); // 델리게이트 객체 생성
//        dg3 = new MultiDelegate(obj.MethodC); // 델리게이트 객체 생성
//                                              // ...
//        dg1 = dg1 + dg2; // 메소드 추가
//        dg1 += dg3; // 메소드 추가
//        dg2 = dg1 - dg2; // 메소드 제거
//        dg1(); //델리게이트 호출
//        Console.WriteLine("After dg1 call ...");
//        dg2(); //델리게이트 호출
//        Console.WriteLine("After dg2 call ...");
//        dg3(); //델리게이트 호출
//    }
//}