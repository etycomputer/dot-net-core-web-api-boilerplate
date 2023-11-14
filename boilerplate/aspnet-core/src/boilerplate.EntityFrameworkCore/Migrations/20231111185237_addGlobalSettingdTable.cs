using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace boilerplate.Migrations
{
    /// <inheritdoc />
    public partial class addGlobalSettingdTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "pub");

            migrationBuilder.CreateTable(
                name: "globalSetting",
                schema: "pub",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    groupname = table.Column<string>(name: "group_name", type: "varchar(100)", maxLength: 100, nullable: false),
                    keyname = table.Column<string>(name: "key_name", type: "varchar(100)", maxLength: 100, nullable: false),
                    keyvalue = table.Column<string>(name: "key_value", type: "varchar(100)", maxLength: 100, nullable: false),
                    comments = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    timestamp = table.Column<byte[]>(type: "timestamp", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_globalSetting", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_globalSetting_group_name_key_name_timestamp",
                schema: "pub",
                table: "globalSetting",
                columns: new[] { "group_name", "key_name", "timestamp" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "globalSetting",
                schema: "pub");
        }
    }
}
