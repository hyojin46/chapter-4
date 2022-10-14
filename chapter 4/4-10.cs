//using System;
//class Fraction
//{
//    int numerator; // 분자 필드
//    int denominator; // 분모 필드
//    public Fraction()
//    { // 디폴트 생성자
//        numerator = 0;
//        denominator = 1;
//    }
//    public Fraction(int n)
//    { // 매개변수 있는 생성자
//        numerator = n;
//        denominator = 1;
//    }
//    public Fraction(int n, int d)
//    { // 매개변수 있는 생성자
//        numerator = n;
//        denominator = d;
//    }
//    override public String ToString() //사용자가 원하는 객체 출력 형태로 재정의(override)
//    { // 기존 ToString() 메소드를 override함
//        return (numerator + "/" + denominator);
//    }
//}
//class OverloadedConstructorApp
//{
//    public static void Main()
//    {
//        Fraction f1 = new Fraction(), f2 = new Fraction(2), f3 = new Fraction(1, 2); //객체 생성 -> 생성자 호출
//        // Console.WriteLine("f1 = {0}, f2 = {1}, f3 = {2}",f1, f2, f3); -> 객체 이름을 출력하면 "객체명.ToString()"이 호출 됨
//        Console.WriteLine("f1 = {0}, f2 = {1}, f3 = {2}", f1.ToString(), f2.ToString(), f3.ToString());
//    }
//}