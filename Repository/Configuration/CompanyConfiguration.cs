using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasData(
                new Company
                {
                    Id = new Guid("1058EA13-52E1-49E6-AC62-416B32A04258"),
                    Name = "IT_Solution Ltd",
                    Address = "583 Wall Dr. Gwynn Oak, MD 21207",
                    Country = "USA"
                },
                new Company
                {
                    Id = new Guid("F8831FB0-FDA0-4E35-8F64-5D19DA2518B5"),
                    Name = "Admin_Solution Ltd",
                    Address = "312 Forest Avenue, BF 923",
                    Country = "USA"
                }
            );
        }
    }
}
