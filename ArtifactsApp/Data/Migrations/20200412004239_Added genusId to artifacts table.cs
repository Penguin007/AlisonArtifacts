using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtifactsApp.Data.Migrations
{
    public partial class AddedgenusIdtoartifactstable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GenusId",
                table: "Artifact",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Artifact_GenusId",
                table: "Artifact",
                column: "GenusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Artifact_Genus_GenusId",
                table: "Artifact",
                column: "GenusId",
                principalTable: "Genus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artifact_Genus_GenusId",
                table: "Artifact");

            migrationBuilder.DropIndex(
                name: "IX_Artifact_GenusId",
                table: "Artifact");

            migrationBuilder.DropColumn(
                name: "GenusId",
                table: "Artifact");
        }
    }
}
