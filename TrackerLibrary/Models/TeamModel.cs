namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents one team in the tournament
    /// </summary>
    public class TeamModel
    {
        /// <summary>
        /// List of team members
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        /// <summary>
        /// The name of the team
        /// </summary>
        public string TeamName { get; set; }
    }
}
