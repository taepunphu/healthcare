using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthCare.Documents.Api.Migrations
{
    /// <inheritdoc />
    public partial class ReviseColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Documents",
                table: "Documents");

            migrationBuilder.RenameTable(
                name: "Documents",
                newName: "documents");

            migrationBuilder.RenameColumn(
                name: "Path",
                table: "documents",
                newName: "path");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "documents",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "documents",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "PatientId",
                table: "documents",
                newName: "patient_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_documents",
                table: "documents",
                column: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_documents",
                table: "documents");

            migrationBuilder.RenameTable(
                name: "documents",
                newName: "Documents");

            migrationBuilder.RenameColumn(
                name: "path",
                table: "Documents",
                newName: "Path");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Documents",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Documents",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "patient_id",
                table: "Documents",
                newName: "PatientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Documents",
                table: "Documents",
                column: "Id");
        }
    }
}
