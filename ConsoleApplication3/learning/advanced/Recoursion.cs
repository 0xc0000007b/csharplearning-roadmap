using System;
using System.Net;

namespace ConsoleApplication3
{
    public class Recoursion
    {
       
        public void DigitsOfNumber(int a)
        {
            
            Console.Write(a + " ");
            if( a > 1) DigitsOfNumber(a-1);
        } // write all digits from a to 1

        public  void ParsePage()
        { 
            using (WebClient wc = new WebClient())
            {
                string link = "https://www.anekdot.ru/last/anekdot/";
                string parsed = wc.DownloadString(link);
                 Console.WriteLine(parsed);
            }
        }
        
        
    }
}