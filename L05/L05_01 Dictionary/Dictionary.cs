using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L05_01_Dictionary
{
    class Dictionary
    {
        private string[] Ru = new string[5];
        private string[] En = new string[5];
        private string[] Ua = new string[5];

        public Dictionary()
        {
            Ru[0] = "книга";  En[0] = "book";  Ua[0] = "книга";
            Ru[1] = "ручка";  En[1] = "pen";   Ua[1] = "ручка";
            Ru[2] = "солнце"; En[2] = "sun";   Ua[2] = "сонце";
            Ru[3] = "яблоко"; En[3] = "apple"; Ua[3] = "яблуко";
            Ru[4] = "стол";   En[4] = "table"; Ua[4] = "стiл";
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < Ru.Length; i++)
                {
                    if (Ru[i] == index) return Ru[i] + " - " + En[i] + " - " + Ua[i];
                    if (En[i] == index) return En[i] + " - " + Ru[i] + " - " + Ua[i];
                    if (Ua[i] == index) return Ua[i] + " - " + En[i] + " - " + Ru[i];
                }
                    

                return string.Format("{0} - нет перевода для этого слова.", index);
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < Ru.Length)
                    return Ru[index] + " - " + En[index] + " - " + Ua[index];
                else
                    return "Попытка обращения за пределы массива.";
            }
        }
    }
}
