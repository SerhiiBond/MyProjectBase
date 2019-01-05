using System;

namespace AbstractHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            Redactor redactor = new Redactor("file.XML");
            redactor.Open();
            redactor.Create();
            redactor.Chenge();
            redactor.Save();

            Redactor redactor1 = new Redactor("file.TXT");
            redactor1.Open();
            redactor1.Create();
            redactor1.Chenge();
            redactor1.Save();

            Redactor redactor2 = new Redactor("file.DOC");
            redactor2.Open();
            redactor2.Create();
            redactor2.Chenge();
            redactor2.Save();

            Console.ReadKey();
        }
    }
}
