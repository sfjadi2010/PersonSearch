using Microsoft.EntityFrameworkCore.Migrations;

namespace PersonSearch.Migrations
{
    public partial class AddedAttributesForRequiredFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "People",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "People",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "People",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Interests",
                table: "People",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Street",
                table: "Addresses",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Addresses",
                maxLength: 120,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Postal",
                table: "Addresses",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Addresses",
                maxLength: 120,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Addresses",
                maxLength: 120,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Interests",
                table: "People");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "People",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 64);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "People",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 64);

            migrationBuilder.AlterColumn<string>(
                name: "Street",
                table: "Addresses",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Addresses",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 120,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Postal",
                table: "Addresses",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 5);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Addresses",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 120,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Addresses",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 120,
                oldNullable: true);
        }
    }
}
