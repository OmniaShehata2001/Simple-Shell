//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Simple_Shell
//{
//    class command
//    {
//        static void Help()
//        {
//            Console.WriteLine(" - cd: sued to change the current directory.");
//            Console.WriteLine(" - quit: used to terminate the shell.");
//            Console.WriteLine(" - import: used to import some file from the virtual os.");
//            Console.WriteLine(" - export: used to export some file to the virtual os.");
//            Console.WriteLine(" - dir: used to list all the files and sub-directories int the current path.");
//            Console.WriteLine(" - md: used to create new directories.");
//            Console.WriteLine(" - rd: used to remove directories.");
//            Console.WriteLine(" - rm: used to remove files.");
//            Console.WriteLine(" - cls: used to clear the screen.");
//            Console.WriteLine(" - move: used to move files.");
//            Console.WriteLine(" - copy: used to copy files.");
//        }


//        static void Main(string[] args)
//        {
//            string path = "c:/";
//            string statment;
//            string[] commands = { "cd", "cls", "help", "dir", "quit", "copy", "del", "md", "rd", "rename", "type", "import", "emport" };
//            bool open = true;

//            while (open)
//            {
//                bool flag = false;


//                Console.Write(path + "> ");
//                statment = Console.ReadLine();
//                statment = statment.ToLower();
//                string[] arrcommand = statment.Split(' ');

//                for (int i = 0; i < commands.Length; i++)
//                {
//                    if (arrcommand[0] == commands[i])
//                    {
//                        flag = true;
//                    }
//                }

//                if (flag == true)
//                {
//                    if (arrcommand.Length == 1)
//                    {
//                        if (arrcommand[0] == "help")
//                        {
//                            Help();
//                        }
//                        else if (arrcommand[0] == "cls")
//                        {
//                            Console.Clear();
//                        }
//                        else if (arrcommand[0] == "quit")
//                        {
//                            System.Environment.Exit(0);

//                        }


//                        else
//                        {
//                            Console.WriteLine(" error : command  need argument");
//                        }
//                    }
//                    else if (arrcommand.Length == 2)
//                    {
//                        if (arrcommand[0] == "cd")
//                        {
//                            int Last_index = 0, First_index = 0;
//                            int count = 0, start = 0;


//                            if (arrcommand[1] != "..")
//                                path += arrcommand[1] + "/";
//                            else if (arrcommand[1] == "..")
//                            {
//                                if (path.Length != 3)
//                                {
//                                    for (int i = 0; i < path.Length; i++)
//                                    {
//                                        Last_index = path.IndexOf("/", i);
//                                        i = Last_index;
//                                        count++;
//                                    }
//                                    for (int i = 0; i < count - 1; i++)
//                                    {
//                                        First_index = path.IndexOf("/", start + 1);
//                                        start = First_index;
//                                    }
//                                    path = path.Remove(First_index + 1);
//                                }
//                            }
//                        }
//                        else if (arrcommand[0] == "md")
//                        {
//                            Console.WriteLine("md command is true");
//                        }
//                        else if (arrcommand[0] == "rd")
//                        {
//                            Console.WriteLine("dir command is true ");
//                        }
//                        else if (arrcommand[0] == "rename")
//                        {
//                            Console.WriteLine("rename command is true");
//                        }
//                        else if (arrcommand[0] == "type")
//                        {
//                            Console.WriteLine("type command is true");
//                        }
//                        else if (arrcommand[0] == "import")
//                        {
//                            Console.WriteLine("import command is true");
//                        }
//                        else if (arrcommand[0] == "export")
//                        {
//                            Console.WriteLine("export command is true");
//                        }
//                        else
//                        {
//                            Console.WriteLine(" error : in argument");
//                        }
//                    }
//                    else if (arrcommand.Length == 3)
//                    {
//                        if (arrcommand[0] == "copy")
//                        {
//                            Console.WriteLine("copy command is true");
//                        }
//                    }
//                    else
//                    {
//                        Console.WriteLine("invalid parameters");
//                    }
//                }
//                else
//                {
//                    Console.WriteLine("command is not valid");
//                }
//            }
//        }
//    }
//}
