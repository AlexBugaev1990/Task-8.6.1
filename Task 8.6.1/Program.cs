using System;
using System.IO;

namespace Task_8._6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите путь к файлам");
            string Path = Console.ReadLine();
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(Path);
                if (dirInfo.Exists)
                {
                    foreach (FileInfo file in dirInfo.GetFiles())
                        file.Delete();
                    foreach (DirectoryInfo dir in dirInfo.GetDirectories())
                    {
                        dir.Delete(true);
                    }
                    Console.WriteLine("Файлы и папки успешно удалены");
                }
                else
                {
                    Console.WriteLine("Путь указан не верно");
                }
                
            }
            
             catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }
    }
}
