﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _03_Player
{
    interface IRecordable
    {
        void Record();
        void Pause();
        void Stop();
    }
}
