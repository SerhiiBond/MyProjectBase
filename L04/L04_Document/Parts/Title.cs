﻿using System;
using System.Collections.Generic;
using System.Text;

namespace L04_Document
{
    class Title : Part
    {
        //string content;

        public override string Content
        {
            get
            {
                if (content != null)
                    return content;
                else
                    return "Заголовок отсутствует.";
            }
            set
            {
                content = value;
            }
        }

        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}