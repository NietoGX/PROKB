using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Prokb.Migrations
{
    public partial class CompletaInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Decisiones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Decisiones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Documentos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEmpresa = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Incidencias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(nullable: true),
                    Inactivo = table.Column<bool>(nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    FechaModificacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incidencias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Motivos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motivos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Proveedores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(nullable: true),
                    Interno = table.Column<bool>(nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    FechaModificacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Areas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    EmpresaId = table.Column<string>(nullable: true),
                    EmpresaId1 = table.Column<int>(nullable: true),
                    Responsable1Id = table.Column<string>(nullable: true),
                    Responsable2Id = table.Column<string>(nullable: true),
                    DirectorId = table.Column<string>(nullable: true),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    FechaModificacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Areas_Empresas_EmpresaId1",
                        column: x => x.EmpresaId1,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Secciones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreSeccion = table.Column<string>(nullable: true),
                    AreaId = table.Column<int>(nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    FechaModificacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Secciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Secciones_Areas_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Areas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmpresaAreaSeccionUsuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpresaId = table.Column<string>(nullable: true),
                    EmpresaId1 = table.Column<int>(nullable: true),
                    AreaId = table.Column<int>(nullable: false),
                    SeccionId = table.Column<int>(nullable: false),
                    UsuarioId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpresaAreaSeccionUsuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmpresaAreaSeccionUsuarios_Areas_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Areas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmpresaAreaSeccionUsuarios_Empresas_EmpresaId1",
                        column: x => x.EmpresaId1,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmpresaAreaSeccionUsuarios_Secciones_SeccionId",
                        column: x => x.SeccionId,
                        principalTable: "Secciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmpresaAreaSeccionUsuarios_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Email",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TiposDecisionSeccion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DecisionId = table.Column<int>(nullable: true),
                    SeccionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposDecisionSeccion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TiposDecisionSeccion_Decisiones_DecisionId",
                        column: x => x.DecisionId,
                        principalTable: "Decisiones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TiposDecisionSeccion_Secciones_SeccionId",
                        column: x => x.SeccionId,
                        principalTable: "Secciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TiposIncidenciaSeccion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeccionId = table.Column<int>(nullable: true),
                    IncidenciaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposIncidenciaSeccion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TiposIncidenciaSeccion_Incidencias_IncidenciaId",
                        column: x => x.IncidenciaId,
                        principalTable: "Incidencias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TiposIncidenciaSeccion_Secciones_SeccionId",
                        column: x => x.SeccionId,
                        principalTable: "Secciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Areas_EmpresaId1",
                table: "Areas",
                column: "EmpresaId1");

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaAreaSeccionUsuarios_AreaId",
                table: "EmpresaAreaSeccionUsuarios",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaAreaSeccionUsuarios_EmpresaId1",
                table: "EmpresaAreaSeccionUsuarios",
                column: "EmpresaId1");

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaAreaSeccionUsuarios_SeccionId",
                table: "EmpresaAreaSeccionUsuarios",
                column: "SeccionId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaAreaSeccionUsuarios_UsuarioId",
                table: "EmpresaAreaSeccionUsuarios",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Secciones_AreaId",
                table: "Secciones",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_TiposDecisionSeccion_DecisionId",
                table: "TiposDecisionSeccion",
                column: "DecisionId");

            migrationBuilder.CreateIndex(
                name: "IX_TiposDecisionSeccion_SeccionId",
                table: "TiposDecisionSeccion",
                column: "SeccionId");

            migrationBuilder.CreateIndex(
                name: "IX_TiposIncidenciaSeccion_IncidenciaId",
                table: "TiposIncidenciaSeccion",
                column: "IncidenciaId");

            migrationBuilder.CreateIndex(
                name: "IX_TiposIncidenciaSeccion_SeccionId",
                table: "TiposIncidenciaSeccion",
                column: "SeccionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Documentos");

            migrationBuilder.DropTable(
                name: "EmpresaAreaSeccionUsuarios");

            migrationBuilder.DropTable(
                name: "Motivos");

            migrationBuilder.DropTable(
                name: "Proveedores");

            migrationBuilder.DropTable(
                name: "TiposDecisionSeccion");

            migrationBuilder.DropTable(
                name: "TiposIncidenciaSeccion");

            migrationBuilder.DropTable(
                name: "Decisiones");

            migrationBuilder.DropTable(
                name: "Incidencias");

            migrationBuilder.DropTable(
                name: "Secciones");

            migrationBuilder.DropTable(
                name: "Areas");

            migrationBuilder.DropTable(
                name: "Empresas");
        }
    }
}
