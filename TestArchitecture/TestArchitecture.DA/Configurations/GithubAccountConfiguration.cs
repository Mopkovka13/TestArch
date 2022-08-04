using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestArchitecture.DA.Entities;

namespace TestArchitecture.DA.Configurations
{
    public class GithubAccountConfiguration : IEntityTypeConfiguration<GithubAccount>
    {
		public void Configure(EntityTypeBuilder<GithubAccount> builder)
		{
			builder.HasKey(x => x.Id);

			builder.Property(x => x.Nickname).HasMaxLength(200);
			builder.Property(x => x.Link).HasMaxLength(1000);

			builder.HasOne(x => x.Member)
				.WithOne(x => x.GithubAccount)
				.OnDelete(DeleteBehavior.NoAction)
				.HasPrincipalKey<GithubAccount>(x => x.MemberId)
				.IsRequired();
		}
	}
}