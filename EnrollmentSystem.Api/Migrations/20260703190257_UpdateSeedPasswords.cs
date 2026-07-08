using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnrollmentSystem.Api.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedPasswords : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$16uHNH4dKW/v1z4Wrb/exujzPpsdGNo4g23aud/bC4olXKOTl8veu");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "$2a$11$16uHNH4dKW/v1z4Wrb/exujzPpsdGNo4g23aud/bC4olXKOTl8veu");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$91B1F3vM6u7hT82.YJtJk.R4GfA6V755E8DkR6S0W/3u9B0i2b7gS");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "$2a$11$91B1F3vM6u7hT82.YJtJk.R4GfA6V755E8DkR6S0W/3u9B0i2b7gS");
        }
    }
}
