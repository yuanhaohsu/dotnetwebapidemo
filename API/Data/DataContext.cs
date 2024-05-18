using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<AppUser> Users { get; set; }
    public DbSet<UserLike> Likes { get; set; } // #171
        protected override void OnModelCreating(ModelBuilder builder)
            {
                base.OnModelCreating(builder);

                builder.Entity<UserLike>()  //primary key #171
                    .HasKey(k => new { k.SourceUserId, k.TargetUserId });

                builder.Entity<UserLike>()      //relationshio between source and target user #171
                    .HasOne(s => s.SourceUser)
                    .WithMany(l => l.LikedUsers)
                    .HasForeignKey(s => s.SourceUserId)
                    .OnDelete(DeleteBehavior.Cascade);
                    //.OnDelete(DeleteBehavior.NoAction);

                builder.Entity<UserLike>()
                    .HasOne(s => s.TargetUser)
                    .WithMany(l => l.LikedByUsers)
                    .HasForeignKey(s => s.TargetUserId)
                    .OnDelete(DeleteBehavior.Cascade);
                    //.OnDelete(DeleteBehavior.NoAction);
            }
}
