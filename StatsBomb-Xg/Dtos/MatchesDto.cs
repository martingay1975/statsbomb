using System.Text.Json.Serialization;

namespace StatsBomb_Xg.Dtos
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class Competition
    {
        [JsonPropertyName("competition_id")]
        public int CompetitionId { get; set; }

        [JsonPropertyName("country_name")]
        public string CountryName { get; set; }

        [JsonPropertyName("competition_name")]
        public string CompetitionName { get; set; }
    }

    public class Season
    {
        [JsonPropertyName("season_id")]
        public int SeasonId { get; set; }

        [JsonPropertyName("season_name")]
        public string SeasonName { get; set; }
    }

    public class Country
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class Manager
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("nickname")]
        public object Nickname { get; set; }

        [JsonPropertyName("dob")]
        public string Dob { get; set; }

        [JsonPropertyName("country")]
        public Country Country { get; set; }
    }

    public class HomeTeam
    {
        [JsonPropertyName("home_team_id")]
        public int HomeTeamId { get; set; }

        [JsonPropertyName("home_team_name")]
        public string HomeTeamName { get; set; }

        [JsonPropertyName("home_team_gender")]
        public string HomeTeamGender { get; set; }

        [JsonPropertyName("home_team_group")]
        public object HomeTeamGroup { get; set; }

        [JsonPropertyName("country")]
        public Country Country { get; set; }

        [JsonPropertyName("managers")]
        public List<Manager> Managers { get; set; }
    }

    public class AwayTeam
    {
        [JsonPropertyName("away_team_id")]
        public int AwayTeamId { get; set; }

        [JsonPropertyName("away_team_name")]
        public string AwayTeamName { get; set; }

        [JsonPropertyName("away_team_gender")]
        public string AwayTeamGender { get; set; }

        [JsonPropertyName("away_team_group")]
        public object AwayTeamGroup { get; set; }

        [JsonPropertyName("country")]
        public Country Country { get; set; }

        [JsonPropertyName("managers")]
        public List<Manager> Managers { get; set; }
    }

    public class Metadata
    {
        [JsonPropertyName("data_version")]
        public string DataVersion { get; set; }
    }

    public class CompetitionStage
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class Stadium
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("country")]
        public Country Country { get; set; }
    }

    public class Referee
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("country")]
        public Country Country { get; set; }
    }

    public class MatchesRoot
    {
        [JsonPropertyName("match_id")]
        public int MatchId { get; set; }

        [JsonPropertyName("match_date")]
        public string MatchDate { get; set; }

        [JsonPropertyName("kick_off")]
        public string KickOff { get; set; }

        [JsonPropertyName("competition")]
        public Competition Competition { get; set; }

        [JsonPropertyName("season")]
        public Season Season { get; set; }

        [JsonPropertyName("home_team")]
        public HomeTeam HomeTeam { get; set; }

        [JsonPropertyName("away_team")]
        public AwayTeam AwayTeam { get; set; }

        [JsonPropertyName("home_score")]
        public int HomeScore { get; set; }

        [JsonPropertyName("away_score")]
        public int AwayScore { get; set; }

        [JsonPropertyName("match_status")]
        public string MatchStatus { get; set; }

        [JsonPropertyName("match_status_360")]
        public string MatchStatus360 { get; set; }

        [JsonPropertyName("last_updated")]
        public object LastUpdated { get; set; }

        [JsonPropertyName("last_updated_360")]
        public DateTime LastUpdated360 { get; set; }

        [JsonPropertyName("metadata")]
        public Metadata Metadata { get; set; }

        [JsonPropertyName("match_week")]
        public int MatchWeek { get; set; }

        [JsonPropertyName("competition_stage")]
        public CompetitionStage CompetitionStage { get; set; }

        [JsonPropertyName("stadium")]
        public Stadium Stadium { get; set; }

        [JsonPropertyName("referee")]
        public Referee Referee { get; set; }
    }

}
