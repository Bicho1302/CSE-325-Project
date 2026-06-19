using CSE325Project.Models;

namespace CSE325Project.Data;
// Provides sample data for study sessions, including group name, topic, date, and location.
public static class StudySessionData
{
    public static List<StudySession> Sessions =
    [
        new StudySession
        {
            Id = 1,
            GroupName = "ASP.NET Study Team",
            Topic = "Blazor Components Review",
            SessionDate = DateTime.Now.AddDays(2),
            Location = "Library Room A"
        }
    ];
}