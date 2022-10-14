//using System;
//class StringIndexer
//{  //인덱스와 대응하는 필드배열이 없는 경우
//    public char this[string str, int index]
//    {
//        get { return str[index]; } // 문자열내 특정 위치 글자 반환
//    }
//    public string this[string str, int index, int len]
//    {
//        get { return str.Substring(index, len); } // 문자열내 특정 위치에서 임의의 개수 글자 반환
//    }
//}
//class StringIndexerApp
//{
//    public static void Main()
//    {
//        string str = "Hello";
//        StringIndexer s = new StringIndexer(); //객체 생성
//        for (int i = 0; i < str.Length; i++)
//            Console.WriteLine("{0}[{1}] = {2}", str, i, s[str, i]); // indexer의 get 동작
//        Console.WriteLine("Substring of {0} is {1}", str, s[str, 2, 3]); // indexer의 get 동작
//    }
//}