﻿using System.IO.Compression;

namespace switchcase;

class Program
{
    static void Main(string[] args)
    {
        int month=DateTime.Now.Month;

        //Expression
        switch(month){
            case 1: Console.WriteLine("ocak"); break;
            case 2: Console.WriteLine("subat"); break;
            case 3: Console.WriteLine("mart"); break;
            case 4: Console.WriteLine("nisan"); break;
            case 5: Console.WriteLine("mayıs"); break;
            case 6: Console.WriteLine("haziran"); break;
            case 7: Console.WriteLine("temmuz"); break;
            case 8: Console.WriteLine("haziran"); break;
            case 9: Console.WriteLine("temmuz"); break;
            case 10: Console.WriteLine("agustos"); break;
            case 11: Console.WriteLine("eylül"); break;
            case 12: Console.WriteLine("ekim"); break;
            default: Console.WriteLine("hatalı giriş"); break;
            }
        
            switch(month){
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("kış");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("ilkbahar");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("kış");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("ilkbahar");
                    break;
                default: break;

            }
            
    }
}
