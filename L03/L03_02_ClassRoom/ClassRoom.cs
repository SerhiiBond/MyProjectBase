using System;
using System.Collections.Generic;
using System.Text;


namespace L03_02_ClassRoom
{
    class ClassRoom
    {
        Pupil[] pupil = new Pupil[4];
        Random rnd = new Random();
        public ClassRoom()
        {
            pupil[0] = GeneratePupil();
            pupil[1] = GeneratePupil();
            pupil[2] = GeneratePupil();
            pupil[3] = GeneratePupil();
        }
        public ClassRoom(Pupil p0)
        {
            pupil[0] = p0;
            pupil[1] = GeneratePupil();
            pupil[2] = GeneratePupil();
            pupil[3] = GeneratePupil();
        }
        public ClassRoom(Pupil p0, Pupil p1)
        {
            pupil[0] = p0;
            pupil[1] = p1;
            pupil[2] = GeneratePupil();
            pupil[3] = GeneratePupil();
        }
        public ClassRoom(Pupil p0, Pupil p1, Pupil p2)
        {
            pupil[0] = p0;
            pupil[1] = p1;
            pupil[2] = p2;
            pupil[3] = GeneratePupil();
        }
        public ClassRoom(Pupil p0, Pupil p1, Pupil p2, Pupil p3)
        {
            pupil[0] = p0;
            pupil[1] = p1;
            pupil[2] = p2;
            pupil[3] = p3;
        }

        Pupil GeneratePupil()
        {
            int r = rnd.Next(1, 4);
            switch (r)
            {
                case 1: return new ExcelentPupil();
                case 2: return new GoodPupil();
                case 3: return new BadPupil();
            }
            return new Pupil();
        }

        public void Study()
        {
            foreach(Pupil p in pupil)
            {
                p.Study();
            }
        }
        public void Read()
        {
            foreach (Pupil p in pupil)
            {
                p.Read();
            }
        }
        public void Write()
        {
            foreach (Pupil p in pupil)
            {
                p.Write();
            }
        }
        public void Relax()
        {
            foreach (Pupil p in pupil)
            {
                p.Relax();
            }
        }
    }
}
