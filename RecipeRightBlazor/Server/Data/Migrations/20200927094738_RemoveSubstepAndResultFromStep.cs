using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RecipeRightBlazor.Server.Data.Migrations
{
    public partial class RemoveSubstepAndResultFromStep : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Step_Ingredient_ResultId",
                table: "Step");

            migrationBuilder.DropForeignKey(
                name: "FK_Step_Step_SubstepId",
                table: "Step");

            migrationBuilder.DropIndex(
                name: "IX_Step_ResultId",
                table: "Step");

            migrationBuilder.DropIndex(
                name: "IX_Step_SubstepId",
                table: "Step");

            migrationBuilder.DropColumn(
                name: "ResultId",
                table: "Step");

            migrationBuilder.DropColumn(
                name: "SubstepId",
                table: "Step");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ResultId",
                table: "Step",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SubstepId",
                table: "Step",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Step_ResultId",
                table: "Step",
                column: "ResultId");

            migrationBuilder.CreateIndex(
                name: "IX_Step_SubstepId",
                table: "Step",
                column: "SubstepId");

            migrationBuilder.AddForeignKey(
                name: "FK_Step_Ingredient_ResultId",
                table: "Step",
                column: "ResultId",
                principalTable: "Ingredient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Step_Step_SubstepId",
                table: "Step",
                column: "SubstepId",
                principalTable: "Step",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}