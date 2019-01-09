using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Train
{
    struct Train
    {
        readonly string destination;
        readonly int numberOfTrain;
        readonly string timeDeparture;

        public Train(string destination, int numberOfTrain, string timeDeparture)
        {
            this.destination = destination;
            this.numberOfTrain = numberOfTrain;
            this.timeDeparture = timeDeparture;
        }
    }
}
