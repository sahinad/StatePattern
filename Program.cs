namespace StatePattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var canvas = new Canvas
            {
                CurrentTool = new BrushTool()
            };
            canvas.MouseDown();
            canvas.MouseUp();

            canvas.CurrentTool = new EraserTool();
            canvas.MouseDown();
            canvas.MouseUp();

            canvas.CurrentTool = new SelectionTool();
            canvas.MouseDown();
            canvas.MouseUp();
        }
    }
}
