﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobApplicationMvc.Migrations.JobApplicationsData
{
    /// <inheritdoc />
    public partial class DataDepartment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "JobOpenings",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Department",
                table: "JobOpenings");
        }
    }
}
