namespace CSE325Project.Models;
// Represents a study group with details such as course name, group name, description, and number of members.
public class StudyGroup
{
    public int Id { get; set; }
    public string CourseName { get; set; } = "";
    public string GroupName { get; set; } = "";
    public string Description { get; set; } = "";
    public int Members { get; set; }
}