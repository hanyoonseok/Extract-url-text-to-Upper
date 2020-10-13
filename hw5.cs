using System;
using System.Text;
using System.IO;
using System.Web;
using System.Net;
using static System.Console;

namespace ossHW
{
    class MainApp
    {
        static void Main(string[] args)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(args[0]);
            request.Method = "GET";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader source = new StreamReader(response.GetResponseStream()); //http로부터 내용 읽기

            string pageSourceStr = string.Empty; //페이지의 txt 들어갈 string 변수
            string upperSource; //대문자로 변환할 txt 담을 string 변수

            pageSourceStr = source.ReadToEnd(); //페이지 처음부터 끝까지 읽기
            response.Close(); //스트림 종료

            upperSource = pageSourceStr.ToUpper(); //대문자 변환

            StreamWriter strwrt;
            strwrt = File.CreateText("1342-0.txt"); //저장될 파일명
            strwrt.Write(upperSource);
            strwrt.Close();
        }
    }
 
}
