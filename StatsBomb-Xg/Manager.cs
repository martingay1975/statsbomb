using StatsBomb_Xg.Dtos;
using System.Text.Json;
using Windows.Foundation;

namespace StatsBomb_Xg
{
    public class Manager
    {
        public static IEnumerable<EventsFile> InitEvents()
        {
            foreach (var file in Directory.GetFiles(@"C:\git\statsbomb-data\data\events", "*.json"))
            {
                var eventsFile = new EventsFile();

                var matchId = Convert.ToInt32(Path.GetFileNameWithoutExtension(file));
                var json = File.OpenText(file).ReadToEnd();

                eventsFile.Events = JsonSerializer.Deserialize<List<EventsRoot>>(json);
                eventsFile.MatchId = matchId;

                yield return eventsFile;
            }
        }

        public static IEnumerable<List<MatchesRoot>> InitMatches()
        {
            var enumerationOptions = new EnumerationOptions { RecurseSubdirectories = true };
            foreach (var file in Directory.GetFiles(@"C:\git\statsbomb-data\data\matches", "*.json", enumerationOptions))
            {
                var json = File.OpenText(file).ReadToEnd();
                var matchesData = JsonSerializer.Deserialize<List<MatchesRoot>>(json);
                if (matchesData != null)
                {
                    yield return matchesData;
                }
            }
        }

        public static Dictionary<int, int> CreateMatchToCompetitionMap(IEnumerable<List<MatchesRoot>> listOfListOfMatches)
        {
            var ret = new Dictionary<int, int>();

            foreach (var listOfMatchRoots in listOfListOfMatches)
            {
                foreach (var matchRoot in listOfMatchRoots)
                {
                    ret[matchRoot.MatchId] = matchRoot.Competition.CompetitionId;
                    //Console.WriteLine($"MatchId:{matchRoot.MatchId} CompetitionId:{matchRoot.Competition.CompetitionId}");
                }
            }

            return ret;
        }
    }
}