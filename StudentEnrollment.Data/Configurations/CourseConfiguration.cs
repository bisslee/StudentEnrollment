using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentEnrollment.Data.Entities;

namespace StudentEnrollment.Data.Configurations
{
    internal class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasData(
                  new Course { Id = 1, Title = "Math", Description = "Mathematics", Credits = 3 },
                  new Course { Id = 2, Title = "Science", Description = "Science", Credits = 4 },
                  new Course { Id = 3, Title = "History", Description = "History", Credits = 3 }
              );
        }
    }
}
