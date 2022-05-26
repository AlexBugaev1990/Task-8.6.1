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
                    
                    foreach (var item in dirInfo.GetFiles())
                    {
                        if (DateTime.Now - item.LastAccessTime  > TimeSpan.FromMinutes(1))
                        {
                            item.Delete();
                        }
                    }
                    foreach (DirectoryInfo dir in dirInfo.GetDirectories())
                    {
                        if (DateTime.Now - dir.LastAccessTime > TimeSpan.FromMinutes(1))
                        {
                            dir.Delete(true);
                        }
                    }
                    Console.WriteLine("Файлы и папки успешно удалены");
                }
                else
                {
                    Console.WriteLine("Путь указан не верно");
                }
                
            }

            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e.Message);

            }
        }
    }
}
