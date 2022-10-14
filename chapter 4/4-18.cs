//using System;
//class Color
//{
//    private string[] color = new string[5]; //문자 배열형식의 필드 생성
//    public string this[int index] //인덱서
//    {
//        get { return color[index]; } //color 배열 반환
//        set { color[index] = value; } // value는 예약어, color배열에 value저장
//    }
//}
//class IndexerApp
//{
//    public static void Main() //static 메소드
//    {
//        Color c = new Color(); //객체 생성
//        c[0] = "WHITE";
//        c[1] = "RED";
//        c[2] = "YELLOW";
//        c[3] = "BLUE";
//        c[4] = "BLACK";
//        for (int i = 0; i < 5; i++)
//            Console.WriteLine("Color is " + c[i]);
//    }
//}