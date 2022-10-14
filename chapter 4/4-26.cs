//using System;
//class Mile
//{
//    public double distance;
//    public Mile(double distance)
//    { // 생성자
//        this.distance = distance;
//    }
//    // Mile operator: double to mile
//    public static implicit operator Mile(double d)
//    { // c#기본형을 mile클래스형으로 형변환(암시적)
//        Mile m = new Mile(d);
//        return m;
//    }
//    // Kilometer operator: Mile to Kilometor
//    public static explicit operator Kilometer(Mile m)
//    { // mile클래스형을 kilometer형으로 형변환(명시적)
//        return m.distance * 1.609;
//    }
//}
//class Kilometer
//{
//    public double distance;
//    public Kilometer(double distance)
//    { // 생성자
//        this.distance = distance;
//    }
//    // Kilometer operator: double to Kilo
//    public static implicit operator Kilometer(double d)
//    { //  c#기본형을 kilometer형으로 형변환(명시적)
//        Kilometer k = new Kilometer(d);
//        return k;
//    }
//    // Mile operator: Kilo to Mile
//    public static explicit operator Mile(Kilometer k)
//    { // Kilometer 클래스 형을Mile 형으로 형변환 (명시적)
//        return k.distance / 1.609;
//    }
//}
//class UserDefinedTypeConversionApp
//{
//    public static void Main()
//    {
//        Kilometer k = new Kilometer(100.0); // 객체 생성
//        Mile m;
//        m = (Mile)k; // 명시적 형변환
//        Console.WriteLine("{0} km = {1} mile", k.distance, m.distance);
//        m = 65.0; // 암시적 형변환 (double to mile)
//        k = (Kilometer)m; // 명시적 형변환 -> K=(Killometer)((Mile)65.0)
//        Console.WriteLine("{0} mile = {1} km", m.distance, k.distance);
//    }
//}