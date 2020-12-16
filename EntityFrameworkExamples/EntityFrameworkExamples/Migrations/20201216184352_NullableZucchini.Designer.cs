﻿// <auto-generated />
using EntityFrameworkExamples;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EntityFrameworkExamples.Migrations
{
    [DbContext(typeof(FruitsDbContext))]
    [Migration("20201216184352_NullableZucchini")]
    partial class NullableZucchini
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("EntityFrameworkExamples.Models.FruitBasket", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Banana")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pear")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zucchini")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("FruitBaskets");
                });
#pragma warning restore 612, 618
        }
    }
}
