using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractHandler
{
    class DOCHandler : AbstractHandler
    {
        public DOCHandler()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
        public override void Open()
        {
            Console.WriteLine("File.DOC opened.");
        }
        public override void Create()
        {
            Console.WriteLine("File.DOC created.");
        }
        public override void Change()
        {
            Console.WriteLine("File.DOC changed");
        }
        public override void Save()
        {
            Console.WriteLine("File.DOC saved");
        }
    }
}
