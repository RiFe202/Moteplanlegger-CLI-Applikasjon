using Moteplanlegger_CLI_Applikasjon.Models;
using System;

namespace MeetingApp.Views
{
  public class MeetingView
  {
    public void ShowPromptForParticipants()
    {
      Console.WriteLine("Enter participant names (type 'done' when finished):");
    }

    public void DisplayParticipantAdded(Participant participant)
    {
      Console.WriteLine($"Added {participant.Name} to the meeting.");
    }

    public void ShowPromptForTIme()
    {
      Console.WriteLine("Enter Meeting time (dd-MM-yyyy HH:mm):");
    }

    public void ShowInvalidDate()
    {
      Console.WriteLine("Invalid date, please enter again (dd-MM-yyyy HH:mm):");
    }

    public void ShowMeetingLogged()
    {
      Console.WriteLine("Meeting logged to file.");
    }
  }
}