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

        // To read data at specific byte: Address = Seek offset + number of bytes
        // i.e. to get data at offset 100 = Seek offset 99, as number of bytes is set to 1
        // if changing the size of bytes, adjust offset up or down
        // holy shit i finally figured it out
        // was using reader.read(), was giving me a random fucking idiot number.
        // even reversing the endianness was still giving out random shit
        // tried converting to int16/int32 AFTER read(), was still giving the same result. 
        // reserved the endianness WHILE ALSO reading it as an int16 gave out -26330, which is
        // 9981 in big endian. so i reversed and back and bam, 9881 returned
        // seems like officer XP could start at index 3052. previously it was around 4700
        // as i thought it started at zhao yun, but looks like it might start with the Wei officers
        // playable officers = 41, officer stat block = 168 bytes, 168*41 = 6888


        string file = @"C:\Users\TTGCh\Desktop\dw6-saves\save.dat";
        //string officer = args[0];
        int numBytes = 4;
        byte[] test = new byte[numBytes];

        var officerDict = new Dictionary<int, string>()
        {
            {0, "Xiahou Dun"},
            {1, "Dian Wei"},
            {2, "Sima Yi"},
            {3, "Zhang Liao"},
            {4, "Cao Cao"},
            {5, "Zhou Yu"},
            {6, "Lu Xun"},
            {7, "Sun Shang Xiang"},
            {8, "Gan Ning"},
            {9, "Sun Jian"},
            {10, "Zhao Yun"},
            {11, "Guan Yu"},
            {12, "Zhang Fei"},
            {13, "Zhuge Liang"},
            {14, "Liu Bei"},
            {15, "Diao Chan"},
            {16, "Lu Bu"},
            {17, "Xu Zhu"},
            {18, "Xiahou Yuan"},
            {19, "Xu Huang"},
            {20, "Zhang He"},
            {21, "Cao Ren"},
            {22, "Cao Pi"},
            {23, "Taishi Ci"},
            {24, "Lu Meng"},
            {25, "Huang Gai"},
            {26, "Zhou Tai"},
            {27, "Ling Tong"},
            {28, "Sun Ce"},
            {29, "Sun Quan"},
            {30, "Ma Chao"},
            {31, "Huang Zhong"},
            {32, "Wei Yan"},
            {33, "Guan Ping"},
            {34, "Pang Tong"},
            {35, "Dong Zhuo"},
            {36, "Yuan Shao"},
            {37, "Zhang Jiao"},
            {38, "Zhen Ji"},
            {39, "Xiao Qiao"},
            {40, "Yue Ying"}
        };
        var titleDict = new Dictionary<int, string>()
        {
            {0, "Lt. General" },
            {1, "Assisstant General" },
            {2, "Field General" },
        };


        using (BinaryReader reader = new BinaryReader(new FileStream(file, FileMode.Open)))
        {
            int xpBaseStart         = 3052;
            int idBaseStart         = 3036;
            int killsBaseStart      = 3056;
            int costumeBaseStart    = 3040;
            int titleBaseStart      = 3044;
            int levelBaseStart      = 3048;
            int weapon1BaseStart    = 2908;
            int weapon2BaseStart    = 2924;
            int weapon3BaseStart    = 2940;
            int weapon4BaseStart    = 2956;
            int weapon5BaseStart    = 2972;
            int weapon6BaseStart    = 2988;
            int weapon7BaseStart    = 3004;
            int weapon8BaseStart    = 3020;

            for (int i = 0; i < 6888; i++)
            {
                Console.WriteLine("*********");


                reader.BaseStream.Seek(idBaseStart + i, SeekOrigin.Begin);
                reader.Read(test, 0, 4);
                Console.WriteLine("officer: " + (officerDict[reader.ReadInt32()]));

                reader.BaseStream.Seek(xpBaseStart + i, SeekOrigin.Begin);
                reader.Read(test, 0, 4);
                Console.WriteLine("xp: " + reader.ReadInt32());

                reader.BaseStream.Seek(killsBaseStart + i, SeekOrigin.Begin);
                reader.Read(test, 0, 4);
                Console.WriteLine("kills: " + reader.ReadInt32());

                reader.BaseStream.Seek(levelBaseStart + i, SeekOrigin.Begin);
                reader.Read(test, 0, 4);
                Console.WriteLine("level: " + reader.ReadInt32());

                reader.BaseStream.Seek(titleBaseStart + i, SeekOrigin.Begin);
                reader.Read(test, 0, 4);
                Console.WriteLine("title: " + reader.ReadInt32());

                reader.BaseStream.Seek(costumeBaseStart + i, SeekOrigin.Begin);
                reader.Read(test, 0, 4);
                Console.WriteLine("costume: " + reader.ReadInt32());


                reader.BaseStream.Seek(weapon1BaseStart + i, SeekOrigin.Begin);
                reader.Read(test, 0, 4);
                Console.WriteLine("weapon 1: " + reader.ReadInt32());

                reader.BaseStream.Seek(weapon2BaseStart + i, SeekOrigin.Begin);
                reader.Read(test, 0, 4);
                Console.WriteLine("weapon 2: " + reader.ReadInt32());

                reader.BaseStream.Seek(weapon3BaseStart + i, SeekOrigin.Begin);
                reader.Read(test, 0, 4);
                Console.WriteLine("weapon 3: " + reader.ReadInt32());

                reader.BaseStream.Seek(weapon4BaseStart + i, SeekOrigin.Begin);
                reader.Read(test, 0, 4);
                Console.WriteLine("weapon 4: " + reader.ReadInt32());

                reader.BaseStream.Seek(weapon5BaseStart + i, SeekOrigin.Begin);
                reader.Read(test, 0, 4);
                Console.WriteLine("weapon 5: " + reader.ReadInt32());

                reader.BaseStream.Seek(weapon6BaseStart + i, SeekOrigin.Begin);
                reader.Read(test, 0, 4);
                Console.WriteLine("weapon 6: " + reader.ReadInt32());

                reader.BaseStream.Seek(weapon7BaseStart + i, SeekOrigin.Begin);
                reader.Read(test, 0, 4);
                Console.WriteLine("weapon 7: " + reader.ReadInt32());

                reader.BaseStream.Seek(weapon8BaseStart + i, SeekOrigin.Begin);
                reader.Read(test, 0, 4);
                Console.WriteLine("weapon 8: " + reader.ReadInt32());


                Console.WriteLine("********* \n\n");

                i = i + 167;
            }

   

            /*
            reader.BaseStream.Seek(4736, SeekOrigin.Begin);     // where to start reading from 
            reader.Read(test, 0, 4);                            // number of bytes to read
            int zhaoYunKillsVal = reader.ReadInt32(); // this has two extra bytes of 0's so might be stored as an int32 to allow for huge values

            reader.BaseStream.Seek(4732, SeekOrigin.Begin);
            reader.Read(test, 0, 4);
            int zhaoYunXP = reader.ReadInt32(); // also a 32bit int

            reader.BaseStream.Seek(4726, SeekOrigin.Begin);
            reader.Read(test, 0, 2);
            int zhaoYunTitle = reader.ReadInt16();

            reader.BaseStream.Seek(4730, SeekOrigin.Begin);
            reader.Read(test, 0, 2);
            int zhaoYunLevel = reader.ReadInt16();

            // offset between XP = 168????
            reader.BaseStream.Seek(4900, SeekOrigin.Begin);
            reader.Read(test, 0, 4);
            int guanYuXP = reader.ReadInt32();

            // 5068 = next officer xp??
            reader.BaseStream.Seek(5068, SeekOrigin.Begin);
            reader.Read(test, 0, 4);
            int zhangFeiXP = reader.ReadInt32();
        

            reader.BaseStream.Seek(5236, SeekOrigin.Begin);
            reader.Read(test, 0, 4);
            int zhugeLiangXP = reader.ReadInt32();
            */


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

    static string DecodeOfficerId(int id)
    {
        if (id == 10)
            return "Xiahou Dun";

        else
            return "idk";
    }

    static string DecodeOfficerTitle(int title)
    {
        return "idk";
    }
}


