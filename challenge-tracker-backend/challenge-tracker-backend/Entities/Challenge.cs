using System.ComponentModel.DataAnnotations;

namespace challenge_tracker_backend.Entities
{
  public class Challenge
  {
    public Guid Id { get; set; }
    [Required]
    public string Name { get; set; } = string.Empty;
    [Required]
    public string Description { get; set; } = string.Empty;
    public DateTime UpdatedTime { get; set; }
    public DateTime CreatedTime { get; set; }
    public DateTime CompletedTime { get; set; }
    public bool IsCompleted { get; set; }

    // Foreign key to ChallengeLength (1 to 1)
    public Guid ChallengeLengthId { get; set; }
    public ChallengeLength ChallengeLength { get; set; }
  }
}
