﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Temple.Blazor.Net.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppointmentsAfterEnd",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Appointmenrs = table.Column<string>(type: "TEXT", nullable: true),
                    Year = table.Column<DateOnly>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentsAfterEnd", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Award",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    YearAward = table.Column<DateOnly>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Award", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Education",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    YearAdmission = table.Column<DateOnly>(type: "TEXT", nullable: true),
                    Institution = table.Column<string>(type: "TEXT", nullable: true),
                    YearOfRease = table.Column<DateOnly>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Education", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MeasuresState",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    YearArrest = table.Column<DateOnly>(type: "TEXT", nullable: true),
                    Verdict = table.Column<string>(type: "TEXT", nullable: true),
                    YearSentence = table.Column<DateOnly>(type: "TEXT", nullable: true),
                    YearRehabilitation = table.Column<DateOnly>(type: "TEXT", nullable: true),
                    Rehabilitaion = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeasuresState", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parishioners",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    TempleName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    YearRestart = table.Column<DateOnly>(type: "TEXT", nullable: true),
                    Otch = table.Column<string>(type: "TEXT", nullable: true),
                    Age = table.Column<int>(type: "INTEGER", nullable: true),
                    Gender = table.Column<string>(type: "TEXT", nullable: true),
                    Adress = table.Column<string>(type: "TEXT", nullable: true),
                    Social = table.Column<string>(type: "TEXT", nullable: true),
                    SocialStatus = table.Column<string>(type: "TEXT", nullable: true),
                    EstateBeforeRevolution = table.Column<string>(type: "TEXT", nullable: true),
                    PropertyStatus = table.Column<string>(type: "TEXT", nullable: false),
                    DateJoinRelligios = table.Column<DateOnly>(type: "TEXT", nullable: true),
                    YearMention = table.Column<DateOnly>(type: "TEXT", nullable: true),
                    Note = table.Column<string>(type: "TEXT", nullable: true),
                    Source = table.Column<string>(type: "TEXT", nullable: true),
                    Photo = table.Column<string>(type: "TEXT", nullable: true),
                    File = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parishioners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sun",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    YearOrdinations = table.Column<DateOnly>(type: "TEXT", nullable: true),
                    SunName = table.Column<string>(type: "TEXT", nullable: true),
                    YearDefrock = table.Column<DateOnly>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sun", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Temples",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Type = table.Column<string>(type: "TEXT", nullable: true),
                    DateStart = table.Column<DateOnly>(type: "TEXT", nullable: true),
                    DateEnd = table.Column<DateOnly>(type: "TEXT", nullable: true),
                    AppointmentsAfterEndId = table.Column<string>(type: "TEXT", nullable: true),
                    YearAdaptation = table.Column<DateOnly>(type: "TEXT", nullable: true),
                    YearDestruction = table.Column<DateOnly>(type: "TEXT", nullable: true),
                    ParshYear = table.Column<DateOnly>(type: "TEXT", nullable: true),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: true),
                    OrientationDiocesse = table.Column<string>(type: "TEXT", nullable: true),
                    Province = table.Column<string>(type: "TEXT", nullable: true),
                    Counties = table.Column<string>(type: "TEXT", nullable: true),
                    District = table.Column<string>(type: "TEXT", nullable: true),
                    Ocrug = table.Column<string>(type: "TEXT", nullable: true),
                    RayonDistrict = table.Column<string>(type: "TEXT", nullable: true),
                    Region = table.Column<string>(type: "TEXT", nullable: true),
                    RayonRegion = table.Column<string>(type: "TEXT", nullable: true),
                    SeparateRegion = table.Column<string>(type: "TEXT", nullable: true),
                    TypeLocality = table.Column<string>(type: "TEXT", nullable: true),
                    Locality = table.Column<string>(type: "TEXT", nullable: true),
                    Lat = table.Column<double>(type: "REAL", nullable: false),
                    Lng = table.Column<double>(type: "REAL", nullable: false),
                    YearReferences = table.Column<string>(type: "TEXT", nullable: true),
                    TempleNameOnMap = table.Column<string>(type: "TEXT", nullable: true),
                    Benevolence = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Temples", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Temples_AppointmentsAfterEnd_AppointmentsAfterEndId",
                        column: x => x.AppointmentsAfterEndId,
                        principalTable: "AppointmentsAfterEnd",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TempleOriention",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    YearFall = table.Column<DateOnly>(type: "TEXT", nullable: true),
                    Oriention = table.Column<string>(type: "TEXT", nullable: true),
                    YearRefund = table.Column<DateOnly>(type: "TEXT", nullable: true),
                    TempleId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TempleOriention", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TempleOriention_Temples_TempleId",
                        column: x => x.TempleId,
                        principalTable: "Temples",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Parsonalions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Otch = table.Column<string>(type: "TEXT", nullable: true),
                    MonaxName = table.Column<string>(type: "TEXT", nullable: true),
                    Born = table.Column<DateOnly>(type: "TEXT", nullable: true),
                    Death = table.Column<DateOnly>(type: "TEXT", nullable: true),
                    Nation = table.Column<string>(type: "TEXT", nullable: true),
                    PlaceOfDeath = table.Column<string>(type: "TEXT", nullable: true),
                    SocialOrigin = table.Column<string>(type: "TEXT", nullable: true),
                    EducationId = table.Column<string>(type: "TEXT", nullable: true),
                    SunId = table.Column<string>(type: "TEXT", nullable: true),
                    AwardId = table.Column<string>(type: "TEXT", nullable: true),
                    OrientionId = table.Column<string>(type: "TEXT", nullable: true),
                    StateId = table.Column<string>(type: "TEXT", nullable: true),
                    YearMention = table.Column<DateOnly>(type: "TEXT", nullable: true),
                    Note = table.Column<string>(type: "TEXT", nullable: true),
                    Source = table.Column<string>(type: "TEXT", nullable: true),
                    PlaceBirths = table.Column<string>(type: "TEXT", nullable: true),
                    LVLEducation = table.Column<string>(type: "TEXT", nullable: true),
                    Photo = table.Column<string>(type: "TEXT", nullable: true),
                    File = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parsonalions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Parsonalions_Award_AwardId",
                        column: x => x.AwardId,
                        principalTable: "Award",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Parsonalions_Education_EducationId",
                        column: x => x.EducationId,
                        principalTable: "Education",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Parsonalions_MeasuresState_StateId",
                        column: x => x.StateId,
                        principalTable: "MeasuresState",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Parsonalions_Sun_SunId",
                        column: x => x.SunId,
                        principalTable: "Sun",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Parsonalions_TempleOriention_OrientionId",
                        column: x => x.OrientionId,
                        principalTable: "TempleOriention",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Parsonalions_AwardId",
                table: "Parsonalions",
                column: "AwardId");

            migrationBuilder.CreateIndex(
                name: "IX_Parsonalions_EducationId",
                table: "Parsonalions",
                column: "EducationId");

            migrationBuilder.CreateIndex(
                name: "IX_Parsonalions_OrientionId",
                table: "Parsonalions",
                column: "OrientionId");

            migrationBuilder.CreateIndex(
                name: "IX_Parsonalions_StateId",
                table: "Parsonalions",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_Parsonalions_SunId",
                table: "Parsonalions",
                column: "SunId");

            migrationBuilder.CreateIndex(
                name: "IX_TempleOriention_TempleId",
                table: "TempleOriention",
                column: "TempleId");

            migrationBuilder.CreateIndex(
                name: "IX_Temples_AppointmentsAfterEndId",
                table: "Temples",
                column: "AppointmentsAfterEndId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parishioners");

            migrationBuilder.DropTable(
                name: "Parsonalions");

            migrationBuilder.DropTable(
                name: "Award");

            migrationBuilder.DropTable(
                name: "Education");

            migrationBuilder.DropTable(
                name: "MeasuresState");

            migrationBuilder.DropTable(
                name: "Sun");

            migrationBuilder.DropTable(
                name: "TempleOriention");

            migrationBuilder.DropTable(
                name: "Temples");

            migrationBuilder.DropTable(
                name: "AppointmentsAfterEnd");
        }
    }
}
