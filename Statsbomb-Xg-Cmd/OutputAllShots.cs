using StatsBomb_Xg;
using StatsBomb_Xg.Dtos;

namespace Statsbomb_Xg_Cmd
{
    internal static class Output
    {
        public static void AllShots(AllZones allZones, IEnumerable<List<Root>> statsbombList)
        {
            foreach (var statsbomb in statsbombList)
            {
                var allShots = statsbomb.Where(root => root.Shot != null);
                //var allShotsShots = allShots.Select(root => root.Shot);
                //var goals = allShotsShots.Where(shot => shot.Outcome.Name == "Goal");
                //var allXg = allShotsShots.Sum(shot => shot.StatsbombXg);
                var groupByTeam = allShots.GroupBy(shot => shot.Team.Name);

                foreach (var team in groupByTeam)
                {
                    var teamXg = team.Sum(root => root.Shot.StatsbombXg);
                    var actualGoals = team.Where(root => root.Shot.Outcome.Name == "Goal").ToList().Count;

                    Console.WriteLine($"{team.First().Team.Name} xG-{teamXg} Goals-{actualGoals}");
                    foreach (var root in team)
                    {
                        bool isGoal = root.Shot.Outcome.Name == "Goal";
                        var isGoalString = isGoal ? "--GOAL" : "";
                        var zone = allZones.GetZoneNumber((int)root.Location[0], (int)root.Location[1]);


                        Console.WriteLine($"Location of shot: X:{root.Location[0]}  Y:{root.Location[1]} {root.Shot.StatsbombXg,-6} {zone} {isGoalString}");
                    }

                    Console.WriteLine("");
                }
            }
        }

        internal static void ZoneSummary(AllZones allZones, IEnumerable<List<Root>> statsbombList)
        {
            var everyShot = new List<Root>();
            var counter = 0;
            foreach (var statsbomb in statsbombList)
            {
                counter++;
                Console.Write("*");
                everyShot.AddRange(statsbomb.Where(root => root.Shot != null));
            }
            Console.WriteLine("");
            Console.WriteLine("");

            var shotGroupByZone = everyShot.GroupBy(root =>
            {
                var zone = allZones.GetZoneNumber((int)root.Location[0], (int)root.Location[1]);
                return zone;
            }).OrderBy(r => r.Key);


            foreach (var zone in shotGroupByZone)
            {
                var shotsInZone = zone.Where(root => root.Shot != null).Select(root => root.Shot);
                var shotsInZoneCount = shotsInZone.Count();
                var goalsInZones = shotsInZone.Where(shot => shot.Outcome.Name == "Goal").Count();
                var xGsInZone = shotsInZone.Sum(shot => shot.StatsbombXg);
                Console.WriteLine($"{zone.Key,-32} Shots:{shotsInZoneCount, -5} Goals:{goalsInZones, -5} xG:{xGsInZone / (double)shotsInZoneCount, -20} BenxG Per Shot:{(double)goalsInZones / (double)shotsInZoneCount}");
            }
        }
    }
}
