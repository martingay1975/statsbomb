namespace StatsBomb_Xg
{
    public class Competitions
    {
        /// <summary>
        /// In the 'Matches' folder, each subfolder is numbered. The number repesents the competition below.
        /// The files within the sub-folders represent the season. e.g. Premier League has a subfolder of '2'.
        /// In there is a file named '44.json'. The '44' repesents the 2003/2004 season.
        /// </summary>
        public enum Competition
        {
            Unknown = -1,
            PremierLeague = 2,
            LaLiga = 11,
            ChampionsLeague = 16,
            FAWomensSuperLeague = 37,
            WorldCup2018 = 43,
            USAWomensNWSL = 49,
            Euros2020 = 55,
            WomensWorldCup2019 = 72,
        }
    }
}
