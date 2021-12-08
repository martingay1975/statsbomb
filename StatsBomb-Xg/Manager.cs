using StatsBomb_Xg.Dtos;
using System.Text.Json;
using Windows.Foundation;

namespace StatsBomb_Xg
{
    public class Manager
    {
        public static IEnumerable<List<Root>> Init()
        {
            foreach (var file in Directory.GetFiles(@"C:\git\statsbomb\data\events", "*.json"))
            {
                var json = File.OpenText(file).ReadToEnd();
                var statsbombData = JsonSerializer.Deserialize<List<Root>>(json);
                if (statsbombData != null)
                {
                    yield return statsbombData;
                }
            }
        }
    }
}