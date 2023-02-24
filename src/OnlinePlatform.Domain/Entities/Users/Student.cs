using OnlinePlatform.Domain.Entities.Courses;

namespace OnlinePlatform.Domain.Entities.Users
{
    public class Student : Person
    {
        public long CourseId { get; set; }
        public Course Course { get; set; } = null!;
    }
}
