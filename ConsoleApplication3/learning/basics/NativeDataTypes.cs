using System;

namespace ConsoleApplication3.learning.basics
{
    public class NativeDataTypes
    {  
         
        
        // integer
        int a = 0; //-> natural number, without floating comma. Maximal value is: 2,147,483,647
        // That int is equals value the 0, have many strurtur's Int16, Int32(that standard type)
         Int16 b = 10; // one structure of int, max value: 32767
         Int32 c = 999; // Standard int structure, max value above
         Int64 d = 33; // integer structure which can be is long, max value equals: 9223372036854775807
         UInt16 e = 12; // next basic structure of the integer, max value is: 965535
         UInt32 f = 400; // next basic tructure of the integer? max value equals is: 4,294,967,295 maximal approximate to standard int
         
         // long
         long g = 333; // same as int , but no larger maximum
         // bytes
         byte h = 10; // very very small format of data. maximal value is 128
         // short
         short i = 65; // smallest  type of of integer. max value is 655535 
         // float
          float j = 12f; //numbers with floating comma, vax value 340,282,300,000,000,000,000,000,000,000,000,000,000, when intialize the float fields, dont forget letter  in the end of initilization
         //double
          double k = 333333; // that number can be inialized with floating comma, please, if you use the floating comme when initialize this type, don forget the d letter in the end, else compiller throws you compile error  
    } 
    
}