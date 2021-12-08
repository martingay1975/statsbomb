// See https://aka.ms/new-console-template for more information
using StatsBomb_Xg;

var statsbombList = Manager.Init();

foreach (var statsbomb in statsbombList)
{
    var allShots = statsbomb.Where(root => root.Shot != null);
    var allShotsShots = allShots.Select(root => root.Shot);
    var goals = allShotsShots.Where(shot => shot.Outcome.Name == "Goal");
    var allXg = allShotsShots.Sum(shot => shot.StatsbombXg);


    var groupByTeam = allShots.GroupBy(shot => shot.Team.Name);

    var allZones = new AllZones();

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


            Console.WriteLine($"Location of shot: X:{root.Location[0]}  Y:{root.Location[1]} {root.Shot.StatsbombXg,-6} Zone:{zone} {isGoalString}");
        }

        Console.WriteLine("");

    }
}

Console.ReadKey();

