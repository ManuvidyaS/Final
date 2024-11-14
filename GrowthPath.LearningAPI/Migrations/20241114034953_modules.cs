﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GrowthPath.LearningAPI.Migrations
{
    /// <inheritdoc />
    public partial class modules : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TotalModules",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalModules",
                table: "Courses");
        }
    }
}