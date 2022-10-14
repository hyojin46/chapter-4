//using System;
//public class Color
//{
//    public const int FULL = 0xFF; // constant member, 컴파일시에 초기화
//    public const int EMPTY = 0x00; // constant member
//    private byte red, green, blue;
//    // readonly fields, static생략시에 오류남
//    public static readonly Color Red = new Color(FULL, EMPTY, EMPTY);// 객체 생성시에 초기화
//    public static readonly Color Green = new Color(EMPTY, FULL, EMPTY);
//    public static readonly Color Blue = new Color(EMPTY, EMPTY, FULL);
//    public Color(byte r, byte g, byte b)
//    { // 생성자
//        red = r;
//        green = g;
//        blue = b;
//    }
//    public static void PrintColor(Color c)
//    { // method
//        Console.WriteLine("RED value={0}, GREEN value={1}, BLUE value={2}",
//        c.red, c.green, c.blue);
//    }
//}
//class ConstVsReadOnlyApp
//{
//    public static void Main()
//    {
//        Console.WriteLine("FULL = " + Color.FULL);//const로 선언된 변수 접근
//        Color.PrintColor(Color.Red); //static멤버함수 접근
//    }
//}