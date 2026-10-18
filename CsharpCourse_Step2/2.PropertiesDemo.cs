using System;

class PropertiesDemo
{
    string filename = "kjirjkd";
    string filelocation = "Dharwad";
    string filesize = "10TB";
    string createdate = "10-20-2025";

    string FileName { get; set; }
    String FileLocation { get; set; }
    string FileSize { get; set; }

    static void Main()
    {
        PropertiesDemo propertiesDemo = new PropertiesDemo();
        string k = propertiesDemo.FileName = "Ram.pdf";
        Console.WriteLine(k);

        String l = propertiesDemo.FileLocation = "Hubli";
        Console.WriteLine(l);


    }
}

