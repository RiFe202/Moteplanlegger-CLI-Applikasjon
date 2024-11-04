using MeetingApp.Models;
using MeetingApp.Views;
using System;

namespace MeetingApp.Controllers
{
  public class MeetingController
  {
    private Meeting _meeting;
    private MeetingView _view;

    public MeetingController(MeetingApp meeting, MeetingView view)
    {
      _meeting = meeting;
      _view = view;
    }

    public void ScheduleMeeting()
    {
      _view.ShowPromptForParticipants();
      string input;
      while ((input = Console.Readline())?.ToLower() != "done")
      {
        var participant = new Participant(input);
        _meeting.AddParticipant(participant);
        _view.DisplayParticipantAdded(participant);
      }
      
      _view.ShowPromptForTIme();
      DateTime meetingTime;
      while (!DateTime.TryParse(Console.Readline(), out meetingTime))
      {
        _view.ShowInvalidDate();
      }
      _meeting.SetMeetingTime(meetingTime);

      _meeting.LogMeeting("meeting_log.json");
      _view.ShowMeetingLogged();
    }
  }
}