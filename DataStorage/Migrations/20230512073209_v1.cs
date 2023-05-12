using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataStorage.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GeometryEntity",
                columns: table => new
                {
                    GeometryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("geometry_id", x => x.GeometryId);
                });

            migrationBuilder.CreateTable(
                name: "Properti",
                columns: table => new
                {
                    PropertiesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    parameter_number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    observed = table.Column<DateTime>(type: "datetime2", nullable: false),
                    station_number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    value = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("propeti_id", x => x.PropertiesId);
                });

            migrationBuilder.CreateTable(
                name: "RootEntity",
                columns: table => new
                {
                    RootId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    time_stamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    number_returned = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("root_id", x => x.RootId);
                });

            migrationBuilder.CreateTable(
                name: "CoordinateEntity",
                columns: table => new
                {
                    CoordinateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    value = table.Column<double>(type: "float", nullable: false),
                    FK_GemoetryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("coordinate_id", x => x.CoordinateId);
                    table.ForeignKey(
                        name: "FK_CoordinateEntity_GeometryEntity_FK_GemoetryId",
                        column: x => x.FK_GemoetryId,
                        principalTable: "GeometryEntity",
                        principalColumn: "GeometryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FeatureEntity",
                columns: table => new
                {
                    FeatureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    type = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    FK_PropertiesId = table.Column<int>(type: "int", nullable: false),
                    Fk_GeometryId = table.Column<int>(type: "int", nullable: false),
                    FK_RootId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("feature_id", x => x.FeatureId);
                    table.ForeignKey(
                        name: "FK_FeatureEntity_GeometryEntity_Fk_GeometryId",
                        column: x => x.Fk_GeometryId,
                        principalTable: "GeometryEntity",
                        principalColumn: "GeometryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FeatureEntity_Properti_FK_PropertiesId",
                        column: x => x.FK_PropertiesId,
                        principalTable: "Properti",
                        principalColumn: "PropertiesId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FeatureEntity_RootEntity_FK_RootId",
                        column: x => x.FK_RootId,
                        principalTable: "RootEntity",
                        principalColumn: "RootId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LinkEntity",
                columns: table => new
                {
                    LinkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    href = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    rel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    type = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FK_RootId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("link_id", x => x.LinkId);
                    table.ForeignKey(
                        name: "FK_LinkEntity_RootEntity_FK_RootId",
                        column: x => x.FK_RootId,
                        principalTable: "RootEntity",
                        principalColumn: "RootId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CoordinateEntity_FK_GemoetryId",
                table: "CoordinateEntity",
                column: "FK_GemoetryId");

            migrationBuilder.CreateIndex(
                name: "IX_FeatureEntity_Fk_GeometryId",
                table: "FeatureEntity",
                column: "Fk_GeometryId");

            migrationBuilder.CreateIndex(
                name: "IX_FeatureEntity_FK_PropertiesId",
                table: "FeatureEntity",
                column: "FK_PropertiesId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FeatureEntity_FK_RootId",
                table: "FeatureEntity",
                column: "FK_RootId");

            migrationBuilder.CreateIndex(
                name: "IX_LinkEntity_FK_RootId",
                table: "LinkEntity",
                column: "FK_RootId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CoordinateEntity");

            migrationBuilder.DropTable(
                name: "FeatureEntity");

            migrationBuilder.DropTable(
                name: "LinkEntity");

            migrationBuilder.DropTable(
                name: "GeometryEntity");

            migrationBuilder.DropTable(
                name: "Properti");

            migrationBuilder.DropTable(
                name: "RootEntity");
        }
    }
}
