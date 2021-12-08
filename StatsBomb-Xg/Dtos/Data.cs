using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StatsBomb_Xg.Dtos
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class Type
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class PossessionTeam
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class PlayPattern
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class Team
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class Player
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class Position
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class Lineup
    {
        [JsonPropertyName("player")]
        public Player Player { get; set; }

        [JsonPropertyName("position")]
        public Position Position { get; set; }

        [JsonPropertyName("jersey_number")]
        public int JerseyNumber { get; set; }
    }

    public class Tactics
    {
        [JsonPropertyName("formation")]
        public int Formation { get; set; }

        [JsonPropertyName("lineup")]
        public List<Lineup> Lineup { get; set; }
    }

    public class Recipient
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class Height
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class BodyPart
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class Outcome
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class Technique
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class Pass
    {
        [JsonPropertyName("recipient")]
        public Recipient Recipient { get; set; }

        [JsonPropertyName("length")]
        public double Length { get; set; }

        [JsonPropertyName("angle")]
        public double Angle { get; set; }

        [JsonPropertyName("height")]
        public Height Height { get; set; }

        [JsonPropertyName("end_location")]
        public List<double> EndLocation { get; set; }

        [JsonPropertyName("type")]
        public Type Type { get; set; }

        [JsonPropertyName("body_part")]
        public BodyPart BodyPart { get; set; }

        [JsonPropertyName("outcome")]
        public Outcome Outcome { get; set; }

        [JsonPropertyName("assisted_shot_id")]
        public string AssistedShotId { get; set; }

        [JsonPropertyName("shot_assist")]
        public bool? ShotAssist { get; set; }

        [JsonPropertyName("through_ball")]
        public bool? ThroughBall { get; set; }

        [JsonPropertyName("technique")]
        public Technique Technique { get; set; }

        [JsonPropertyName("cross")]
        public bool? Cross { get; set; }

        [JsonPropertyName("switch")]
        public bool? Switch { get; set; }

        [JsonPropertyName("goal_assist")]
        public bool? GoalAssist { get; set; }

        [JsonPropertyName("aerial_won")]
        public bool? AerialWon { get; set; }

        [JsonPropertyName("backheel")]
        public bool? Backheel { get; set; }

        [JsonPropertyName("deflected")]
        public bool? Deflected { get; set; }
    }

    public class Carry
    {
        [JsonPropertyName("end_location")]
        public List<double> EndLocation { get; set; }
    }

    public class BallReceipt
    {
        [JsonPropertyName("outcome")]
        public Outcome Outcome { get; set; }
    }

    public class Dribble
    {
        [JsonPropertyName("outcome")]
        public Outcome Outcome { get; set; }

        [JsonPropertyName("nutmeg")]
        public bool? Nutmeg { get; set; }

        [JsonPropertyName("overrun")]
        public bool? Overrun { get; set; }
    }

    public class FreezeFrame
    {
        [JsonPropertyName("location")]
        public List<double> Location { get; set; }

        [JsonPropertyName("player")]
        public Player Player { get; set; }

        [JsonPropertyName("position")]
        public Position Position { get; set; }

        [JsonPropertyName("teammate")]
        public bool Teammate { get; set; }
    }

    public class Shot
    {
        [JsonPropertyName("statsbomb_xg")]
        public double StatsbombXg { get; set; }

        [JsonPropertyName("end_location")]
        public List<double> EndLocation { get; set; }

        [JsonPropertyName("key_pass_id")]
        public string KeyPassId { get; set; }

        [JsonPropertyName("outcome")]
        public Outcome Outcome { get; set; }

        [JsonPropertyName("type")]
        public Type Type { get; set; }

        [JsonPropertyName("technique")]
        public Technique Technique { get; set; }

        [JsonPropertyName("body_part")]
        public BodyPart BodyPart { get; set; }

        [JsonPropertyName("freeze_frame")]
        public List<FreezeFrame> FreezeFrame { get; set; }

        [JsonPropertyName("first_time")]
        public bool? FirstTime { get; set; }

        [JsonPropertyName("one_on_one")]
        public bool? OneOnOne { get; set; }
    }

    public class Goalkeeper
    {
        [JsonPropertyName("end_location")]
        public List<double> EndLocation { get; set; }

        [JsonPropertyName("type")]
        public Type Type { get; set; }

        [JsonPropertyName("position")]
        public Position Position { get; set; }

        [JsonPropertyName("outcome")]
        public Outcome Outcome { get; set; }

        [JsonPropertyName("technique")]
        public Technique Technique { get; set; }

        [JsonPropertyName("body_part")]
        public BodyPart BodyPart { get; set; }
    }

    public class Duel
    {
        [JsonPropertyName("outcome")]
        public Outcome Outcome { get; set; }

        [JsonPropertyName("type")]
        public Type Type { get; set; }
    }

    public class BallRecovery
    {
        [JsonPropertyName("recovery_failure")]
        public bool RecoveryFailure { get; set; }

        [JsonPropertyName("offensive")]
        public bool? Offensive { get; set; }
    }

    public class Interception
    {
        [JsonPropertyName("outcome")]
        public Outcome Outcome { get; set; }
    }

    public class Block
    {
        [JsonPropertyName("deflection")]
        public bool Deflection { get; set; }
    }

    public class Replacement
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class Substitution
    {
        [JsonPropertyName("outcome")]
        public Outcome Outcome { get; set; }

        [JsonPropertyName("replacement")]
        public Replacement Replacement { get; set; }
    }

    public class FoulCommitted
    {
        [JsonPropertyName("advantage")]
        public bool Advantage { get; set; }

        [JsonPropertyName("offensive")]
        public bool? Offensive { get; set; }
    }

    public class FoulWon
    {
        [JsonPropertyName("advantage")]
        public bool Advantage { get; set; }

        [JsonPropertyName("defensive")]
        public bool? Defensive { get; set; }
    }

    public class InjuryStoppage
    {
        [JsonPropertyName("in_chain")]
        public bool InChain { get; set; }
    }

    public class Card
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class BadBehaviour
    {
        [JsonPropertyName("card")]
        public Card Card { get; set; }
    }

    public class Root
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("index")]
        public int Index { get; set; }

        [JsonPropertyName("period")]
        public int Period { get; set; }

        [JsonPropertyName("timestamp")]
        public string Timestamp { get; set; }

        [JsonPropertyName("minute")]
        public int Minute { get; set; }

        [JsonPropertyName("second")]
        public int Second { get; set; }

        [JsonPropertyName("type")]
        public Type Type { get; set; }

        [JsonPropertyName("possession")]
        public int Possession { get; set; }

        [JsonPropertyName("possession_team")]
        public PossessionTeam PossessionTeam { get; set; }

        [JsonPropertyName("play_pattern")]
        public PlayPattern PlayPattern { get; set; }

        [JsonPropertyName("team")]
        public Team Team { get; set; }

        [JsonPropertyName("duration")]
        public double Duration { get; set; }

        [JsonPropertyName("tactics")]
        public Tactics Tactics { get; set; }

        [JsonPropertyName("related_events")]
        public List<string> RelatedEvents { get; set; }

        [JsonPropertyName("player")]
        public Player Player { get; set; }

        [JsonPropertyName("position")]
        public Position Position { get; set; }

        [JsonPropertyName("location")]
        public List<double> Location { get; set; }

        [JsonPropertyName("pass")]
        public Pass Pass { get; set; }

        [JsonPropertyName("under_pressure")]
        public bool? UnderPressure { get; set; }

        [JsonPropertyName("carry")]
        public Carry Carry { get; set; }

        [JsonPropertyName("ball_receipt")]
        public BallReceipt BallReceipt { get; set; }

        [JsonPropertyName("dribble")]
        public Dribble Dribble { get; set; }

        [JsonPropertyName("shot")]
        public Shot Shot { get; set; }

        [JsonPropertyName("goalkeeper")]
        public Goalkeeper Goalkeeper { get; set; }

        [JsonPropertyName("counterpress")]
        public bool? Counterpress { get; set; }

        [JsonPropertyName("duel")]
        public Duel Duel { get; set; }

        [JsonPropertyName("ball_recovery")]
        public BallRecovery BallRecovery { get; set; }

        [JsonPropertyName("interception")]
        public Interception Interception { get; set; }

        [JsonPropertyName("block")]
        public Block Block { get; set; }

        [JsonPropertyName("substitution")]
        public Substitution Substitution { get; set; }

        [JsonPropertyName("foul_committed")]
        public FoulCommitted FoulCommitted { get; set; }

        [JsonPropertyName("foul_won")]
        public FoulWon FoulWon { get; set; }

        [JsonPropertyName("injury_stoppage")]
        public InjuryStoppage InjuryStoppage { get; set; }

        [JsonPropertyName("bad_behaviour")]
        public BadBehaviour BadBehaviour { get; set; }
    }


}
