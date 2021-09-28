﻿using System;

namespace StatePattern
{
    public class EraserTool : ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("Eraser icon");
        }

        public void MouseUp()
        {
            Console.WriteLine("Erase something");
        }
    }
}
