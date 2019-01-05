using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractHandler
{
    class XMLHandler : AbstractHandler
    {
        public XMLHandler()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        public override void Open()
        {
            Console.WriteLine("File.XML opened.");
        }
        public override void Create()
        {
            Console.WriteLine("File.XML created.");
        }
        public override void Change()
        {
            Console.WriteLine("File.XML changed");
        }
        public override void Save()
        {
            Console.WriteLine("File.XML saved");
        }
    }
}
