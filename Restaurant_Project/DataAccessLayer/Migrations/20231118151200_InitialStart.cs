using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class InitialStart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    About_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    About_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    About_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    About_Image_Url = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.About_ID);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Booking_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Booking_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Booking_Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Booking_Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Booking_Person_Count = table.Column<int>(type: "int", nullable: false),
                    Booking_Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Booking_ID);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Category_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category_Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Category_ID);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Contact_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Contact_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact_Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact_Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact_Mail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Contact_ID);
                });

            migrationBuilder.CreateTable(
                name: "Discounts",
                columns: table => new
                {
                    Discount_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Discount_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discount_Amount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discount_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discount_Image_Url = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.Discount_ID);
                });

            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    Feature_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Feature_Title_1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Feature_Description_1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Feature_Image_Url_1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Feature_Title_2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Feature_Description_2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Feature_Image_Url_2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Feature_Title_3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Feature_Description_3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Feature_Image_Url_3 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.Feature_ID);
                });

            migrationBuilder.CreateTable(
                name: "SocialMedias",
                columns: table => new
                {
                    Social_Media_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Social_Media_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Social_Media_Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Social_Media_Icon = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedias", x => x.Social_Media_ID);
                });

            migrationBuilder.CreateTable(
                name: "Testimonials",
                columns: table => new
                {
                    Testimonial_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Testimonial_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Testimonial_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Testimonial_Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Testimonial_Image_Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Testimonial_Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testimonials", x => x.Testimonial_ID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Product_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Product_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Product_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Product_Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Product_Image_Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Product_Status = table.Column<bool>(type: "bit", nullable: false),
                    Category_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Product_ID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_Category_ID",
                        column: x => x.Category_ID,
                        principalTable: "Categories",
                        principalColumn: "Category_ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_Category_ID",
                table: "Products",
                column: "Category_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Discounts");

            migrationBuilder.DropTable(
                name: "Features");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "SocialMedias");

            migrationBuilder.DropTable(
                name: "Testimonials");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
