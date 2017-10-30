using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastSort
{
    class Program
    {
        static void Main()
        {
            //using(StreamWriter writer = File.CreateText("reminders.txt"))
            // {
            //     writer.WriteLine("Don't forget Mother's Day this Year...");
            //     writer.WriteLine("Don't forget Mother's Day this Year...");
            //     writer.WriteLine("Don't forget these numbers :");
            //     for(int i = 0;i < 10; i++)
            //         writer.Write(i + " ");

            //     writer.Write(writer.NewLine);
            // }

            // Console.WriteLine("Created file and wrote some thoughts...");

            //using(StreamReader sr = File.OpenText("reminders.txt"))
            //{
            //    string input = null;
            //    while((input = sr.ReadLine()) != null)
            //    {
            //        Console.WriteLine(input);
            //    }
            //}

            FileSystemWatcher watcher = new FileSystemWatcher();
            try
            {
                watcher.Path = @"D:\MyFolder";
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.LastWrite | NotifyFilters.DirectoryName;

            watcher.Filter = "*.txt";

            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);

            watcher.EnableRaisingEvents = true;
            Console.WriteLine(@"Press 'q' to quit app.");
            while (Console.Read() != 'q') ;

        }

        static void OnChanged(object source,FileSystemEventArgs e)
        {
            Console.WriteLine("File : {0} {1} !", e.FullPath, e.ChangeType);
        }

        static void OnRenamed(object source,RenamedEventArgs e)
        {
            Console.WriteLine("File : {0} renamed to {1}", e.OldFullPath, e.FullPath);
        }
    }
}
