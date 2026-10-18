
//using ExcelFileSystem;
using PPTFileSystem;
using System;

namespace MainProgramSystem
{
    class MainProgram
    {
        public static void Main()
        {
            ExcelFileSystem.Jan_File jan_File = new ExcelFileSystem.Jan_File();
            Console.WriteLine(jan_File.filename);

            ExcelFileSystem.Feb_File feb_File = new ExcelFileSystem.Feb_File();
            Console.WriteLine(feb_File.filename);

            ExcelFileSystem.Mar_File mar_File = new ExcelFileSystem.Mar_File();
            Console.WriteLine(mar_File.filename);


            Jan_File ppt_jan_file = new Jan_File();
            Console.WriteLine(ppt_jan_file.filename);

            Feb_File ppt_feb_file = new Feb_File();
            Console.WriteLine(ppt_feb_file.filename);

            Mar_File ppt_mar_file = new Mar_File();
            Console.WriteLine(ppt_mar_file.filename);


            WordFileSystem.Jan_File jan_file = new WordFileSystem.Jan_File();
            Console.WriteLine(jan_file.filename);

            WordFileSystem.Feb_File feb_file = new WordFileSystem.Feb_File();
            Console.WriteLine(feb_file.filename);

            WordFileSystem.Mar_File mar_file = new WordFileSystem.Mar_File();
            Console.WriteLine(mar_file.filename);
        }
    }
}