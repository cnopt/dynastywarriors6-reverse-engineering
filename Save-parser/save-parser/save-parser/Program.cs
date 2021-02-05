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
        int numBytes = 1;
        byte[] test = new byte[numBytes];

        // To read data at specific byte: Address = Seek offset + number of bytes
        // i.e. to get data at offset 100 = Seek offset 99, as number of bytes is set to 1
        // if changing the size of bytes, adjust offset up or down

        using (BinaryReader reader = new BinaryReader(new FileStream(file, FileMode.Open)))
        {
            reader.BaseStream.Seek(99, SeekOrigin.Begin); // where to start reading from 
            reader.Read(test, 0, numBytes); // number of bytes to read
            var val1 = reader.Read();

            reader.BaseStream.Seek(103, SeekOrigin.Begin); // where to start reading from 
            reader.Read(test, 0, numBytes); // number of bytes to read
            var val2 = reader.Read();

            Console.WriteLine(val1);
            Console.WriteLine(val2);
        }

        // read all
        //FileStream fs = new FileStream(file, FileMode.Open);
        //int hexIn;
        //String hex;
        //
        //for (int i = 0; (hexIn = fs.ReadByte()) != -1; i++)
        //{
        //    hex = string.Format("{0:X2}", hexIn);
        //    Console.Write(hex);
        //}






        while (true) ;
    }
}

