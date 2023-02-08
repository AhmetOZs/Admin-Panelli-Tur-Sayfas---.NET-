﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Models.sınıflar;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20221010094050_bolge4")]
    partial class bolge4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication1.Models.sınıflar.DetayGorsel", b =>
                {
                    b.Property<int>("DetayGorselID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DetayResim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("turID")
                        .HasColumnType("int");

                    b.HasKey("DetayGorselID");

                    b.HasIndex("turID");

                    b.ToTable("detayGorsels");
                });

            modelBuilder.Entity("WebApplication1.Models.sınıflar.Iletisim", b =>
                {
                    b.Property<int>("iletisimID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("adres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("facebook")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fotaciklamaen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fotaciklamaru")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fotaciklamatr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("instagram")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("konum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("linkedin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("metinen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("metinru")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("metintr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefoncep")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefonsabit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("twitter")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("iletisimID");

                    b.ToTable("iletisims");
                });

            modelBuilder.Entity("WebApplication1.Models.sınıflar.Turlar", b =>
                {
                    b.Property<int>("turID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bolgesicaklik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("bolgeID")
                        .HasColumnType("int");

                    b.Property<string>("girisresim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("kontejyan")
                        .HasColumnType("int");

                    b.Property<string>("sehir")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("turismi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("turtarihi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ucret")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("turID");

                    b.HasIndex("bolgeID");

                    b.ToTable("Turlars");
                });

            modelBuilder.Entity("WebApplication1.Models.sınıflar.bolge", b =>
                {
                    b.Property<int>("bolgeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("bolgeismi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("bolgeID");

                    b.ToTable("bolges");
                });

            modelBuilder.Entity("WebApplication1.Models.sınıflar.fotogaleri", b =>
                {
                    b.Property<int>("galeriID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("galeriResim")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("galeriID");

                    b.ToTable("fotogaleris");
                });

            modelBuilder.Entity("WebApplication1.Models.sınıflar.hakkimizdaen", b =>
                {
                    b.Property<int>("hakkimizdaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("hakkimizdaaciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hakkimizdabaslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hakkimizdavideo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("hakkimizdaID");

                    b.ToTable("hakkimizdaens");
                });

            modelBuilder.Entity("WebApplication1.Models.sınıflar.turdetay", b =>
                {
                    b.Property<int>("detayID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("detayaciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("detaybaslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("detayresim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("turID")
                        .HasColumnType("int");

                    b.HasKey("detayID");

                    b.HasIndex("turID");

                    b.ToTable("turdetays");
                });

            modelBuilder.Entity("WebApplication1.Models.sınıflar.DetayGorsel", b =>
                {
                    b.HasOne("WebApplication1.Models.sınıflar.Turlar", "Turlar")
                        .WithMany("detayGorsels")
                        .HasForeignKey("turID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Turlar");
                });

            modelBuilder.Entity("WebApplication1.Models.sınıflar.Turlar", b =>
                {
                    b.HasOne("WebApplication1.Models.sınıflar.bolge", "Bolge")
                        .WithMany("Turlars")
                        .HasForeignKey("bolgeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bolge");
                });

            modelBuilder.Entity("WebApplication1.Models.sınıflar.turdetay", b =>
                {
                    b.HasOne("WebApplication1.Models.sınıflar.Turlar", "Turlar")
                        .WithMany("turdetays")
                        .HasForeignKey("turID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Turlar");
                });

            modelBuilder.Entity("WebApplication1.Models.sınıflar.Turlar", b =>
                {
                    b.Navigation("detayGorsels");

                    b.Navigation("turdetays");
                });

            modelBuilder.Entity("WebApplication1.Models.sınıflar.bolge", b =>
                {
                    b.Navigation("Turlars");
                });
#pragma warning restore 612, 618
        }
    }
}
