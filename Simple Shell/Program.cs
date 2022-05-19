using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Shell
{
    public enum TokenType
    {
        Command, Not_Recognized, FullPathToDirectory, FileName, DirName, FullPathToFile
    }
    public struct Token
    {
        public TokenType key;
        public string value;
    }
    class Program
    {
        public static Directory current;
        public static string currentPath;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to My Simple shell\n");
            Virtual_Disk.initalize("virtualDisk");
           // FAT.printFAT();
            currentPath = new string(current.dir_name);
            currentPath = currentPath.Trim(new char[] { '\0', ' ' });
            while (true)
            {
                Console.Write(currentPath + "\\" + ">");
                current.readDirectory();
                //for (int i = 0; i < current.DirOrFiles.Count; i++)
                //{
                //    Console.WriteLine(new string(current.DirOrFiles[i].dir_name) + $" fc={current.DirOrFiles[i].dir_firstCluster}");
                //}
                string input;
                input = Console.ReadLine();
                Parser.parse(input);
            }
        }
    }
}
