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
    [Migration("20240630175420_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("Temple.Net.Models.AppointmentsAfterEnd", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Appointmenrs")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("AppointmentsAfterEnd");
                });

            modelBuilder.Entity("Temple.Net.Models.Award", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("YearAward")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Award");
                });

            modelBuilder.Entity("Temple.Net.Models.Education", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Institution")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("YearAdmission")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("YearOfRease")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Education");
                });

            modelBuilder.Entity("Temple.Net.Models.MeasuresState", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rehabilitaion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Verdict")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("YearArrest")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("YearRehabilitation")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("YearSentence")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("MeasuresState");
                });

            modelBuilder.Entity("Temple.Net.Models.Parishioners", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DateJoinRelligios")
                        .HasColumnType("TEXT");

                    b.Property<string>("EstateBeforeRevolution")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("File")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Otch")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PropertyStatus")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Social")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SocialStatus")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TempleName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("YearMention")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("YearRestart")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Parishioners");
                });

            modelBuilder.Entity("Temple.Net.Models.Parsonalion", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("AwardId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Born")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Death")
                        .HasColumnType("TEXT");

                    b.Property<string>("EducationId")
                        .HasColumnType("TEXT");

                    b.Property<string>("File")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LVLEducation")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MonaxName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nation")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("OrientionId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Otch")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Place1Births")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PlaceOfDeath")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SocialOrigin")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StateId")
                        .HasColumnType("TEXT");

                    b.Property<string>("SunId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("YearMention")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AwardId");

                    b.HasIndex("EducationId");

                    b.HasIndex("OrientionId");

                    b.HasIndex("StateId");

                    b.HasIndex("SunId");

                    b.ToTable("Parsonalions");
                });

            modelBuilder.Entity("Temple.Net.Models.Sun", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("SunName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("YearDefrock")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("YearOrdinations")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Sun");
                });

            modelBuilder.Entity("Temple.Net.Models.Temple", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("AppointmentsAfterEndId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DateEnd")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DateStart")
                        .HasColumnType("TEXT");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("OrientationDiocesse")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("OrientionId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("ParshYear")
                        .HasColumnType("TEXT");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("YearAdaptation")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("YearDestruction")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AppointmentsAfterEndId");

                    b.HasIndex("OrientionId");

                    b.ToTable("Temples");
                });

            modelBuilder.Entity("Temple.Net.Models.TempleOriention", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Oriention")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("YearFall")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("YearRefund")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("TempleOriention");
                });

            modelBuilder.Entity("Temple.Net.Models.Parsonalion", b =>
                {
                    b.HasOne("Temple.Net.Models.Award", "Award")
                        .WithMany()
                        .HasForeignKey("AwardId");

                    b.HasOne("Temple.Net.Models.Education", "Education")
                        .WithMany()
                        .HasForeignKey("EducationId");

                    b.HasOne("Temple.Net.Models.TempleOriention", "Oriention")
                        .WithMany()
                        .HasForeignKey("OrientionId");

                    b.HasOne("Temple.Net.Models.MeasuresState", "State")
                        .WithMany()
                        .HasForeignKey("StateId");

                    b.HasOne("Temple.Net.Models.Sun", "Sun")
                        .WithMany()
                        .HasForeignKey("SunId");

                    b.Navigation("Award");

                    b.Navigation("Education");

                    b.Navigation("Oriention");

                    b.Navigation("State");

                    b.Navigation("Sun");
                });

            modelBuilder.Entity("Temple.Net.Models.Temple", b =>
                {
                    b.HasOne("Temple.Net.Models.AppointmentsAfterEnd", "AppointmentsAfterEnd")
                        .WithMany()
                        .HasForeignKey("AppointmentsAfterEndId");

                    b.HasOne("Temple.Net.Models.TempleOriention", "Oriention")
                        .WithMany()
                        .HasForeignKey("OrientionId");

                    b.Navigation("AppointmentsAfterEnd");

                    b.Navigation("Oriention");
                });
#pragma warning restore 612, 618
        }
    }
}
