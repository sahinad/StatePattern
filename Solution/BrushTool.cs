﻿using System;

namespace StatePattern.Solution
{
    public class BrushTool : ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("Brush icon");
        }

        public void MouseUp()
        {
            Console.WriteLine("Draw a line");
        }
    }
}