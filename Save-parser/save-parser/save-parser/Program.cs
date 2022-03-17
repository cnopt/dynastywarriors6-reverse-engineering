using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Buffers.Binary;
using CommandLine;
using Newtonsoft.Json;

class Program
{
    public class Options
    {
        [Option('f', "file", Required = true, HelpText = "Save file to parse")]
        public string File {get; set;}
    }

    public class Weapon
    {
        public int weaponId { get; set; }
        public string weaponName { get; set; }
    }

    public class DWOfficer
    {
        public string officerName { get; set; }
        //public int officerId { get; set; }
        public int officerLevel { get; set; }
        public string officerTitle { get; set; }
        public int officerKills { get; set; }
        public int officerXP { get; set; }
        public int costume { get; set; }
        public Weapon weapon1 { get; set; }
        public Weapon weapon2 { get; set; }
        public Weapon weapon3 { get; set; }
        public Weapon weapon4 { get; set; }
        public Weapon weapon5 { get; set; }
        public Weapon weapon6 { get; set; }
        public Weapon weapon7 { get; set; }
        public Weapon weapon8 { get; set; }
    }


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

        string file;
        

        Parser.Default.ParseArguments<Options>(args)
            .WithParsed<Options>(o =>
            {
                file = o.File;

                int numBytes = 4;
                byte[] test = new byte[numBytes];

                var officersDict = new Dictionary<int, string>()
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
                var titleMap = new Dictionary<int, string>()
                {
                    {0, "Lt. General" },
                    {1, "Assisstant General" },
                    {2, "Field General" },
                    {3, "Gate General" },
                    {4, "4th Foot General" },
                    {5, "3rd Foot General" },
                    {6, "Lt. Foot General" },
                    {7, "Foot General" },
                    {8, "4th Crusher General" },
                    {9, "3rd Crusher General" },
                    {10, "Lt. Crusher General" },
                    {11, "Crusher General" },
                    {12, "4th Guard General" },
                    {13, "3rd Guard General" },
                    {14, "Lt. Guard General" },
                    {15, "Guard General" },
                    {16, "Winged General" },
                    {17, "Flying General" },
                    {18, "Lt. Support General" },
                    {19, "Support General" },
                    {20, "4th Order General" },
                    {21, "3rd Order General" },
                    {22, "Lt. Order General" },
                    {23, "Order General" },
                    {24, "4th Slashing General" },
                    {25, "3rd Slashing General" },
                    {26, "Lt. Slashing General" },
                    {27, "Slashing General" },
                    {28, "4th Pacifying General" },
                    {29, "3rd Pacifying General" },
                    {30, "Lt. Pacifying General" },
                    {31, "Pacifying General" },
                    {32, "4th Pike General" },
                    {33, "3rd Pike General" },
                    {34, "Pike General" },
                    {35, "4th Dignified General" },
                    {36, "3rd Dignified General" },
                    {37, "Lt. Dignified General" },
                    {38, "Dignified General" },
                    {39, "4th Dispatch General" },
                    {40, "3rd Dispatch General" },
                    {41, "Lt. Dispatch General" },
                    {42, "Dispatch General" },
                    {43, "4th Cohort General" },
                    {44, "3rd Cohort General" },
                    {45, "Lt. Cohort General" },
                    {46, "Cohort General" },
                    {47, "Commander General" },
                    {48, "Restoring General" },
                    {49, "4th Justice General" },
                    {50, "3rd Justice General" },
                    {51, "Tower General" },
                    {52, "River General" },
                    {53, "Sea General" },
                    {54, "Plains General" },
                    {55, "Lt. Justice General" },
                    {56, "Justice General" },
                    {57, "Lt. Moral General" },
                    {58, "Moral General" },
                    {59, "4th Loyal General" },
                    {60, "3rd Loyal General" },
                    {61, "Lt. Loyal General" },
                    {62, "Loyal General" },
                    {63, "4th Trusted General" },
                    {64, "3rd Trusted General" },
                    {65, "Lt. Trusted General" },
                    {66, "Trusted General" },
                    {67, "4th Spear General" },
                    {68, "3rd Spear General" },
                    {69, "Lt. Spear General" },
                    {70, "Spear General" },
                    {71, "4th Resolute General" },
                    {72, "3rd Resolute General" },
                    {73, "Lt. Resolute General" },
                    {74, "Resolute General" },
                    {75, "4th Enchanter General" },
                    {76, "3rd Enchanter General" },
                    {77, "Lt. Enchanter General" },
                    {78, "Enchanter General" },
                    {79, "4th Assault General" },
                    {80, "3rd Assault General" },
                    {81, "Lt. Assault General" },
                    {82, "Assault General" },
                    {83, "4th Tiger General" },
                    {84, "3rd Tiger General" },
                    {85, "Lt. Tiger General" },
                    {86, "Tiger General" },
                    {87, "Negotiator General" },
                    {88, "Generous General" },
                    {89, "Right Flank General" },
                    {90, "Ambush General" },
                    {91, "Archer General" },
                    {92, "Lt. Crossbow General" },
                    {93, "Left Flank General" },
                    {94, "Lt. Rank General" },
                    {95, "Rank General" },
                    {96, "Lt. File General" },
                    {97, "File General" },
                    {98, "Lt. Horse General" },
                    {99, "Horse General" },
                    {100, "Lt. Banner General" },
                    {101, "Banner General" },
                    {102, "Lt. Lance General" },
                    {103, "Lance General" },
                    {104, "Sword General" },
                    {105, "Guardian General" },
                    {106, "Crane General" },
                    {107, "Stallion General" },
                    {108, "Garrison General" },
                    {109, "Escort General" },
                    {110, "Coommandant General" },
                    {111, "Warden General" },
                    {112, "Distinguished General" },
                    {113, "Capital General" },
                    {114, "Tiger's Fangs General" },
                    {115, "Rising Dragon General" },
                    {116, "4th Tranquil General" },
                    {117, "3rd Tranquil General" },
                    {118, "Lt. Tranquil General" },
                    {119, "Tranquil General" },
                    {120, "Peacemaker General" },
                    {121, "Peacekeeper General" },
                    {122, "Crown General" },
                    {123, "4th Elite General" },
                    {124, "3rd Elite General" },
                    {125, "Lt. Elite General" },
                    {126, "Elite General" },
                    {127, "Master General" },
                    {128, "Rear General" },
                    {129, "Front General" },
                    {130, "General of the Right" },
                    {131, "General of the Left" },
                    {132, "4th North General" },
                    {133, "4th West General" },
                    {134, "4th South General" },
                    {135, "4th East General" },
                    {136, "3rd North General" },
                    {137, "3rd West General" },
                    {138, "3rd South General" },
                    {139, "3rd East General" },
                    {140, "Lt. North General" },
                    {141, "Lt. West General" },
                    {142, "Lt. South General" },
                    {143, "Lt. East General" },
                    {144, "North General" },
                    {145, "West General" },
                    {146, "South General" },
                    {147, "East General" },
                    {148, "Perimeter General" },
                    {149, "Chariot General" },
                    {150, "Cavalier General" },
                    {151, "Grand General" },
                    {152, "Lord General" },
                };
                var weaponsDict = new Dictionary<int, string>()
                {
                    { 00, "Rock Crusher"},
                    { 01, "Wave Breaker"},
                    { 02, "Thundersmash"},
                    { 03, "Violent Soul Flail"},
                    { 04, "Lion's Head Flail"},
                    { 05, "Beserker Flail"},
                    { 06, " Eradication Claws"},
                    { 07, "Anguish Claws"},
                    { 08, "Necrosis Claws"},
                    { 09, "Twin Vipers"},
                    { 10, "Twin Dragons"},
                    { 11, "Twin Eagles"},
                    { 12, "Sword of Heaven"},
                    { 13, "Blue Blade"},
                    { 14, "Seven Star Sword"},
                    { 15, "Red Dusk"},
                    { 16, "Dark Night"},
                    { 17, "Scarlet Dawn"},
                    { 18, "Silver Swallow"},
                    { 19, "Blue Falcon"},
                    { 20, "Jade Warbler"},
                    { 21, "Madder Rose"},
                    { 22, "Wisteria Breeze"},
                    { 23, "Lotus Bow"},
                    { 24, "Crescent Moon"},
                    { 25, "Dancing Dragon"},
                    { 26, "Wing Blade"},
                    { 27, "Elder Sword"},
                    { 28, "Nine Hook Sword"},
                    { 29, "Golden Pheonix"},
                    { 30, "Dragon Spike"},
                    { 31, "Dragon Fang"},
                    { 32, "Dragon Talon"},
                    { 33, "Blue Dragon"},
                    { 34, "Black Dragon"},
                    { 35, "White Dragon"},
                    { 36, "Serpent Blade"},
                    { 37, "Python Blade"},
                    { 38, "Viper Blade"},
                    { 39, "Brilliance"},
                    { 40, "Distinction"},
                    { 41, "Enlightenment"},
                    { 42, "Strength and Virtue"},
                    { 43, "Heaven and Earth"},
                    { 44, "Yin and Yang"},
                    { 45, "Moonflower"},
                    { 46, "Dewflower"},
                    { 47, "Rainflower"},
                    { 48, "Sky Piercer"},
                    { 49, "Demon Bane"},
                    { 50, "Heron Blade Halberd"},
                    { 51, "Bone Crusher"},
                    { 52, "Chaos Crusher"},
                    { 53, "Whirlwind Crusher"},
                    { 54, "Heavens Destroyer"},
                    { 55, "Heavens Smasher"},
                    { 56, "Heavens Cutter"},
                    { 57, "Destroyer"},
                    { 58, "Annihilator"},
                    { 59, "Obliterator"},
                    { 60, "Splendor"},
                    { 61, "Mystery"},
                    { 62, "Ostentation"},
                    { 63, "Phoenix Wing"},
                    { 64, "Dragon Scale"},
                    { 65, "Tortoise Bite"},
                    { 66, "Havoc"},
                    { 67, "Mayhem"},
                    { 68, "Chaos"},
                    { 69, "Rage Trident"},
                    { 70, "Savage Trident"},
                    { 71, "Tsunami Trident"},
                    { 72, "Valor"},
                    { 73, "Spirit"},
                    { 74, "Courage"},
                    { 75, "River Slicer"},
                    { 76, "Mountain Breaker"},
                    { 77, "Sky Lasher"},
                    { 78, "Flashstrike"},
                    { 79, "Dawnstrike"},
                    { 80, "Duskstrike"},
                    { 81, "Flying Nimbus"},
                    { 82, "Rising Nimbus"},
                    { 83, "Lofting Nimbus"},
                    { 84, "Tryant Strike"},
                    { 85, "Glimmer Strike"},
                    { 86, "Stoic Strike"},
                    { 87, "Dragon's Might"},
                    { 88, "Heaven's Might"},
                    { 89, "Tiatan's Might"},
                    { 90, "Ironhorse Glaive"},
                    { 91, "Dragonrun Glaive"},
                    { 92, "Warsteed Glaive"},
                    { 93, "Immortal Blade"},
                    { 94, "Battle Master Blade"},
                    { 95, "Princeps Blade"},
                    { 96, "The Awakener"},
                    { 97, "Bone Splitter"},
                    { 98, "Stormhowl"},
                    { 99, "Blue Dragon Ji"},
                    { 100, "Black Dragon Ji"},
                    { 101, "White Dragon Ji"},
                    { 102, "Firestorm Staff"},
                    { 103, "Blizzard Staff"},
                    { 104, "Typhoon Staff"},
                    { 105, "Wizard Club"},
                    { 106, "Magus Club"},
                    { 107, "Augur Club"},
                    { 108, "Sword of Kings"},
                    { 109, "Sword of Severity"},
                    { 110, "North Star Sword"},
                    { 111, "Blaze Staff"},
                    { 112, "Blight Staff"},
                    { 113, "Judgement Staff"},
                    { 114, "Allure"},
                    { 115, "Charm"},
                    { 116, "Seduction"},
                    { 117, "True"},
                    { 118, "True Beauty"},
                    { 119, "True Luster"},
                    { 120, "Emerald Dew"},
                    { 121, "Emerald Veil"},
                    { 122, "Emerald Mist"},
                    { 174, "Empty" }
                };

                var DWOfficerDictionary = new Dictionary<string, DWOfficer>();

                
                using (BinaryReader reader = new BinaryReader(new FileStream(file, FileMode.Open)))
                {
                    int xpBaseStart = 3052;
                    int idBaseStart = 3036;
                    int killsBaseStart = 3056;
                    int costumeBaseStart = 3040;
                    int titleBaseStart = 3044;
                    int levelBaseStart = 3048;
                    int weapon1BaseStart = 2908;
                    int weapon2BaseStart = 2924;
                    int weapon3BaseStart = 2940;
                    int weapon4BaseStart = 2956;
                    int weapon5BaseStart = 2972;
                    int weapon6BaseStart = 2988;
                    int weapon7BaseStart = 3004;
                    int weapon8BaseStart = 3020;

                    int readerBuffer;

                    for (int i = 0; i < 6888; i++)
                    {

                        // create new item in dwofficerdictionary on each loop
                        // and new dwofficer 
                        DWOfficerDictionary.Add("DWOfficer" + i, new DWOfficer());


                        Console.WriteLine("*********");

                        reader.BaseStream.Seek(idBaseStart + i, SeekOrigin.Begin);
                        reader.Read(test, 0, 4);
                        DWOfficerDictionary["DWOfficer" + i].officerName = officersDict[reader.ReadInt32()];
                        //DWOfficerDictionary["DWOfficer" + i].officerId = reader.ReadInt32();
                        //Console.WriteLine("officer: " + officersDict[reader.ReadInt32()]);


                        reader.BaseStream.Seek(levelBaseStart + i, SeekOrigin.Begin);
                        reader.Read(test, 0, 4);
                        //Console.WriteLine("level: " + reader.ReadInt32());
                        DWOfficerDictionary["DWOfficer" + i].officerLevel = reader.ReadInt32();

                        reader.BaseStream.Seek(xpBaseStart + i, SeekOrigin.Begin);
                        reader.Read(test, 0, 4);
                        //Console.WriteLine("xp: " + reader.ReadInt32());
                        DWOfficerDictionary["DWOfficer" + i].officerXP = reader.ReadInt32();

                        reader.BaseStream.Seek(killsBaseStart + i, SeekOrigin.Begin);
                        reader.Read(test, 0, 4);
                        //Console.WriteLine("kills: " + reader.ReadInt32());
                        DWOfficerDictionary["DWOfficer" + i].officerKills = reader.ReadInt32();

                        reader.BaseStream.Seek(titleBaseStart + i, SeekOrigin.Begin);
                        reader.Read(test, 0, 4);
                        //Console.WriteLine("title: " + reader.ReadInt32());
                        DWOfficerDictionary["DWOfficer" + i].officerTitle = titleMap[reader.ReadInt32()];

                        reader.BaseStream.Seek(costumeBaseStart + i, SeekOrigin.Begin);
                        reader.Read(test, 0, 4);
                        DWOfficerDictionary["DWOfficer" + i].costume = reader.ReadInt32();
                        //Console.WriteLine("costume: " + reader.ReadInt32());

                        reader.BaseStream.Seek(weapon1BaseStart + i, SeekOrigin.Begin);
                        reader.Read(test, 0, 4);
                        // use temporary reader.readerint because calling reader.readerint causes the 
                        // buffer to move forward, so ONLY CALL THIS ONCE PER FUNCTION
                        readerBuffer = reader.ReadInt32();
                        DWOfficerDictionary["DWOfficer" + i].weapon1 = new Weapon {
                            weaponName = weaponsDict[readerBuffer],
                            weaponId = readerBuffer
                        };


                        reader.BaseStream.Seek(weapon2BaseStart + i, SeekOrigin.Begin);
                        reader.Read(test, 0, 4);
                        DWOfficerDictionary["DWOfficer" + i].weapon2 = new Weapon
                        {
                            weaponName = weaponsDict[reader.ReadInt32()],
                            weaponId = reader.ReadInt32()
                        };
                        //DWOfficerDictionary["DWOfficer" + i].weapon2.weaponName = weaponsDict[reader.ReadInt32()];
                        //Console.WriteLine("weapon 2: " + weaponsDict[reader.ReadInt32()]);

                        reader.BaseStream.Seek(weapon3BaseStart + i, SeekOrigin.Begin);
                        reader.Read(test, 0, 4);
                        DWOfficerDictionary["DWOfficer" + i].weapon3 = new Weapon
                        {
                            weaponName = weaponsDict[reader.ReadInt32()],
                            weaponId = reader.ReadInt32()
                        };
                        //DWOfficerDictionary["DWOfficer" + i].weapon3.weaponName = weaponsDict[reader.ReadInt32()];
                        //Console.WriteLine("weapon 3: " + weaponsDict[reader.ReadInt32()]);

                        reader.BaseStream.Seek(weapon4BaseStart + i, SeekOrigin.Begin);
                        reader.Read(test, 0, 4);
                        DWOfficerDictionary["DWOfficer" + i].weapon4 = new Weapon
                        {
                            weaponName = weaponsDict[reader.ReadInt32()],
                            weaponId = reader.ReadInt32()
                        };
                        //DWOfficerDictionary["DWOfficer" + i].weapon4.weaponName = weaponsDict[reader.ReadInt32()];
                        //Console.WriteLine("weapon 4: " + weaponsDict[reader.ReadInt32()]);

                        reader.BaseStream.Seek(weapon5BaseStart + i, SeekOrigin.Begin);
                        reader.Read(test, 0, 4);
                        DWOfficerDictionary["DWOfficer" + i].weapon5 = new Weapon
                        {
                            weaponName = weaponsDict[reader.ReadInt32()],
                            weaponId = reader.ReadInt32()
                        };
                        //DWOfficerDictionary["DWOfficer" + i].weapon5.weaponName = weaponsDict[reader.ReadInt32()];
                        //Console.WriteLine("weapon 5: " + weaponsDict[reader.ReadInt32()]);

                        reader.BaseStream.Seek(weapon6BaseStart + i, SeekOrigin.Begin);
                        reader.Read(test, 0, 4);
                        DWOfficerDictionary["DWOfficer" + i].weapon6 = new Weapon
                        {
                            weaponName = weaponsDict[reader.ReadInt32()],
                            weaponId = reader.ReadInt32()
                        };
                        //DWOfficerDictionary["DWOfficer" + i].weapon6.weaponName = weaponsDict[reader.ReadInt32()];
                        //Console.WriteLine("weapon 6: " + weaponsDict[reader.ReadInt32()]);

                        reader.BaseStream.Seek(weapon7BaseStart + i, SeekOrigin.Begin);
                        reader.Read(test, 0, 4);
                        DWOfficerDictionary["DWOfficer" + i].weapon7 = new Weapon
                        {
                            weaponName = weaponsDict[reader.ReadInt32()],
                            weaponId = reader.ReadInt32()
                        };
                        //DWOfficerDictionary["DWOfficer" + i].weapon7.weaponName = weaponsDict[reader.ReadInt32()];
                        //Console.WriteLine("weapon 7: " + weaponsDict[reader.ReadInt32()]);

                        reader.BaseStream.Seek(weapon8BaseStart + i, SeekOrigin.Begin);
                        reader.Read(test, 0, 4);
                        DWOfficerDictionary["DWOfficer" + i].weapon8 = new Weapon
                        {
                            weaponName = weaponsDict[reader.ReadInt32()],
                            weaponId = reader.ReadInt32()
                        };
                        //DWOfficerDictionary["DWOfficer" + i].weapon8.weaponName = weaponsDict[reader.ReadInt32()];
                        //Console.WriteLine("weapon 8: " + weaponsDict[reader.ReadInt32()]);

                        string json = JsonConvert.SerializeObject(DWOfficerDictionary["DWOfficer" + i], Formatting.Indented);
                        Console.WriteLine(json);

                        Console.WriteLine("********* \n\n");


                        i = i + 167;
                        // 168 bytes per officer 
                        // fyi - save.dat bytes 2904 to 9791
                        // 6888 / 168 = 41 :)



                    }

                }

            });

        while (true) ;
    }

    static string DecodeOfficerId(int id)
    {
        if (id == 10)
            return "Xiahou Dun";

        else
            return "idk";
    }
}

   

