namespace CSE325Project.Models;

public class StudyGroup
{
    public int Id { get; set; }
    public string CourseName { get; set; } = "";
    public string GroupName { get; set; } = "";
    public string Description { get; set; } = "";
    public int Members { get; set; }
}