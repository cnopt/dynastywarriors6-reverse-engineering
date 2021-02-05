using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Buffers.Binary;

class Program
{
    static void Main(string[] args)
    {
        R();
    }

    static void R()
    {
        string file = @"C:\Users\TTGCh\Desktop\dw6-saves\new-save.dat";
        int numBytes = 2;
        byte[] test = new byte[numBytes];

        // To read data at specific byte: Address = Seek offset + number of bytes
        // i.e. to get data at offset 100 = Seek offset 99, as number of bytes is set to 1
        // if changing the size of bytes, adjust offset up or down
        // holy shit i finally figured it out
        // was using reader.read(), was giving me a random fucking idiot number.
        // even reversing the endianness was still giving out random shit
        // tried converting to int16/int32 AFTER read(), was still giving the same result. 
        // reserved the endianness WHILE ALSO reading it as an int16 gave out -26330, which is
        // 9981 in big endian. so i reversed and back and bam, 9881 returned

        using (BinaryReader reader = new BinaryReader(new FileStream(file, FileMode.Open)))
        {
            reader.BaseStream.Seek(4738, SeekOrigin.Begin); // where to start reading from 
            reader.Read(test, 0, numBytes); // number of bytes to read
            var val1 = reader.ReadInt16();

 

            Console.WriteLine(val1);
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

