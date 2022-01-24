using Windows.Foundation;

namespace StatsBomb_Xg
{
    public class Zone
    {
        public string Label { get; set; }
        public  List<Rect> Rectangles { get; set; }

        public void AddReflection()
        {
            // 120 - x
            // y - 40. If < 0 then add 80

            var reflectedTriangles = new List<Rect>();
            foreach (var rect in Rectangles)
            {
                double newBottomRightX = 120 - rect.X;
                double newBottomRightY = 80 - rect.Y;
                double newTopLeftX = newBottomRightX - rect.Width;
                double newTopLeftY = newBottomRightY - rect.Height;
                reflectedTriangles.Add(new Rect(new Point(newTopLeftX, newTopLeftY), new Point(newBottomRightX, newBottomRightY)));
            }

            this.Rectangles.AddRange(reflectedTriangles);
        }

        public void PrintOut()
        {
            foreach (var rect in Rectangles)
            {
                Console.WriteLine($"{Label} top left: {rect.X:0.##},{rect.Y:0.##} bottom right: {rect.X + rect.Width:0.##},{rect.Y + rect.Height:0.##}");
            }
        }
    }
}