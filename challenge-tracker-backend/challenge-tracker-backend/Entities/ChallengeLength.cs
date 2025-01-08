using System.ComponentModel.DataAnnotations;

namespace challenge_tracker_backend.Entities
{
  public class ChallengeLength
  {
    public Guid Id { get; set; }

    // Start and end dates of the challenge
    [Required]
    public DateTime ChallengeStartDate { get; set; }
    [Required]
    public DateTime ChallengeEndDate { get; set; }

    // Duration properties (calculated from start and end dates)
    public TimeSpan Duration  => ChallengeStartDate - ChallengeEndDate;
    public int Days => Duration.Days;
    public int Weeks => (int)(Duration.TotalDays / 7);
    public int Years => (int)(Duration.TotalDays / 365);

    // Foreign key to Challange (1 to 1)
    public Guid ChallengeId { get; set; }
    public Challenge Challenge { get; set; }
  }
}
