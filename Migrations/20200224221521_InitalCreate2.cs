using Microsoft.EntityFrameworkCore.Migrations;

namespace UnityProject.Migrations
{
    public partial class InitalCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Role_Contributor_ID",
                table: "Role");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contributor",
                table: "Contributor");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "Role",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "Contributor",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "RoleID",
                table: "Contributor",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contributor",
                table: "Contributor",
                column: "RoleID");

            migrationBuilder.AddForeignKey(
                name: "FK_Contributor_Role_RoleID",
                table: "Contributor",
                column: "RoleID",
                principalTable: "Role",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contributor_Role_RoleID",
                table: "Contributor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contributor",
                table: "Contributor");

            migrationBuilder.DropColumn(
                name: "RoleID",
                table: "Contributor");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "Role",
                type: "int",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "Contributor",
                type: "int",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contributor",
                table: "Contributor",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Role_Contributor_ID",
                table: "Role",
                column: "ID",
                principalTable: "Contributor",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
