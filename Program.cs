using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace BatchToDbTool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Mention Folder Path The Files Exist In:");
            string folderPath = Console.ReadLine();
            Console.WriteLine("Please Mention The CSV path you would like to output to:");
            string csvPath = Console.ReadLine();


            //"C:\\Users\\Akshat College\\OneDrive\\Desktop\\forcsAttempt";



            if (Directory.Exists(folderPath))
            {
                //foreach (string file in Directory.GetFiles(folderPath))
                //{

                //}



                //using (StreamReader reader = new StreamReader(Path.Combine(folderPath, "reading.txt")))
                //{





                //}

                var files = from file in Directory.EnumerateFiles(folderPath) select file;

                using (StreamWriter writer = new StreamWriter(csvPath))
                {


                    writer.WriteLine("BatchTitle,BatchContent");

                    foreach (var file in files)
                    {
                        //Console.WriteLine($"File Path: {file}");
                        string x = File.ReadAllText(file);
                        //Console.WriteLine($"File Contents: {x}");

                        string fileName = Path.GetFileName(file);
                        string batchFileContent = File.ReadAllText(file);
                        string formattedContent = $"\"{batchFileContent.Replace("\r\n", "\n")}\"";


                        writer.WriteLine($"{fileName},{formattedContent}");


                    }
                }

                Process process = new Process();
                process.StartInfo.FileName = csvPath;
                process.Start();

                Console.WriteLine("Finished");



            }



            Console.Read();

        }
    }
}
