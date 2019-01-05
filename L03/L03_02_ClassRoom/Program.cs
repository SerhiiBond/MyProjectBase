using System;

namespace L03_02_ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
 //           ExcelentPupil pe = new ExcelentPupil();
 //           GoodPupil pg = new GoodPupil();
 //           BadPupil pb = new BadPupil();
 //           ClassRoom groop = new ClassRoom(pe, pg, pb, pb);
            ClassRoom groop = new ClassRoom();

            groop.Study();
            Console.WriteLine(new String('*', 30));
            groop.Read();
            Console.WriteLine(new String('*', 30));
            groop.Write();
            Console.WriteLine(new String('*', 30));
            groop.Relax();
            Console.WriteLine(new String('*', 30));


            Console.ReadKey();
        }
    }
}
