// See https://aka.ms/new-console-template for more information
using StatsBomb_Xg;
using Statsbomb_Xg_Cmd;

var eventsFileList = Manager.InitEvents();
var matchesList = Manager.InitMatches();
var matchIdToCompetitionIdMap = Manager.CreateMatchToCompetitionMap(matchesList);

var allZones = new AllZones();


// Output.AllShots(allZones, statsbombList);

Output.ZoneSummary(allZones, eventsFileList, matchIdToCompetitionIdMap);

Console.ReadKey();

