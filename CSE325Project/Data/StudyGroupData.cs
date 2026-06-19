using CSE325Project.Models;

namespace CSE325Project.Data;
// Provides sample data for study groups, including course name, group name, description, and number of members.
public static class StudyGroupData
{
    public static List<StudyGroup> Groups =
    [
        new StudyGroup
        {
            Id = 1,
            CourseName = "CSE 325",
            GroupName = "ASP.NET Study Team",
            Description = "Study ASP.NET Core and Blazor together.",
            Members = 5
        },

        new StudyGroup
        {
            Id = 2,
            CourseName = "CSE 212",
            GroupName = "Data Structures Group",
            Description = "Practice data structures and algorithms.",
            Members = 8
        },

        new StudyGroup
        {
            Id = 3,
            CourseName = "MATH 108X",
            GroupName = "Quantitative Reasoning",
            Description = "Work through weekly assignments.",
            Members = 4
        }
    ];
}