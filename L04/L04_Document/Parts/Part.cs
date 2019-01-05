using System;
using System.Collections.Generic;
using System.Text;

namespace L04_Document
{
    abstract class Part
    {
        protected string content;
        abstract public string Content { get; set; }
        abstract public void Show();
    }
}
