namespace Infrastructure.Entities;

public class SubscriberEntity
{
    public int Id { get; set; }

    public string Email { get; set; } = null!;

    public bool CheckboxDaily { get; set; }

    public bool CheckboxEvent { get; set; }

    public bool CheckboxAdvertising { get; set; }

    public bool CheckboxStartups { get; set; }

    public bool CheckboxWeek { get; set; }

    public bool CheckboxPodcasts { get; set; }
}
