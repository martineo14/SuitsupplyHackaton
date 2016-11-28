using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Suitsupply.SalesRep.API.DAL;

namespace Suitsupply.SalesRep.API.Migrations
{
    [DbContext(typeof(SaleRepresentativeContext))]
    [Migration("20161125120043_SalesRepresentativeTable")]
    partial class SalesRepresentativeTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Suitsupply.SalesRep.API.DAL.Entities.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<int>("SaleRepresentativeId");

                    b.HasKey("Id");

                    b.HasIndex("SaleRepresentativeId");

                    b.ToTable("Review");
                });

            modelBuilder.Entity("Suitsupply.SalesRep.API.DAL.Entities.SaleRepresentative", b =>
                {
                    b.Property<int>("SalesRepId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("PictureUrl");

                    b.Property<int>("Rating");

                    b.Property<int>("SalesForceId");

                    b.Property<string>("Story");

                    b.HasKey("SalesRepId");

                    b.ToTable("SalesRepresentatives");
                });

            modelBuilder.Entity("Suitsupply.SalesRep.API.DAL.Entities.Review", b =>
                {
                    b.HasOne("Suitsupply.SalesRep.API.DAL.Entities.SaleRepresentative", "SaleRepresentative")
                        .WithMany("Reviews")
                        .HasForeignKey("SaleRepresentativeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
