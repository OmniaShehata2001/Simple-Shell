using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Shell
{
    class FAT
    {
        public static int[] Fat = new int[1024];
        public static void createFAT()
        {
            for (int i = 0; i < Fat.Length; i++)
            {
                if (i == 0 || i == 4)
                {
                    Fat[i] = -1;
                }
                else if (i > 0 && i <= 3)
                {
                    Fat[i] = i + 1;
                }
                else
                {
                    Fat[i] = 0;
                }
            }
        }
        public static void writeFAT()
        {
            byte[] FATBYTES = Converter.ToBytes(FAT.Fat);
            List<byte[]> ls = Converter.splitBytes(FATBYTES);
            for (int i = 0; i < ls.Count; i++)
            {
                Virtual_Disk.writeCluster(ls[i], i + 1, 0, ls[i].Length);
            }
        }
        public static void readFAT()
        {
            List<byte> ls = new List<byte>();
            for (int i = 1; i <= 4; i++)
            {
                ls.AddRange(Virtual_Disk.readCluster(i));
            }
            Fat = Converter.ToInt(ls.ToArray());
        }
        public static void printFAT()
        {
            Console.WriteLine("FAT has the following: ");
            for (int i = 0; i < Fat.Length; i++)
                Console.WriteLine("FAT[" + i + "] = " + Fat[i]);
        }
        public static void setFAT(int[] arr)
        {
            if (arr.Length <= 1024)
                Fat = arr;
        }
        public static int getAvilableCluster()
        {
            for (int i = 0; i < Fat.Length; i++)
            {
                if (Fat[i] == 0)
                    return i;
            }
            return -1;//our disk is full
        }
        public static void setClusterPointer(int clusterIndex, int pointer)
        {
            Fat[clusterIndex] = pointer;
        }
        public static int getClusterPointer(int clusterIndex)
        {
            if (clusterIndex >= 0 && clusterIndex < Fat.Length)
                return Fat[clusterIndex];
            else
                return -1;
        }
    }
}
