using System;
using System.Collections.Generic;
using System.Text;

namespace L03_02_ClassRoom
{
    class Pupil
    {
        public virtual void Study()
        {
            Console.WriteLine("Pupil.Study()");
        }
        public virtual void Read()
        {
            Console.WriteLine("Pupil.Read()");
        }
        public virtual void Write()
        {
            Console.WriteLine("Pupil.Write()");
        }
        public virtual void Relax()
        {
            Console.WriteLine("Pupil.Relax()");
        }
    }
    class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("ExcelentPupil.Study()");
            Console.ResetColor();
        }
        public override void Read()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("ExcelentPupil.Read()");
            Console.ResetColor();
        }
        public override void Write()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("ExcelentPupil.Write()");
            Console.ResetColor();
        }
        public override void Relax()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("ExcelentPupil.Relax()");
            Console.ResetColor();
        }
    }
    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("GoodPupil.Study()");
            Console.ResetColor();
        }
        public override void Read()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("GoodPupil.Read()");
            Console.ResetColor();
        }
        public override void Write()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("GoodPupil.Write()");
            Console.ResetColor();
        }
        public override void Relax()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("GoodPupil.Relax()");
            Console.ResetColor();
        }
    }
    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("BadPupil.Study()");
            Console.ResetColor();
        }
        public override void Read()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("BadPupil.Read()");
            Console.ResetColor();
        }
        public override void Write()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("BadPupil.Write()");
            Console.ResetColor();
        }
        public override void Relax()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("BadPupil.Relax()");
            Console.ResetColor();
        }
    }

}
