namespace CSE325Project.Models
{
    // Represents a study session with details such as group name, topic, date, and location.
    public class StudySession
    {
        public int Id { get; set; }

        public string GroupName { get; set; } = "";

        public string Topic { get; set; } = "";

        public DateTime SessionDate { get; set; }

        public string Location { get; set; } = "";
    }
}