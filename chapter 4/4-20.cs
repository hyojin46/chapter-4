//using System;
//delegate void DelegateOne(); // 수정자: internal
//delegate void DelegateTwo(int i); // 델리게이트 정의
//class DelegateClass
//{
//    public void MethodA() //델리게이트 할 대상이 되는 메소드(인자0개)
//    {
//        Console.WriteLine("In the DelegateClass.MethodA ...");
//    }
//    public void MethodB(int i) //델리게이트 할 대상이 되는 메소드(인자1개)
//    {
//        Console.WriteLine("DelegateClass.MethodB, i = " + i);
//    }
//}
//class DelegateCallApp
//{
//    public static void Main()
//    {
//        DelegateClass obj = new DelegateClass(); // delegate대상이 되는 메소드를 포함하는 객체 생성
//        DelegateOne d1 = new DelegateOne(obj.MethodA); // delegate 객체(d1) 생성
//        DelegateTwo d2 = new DelegateTwo(obj.MethodB); // delegate 객체(d2) 생성
//        d1(); // delegate 객체 호출 : 메소드 대리인 -> 6번째 줄
//        d2(10); // delegate 객체 호출 -> 10번째 줄
//    }
//}