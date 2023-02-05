namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents one team in the tournament
    /// </summary>
    public class TeamModel
    {
        /// <summary>
        /// The unique identifier for the team
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of the team
        /// </summary>
        public string TeamName { get; set; }

        /// <summary>
        /// List of team members
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
    }
}
