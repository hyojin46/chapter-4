//using System;
//delegate void MultiCastDelegate(); //델리게이트 정의
//class Schedule
//{
//    public void Now() //델리게이트 할 대상이 되는 메소드(인자0개) -> instance메소드(객체생성 필요)
//    {
//        Console.WriteLine("Time : " + DateTime.Now.ToString());
//    }
//    public static void Today() //델리게이트 할 대상이 되는 메소드(인자0개) -> static메소드(객체생성 불필요)
//    {
//        Console.WriteLine("Date : " + DateTime.Today.ToString());
//    }
//}
//class MultiCastApp
//{
//    public static void Main()
//    {
//        Schedule obj = new Schedule(); // delegate대상이 되는 메소드를 포함하는 객체 생성
//        MultiCastDelegate mcd = new MultiCastDelegate(obj.Now); // delegate 객체(mcd) 생성
//        mcd += new MultiCastDelegate(Schedule.Today); // delegate 객체 생성 (+=: multicast)
//        mcd(); // delegate 객체 호출 (2개의 메소드 수행)
//    }
//}