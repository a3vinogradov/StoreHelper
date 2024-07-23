using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace StoreHelherAttempt2.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ParentIdId = table.Column<int>(type: "integer", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stores_Stores_ParentIdId",
                        column: x => x.ParentIdId,
                        principalTable: "Stores",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stores_Name",
                table: "Stores",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Stores_ParentIdId",
                table: "Stores",
                column: "ParentIdId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stores");
        }
    }
}
