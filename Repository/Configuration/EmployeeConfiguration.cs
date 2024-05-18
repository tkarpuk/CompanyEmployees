using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData(
                new Employee
                {
                    Id = new Guid("1058EA13-52E1-49E6-AC62-416B32A04258"),
                    Name = "Sam Raiden",
                    Age = 26,
                    Position = "Software developer",
                    CompanyId = new Guid("1058EA13-52E1-49E6-AC62-416B32A04258")
                },
                new Employee
                {
                    Id = new Guid("E04F4A64-0245-420F-9397-EE902DAB7D5F"),
                    Name = "Jana McLeaf",
                    Age = 30,
                    Position = "Software developer",
                    CompanyId = new Guid("1058EA13-52E1-49E6-AC62-416B32A04258")
                },
                new Employee
                {
                    Id = new Guid("050D0CA3-8B80-4EDD-BB58-2AFB2F0FAFBE"),
                    Name = "Kane Miller",
                    Age = 35,
                    Position = "Administrator",
                    CompanyId = new Guid("1058EA13-52E1-49E6-AC62-416B32A04258")
                }
            );
        }
    }
}
