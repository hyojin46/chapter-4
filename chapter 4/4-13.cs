//using System;
//class DisposeClass : IDisposable // IDisposable인터페이스 구현
//{
//    // ...
//    public void Dispose()
//    {
//        Console.WriteLine("In the Dispose ...");
//        GC.SuppressFinalize(this);
//    }
//}
//class DisposeApp
//{
//    public static void Main() //
//    {
//        Console.WriteLine("Start of Main");
//        using (DisposeClass obj = new DisposeClass())
//        { //using문 : DisposeClass객체 사용을 마치면, 해당 클래스의 Dispose()메소드가 자원관리를 위해 호출됨
//            // ...
//        }
//        Console.WriteLine("End of Main");
//    }
//}