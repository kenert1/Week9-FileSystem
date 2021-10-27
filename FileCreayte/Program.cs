using System;
using System.IO;


namespace FileCreayte
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"c:\Users/opilane/samples";
            string userFile = "wishList";
            string FullFilePath = $@"{rootDirectory} / {userFile}.txt";
            File.Create(FullFilePath);

            bool directoryExists = Directory.Exists(rootDirectory);
            bool fileExists = File.Exists(FullFilePath);
            
            if (directoryExists && fileExists)
            {
                Console.WriteLine($"{userFile} already exists in {rootDirectory}");

            }
            else if (!directoryExists)
            {
                Console.WriteLine($"{rootDirectory} does not exist.");
                Directory.CreateDirectory(rootDirectory);
                Console.WriteLine($"{rootDirectory} has been created");
                File.Create(FullFilePath);
                Console.WriteLine($"{userFile}.txt has been created in {rootDirectory}");
            }
            else
            {
                File.Create(FullFilePath);
                Console.WriteLine($"{userFile}.txt has been created in {rootDirectory}");
            }
            

        }
    }
}
