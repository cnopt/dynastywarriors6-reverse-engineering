using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        R();
    }

    static void R()
    {
        string file = @"C:\Users\TTGCh\Desktop\dw6-saves\new-save.dat";

        // read all
        FileStream fs = new FileStream(file, FileMode.Open);
        int hexIn;
        String hex;
        
        for (int i = 0; (hexIn = fs.ReadByte()) != -1; i++)
        {
            hex = string.Format("{0:X2}", hexIn);
            Console.Write(hex);
        }





        while (true) ;
    }
}

