using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib_1
{
   public static class MyFile
    {
      public  static void generateFile(String path, double sizeInMb)
        {
            String fileName = path;
            const int blockSize = 1024 * 8;
            const int blocksPerMb = (1024 * 1024) / blockSize;
            char[] data = new char[blockSize];
            Random rng = new Random();
            using (BinaryWriter stream = new BinaryWriter(File.OpenWrite(fileName)))
            {
                // There 
                for (int i = 0; i < sizeInMb * blocksPerMb; i++)
                {
                    Char[] pwdChars = new Char[36] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                    for (int j = 0; j < data.Length; j++)
                    {
                        data[j] = pwdChars[rng.Next(0, 36)];
                    }
                    stream.Write(data, 0, data.Length);
                }
            }
        }
    }
 public   static class Sort
    {
      public  static void MergeSort(String path)
        {
            String path_1 = @"D:\lol_1.txt";
            String path_2 = @"D:\lol_2.txt";

            char l_1, l_2;
            bool end = false;
            while (!end)
            {
                // end = true; 
                int num = 1;
                Stream f = File.Open(path, FileMode.Open);
                Stream f_1 = File.Open(path_1, FileMode.Create);
                Stream f_2 = File.Open(path_2, FileMode.Create);
                using (BinaryWriter fw_1 = new BinaryWriter(f_1))
                using (BinaryWriter fw_2 = new BinaryWriter(f_2))
                using (BinaryReader fr = new BinaryReader(f))
                {
                    if (fr.PeekChar() > -1)
                    {
                        l_1 = fr.ReadChar();
                        while (fr.PeekChar() > -1)
                        {

                            l_2 = fr.ReadChar();

                            switch (num)
                            {
                                case 1: fw_1.Write(l_1); break;
                                case 2: fw_2.Write(l_1); break;
                            }
                            if (l_1 > l_2)
                            {
                                if (num == 1)
                                {
                                    fw_1.Write('*');
                                    num = 2;
                                }
                                else
                                {
                                    fw_2.Write('*');
                                    num = 1;
                                }

                            }

                            l_1 = l_2;

                        }
                        switch (num)
                        {
                            case 1: fw_1.Write(l_1); break;
                            case 2: fw_2.Write(l_1); break;

                        }
                    }
                }

                f_1 = File.Open(path_1, FileMode.Open);
                f_2 = File.Open(path_2, FileMode.Open);
                f = File.Open(path, FileMode.Create);
                using (BinaryReader fr_1 = new BinaryReader(f_1))
                using (BinaryReader fr_2 = new BinaryReader(f_2))
                using (BinaryWriter fw = new BinaryWriter(f))

                {
                    bool isL1 = false;
                    bool isL2 = false;
                    if (fr_1.PeekChar() > -1 && fr_2.PeekChar() > -1)
                    {
                        l_1 = fr_1.ReadChar();
                        l_2 = fr_2.ReadChar();

                        while (fr_1.PeekChar() > -1 || fr_2.PeekChar() > -1)
                        {

                            if (l_1 < l_2)
                            {
                                fw.Write(l_1);
                                // Console.WriteLine($"l1:{l_1}");
                                if (fr_1.PeekChar() > -1)
                                {
                                    l_1 = fr_1.ReadChar();
                                }
                                else
                                {
                                    isL1 = true;
                                    break;
                                }
                            }
                            else
                            {

                                fw.Write(l_2);
                                // Console.WriteLine($"l2:{l_2}");
                                if (fr_2.PeekChar() > -1)
                                {
                                    l_2 = fr_2.ReadChar();
                                }
                                else
                                {
                                    isL2 = true;
                                    break;
                                }

                            }
                            if (l_1 == '*')
                            {
                                if (fr_1.PeekChar() > -1)
                                {
                                    l_1 = fr_1.ReadChar();
                                }
                                else
                                {
                                    isL1 = true;
                                }
                                while (l_2 != '*' && fr_2.PeekChar() > -1)
                                {
                                    fw.Write(l_2);
                                    l_2 = fr_2.ReadChar();
                                }
                                if (l_2 == '*' && fr_2.PeekChar() > -1)
                                {
                                    l_2 = fr_2.ReadChar();

                                }
                                else if (fr_2.PeekChar() <= -1)
                                {
                                    isL2 = true;
                                }
                            }
                            if (l_2 == '*')
                            {
                                if (fr_2.PeekChar() > -1)
                                {
                                    l_2 = fr_2.ReadChar();
                                }
                                else
                                {
                                    isL2 = true;
                                }
                                while (l_1 != '*' && fr_1.PeekChar() > -1)
                                {
                                    fw.Write(l_1);
                                    l_1 = fr_1.ReadChar();
                                }
                                if (l_1 == '*' && fr_1.PeekChar() > -1)
                                {
                                    l_1 = fr_1.ReadChar();

                                }
                                else
                                if (fr_1.PeekChar() <= -1)
                                {
                                    isL1 = true;
                                }
                            }
                        }
                        //   Console.WriteLine();
                        if (isL1 && !isL2)
                        {
                            //       Console.WriteLine($"l2+:{l_2}");
                            fw.Write(l_2);
                        }
                        else if (isL2 && !isL1)
                        {
                            //     Console.WriteLine($"l1+:{l_1}");
                            fw.Write(l_1);
                        }
                        else if (!isL1 && !isL2)
                        {
                            if (l_1 < l_2)
                            {
                                //  Console.WriteLine($"l1:{l_1}");
                                //  Console.WriteLine($"l2:{l_2}");
                                fw.Write(l_1);
                                fw.Write(l_2);
                            }
                            else
                            {
                                //  Console.WriteLine($"l2:{l_2}");
                                //  Console.WriteLine($"l1:{l_1}");
                                fw.Write(l_2);
                                fw.Write(l_1);
                            }
                        }

                    }
                    //  Console.WriteLine();
                    while (fr_1.PeekChar() > -1)
                    {

                        l_1 = fr_1.ReadChar();
                        //  Console.WriteLine($"l1++:{l_1}");
                        if (l_1 != '*')
                            fw.Write(l_1);


                    }
                    while (fr_2.PeekChar() > -1)
                    {
                        l_2 = fr_2.ReadChar();
                        //   Console.WriteLine($"l2++:{l_2}");
                        if (l_2 != '*')
                            fw.Write(l_2);
                    }

                    if (f_1.Length == 0 || f_2.Length == 0)
                    {
                        end = true;
                    }
                    // end = true;
                    // Console.WriteLine();
                    // Console.WriteLine();

                }

            }
        }
    }
}

