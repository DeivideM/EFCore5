using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore5.DAL.Migrations
{
    public partial class InitialSetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "LookUps",
                columns: table => new
                {
                    Code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LookUpType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LookUps", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                schema: "dbo",
                columns: table => new
                {
                    Person_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    LastName = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    EmailAddress = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Person_Id);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressLine1 = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    AddressLine2 = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    City = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    State = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    Country = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    ZipCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 6, 5, 4, 42, 27, 143, DateTimeKind.Local).AddTicks(3230))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Persons_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "dbo",
                        principalTable: "Persons",
                        principalColumn: "Person_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "LookUps",
                columns: new[] { "Code", "Description", "LookUpType" },
                values: new object[,]
                {
                    { "AL", "Alabama", 0 },
                    { "NJ", "New Jersey", 0 },
                    { "NM", "New Mexico", 0 },
                    { "NY", "New York", 0 },
                    { "NC", "New Carolina", 0 },
                    { "ND", "North Dakota", 0 },
                    { "OH", "Ohio", 0 },
                    { "OK", "Oklahoma", 0 },
                    { "OR", "Oregon", 0 },
                    { "PA", "Pennsylvania", 0 },
                    { "RI", "Rhode Island", 0 },
                    { "SC", "South Carolina", 0 },
                    { "SD", "South Dakota", 0 },
                    { "TN", "Tennessee", 0 },
                    { "TX", "Texas", 0 },
                    { "UT", "Utah", 0 },
                    { "VT", "Vermont", 0 },
                    { "VA", "Virginia", 0 },
                    { "WA", "Washington", 0 },
                    { "WV", "West Virginia", 0 },
                    { "WI", "Wisconsis", 0 },
                    { "WY", "Wyoming", 0 },
                    { "PR", "Puerto Rico", 0 },
                    { "USA", "United States of America", 1 },
                    { "NH", "New Hampshire", 0 },
                    { "NV", "Nevada", 0 },
                    { "NE", "Montana", 0 },
                    { "MT", "Missouri", 0 },
                    { "AK", "Alaska", 0 },
                    { "AZ", "Arizona", 0 },
                    { "AR", "Arkansas", 0 },
                    { "CA", "California", 0 },
                    { "CO", "Colorado", 0 },
                    { "CT", "Connecticut", 0 },
                    { "DE", "Delaware", 0 },
                    { "DC", "District of Columbia", 0 },
                    { "FL", "Florida", 0 },
                    { "GA", "Georgia", 0 },
                    { "ID", "Hawaii", 0 },
                    { "IL", "Idaho", 0 },
                    { "IA", "Indiana", 0 },
                    { "KS", "Iowa", 0 }
                });

            migrationBuilder.InsertData(
                table: "LookUps",
                columns: new[] { "Code", "Description", "LookUpType" },
                values: new object[,]
                {
                    { "KY", "Kansas", 0 },
                    { "LA", "Kentucky", 0 },
                    { "ME", "Louisiana", 0 },
                    { "MD", "Maine", 0 },
                    { "MA", "Maryland", 0 },
                    { "MI", "Massachusetts", 0 },
                    { "MN", "Michigan", 0 },
                    { "MS", "Minnesota", 0 },
                    { "MO", "Mississippi", 0 },
                    { "IN", "Illinois", 0 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Persons",
                columns: new[] { "Person_Id", "EmailAddress", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "john@smith.com", "John", "Smith" },
                    { 2, "susan@jones.com", "Susan", "Jones" }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "AddressLine1", "AddressLine2", "City", "Country", "PersonId", "State", "ZipCode" },
                values: new object[] { 1, "123 Test St", "", "Beverly Hills", "USA", 1, "CA", "90210" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "AddressLine1", "AddressLine2", "City", "Country", "PersonId", "State", "ZipCode" },
                values: new object[] { 2, "123 Michigan Ave", "", "Chicago", "USA", 2, "IL", "60612" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "AddressLine1", "AddressLine2", "City", "Country", "PersonId", "State", "ZipCode" },
                values: new object[] { 3, "100 1St St", "", "Chicago", "USA", 2, "IL", "60612" });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_PersonId",
                table: "Addresses",
                column: "PersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "LookUps");

            migrationBuilder.DropTable(
                name: "Persons",
                schema: "dbo");
        }
    }
}
