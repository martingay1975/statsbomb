// See https://aka.ms/new-console-template for more information
using StatsBomb_Xg;
using Statsbomb_Xg_Cmd;

var statsbombList = Manager.Init();
var allZones = new AllZones();

// Output.AllShots(allZones, statsbombList);

Output.ZoneSummary(allZones, statsbombList);

Console.ReadKey();

