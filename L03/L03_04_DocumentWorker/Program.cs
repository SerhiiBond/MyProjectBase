using System;

namespace L03_04_DocumentWorker
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExpertDocumentWorker docE;
            DocumentWorker doc = null;
            //ProDocumentWorker docP
            string passPro = "pro";
            string passExp = "exp";
                        
            Console.WriteLine("Введите пароль: ");
            string pass = Convert.ToString(Console.ReadLine());
            if (pass == passPro) doc = new ProDocumentWorker();
            if (pass == passExp) doc = new ExpertDocumentWorker();
            if (pass != passPro && pass != passExp) doc = new DocumentWorker();
            doc.OpenDocument();
            doc.EditDocument();
            doc.SaveDocument();

            Console.ReadKey();
        }
    }
}
