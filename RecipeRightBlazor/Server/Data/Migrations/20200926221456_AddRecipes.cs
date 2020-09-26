using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RecipeRightBlazor.Server.Data.Migrations
{
    public partial class AddRecipes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ingredient",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredient", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Step",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Action = table.Column<string>(nullable: true),
                    SubstepId = table.Column<Guid>(nullable: true),
                    ResultId = table.Column<Guid>(nullable: true),
                    RecipeId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Step", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Step_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Step_Ingredient_ResultId",
                        column: x => x.ResultId,
                        principalTable: "Ingredient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Step_Step_SubstepId",
                        column: x => x.SubstepId,
                        principalTable: "Step",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IngredientWithAmount",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IngredientId = table.Column<Guid>(nullable: true),
                    Quantity = table.Column<float>(nullable: false),
                    Unit = table.Column<string>(nullable: true),
                    StepId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientWithAmount", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IngredientWithAmount_Ingredient_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IngredientWithAmount_Step_StepId",
                        column: x => x.StepId,
                        principalTable: "Step",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IngredientWithAmount_IngredientId",
                table: "IngredientWithAmount",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientWithAmount_StepId",
                table: "IngredientWithAmount",
                column: "StepId");

            migrationBuilder.CreateIndex(
                name: "IX_Step_RecipeId",
                table: "Step",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_Step_ResultId",
                table: "Step",
                column: "ResultId");

            migrationBuilder.CreateIndex(
                name: "IX_Step_SubstepId",
                table: "Step",
                column: "SubstepId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IngredientWithAmount");

            migrationBuilder.DropTable(
                name: "Step");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "Ingredient");
        }
    }
}