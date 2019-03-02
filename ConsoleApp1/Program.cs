using System;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Input a folder path:");
        string path = Console.ReadLine();
        Console.WriteLine("File type to rename & what you want to rename it to. [ex: txt md]");
        string[] extensions = Console.ReadLine().Split(' ');
        string oldExtension = extensions[0];
        string newExtension = extensions[1];

        DirectoryInfo directoryInfo = new DirectoryInfo(path);
        FileInfo[] files = directoryInfo.GetFiles($"*.{oldExtension.Trim('.')}");

        foreach(FileInfo file in files)
        {
            string newFile = Path.ChangeExtension(file.FullName,newExtension.Trim('.'));
            File.Copy(file.FullName, newFile);
            File.Delete(file.FullName);
        }

    }
}