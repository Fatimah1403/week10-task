using System;
using System.IO;
namespace MyTask2

{
    public class FileManagement
    {
        public static string filepath = @"../MyTask2/Example.txt";
        public static void FileStuff()
        {
        
            // File ->
            // FileInfo -Instantaneous
            // FileInfo fileInfo = new FileInfo();
            // Directory
            // DirectoryInfo
            // var file = File.Create("../MyTask2/Example.txt");
            // System.Console.WriteLine(file.CanRead);
            // System.Console.WriteLine(file.CanWrite);
            // System.Console.WriteLine(file.Name);


           

            // if (!File.Exists(path))
            {
                using StreamWriter sw = File.CreateText(filepath);

            }

            // using (StreamWriter streamWriter = File.AppendText(filepath))
            // {
            //     streamWriter.WriteLine("Full Name,Email Address,Hospital list");
            // }

            using (StreamReader streamReader = File.OpenText(filepath))
            {
                
                // FileManagement.ReadFile();

                var read = streamReader.ReadToEnd();
                read = read.TrimEnd();
                var users = read.Split(Environment.NewLine);
                // var last = users[^1];
                foreach (var item in users)
                {
                var splittedItem =  item.Split(',');
                    // var user = item.Split(',');
                    // System.Console.WriteLine(user[0]);
                    // System.Console.WriteLine(user[1]);
                    // System.Console.WriteLine(user[2]);
                    HospitalQueueLogic<string>.Enqueue(splittedItem[0],splittedItem[1], splittedItem[2], splittedItem[3]);

                    //  FileManagement.WriteFile();

                }
            }


        }
        public static void WriteToEnd()
        {
            StreamWriter streamwrite = File.CreateText(filepath);
            
            using (StreamWriter streamWriter = File.AppendText(filepath))
            {
                streamWriter.WriteLine("First Name,Last Name, Email ,list");
            }

           



        }
        
        
    }
}