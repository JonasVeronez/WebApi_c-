using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class atualizarDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Data_baseForkLift",
                table: "Data_baseForkLift");

            migrationBuilder.RenameTable(
                name: "Data_baseForkLift",
                newName: "ForkLift");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ForkLift",
                table: "ForkLift",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ForkLift",
                table: "ForkLift");

            migrationBuilder.RenameTable(
                name: "ForkLift",
                newName: "Data_baseForkLift");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Data_baseForkLift",
                table: "Data_baseForkLift",
                column: "Id");
        }
    }
}
