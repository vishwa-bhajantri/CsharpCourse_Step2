using System;


class PDFFile
{
    public string file_name;
    public string file_location;
    public string file_size;
    public string create_date;
}

class PDFFileSystem
{
    public void showPDFFileNamesLength(string[] filenames)
    {
        Console.WriteLine(filenames.Length);
    }

    public void showPrintEveryPDFFileName(string[] filename)
    {
        foreach (string filenames in filename)
        {
            Console.WriteLine(filenames);
        }
    }

    public void printEveryPdfFileDeatails(PDFFile[] files)
    {
        Console.WriteLine("sd"+files.Length);
    }

    public PDFFile getFirstPdf(PDFFile[] files)
    {
        return files[0];
    }

}

class PDFProgram
{
    static void Main(string[] args)
    {
        PDFFileSystem pDFFileSystem = new PDFFileSystem();
        string[] filenames = { "asdas", "qweqwe", "wiuohweifhi" };
        pDFFileSystem.showPDFFileNamesLength(filenames);

        pDFFileSystem.showPrintEveryPDFFileName(filenames);

        PDFFile creditcardStatementMarch = new PDFFile()
        {
            file_name = "march.pdf",
            file_location = "hhgjdj",
            file_size = "100mb",
            create_date = "23-06-9887"

        };

        PDFFile creditcardStatementApril = new PDFFile()
        {
            file_name = "April.pdf",
            file_location = "hhgjdj",
            file_size = "100mb",
            create_date = "23-06-9887"

        };

        PDFFile creditcardStatementMay = new PDFFile()
        {
            file_name = "may.pdf",
            file_location = "hhgjdj",
            file_size = "100mb",
            create_date = "23-06-9887"

        };

        //PDFFile[] pdffilelist = new PDFFile[]
        //{
        //    creditcardStatementMarch,
        //    creditcardStatementApril,
        //    creditcardStatementMay
        //};

        PDFFile[] pdffilelist = new PDFFile[]
        {
             new PDFFile()
             {
                 file_name = "march.pdf",
                 file_location = "hhgjdj",
                 file_size = "100mb",
                 create_date = "23-06-9887"
            },

             new PDFFile()
             {
                file_name = "April.pdf",
                file_location = "hhgjdj",
                file_size = "100mb",
                create_date = "23-06-9887"
             },

             new PDFFile()
             {
                file_name = "may.pdf",
                file_location = "hhgjdj",
                file_size = "100mb",
                create_date = "23-06-9887"
            }
       };

        pDFFileSystem.printEveryPdfFileDeatails(pdffilelist);
        PDFFile pdffile = pDFFileSystem.getFirstPdf(pdffilelist);
        Console.WriteLine(pdffile);
    }
}
