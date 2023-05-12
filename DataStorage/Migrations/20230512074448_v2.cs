using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataStorage.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CoordinateEntity_GeometryEntity_FK_GemoetryId",
                table: "CoordinateEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_FeatureEntity_GeometryEntity_Fk_GeometryId",
                table: "FeatureEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_FeatureEntity_Properti_FK_PropertiesId",
                table: "FeatureEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_FeatureEntity_RootEntity_FK_RootId",
                table: "FeatureEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_LinkEntity_RootEntity_FK_RootId",
                table: "LinkEntity");

            migrationBuilder.RenameTable(
                name: "RootEntity",
                newName: "Root");

            migrationBuilder.RenameTable(
                name: "LinkEntity",
                newName: "Link");

            migrationBuilder.RenameTable(
                name: "GeometryEntity",
                newName: "Geometry");

            migrationBuilder.RenameTable(
                name: "FeatureEntity",
                newName: "Feature");

            migrationBuilder.RenameTable(
                name: "CoordinateEntity",
                newName: "Coordinate");

            migrationBuilder.RenameIndex(
                name: "IX_LinkEntity_FK_RootId",
                table: "Link",
                newName: "IX_Link_FK_RootId");

            migrationBuilder.RenameIndex(
                name: "IX_FeatureEntity_FK_RootId",
                table: "Feature",
                newName: "IX_Feature_FK_RootId");

            migrationBuilder.RenameIndex(
                name: "IX_FeatureEntity_FK_PropertiesId",
                table: "Feature",
                newName: "IX_Feature_FK_PropertiesId");

            migrationBuilder.RenameIndex(
                name: "IX_FeatureEntity_Fk_GeometryId",
                table: "Feature",
                newName: "IX_Feature_Fk_GeometryId");

            migrationBuilder.RenameIndex(
                name: "IX_CoordinateEntity_FK_GemoetryId",
                table: "Coordinate",
                newName: "IX_Coordinate_FK_GemoetryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Coordinate_Geometry_FK_GemoetryId",
                table: "Coordinate",
                column: "FK_GemoetryId",
                principalTable: "Geometry",
                principalColumn: "GeometryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Feature_Geometry_Fk_GeometryId",
                table: "Feature",
                column: "Fk_GeometryId",
                principalTable: "Geometry",
                principalColumn: "GeometryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Feature_Properti_FK_PropertiesId",
                table: "Feature",
                column: "FK_PropertiesId",
                principalTable: "Properti",
                principalColumn: "PropertiesId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Feature_Root_FK_RootId",
                table: "Feature",
                column: "FK_RootId",
                principalTable: "Root",
                principalColumn: "RootId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Link_Root_FK_RootId",
                table: "Link",
                column: "FK_RootId",
                principalTable: "Root",
                principalColumn: "RootId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coordinate_Geometry_FK_GemoetryId",
                table: "Coordinate");

            migrationBuilder.DropForeignKey(
                name: "FK_Feature_Geometry_Fk_GeometryId",
                table: "Feature");

            migrationBuilder.DropForeignKey(
                name: "FK_Feature_Properti_FK_PropertiesId",
                table: "Feature");

            migrationBuilder.DropForeignKey(
                name: "FK_Feature_Root_FK_RootId",
                table: "Feature");

            migrationBuilder.DropForeignKey(
                name: "FK_Link_Root_FK_RootId",
                table: "Link");

            migrationBuilder.RenameTable(
                name: "Root",
                newName: "RootEntity");

            migrationBuilder.RenameTable(
                name: "Link",
                newName: "LinkEntity");

            migrationBuilder.RenameTable(
                name: "Geometry",
                newName: "GeometryEntity");

            migrationBuilder.RenameTable(
                name: "Feature",
                newName: "FeatureEntity");

            migrationBuilder.RenameTable(
                name: "Coordinate",
                newName: "CoordinateEntity");

            migrationBuilder.RenameIndex(
                name: "IX_Link_FK_RootId",
                table: "LinkEntity",
                newName: "IX_LinkEntity_FK_RootId");

            migrationBuilder.RenameIndex(
                name: "IX_Feature_FK_RootId",
                table: "FeatureEntity",
                newName: "IX_FeatureEntity_FK_RootId");

            migrationBuilder.RenameIndex(
                name: "IX_Feature_FK_PropertiesId",
                table: "FeatureEntity",
                newName: "IX_FeatureEntity_FK_PropertiesId");

            migrationBuilder.RenameIndex(
                name: "IX_Feature_Fk_GeometryId",
                table: "FeatureEntity",
                newName: "IX_FeatureEntity_Fk_GeometryId");

            migrationBuilder.RenameIndex(
                name: "IX_Coordinate_FK_GemoetryId",
                table: "CoordinateEntity",
                newName: "IX_CoordinateEntity_FK_GemoetryId");

            migrationBuilder.AddForeignKey(
                name: "FK_CoordinateEntity_GeometryEntity_FK_GemoetryId",
                table: "CoordinateEntity",
                column: "FK_GemoetryId",
                principalTable: "GeometryEntity",
                principalColumn: "GeometryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FeatureEntity_GeometryEntity_Fk_GeometryId",
                table: "FeatureEntity",
                column: "Fk_GeometryId",
                principalTable: "GeometryEntity",
                principalColumn: "GeometryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FeatureEntity_Properti_FK_PropertiesId",
                table: "FeatureEntity",
                column: "FK_PropertiesId",
                principalTable: "Properti",
                principalColumn: "PropertiesId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FeatureEntity_RootEntity_FK_RootId",
                table: "FeatureEntity",
                column: "FK_RootId",
                principalTable: "RootEntity",
                principalColumn: "RootId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LinkEntity_RootEntity_FK_RootId",
                table: "LinkEntity",
                column: "FK_RootId",
                principalTable: "RootEntity",
                principalColumn: "RootId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
