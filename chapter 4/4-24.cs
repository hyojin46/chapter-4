﻿//using System;
//class Complex //복소수 = a(실수부) + b(허수부)i
//{
//    private double realPart; // 실수부
//    private double imagePart; // 허수부
//    public Complex(double rVal, double iVal)
//    { // 생성자
//        realPart = rVal;
//        imagePart = iVal;
//    }
//    public static Complex operator +(Complex x1, Complex x2)
//    {
//        Complex x = new Complex(0, 0); // 반환결과를 담을 complex객체
//        x.realPart = x1.realPart + x2.realPart;
//        x.imagePart = x1.imagePart + x2.imagePart;
//        return x;
//    }
//    override public string ToString()
//    { // ToString 메소드 재정의
//        return "(" + realPart + "," + imagePart + "i)";
//    }
//}
//class OperatorOverloadingApp
//{
//    public static void Main()
//    {
//        Complex c, c1, c2; // 클래스 변수 생성
//        c1 = new Complex(1, 2); //객체선언과 동시에 초기화
//        c2 = new Complex(3, 4);
//        c = c1 + c2; // 재정의된 연산자를 사용한 복소수 덧셈
//        Console.WriteLine(c1 + " + " + c2 + " = " + c);
//    }
//}