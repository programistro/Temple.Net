﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Temple.Net.Data;

#nullable disable

namespace Temple.Blazor.Net.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240811185856_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("Temple.Core.AppointmentsAfterEnd", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Appointmenrs")
                        .HasColumnType("TEXT");

                    b.Property<DateOnly?>("Year")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("AppointmentsAfterEnd");
                });

            modelBuilder.Entity("Temple.Core.Award", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<DateOnly?>("YearAward")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Award");
                });

            modelBuilder.Entity("Temple.Core.Education", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Institution")
                        .HasColumnType("TEXT");

                    b.Property<DateOnly?>("YearAdmission")
                        .HasColumnType("TEXT");

                    b.Property<DateOnly?>("YearOfRease")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Education");
                });

            modelBuilder.Entity("Temple.Core.MeasuresState", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rehabilitaion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Verdict")
                        .HasColumnType("TEXT");

                    b.Property<DateOnly?>("YearArrest")
                        .HasColumnType("TEXT");

                    b.Property<DateOnly?>("YearRehabilitation")
                        .HasColumnType("TEXT");

                    b.Property<DateOnly?>("YearSentence")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("MeasuresState");
                });

            modelBuilder.Entity("Temple.Core.Parishioners", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Adress")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly?>("DateJoinRelligios")
                        .HasColumnType("TEXT");

                    b.Property<string>("EstateBeforeRevolution")
                        .HasColumnType("TEXT");

                    b.Property<string>("File")
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Note")
                        .HasColumnType("TEXT");

                    b.Property<string>("Otch")
                        .HasColumnType("TEXT");

                    b.Property<string>("Photo")
                        .HasColumnType("TEXT");

                    b.Property<string>("PropertyStatus")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Social")
                        .HasColumnType("TEXT");

                    b.Property<string>("SocialStatus")
                        .HasColumnType("TEXT");

                    b.Property<string>("Source")
                        .HasColumnType("TEXT");

                    b.Property<string>("TempleName")
                        .HasColumnType("TEXT");

                    b.Property<DateOnly?>("YearMention")
                        .HasColumnType("TEXT");

                    b.Property<DateOnly?>("YearRestart")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Parishioners");
                });

            modelBuilder.Entity("Temple.Core.ParishionersTemple", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateOnly?>("ParshYear")
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TempleId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("TempleId");

                    b.ToTable("ParishionersTemple");
                });

            modelBuilder.Entity("Temple.Core.ParshNote", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Adress")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EstateBeforeRevolution")
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Note")
                        .HasColumnType("TEXT");

                    b.Property<string>("Otch")
                        .HasColumnType("TEXT");

                    b.Property<string>("PropertyStatus")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Social")
                        .HasColumnType("TEXT");

                    b.Property<string>("SocialStatus")
                        .HasColumnType("TEXT");

                    b.Property<string>("TempleName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ParshNotes");
                });

            modelBuilder.Entity("Temple.Core.Parsonalion", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("AwardId")
                        .HasColumnType("TEXT");

                    b.Property<DateOnly?>("Born")
                        .HasColumnType("TEXT");

                    b.Property<DateOnly?>("Death")
                        .HasColumnType("TEXT");

                    b.Property<string>("EducationId")
                        .HasColumnType("TEXT");

                    b.Property<string>("File")
                        .HasColumnType("TEXT");

                    b.Property<string>("LVLEducation")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("MonaxName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nation")
                        .HasColumnType("TEXT");

                    b.Property<string>("Note")
                        .HasColumnType("TEXT");

                    b.Property<string>("OrientionId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Otch")
                        .HasColumnType("TEXT");

                    b.Property<string>("Photo")
                        .HasColumnType("TEXT");

                    b.Property<string>("PlaceBirths")
                        .HasColumnType("TEXT");

                    b.Property<string>("PlaceOfDeath")
                        .HasColumnType("TEXT");

                    b.Property<string>("SocialOrigin")
                        .HasColumnType("TEXT");

                    b.Property<string>("Source")
                        .HasColumnType("TEXT");

                    b.Property<string>("StateId")
                        .HasColumnType("TEXT");

                    b.Property<string>("SunId")
                        .HasColumnType("TEXT");

                    b.Property<DateOnly?>("YearMention")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AwardId");

                    b.HasIndex("EducationId");

                    b.HasIndex("OrientionId");

                    b.HasIndex("StateId");

                    b.HasIndex("SunId");

                    b.ToTable("Parsonalions");
                });

            modelBuilder.Entity("Temple.Core.PersNote", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("LVLEducation")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("MonaxName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nation")
                        .HasColumnType("TEXT");

                    b.Property<string>("Note")
                        .HasColumnType("TEXT");

                    b.Property<string>("Otch")
                        .HasColumnType("TEXT");

                    b.Property<string>("PlaceBirths")
                        .HasColumnType("TEXT");

                    b.Property<string>("PlaceOfDeath")
                        .HasColumnType("TEXT");

                    b.Property<string>("SocialOrigin")
                        .HasColumnType("TEXT");

                    b.Property<string>("Source")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("PersNotes");
                });

            modelBuilder.Entity("Temple.Core.Sun", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("SunName")
                        .HasColumnType("TEXT");

                    b.Property<DateOnly?>("YearDefrock")
                        .HasColumnType("TEXT");

                    b.Property<DateOnly?>("YearOrdinations")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Sun");
                });

            modelBuilder.Entity("Temple.Core.Temple", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("AppointmentsAfterEndId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Benevolence")
                        .HasColumnType("TEXT");

                    b.Property<string>("Counties")
                        .HasColumnType("TEXT");

                    b.Property<DateOnly?>("DateEnd")
                        .HasColumnType("TEXT");

                    b.Property<DateOnly?>("DateStart")
                        .HasColumnType("TEXT");

                    b.Property<string>("District")
                        .HasColumnType("TEXT");

                    b.Property<double>("Lat")
                        .HasColumnType("REAL");

                    b.Property<double>("Lng")
                        .HasColumnType("REAL");

                    b.Property<string>("Locality")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Ocrug")
                        .HasColumnType("TEXT");

                    b.Property<string>("OrientationDiocesse")
                        .HasColumnType("TEXT");

                    b.Property<string>("Province")
                        .HasColumnType("TEXT");

                    b.Property<string>("RayonDistrict")
                        .HasColumnType("TEXT");

                    b.Property<string>("RayonRegion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Region")
                        .HasColumnType("TEXT");

                    b.Property<string>("SeparateRegion")
                        .HasColumnType("TEXT");

                    b.Property<string>("TempleNameOnMap")
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.Property<string>("TypeLocality")
                        .HasColumnType("TEXT");

                    b.Property<DateOnly?>("YearAdaptation")
                        .HasColumnType("TEXT");

                    b.Property<DateOnly?>("YearDestruction")
                        .HasColumnType("TEXT");

                    b.Property<string>("YearReferences")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AppointmentsAfterEndId");

                    b.ToTable("Temples");
                });

            modelBuilder.Entity("Temple.Core.TempleNote", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Benevolence")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Counties")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Locality")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Ocrug")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("OrientationDiocesse")
                        .HasColumnType("TEXT");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("RayonDistrict")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("RayonRegion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SeparateRegion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TempleNameOnMap")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.Property<string>("TypeLocality")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("TempleNotes");
                });

            modelBuilder.Entity("Temple.Core.TempleOriention", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Oriention")
                        .HasColumnType("TEXT");

                    b.Property<string>("TempleId")
                        .HasColumnType("TEXT");

                    b.Property<DateOnly?>("YearFall")
                        .HasColumnType("TEXT");

                    b.Property<DateOnly?>("YearRefund")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("TempleId");

                    b.ToTable("TempleOriention");
                });

            modelBuilder.Entity("Temple.Core.ParishionersTemple", b =>
                {
                    b.HasOne("Temple.Core.Temple", null)
                        .WithMany("ParishionersTemple")
                        .HasForeignKey("TempleId");
                });

            modelBuilder.Entity("Temple.Core.Parsonalion", b =>
                {
                    b.HasOne("Temple.Core.Award", "Award")
                        .WithMany()
                        .HasForeignKey("AwardId");

                    b.HasOne("Temple.Core.Education", "Education")
                        .WithMany()
                        .HasForeignKey("EducationId");

                    b.HasOne("Temple.Core.TempleOriention", "Oriention")
                        .WithMany()
                        .HasForeignKey("OrientionId");

                    b.HasOne("Temple.Core.MeasuresState", "State")
                        .WithMany()
                        .HasForeignKey("StateId");

                    b.HasOne("Temple.Core.Sun", "Sun")
                        .WithMany()
                        .HasForeignKey("SunId");

                    b.Navigation("Award");

                    b.Navigation("Education");

                    b.Navigation("Oriention");

                    b.Navigation("State");

                    b.Navigation("Sun");
                });

            modelBuilder.Entity("Temple.Core.Temple", b =>
                {
                    b.HasOne("Temple.Core.AppointmentsAfterEnd", "AppointmentsAfterEnd")
                        .WithMany()
                        .HasForeignKey("AppointmentsAfterEndId");

                    b.Navigation("AppointmentsAfterEnd");
                });

            modelBuilder.Entity("Temple.Core.TempleOriention", b =>
                {
                    b.HasOne("Temple.Core.Temple", null)
                        .WithMany("Oriention")
                        .HasForeignKey("TempleId");
                });

            modelBuilder.Entity("Temple.Core.Temple", b =>
                {
                    b.Navigation("Oriention");

                    b.Navigation("ParishionersTemple");
                });
#pragma warning restore 612, 618
        }
    }
}
