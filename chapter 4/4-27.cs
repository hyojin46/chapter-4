//using System;
//struct Point
//{
//    public int x, y; // x, y 좌표
//    public Point(int x, int y)
//    { // 생성자 -> 초기화 시켜주어야 햠
//        this.x = x;
//        this.y = y;
//    }
//    override public string ToString()
//    { // ToString 메소드 재정의
//        return "(" + x + ", " + y + ")";
//    }
//}
//class StructApp
//{
//    public static void Main()
//    {
//        Point[] pts = new Point[3]; //구조체 배열
//        pts[0] = new Point(100, 100); //new를 사용하여 인스턴스 생성후 초기화
//        pts[1] = new Point(100, 200);
//        pts[2] = new Point(200, 100);
//        foreach (Point pt in pts)
//            Console.WriteLine(pt.ToString());
//    }
//}