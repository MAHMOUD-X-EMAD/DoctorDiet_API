using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sakiny.Data.Migrations
{
    /// <inheritdoc />
    public partial class init_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApartmentImages_apartments_ApartmentId",
                table: "ApartmentImages");

            migrationBuilder.AlterColumn<int>(
                name: "ApartmentId",
                table: "ApartmentImages",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ApartmentImages_apartments_ApartmentId",
                table: "ApartmentImages",
                column: "ApartmentId",
                principalTable: "apartments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApartmentImages_apartments_ApartmentId",
                table: "ApartmentImages");

            migrationBuilder.AlterColumn<int>(
                name: "ApartmentId",
                table: "ApartmentImages",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ApartmentImages_apartments_ApartmentId",
                table: "ApartmentImages",
                column: "ApartmentId",
                principalTable: "apartments",
                principalColumn: "Id");
        }
    }
}
