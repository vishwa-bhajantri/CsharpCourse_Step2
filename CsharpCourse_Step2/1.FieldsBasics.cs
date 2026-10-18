using System;

    class FieldsDetails
    {

    string filename = "kjirjkd";
    string filelocation = "Dharwad";
    string filesize = "10TB";
    string createdate = "10-20-2025";

    void ShowMessage(string fileName, string fileLocation)
    {
        Console.WriteLine($"File Name is :{fileName} File Location is : {fileLocation}");
    }

    void SHowDetailsMessage(FieldsDetails file)
    {
        Console.WriteLine($"Hello file name is :{file.filename}");

    }

    static void staticSHowDetailsMessage(FieldsDetails field)
    {
        Console.WriteLine(field.filename );
    }

    DateTime createdDateTime = DateTime.Now;
        static void Main(string[] args)
        {
            FieldsDetails fieldsDetails = new FieldsDetails();
            Console.WriteLine(fieldsDetails.filename); 
            Console.WriteLine(fieldsDetails.filelocation);
            Console.WriteLine(fieldsDetails.filesize);
            Console.WriteLine(fieldsDetails.createdDateTime);

            fieldsDetails.ShowMessage(fieldsDetails.filename, fieldsDetails.filelocation);

            fieldsDetails.SHowDetailsMessage(fieldsDetails);

            staticSHowDetailsMessage(fieldsDetails);

        }
    }

