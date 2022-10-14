//using System;
//class Fraction
//{
//    int numerator; // 분자 필드
//    int denominator; // 분모 필드
//    public Fraction(int num, int denom) //생성자(클래스이름과 동일)
//    { //this는 객체 자신을 가르킴
//        numerator = num; // this.numerator = num; 
//        denominator = denom; // this.denominator = denom;
//    }
//    public void PrintFraction()
//    { // 출력 메소드
//        Console.WriteLine(numerator + "/" + denominator);
//    }
//}
//class FractionApp
//{
//    public static void Main()
//    {
//        Fraction f = new Fraction(1, 2); // 객체 생성: 생성자 형식
//        f.PrintFraction(); // 객체의 메소드 호출
//    }
//}