using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BaseCrud.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "Department", "Email", "Mobile", "Name", "Title" },
                values: new object[,]
                {
                    { 1, "產品部", "imall@gmail.com", "0987654321", "imall", "經理" },
                    { 2, "行銷部", "alice@gmail.com", "0987654322", "Alice", "專員" },
                    { 3, "財務部", "bob@gmail.com", "0987654323", "Bob", "經理" },
                    { 4, "人力資源部", "carol@gmail.com", "0987654324", "Carol", "主管" },
                    { 5, "技術部", "david@gmail.com", "0987654325", "David", "工程師" },
                    { 6, "業務部", "eva@gmail.com", "0987654326", "Eva", "業務員" },
                    { 7, "研發部", "frank@gmail.com", "0987654327", "Frank", "研究員" },
                    { 8, "客服部", "grace@gmail.com", "0987654328", "Grace", "客服" },
                    { 9, "採購部", "henry@gmail.com", "0987654329", "Henry", "專員" },
                    { 10, "行政部", "ivy@gmail.com", "0987654330", "Ivy", "行政助理" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
