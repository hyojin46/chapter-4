//using System;
//class RWOnlyPropertyApp
//{
//    private int readOnlyField = 100; //필드
//    private int writeOnlyField; //필드
//    public int ReadOnlyProperty //겟-연산자만 있는 프로퍼티
//    {
//        get
//        {
//            Console.WriteLine("In the ReadOnlyProperty ...");
//            return readOnlyField;
//        }
//    }
//    public int WriteOnlyProperty //셋-연산자만 있는 프로퍼티
//    {
//        set
//        {
//            Console.WriteLine("In the WriteOnlyProperty ...");
//            writeOnlyField = value;
//        }
//    }
//    public static void Main()
//    {
//        RWOnlyPropertyApp obj = new RWOnlyPropertyApp(); //객체 생성
//        obj.WriteOnlyProperty = obj.ReadOnlyProperty; //메소드 방식: obj.get(), obj.set()
//        Console.WriteLine("value = " + obj.writeOnlyField); //writeOnlyField는 프로퍼티가 아닌 필드
//    }
//}