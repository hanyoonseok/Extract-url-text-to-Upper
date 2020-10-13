using System;
using System.IO;
using static System.Console;
using System.Text.RegularExpressions;

namespace ossHW6
{
    class hw6
    {
        static void Main(string[] args)
        {
            string txt = File.ReadAllText(args[0]); //txt파일 읽기
            MatchCollection match = Regex.Matches(txt, args[1]); //문자열 txt에서 2번째인자 args[1] 이라는 문자가 몇 개인지
            int cnt = match.Count;
            WriteLine(cnt.ToString());
            /*
            string pageSourceStr = string.Empty; //페이지의 txt 들어갈 string 변수
            string upperSource; //대문자로 변환할 txt 담을 string 변수

            pageSourceStr = source.ReadToEnd(); //페이지 처음부터 끝까지 읽기
            response.Close(); //스트림 종료

            upperSource = pageSourceStr.ToUpper(); //대문자 변환

            StreamWriter strwrt;
            strwrt = File.CreateText("1342-0.txt"); //저장될 파일명
            strwrt.Write(upperSource);
            strwrt.Close();*/
        }
    }
}
