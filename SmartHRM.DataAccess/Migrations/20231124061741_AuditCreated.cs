﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHRM.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AuditCreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Currencies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Currencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Currencies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Currencies",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Currencies");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Currencies");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Currencies");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Currencies");
        }
    }
}