using UserClass.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mappings
{
    internal class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Login)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("Login")
                .HasColumnType("VARCHAR(100)");

            builder.Property(prop => prop.Password)
               .HasConversion(prop => prop.ToString(), prop => prop)
               .IsRequired()
               .HasColumnName("Password")
               .HasColumnType("VARCHAR(100)");

            builder.Property(prop => prop.Email)
               .HasConversion(prop => prop.ToString(), prop => prop)
               .IsRequired()
               .HasColumnName("Email")
               .HasColumnType("VARCHAR(250)");
        }
    }
}
