namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents one team in a matchup
    /// </summary>
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents the unique identifier for the matchup entry
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Represents One Team in the Matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Represents the score for this Particular Team
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// Represents the matchup that this team came
        /// from as the winner
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}