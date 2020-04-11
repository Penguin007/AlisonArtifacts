using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtifactsApp.Data.Migrations
{
    public partial class AddedRelationshipstoTaxonomytables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artifact_Class_ClassId",
                table: "Artifact");

            migrationBuilder.DropForeignKey(
                name: "FK_Artifact_Family_FamilyId",
                table: "Artifact");

            migrationBuilder.DropForeignKey(
                name: "FK_Artifact_Kingdom_KingdomId",
                table: "Artifact");

            migrationBuilder.DropForeignKey(
                name: "FK_Artifact_Owner_OwnerId",
                table: "Artifact");

            migrationBuilder.DropForeignKey(
                name: "FK_Artifact_Phylum_PhylumId",
                table: "Artifact");

            migrationBuilder.DropForeignKey(
                name: "FK_Artifact_Source_SourceId",
                table: "Artifact");

            migrationBuilder.DropForeignKey(
                name: "FK_Artifact_Species_SpeciesId",
                table: "Artifact");

            migrationBuilder.AddColumn<int>(
                name: "ClassId",
                table: "Species",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FamilyId",
                table: "Species",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KingdomId",
                table: "Species",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Species",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PhylumId",
                table: "Species",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KingdomId",
                table: "Phylum",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClassId",
                table: "Order",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KingdomId",
                table: "Order",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PhylumId",
                table: "Order",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClassId",
                table: "Genus",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FamilyId",
                table: "Genus",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KingdomId",
                table: "Genus",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Genus",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PhylumId",
                table: "Genus",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClassId",
                table: "Family",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KingdomId",
                table: "Family",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Family",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PhylumId",
                table: "Family",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KingdomId",
                table: "Class",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PhylumId",
                table: "Class",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SpeciesId",
                table: "Artifact",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SourceId",
                table: "Artifact",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PhylumId",
                table: "Artifact",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "OwnerId",
                table: "Artifact",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "KingdomId",
                table: "Artifact",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FamilyId",
                table: "Artifact",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ClassId",
                table: "Artifact",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Species_ClassId",
                table: "Species",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Species_FamilyId",
                table: "Species",
                column: "FamilyId");

            migrationBuilder.CreateIndex(
                name: "IX_Species_KingdomId",
                table: "Species",
                column: "KingdomId");

            migrationBuilder.CreateIndex(
                name: "IX_Species_OrderId",
                table: "Species",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Species_PhylumId",
                table: "Species",
                column: "PhylumId");

            migrationBuilder.CreateIndex(
                name: "IX_Phylum_KingdomId",
                table: "Phylum",
                column: "KingdomId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ClassId",
                table: "Order",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_KingdomId",
                table: "Order",
                column: "KingdomId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_PhylumId",
                table: "Order",
                column: "PhylumId");

            migrationBuilder.CreateIndex(
                name: "IX_Genus_ClassId",
                table: "Genus",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Genus_FamilyId",
                table: "Genus",
                column: "FamilyId");

            migrationBuilder.CreateIndex(
                name: "IX_Genus_KingdomId",
                table: "Genus",
                column: "KingdomId");

            migrationBuilder.CreateIndex(
                name: "IX_Genus_OrderId",
                table: "Genus",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Genus_PhylumId",
                table: "Genus",
                column: "PhylumId");

            migrationBuilder.CreateIndex(
                name: "IX_Family_ClassId",
                table: "Family",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Family_KingdomId",
                table: "Family",
                column: "KingdomId");

            migrationBuilder.CreateIndex(
                name: "IX_Family_OrderId",
                table: "Family",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Family_PhylumId",
                table: "Family",
                column: "PhylumId");

            migrationBuilder.CreateIndex(
                name: "IX_Class_KingdomId",
                table: "Class",
                column: "KingdomId");

            migrationBuilder.CreateIndex(
                name: "IX_Class_PhylumId",
                table: "Class",
                column: "PhylumId");

            migrationBuilder.AddForeignKey(
                name: "FK_Artifact_Class_ClassId",
                table: "Artifact",
                column: "ClassId",
                principalTable: "Class",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Artifact_Family_FamilyId",
                table: "Artifact",
                column: "FamilyId",
                principalTable: "Family",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Artifact_Kingdom_KingdomId",
                table: "Artifact",
                column: "KingdomId",
                principalTable: "Kingdom",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Artifact_Owner_OwnerId",
                table: "Artifact",
                column: "OwnerId",
                principalTable: "Owner",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Artifact_Phylum_PhylumId",
                table: "Artifact",
                column: "PhylumId",
                principalTable: "Phylum",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Artifact_Source_SourceId",
                table: "Artifact",
                column: "SourceId",
                principalTable: "Source",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Artifact_Species_SpeciesId",
                table: "Artifact",
                column: "SpeciesId",
                principalTable: "Species",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Class_Kingdom_KingdomId",
                table: "Class",
                column: "KingdomId",
                principalTable: "Kingdom",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Class_Phylum_PhylumId",
                table: "Class",
                column: "PhylumId",
                principalTable: "Phylum",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Family_Class_ClassId",
                table: "Family",
                column: "ClassId",
                principalTable: "Class",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Family_Kingdom_KingdomId",
                table: "Family",
                column: "KingdomId",
                principalTable: "Kingdom",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Family_Order_OrderId",
                table: "Family",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Family_Phylum_PhylumId",
                table: "Family",
                column: "PhylumId",
                principalTable: "Phylum",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Genus_Class_ClassId",
                table: "Genus",
                column: "ClassId",
                principalTable: "Class",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Genus_Family_FamilyId",
                table: "Genus",
                column: "FamilyId",
                principalTable: "Family",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Genus_Kingdom_KingdomId",
                table: "Genus",
                column: "KingdomId",
                principalTable: "Kingdom",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Genus_Order_OrderId",
                table: "Genus",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Genus_Phylum_PhylumId",
                table: "Genus",
                column: "PhylumId",
                principalTable: "Phylum",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Class_ClassId",
                table: "Order",
                column: "ClassId",
                principalTable: "Class",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Kingdom_KingdomId",
                table: "Order",
                column: "KingdomId",
                principalTable: "Kingdom",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Phylum_PhylumId",
                table: "Order",
                column: "PhylumId",
                principalTable: "Phylum",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Phylum_Kingdom_KingdomId",
                table: "Phylum",
                column: "KingdomId",
                principalTable: "Kingdom",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Species_Class_ClassId",
                table: "Species",
                column: "ClassId",
                principalTable: "Class",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Species_Family_FamilyId",
                table: "Species",
                column: "FamilyId",
                principalTable: "Family",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Species_Kingdom_KingdomId",
                table: "Species",
                column: "KingdomId",
                principalTable: "Kingdom",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Species_Order_OrderId",
                table: "Species",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Species_Phylum_PhylumId",
                table: "Species",
                column: "PhylumId",
                principalTable: "Phylum",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artifact_Class_ClassId",
                table: "Artifact");

            migrationBuilder.DropForeignKey(
                name: "FK_Artifact_Family_FamilyId",
                table: "Artifact");

            migrationBuilder.DropForeignKey(
                name: "FK_Artifact_Kingdom_KingdomId",
                table: "Artifact");

            migrationBuilder.DropForeignKey(
                name: "FK_Artifact_Owner_OwnerId",
                table: "Artifact");

            migrationBuilder.DropForeignKey(
                name: "FK_Artifact_Phylum_PhylumId",
                table: "Artifact");

            migrationBuilder.DropForeignKey(
                name: "FK_Artifact_Source_SourceId",
                table: "Artifact");

            migrationBuilder.DropForeignKey(
                name: "FK_Artifact_Species_SpeciesId",
                table: "Artifact");

            migrationBuilder.DropForeignKey(
                name: "FK_Class_Kingdom_KingdomId",
                table: "Class");

            migrationBuilder.DropForeignKey(
                name: "FK_Class_Phylum_PhylumId",
                table: "Class");

            migrationBuilder.DropForeignKey(
                name: "FK_Family_Class_ClassId",
                table: "Family");

            migrationBuilder.DropForeignKey(
                name: "FK_Family_Kingdom_KingdomId",
                table: "Family");

            migrationBuilder.DropForeignKey(
                name: "FK_Family_Order_OrderId",
                table: "Family");

            migrationBuilder.DropForeignKey(
                name: "FK_Family_Phylum_PhylumId",
                table: "Family");

            migrationBuilder.DropForeignKey(
                name: "FK_Genus_Class_ClassId",
                table: "Genus");

            migrationBuilder.DropForeignKey(
                name: "FK_Genus_Family_FamilyId",
                table: "Genus");

            migrationBuilder.DropForeignKey(
                name: "FK_Genus_Kingdom_KingdomId",
                table: "Genus");

            migrationBuilder.DropForeignKey(
                name: "FK_Genus_Order_OrderId",
                table: "Genus");

            migrationBuilder.DropForeignKey(
                name: "FK_Genus_Phylum_PhylumId",
                table: "Genus");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Class_ClassId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Kingdom_KingdomId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Phylum_PhylumId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Phylum_Kingdom_KingdomId",
                table: "Phylum");

            migrationBuilder.DropForeignKey(
                name: "FK_Species_Class_ClassId",
                table: "Species");

            migrationBuilder.DropForeignKey(
                name: "FK_Species_Family_FamilyId",
                table: "Species");

            migrationBuilder.DropForeignKey(
                name: "FK_Species_Kingdom_KingdomId",
                table: "Species");

            migrationBuilder.DropForeignKey(
                name: "FK_Species_Order_OrderId",
                table: "Species");

            migrationBuilder.DropForeignKey(
                name: "FK_Species_Phylum_PhylumId",
                table: "Species");

            migrationBuilder.DropIndex(
                name: "IX_Species_ClassId",
                table: "Species");

            migrationBuilder.DropIndex(
                name: "IX_Species_FamilyId",
                table: "Species");

            migrationBuilder.DropIndex(
                name: "IX_Species_KingdomId",
                table: "Species");

            migrationBuilder.DropIndex(
                name: "IX_Species_OrderId",
                table: "Species");

            migrationBuilder.DropIndex(
                name: "IX_Species_PhylumId",
                table: "Species");

            migrationBuilder.DropIndex(
                name: "IX_Phylum_KingdomId",
                table: "Phylum");

            migrationBuilder.DropIndex(
                name: "IX_Order_ClassId",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_KingdomId",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_PhylumId",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Genus_ClassId",
                table: "Genus");

            migrationBuilder.DropIndex(
                name: "IX_Genus_FamilyId",
                table: "Genus");

            migrationBuilder.DropIndex(
                name: "IX_Genus_KingdomId",
                table: "Genus");

            migrationBuilder.DropIndex(
                name: "IX_Genus_OrderId",
                table: "Genus");

            migrationBuilder.DropIndex(
                name: "IX_Genus_PhylumId",
                table: "Genus");

            migrationBuilder.DropIndex(
                name: "IX_Family_ClassId",
                table: "Family");

            migrationBuilder.DropIndex(
                name: "IX_Family_KingdomId",
                table: "Family");

            migrationBuilder.DropIndex(
                name: "IX_Family_OrderId",
                table: "Family");

            migrationBuilder.DropIndex(
                name: "IX_Family_PhylumId",
                table: "Family");

            migrationBuilder.DropIndex(
                name: "IX_Class_KingdomId",
                table: "Class");

            migrationBuilder.DropIndex(
                name: "IX_Class_PhylumId",
                table: "Class");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "Species");

            migrationBuilder.DropColumn(
                name: "FamilyId",
                table: "Species");

            migrationBuilder.DropColumn(
                name: "KingdomId",
                table: "Species");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Species");

            migrationBuilder.DropColumn(
                name: "PhylumId",
                table: "Species");

            migrationBuilder.DropColumn(
                name: "KingdomId",
                table: "Phylum");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "KingdomId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "PhylumId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "Genus");

            migrationBuilder.DropColumn(
                name: "FamilyId",
                table: "Genus");

            migrationBuilder.DropColumn(
                name: "KingdomId",
                table: "Genus");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Genus");

            migrationBuilder.DropColumn(
                name: "PhylumId",
                table: "Genus");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "Family");

            migrationBuilder.DropColumn(
                name: "KingdomId",
                table: "Family");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Family");

            migrationBuilder.DropColumn(
                name: "PhylumId",
                table: "Family");

            migrationBuilder.DropColumn(
                name: "KingdomId",
                table: "Class");

            migrationBuilder.DropColumn(
                name: "PhylumId",
                table: "Class");

            migrationBuilder.AlterColumn<int>(
                name: "SpeciesId",
                table: "Artifact",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SourceId",
                table: "Artifact",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PhylumId",
                table: "Artifact",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OwnerId",
                table: "Artifact",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "KingdomId",
                table: "Artifact",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FamilyId",
                table: "Artifact",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClassId",
                table: "Artifact",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Artifact_Class_ClassId",
                table: "Artifact",
                column: "ClassId",
                principalTable: "Class",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Artifact_Family_FamilyId",
                table: "Artifact",
                column: "FamilyId",
                principalTable: "Family",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Artifact_Kingdom_KingdomId",
                table: "Artifact",
                column: "KingdomId",
                principalTable: "Kingdom",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Artifact_Owner_OwnerId",
                table: "Artifact",
                column: "OwnerId",
                principalTable: "Owner",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Artifact_Phylum_PhylumId",
                table: "Artifact",
                column: "PhylumId",
                principalTable: "Phylum",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Artifact_Source_SourceId",
                table: "Artifact",
                column: "SourceId",
                principalTable: "Source",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Artifact_Species_SpeciesId",
                table: "Artifact",
                column: "SpeciesId",
                principalTable: "Species",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
