using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractHandler
{
    class Redactor
    {
        string fileFormat;
        AbstractHandler file;
        public Redactor(string fileName)
        {
            fileFormat = fileName.Substring(fileName.Length - 4);

            switch (fileFormat)
            {
                case ".XML": file = new XMLHandler();
                    break;
                case ".TXT": file = new TXTHandler();
                    break;
                case ".DOC":
                    file = new DOCHandler();
                    break;
            }
        }
        public void Open()
        {
            file.Open();
        }
        public void Create()
        {
            file.Create();
        }
        public void Chenge()
        {
            file.Change();
        }
        public void Save()
        {
            file.Save();
        }

    }
}
