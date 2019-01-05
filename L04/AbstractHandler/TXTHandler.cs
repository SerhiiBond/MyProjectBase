using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractHandler
{
    class TXTHandler : AbstractHandler
    {
        public TXTHandler()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        public override void Open()
        {
            Console.WriteLine("File.TXT opened.");
        }
        public override void Create()
        {
            Console.WriteLine("File.TXT created.");
        }
        public override void Change()
        {
            Console.WriteLine("File.TXT changed");
        }
        public override void Save()
        {
            Console.WriteLine("File.TXT saved");
        }
    }
}
