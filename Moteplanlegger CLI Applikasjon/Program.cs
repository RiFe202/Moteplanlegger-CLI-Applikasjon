using MeetingApp.Models;
using MeetingApp.Views;
using MeetingApp.Controllers;

namespace MeetingApp
{
  class Program
  {
    static void Main()
    {
      var meeting = new MeetingApp();
      var view = new MeetingView();
      var controller = new MeetingController(meeting, view);

      controller.ScheduleMeeting();
    }
  }
}