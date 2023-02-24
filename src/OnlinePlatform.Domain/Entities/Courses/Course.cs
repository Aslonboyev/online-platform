using OnlinePlatform.Domain.Common;
using OnlinePlatform.Domain.Entities.Users;

namespace OnlinePlatform.Domain.Entities.Courses
{
    public class Course : Auditable
    {
        public string Name { get; set; } = string.Empty;

        public long TeacherId { get; set; }

        public Teacher Teacher { get; set; } = null!;

        public long SubjectId { get; set; }
        public Subject Subject { get; set; } = null!;
    }
}
