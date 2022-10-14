//using System;
//class Fraction
//{
//    private int numerator;
//    private int denominator;
//    public int Numerator
//    {
//        get { return numerator; }
//        set { numerator = value; } // f.Numerator = 1 -> value =1의 값이 들어옴
//    }
//    public int Denominator
//    {
//        get { return denominator; }
//        set { denominator = value; } // f.Denominator = i -> valud = i의 값이 들어옴
//    }
//    override public string ToString()
//    {
//        return (numerator + "/" + denominator);
//    }
//}
//class PropertyApp
//{
//    public static void Main()
//    {
//        Fraction f = new Fraction(); int i;
//        f.Numerator = 1; // 배정문 왼쪽의 프로퍼티 -> set접근자 호출
//        i = f.Numerator + 1; //배정문 오른쪽의 프로퍼티 -> get접근자 호출
//        f.Denominator = i; //배정문 왼쪽의 프로퍼티 -> set접근자 호출
//        Console.WriteLine(f.ToString());
//    }
//}