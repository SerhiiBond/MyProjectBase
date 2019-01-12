using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Train
{
    class Timetable
    {
        int countTrain;
        Train[] timeTable = new Train[8];
        Train train;
        public Timetable (string destination, int numberOfTrain, string timeDeparture)
        {
            train = new Train(destination, numberOfTrain, timeDeparture);
        }

        public void AddTrain(string destination, int numberOfTrain, string timeDeparture)
        {
            train = new Train(destination, numberOfTrain, timeDeparture);
            if (countTrain < timeTable.Length)
            {
                timeTable[countTrain] = train;
            }
            else
            {
                Console.WriteLine("Расписание переполнено");
            }
        }

        public void ShowTimeTable()
        {
            for (int i = 0; i < timeTable.Length; i++)
            {
                if (timeTable[i].NumberOfTrain != 0)
                {
                    Console.WriteLine("Строка пуста!");
                }
                else
                {
                    Console.WriteLine(timeTable[i].Info());
                }
            }
        }
    }
}
