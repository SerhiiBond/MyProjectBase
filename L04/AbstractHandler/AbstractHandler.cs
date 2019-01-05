using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractHandler
{
    abstract class AbstractHandler
    {
        abstract public void Open();
        abstract public void Create();
        abstract public void Change();
        abstract public void Save();
    }
}
