using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Train
{
    class Timetable
    {
        int countTrain;
        Train[] timeTable = new Train[0];
        Train train;
        //public Timetable (string destination, int numberOfTrain, string timeDeparture)
        //{
          //  train = new Train(destination, numberOfTrain, timeDeparture);
        //}

        public void AddTrain(string destination, int numberOfTrain, string timeDeparture)
        {
            train = new Train(destination, numberOfTrain, timeDeparture);
            if (countTrain < 8)
            {
                Train[] tmpTimeTable = new Train[timeTable.Length + 1];
                //int j = 0;
                for (int i = 0; i < timeTable.Length; i++)
                {
                    if (train.NumberOfTrain < timeTable[i].NumberOfTrain || timeTable[i].NumberOfTrain == 0)
                    {
                        tmpTimeTable[i] = train;
                    }
                    else
                    {
                        tmpTimeTable[i+1] = timeTable[i];
                    }
                    
                }
                timeTable = tmpTimeTable;
            }
            else
            {
                Console.WriteLine("Расписание переполнено");
            }
        }

        public void ShowTimeTable()
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("| № поезда  |    Назначение    |  Отправление  |");
            Console.WriteLine("----------------------------------------------");
            for (int i = 0; i < timeTable.Length; i++)
            {
                if (timeTable[i].NumberOfTrain != 0)
                {
                    Console.WriteLine("Строка пуста!");
                }
                else
                {
                    Console.WriteLine("|{0,10} | {1,16} |{2,15}|",timeTable[i].NumberOfTrain,timeTable[i].Destination,timeTable[i].TimeDeparture);
//                    Console.WriteLine("|{0} | {1} |{2}|", timeTable[i].NumberOfTrain, timeTable[i].Destination, timeTable[i].TimeDeparture);
                }
            }
        }
    }
}
