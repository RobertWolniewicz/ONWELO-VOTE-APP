using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ONWELOVOTEAPP.Migrations
{
    /// <inheritdoc />
    public partial class AddAmountOfCandidatsAndDefaulValues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "HasVoted",
                table: "Voters",
                type: "INTEGER",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<int>(
                name: "AmountOfCandidats",
                table: "Voters",
                type: "INTEGER",
                nullable: false,
                defaultValue: 3);

            migrationBuilder.AlterColumn<int>(
                name: "Votes",
                table: "Candidates",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AmountOfCandidats",
                table: "Voters");

            migrationBuilder.AlterColumn<bool>(
                name: "HasVoted",
                table: "Voters",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "INTEGER",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "Votes",
                table: "Candidates",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldDefaultValue: 0);
        }
    }
}
