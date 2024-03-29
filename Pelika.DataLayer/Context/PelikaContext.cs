﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Pelika.DataLayer.Entities.Contact;
using Pelika.DataLayer.Entities.Course;
using Pelika.DataLayer.Entities.Order;
using Pelika.DataLayer.Entities.Permissions;
using Pelika.DataLayer.Entities.User;
using Pelika.DataLayer.Entities.Wallet;

namespace Pelika.DataLayer.Context
{
    public class PelikaContext : DbContext
    {

        public PelikaContext(DbContextOptions<PelikaContext> options) : base(options)
        {

        }

        #region User

        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<UserDiscountCode> UserDiscountCodes { get; set; }


        #endregion

        #region Wallet

        public DbSet<WalletType> WalletTypes { get; set; }
        public DbSet<Wallet> Wallets { get; set; }

        #endregion

        #region Permission

        public DbSet<Permission> Permission { get; set; }
        public DbSet<RolePermission> RolePermission { get; set; }

        #endregion

        #region Course

        public DbSet<CourseGroup> CourseGroups { get; set; }
        public DbSet<CourseLevel> CourseLevels { get; set; }
        public DbSet<CourseStatus> CourseStatus { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseEpisode> CourseEpisodes { get; set; }
        public DbSet<UserCourse> UserCourses { get; set; }
        public DbSet<CourseComment> CourseComments { get; set; }
        public DbSet<CourseVote> CourseVotes { get; set; }



        #endregion

        #region Order

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Discount> Discounts { get; set; }


        #endregion

        #region ContactUs

        public DbSet<ContactUs> contactUs { get; set; }


        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var cascadeFKs = modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetForeignKeys())
                .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs)
                fk.DeleteBehavior = DeleteBehavior.Restrict;
            modelBuilder.Entity<User>().HasQueryFilter(u => !u.IsDelete);
            modelBuilder.Entity<Role>().HasQueryFilter(r => !r.IsDelete);
            modelBuilder.Entity<CourseGroup>().HasQueryFilter(g => !g.IsDelete);

            modelBuilder.Entity<Course>().HasOne<CourseGroup>(f => f.CourseGroup)
                .WithMany(g => g.Courses).HasForeignKey(f => f.GroupId);
            modelBuilder.Entity<Course>().HasOne<CourseGroup>(f => f.Group).WithMany(g => g.SubGroup)
                .HasForeignKey(f => f.SubGroup);

            //modelBuilder.Entity<Course>().HasOne(b => b.CourseGroup).WithMany(i => i.Courses);   
            //modelBuilder.Entity<Course>().HasOne(b => b.Group).WithMany(i => i.SubGroup);

            base.OnModelCreating(modelBuilder);
        }
    }
}