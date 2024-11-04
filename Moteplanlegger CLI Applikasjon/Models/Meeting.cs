using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace MeetingApp.Models
{
  public class Meeting
  {
    public List<Participant> Participants { get; private set; } = new List<Participant>();
    public DateTime MeetingTime { get; private set; }

    public void AddParticipant(Participant participant)
    {
      MeetingTime = dateTime;
    }

    public void LogMeeting(string filepath)
    {
      var meetingDetails = new
      {
        Participants = Participants.ConvertAll(p => p.Name),
        MeetingTime
      };
      string json = JsonConvert.SerializeObject(meetingDetails, Formatting.indented);
      File.WriteAllText(filepath, json);
    }
  }
}