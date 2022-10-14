//using System;
//class PropertyWithManyFieldsApp
//{
//    private string text = "Dept. of Computer Engineering";
//    private bool isModified = false;
//    public string Text
//    {
//        get { return text; }
//        set { text = value; isModified = true; } // 2개의 필드와 연관
//    }
//    public void PrintStatus()
//    {
//        Console.WriteLine("text is \"" + text + "\", and " + (isModified ? "is" : "not") + " modified."); //조건연산자
//    }   // 인용부호 표시 -> \를 앞에 추가
//    public static void Main()
//    {
//        PropertyWithManyFieldsApp obj = new PropertyWithManyFieldsApp(); //객체 생성
//        obj.PrintStatus(); //초기상태 출력
//        obj.Text = "Programming Language Lab"; // 프로퍼티의 set 동작 -> Text필드와 isModified 필드 변경
//        obj.PrintStatus(); //변경상태 출력
//    }
//}