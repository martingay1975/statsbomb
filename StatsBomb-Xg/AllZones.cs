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
                    Label = "Zone 1 - 6yd Box", 
                    Rectangles = new List<Rect> {
                        new Rect(new Point(0, 30), new Point(6,50)),
                    } 
                },
                new Zone() {
                    Label = "Zone 2 - Penalty Box Sides",
                    Rectangles = new List<Rect> {
                        new Rect(new Point(0, 18), new Point(18,29.999)),
                        new Rect(new Point(0, 50.0001), new Point(18,62))
                    }
                },
                new Zone() {
                    Label = "Zone 3 - Inner Penalty Spot",
                    Rectangles = new List<Rect> {
                        new Rect(new Point(6.0001, 30), new Point(12,50)),
                    }
                },
                new Zone() {
                    Label = "Zone 4 - Outer Penalty Spot",
                    Rectangles = new List<Rect> {
                        new Rect(new Point(12.001, 30), new Point(18,50)),
                    }
                },
                new Zone() {
                    Label = "Zone 5 - Attacking Wings",
                    Rectangles = new List<Rect> {
                        new Rect(new Point(0, 62.001), new Point(18,80)),
                        new Rect(new Point(0, 0), new Point(18,17.999)),
                    }
                },
                new Zone() {
                    Label = "Zone 6 - Outside Penalty Box",
                    Rectangles = new List<Rect> {
                        new Rect(new Point(18.001, 18), new Point(30,62)),
                    }
                },
                new Zone() {
                    Label = "Zone 7 - Midfield Centre",
                    Rectangles = new List<Rect> {
                        new Rect(new Point(30.001, 18), new Point(60,62)),
                    }
                },
                new Zone() {
                    Label = "Zone 8 - Midfield Wings",
                    Rectangles = new List<Rect> {
                        new Rect(new Point(18.001, 62.001), new Point(60,80)),
                        new Rect(new Point(18.001, 0), new Point(60,17.999)),
                    }
                }
            };

            foreach (var zone in zones)
            {
                zone.AddReflection();
                zone.PrintOut();
            }
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