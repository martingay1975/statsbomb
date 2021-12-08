using Windows.Foundation;

namespace StatsBomb_Xg
{
    public class AllZones
    {
        private List<Zone> zones;

        public AllZones()
        {
            zones = new List<Zone>()
            {
                new Zone() { 
                    Label = "Zone 1", 
                    Rectangles = new List<Rect> {
                        new Rect(new Point(0, 30), new Point(6,50)),
                        new Rect(new Point(0, 18), new Point(18,30))
                    } 
                }
            };
        }

        public string GetZoneNumber(int x, int y)
        {
            var locationOfShot = new Point(x, y);
            foreach (var zone in zones)
            {
                foreach (var rectangle in zone.Rectangles)
                {
                    if (rectangle.Contains(locationOfShot))
                    {
                        return zone.Label;
                    }
                }
            }

            throw new Exception($"Unable to find a zone for the location: X:{locationOfShot.X}, Y:{locationOfShot.Y}");
        }
    }
}