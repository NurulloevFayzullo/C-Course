﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastruction.Migrations
{
    /// <inheritdoc />
    public partial class addedImageName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Quotes",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Quotes");
        }
    }
}
