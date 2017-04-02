using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using EFCoreExplicitLoading;

namespace EFCoreExplicitLoading.Migrations
{
    [DbContext(typeof(StudentContext))]
    [Migration("20170402110057_InitialDatabase")]
    partial class InitialDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFCoreExplicitLoading.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("EFCoreExplicitLoading.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DepartMentId");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("StudentId");

                    b.HasIndex("DepartMentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("EFCoreExplicitLoading.Student", b =>
                {
                    b.HasOne("EFCoreExplicitLoading.Department", "Department")
                        .WithMany("Students")
                        .HasForeignKey("DepartMentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
