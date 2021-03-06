﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MemigrationProBonoTracker.Migrations
{
    public partial class assperson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssociatedPerson_People_PersonId",
                table: "AssociatedPerson");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "AssociatedPerson",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AssociatedPerson_People_PersonId",
                table: "AssociatedPerson",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssociatedPerson_People_PersonId",
                table: "AssociatedPerson");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "AssociatedPerson",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_AssociatedPerson_People_PersonId",
                table: "AssociatedPerson",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
