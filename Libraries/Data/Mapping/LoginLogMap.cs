using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.DbEntities;

namespace Data.Mapping
{
    public class LoginLogMap : MappingEntityTypeConfiguration<LoginLog>
    {
        public override void Configure(EntityTypeBuilder<LoginLog> builder)
        {
            builder.ToTable("LoginLogs");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.UserEmail).HasMaxLength(255);
            builder.Property(p => p.LoginTime).HasColumnType("timestamp without time zone").HasDefaultValueSql("now()");
            builder.Property(p => p.CreateUTC).HasColumnType("timestamp without time zone").HasDefaultValueSql("now()");
            base.Configure(builder);
        }
    }
}
