using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class files : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LocalFile_Lessons_LessonId",
                table: "LocalFile");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LocalFile",
                table: "LocalFile");

            migrationBuilder.RenameTable(
                name: "LocalFile",
                newName: "LocalFiles");

            migrationBuilder.RenameIndex(
                name: "IX_LocalFile_LessonId",
                table: "LocalFiles",
                newName: "IX_LocalFiles_LessonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LocalFiles",
                table: "LocalFiles",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LocalFiles_Lessons_LessonId",
                table: "LocalFiles",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LocalFiles_Lessons_LessonId",
                table: "LocalFiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LocalFiles",
                table: "LocalFiles");

            migrationBuilder.RenameTable(
                name: "LocalFiles",
                newName: "LocalFile");

            migrationBuilder.RenameIndex(
                name: "IX_LocalFiles_LessonId",
                table: "LocalFile",
                newName: "IX_LocalFile_LessonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LocalFile",
                table: "LocalFile",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LocalFile_Lessons_LessonId",
                table: "LocalFile",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
