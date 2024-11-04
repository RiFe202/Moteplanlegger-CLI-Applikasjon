namespace MeetingApp.Models
{
  public class Participant
  {
    public string Name { get; private set; }

    public Participant(string name)
    {
      Name = name;
    }
  }
}