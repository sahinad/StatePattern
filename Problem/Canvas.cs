using System;

namespace StatePattern.Problem
{
    public class Canvas
    {
        public ToolType CurrentTool { get; set; }

        public void MouseDown()
        {
            if (CurrentTool == ToolType.Selection)
            {
                Console.WriteLine("Selection icon");
            }
            else if (CurrentTool == ToolType.Brush)
            {
                Console.WriteLine("Bursh icon");
            }
            else if (CurrentTool == ToolType.Eraser)
            {
                Console.WriteLine("Eraser icon");
            }
        }

        public void MouseUp()
        {
            if (CurrentTool == ToolType.Selection)
            {
                Console.WriteLine("Draw dashed rectangle");
            }
            else if (CurrentTool == ToolType.Brush)
            {
                Console.WriteLine("Draw a line");
            }
            else if (CurrentTool == ToolType.Eraser)
            {
                Console.WriteLine("Erase something");
            }
        }
    }
}
