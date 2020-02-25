using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UnityProject.Migrations
{
    public partial class InitalCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Campaign",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Overview = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: true),
                    EndDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campaign", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Contributor",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contributor", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SitecoreProductID = table.Column<string>(nullable: true),
                    StudioOnlineProductID = table.Column<string>(nullable: true),
                    StudioEnterpriseProductID = table.Column<string>(nullable: true),
                    CampaignID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Product_Campaign_CampaignID",
                        column: x => x.CampaignID,
                        principalTable: "Campaign",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RelatedLink",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrlString = table.Column<string>(nullable: true),
                    Relation = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CampaignID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelatedLink", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RelatedLink_Campaign_CampaignID",
                        column: x => x.CampaignID,
                        principalTable: "Campaign",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Timeline",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    OutletID = table.Column<int>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: true),
                    EndDate = table.Column<DateTime>(nullable: true),
                    CampaignID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Timeline", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Timeline_Campaign_CampaignID",
                        column: x => x.CampaignID,
                        principalTable: "Campaign",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    RoleFunction = table.Column<string>(nullable: true),
                    CampaignID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Role_Campaign_CampaignID",
                        column: x => x.CampaignID,
                        principalTable: "Campaign",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Role_Contributor_ID",
                        column: x => x.ID,
                        principalTable: "Contributor",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: true),
                    EndDate = table.Column<DateTime>(nullable: true),
                    LastModifiedTime = table.Column<DateTime>(nullable: true),
                    LastModifiedUser = table.Column<string>(nullable: true),
                    TimelineID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Event_Timeline_TimelineID",
                        column: x => x.TimelineID,
                        principalTable: "Timeline",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Url",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrlString = table.Column<string>(nullable: true),
                    ForwardUrl = table.Column<string>(nullable: true),
                    OutletID = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    TimelineID = table.Column<int>(nullable: false),
                    CampaignID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Url", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Url_Campaign_CampaignID",
                        column: x => x.CampaignID,
                        principalTable: "Campaign",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Url_Timeline_TimelineID",
                        column: x => x.TimelineID,
                        principalTable: "Timeline",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Event_TimelineID",
                table: "Event",
                column: "TimelineID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CampaignID",
                table: "Product",
                column: "CampaignID");

            migrationBuilder.CreateIndex(
                name: "IX_RelatedLink_CampaignID",
                table: "RelatedLink",
                column: "CampaignID");

            migrationBuilder.CreateIndex(
                name: "IX_Role_CampaignID",
                table: "Role",
                column: "CampaignID");

            migrationBuilder.CreateIndex(
                name: "IX_Timeline_CampaignID",
                table: "Timeline",
                column: "CampaignID");

            migrationBuilder.CreateIndex(
                name: "IX_Url_CampaignID",
                table: "Url",
                column: "CampaignID");

            migrationBuilder.CreateIndex(
                name: "IX_Url_TimelineID",
                table: "Url",
                column: "TimelineID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "RelatedLink");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Url");

            migrationBuilder.DropTable(
                name: "Contributor");

            migrationBuilder.DropTable(
                name: "Timeline");

            migrationBuilder.DropTable(
                name: "Campaign");
        }
    }
}
