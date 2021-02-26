using Microsoft.EntityFrameworkCore.Migrations;

namespace ResponseLinkAlertOneAssessment.Migrations
{
    public partial class fixItemQuantity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_shippingOptions_ChosenShippingId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_shippingOptions",
                table: "shippingOptions");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Items");

            migrationBuilder.RenameTable(
                name: "shippingOptions",
                newName: "ShippingOptions");

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShippingOptions",
                table: "ShippingOptions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_ShippingOptions_ChosenShippingId",
                table: "Orders",
                column: "ChosenShippingId",
                principalTable: "ShippingOptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_ShippingOptions_ChosenShippingId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShippingOptions",
                table: "ShippingOptions");

            migrationBuilder.RenameTable(
                name: "ShippingOptions",
                newName: "shippingOptions");

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "Items",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Items",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_shippingOptions",
                table: "shippingOptions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_shippingOptions_ChosenShippingId",
                table: "Orders",
                column: "ChosenShippingId",
                principalTable: "shippingOptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
