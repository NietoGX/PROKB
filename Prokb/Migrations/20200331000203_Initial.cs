using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Prokb.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articulo",
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
                    table.PrimaryKey("PK_Articulo", x => x.Id);
                });

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
                name: "Usuarios",
                columns: table => new
                {
                    Email = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    FechaModificacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Email);
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
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FichasArticulo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FichaReferencia = table.Column<string>(nullable: true),
                    EmpresaId = table.Column<int>(nullable: false),
                    EmisorId = table.Column<string>(nullable: true),
                    EmisorId1 = table.Column<int>(nullable: true),
                    AreaId = table.Column<int>(nullable: false),
                    SeccionId = table.Column<int>(nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    FechaModificacion = table.Column<DateTime>(nullable: false),
                    NumAlbaran = table.Column<int>(nullable: false),
                    FechaAlbaran = table.Column<DateTime>(nullable: false),
                    NumPedido = table.Column<int>(nullable: false),
                    FechaPedido = table.Column<DateTime>(nullable: false),
                    CantidadTotal = table.Column<string>(maxLength: 50, nullable: true),
                    CantidadAfectada = table.Column<string>(maxLength: 50, nullable: true),
                    ProveedorId = table.Column<int>(nullable: false),
                    ArticuloId = table.Column<int>(nullable: false),
                    Ubicacion = table.Column<string>(maxLength: 50, nullable: true),
                    Notas = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FichasArticulo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FichasArticulo_Areas_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Areas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasArticulo_Articulo_ArticuloId",
                        column: x => x.ArticuloId,
                        principalTable: "Articulo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasArticulo_EmpresaAreaSeccionUsuarios_EmisorId1",
                        column: x => x.EmisorId1,
                        principalTable: "EmpresaAreaSeccionUsuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasArticulo_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasArticulo_Proveedores_ProveedorId",
                        column: x => x.ProveedorId,
                        principalTable: "Proveedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasArticulo_Secciones_SeccionId",
                        column: x => x.SeccionId,
                        principalTable: "Secciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FichasArticuloEFIMED",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FichaReferencia = table.Column<string>(nullable: true),
                    EmpresaId = table.Column<int>(nullable: false),
                    EmisorId = table.Column<string>(nullable: true),
                    EmisorId1 = table.Column<int>(nullable: true),
                    AreaId = table.Column<int>(nullable: false),
                    SeccionId = table.Column<int>(nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    FechaModificacion = table.Column<DateTime>(nullable: false),
                    ProveedorId = table.Column<int>(nullable: false),
                    ArticuloId = table.Column<int>(nullable: false),
                    Ubicacion = table.Column<string>(nullable: true),
                    Notas = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FichasArticuloEFIMED", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FichasArticuloEFIMED_Areas_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Areas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasArticuloEFIMED_Articulo_ArticuloId",
                        column: x => x.ArticuloId,
                        principalTable: "Articulo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasArticuloEFIMED_EmpresaAreaSeccionUsuarios_EmisorId1",
                        column: x => x.EmisorId1,
                        principalTable: "EmpresaAreaSeccionUsuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasArticuloEFIMED_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasArticuloEFIMED_Proveedores_ProveedorId",
                        column: x => x.ProveedorId,
                        principalTable: "Proveedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasArticuloEFIMED_Secciones_SeccionId",
                        column: x => x.SeccionId,
                        principalTable: "Secciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FichasAnalisis",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FichaReferencia = table.Column<string>(nullable: true),
                    EmpresaId = table.Column<int>(nullable: false),
                    EmisorId = table.Column<string>(nullable: true),
                    EmisorId1 = table.Column<int>(nullable: true),
                    AreaId = table.Column<int>(nullable: false),
                    SeccionId = table.Column<int>(nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    FechaModificacion = table.Column<DateTime>(nullable: false),
                    FechaAnalisis = table.Column<DateTime>(nullable: false),
                    ResponsableAnalisisId = table.Column<int>(nullable: false),
                    EsDecision = table.Column<bool>(nullable: false),
                    PropuestaId = table.Column<int>(nullable: false),
                    DecisionId = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FichasAnalisis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FichasAnalisis_Areas_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Areas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasAnalisis_TiposDecisionSeccion_DecisionId",
                        column: x => x.DecisionId,
                        principalTable: "TiposDecisionSeccion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasAnalisis_EmpresaAreaSeccionUsuarios_EmisorId1",
                        column: x => x.EmisorId1,
                        principalTable: "EmpresaAreaSeccionUsuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasAnalisis_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasAnalisis_TiposDecisionSeccion_PropuestaId",
                        column: x => x.PropuestaId,
                        principalTable: "TiposDecisionSeccion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasAnalisis_EmpresaAreaSeccionUsuarios_ResponsableAnalisisId",
                        column: x => x.ResponsableAnalisisId,
                        principalTable: "EmpresaAreaSeccionUsuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasAnalisis_Secciones_SeccionId",
                        column: x => x.SeccionId,
                        principalTable: "Secciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FichasCalidad",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FichaReferencia = table.Column<string>(nullable: true),
                    EmpresaId = table.Column<int>(nullable: false),
                    EmisorId = table.Column<string>(nullable: true),
                    EmisorId1 = table.Column<int>(nullable: true),
                    AreaId = table.Column<int>(nullable: false),
                    SeccionId = table.Column<int>(nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    FechaModificacion = table.Column<DateTime>(nullable: false),
                    FechaCalidad = table.Column<DateTime>(nullable: false),
                    ResponsableCalidadId = table.Column<int>(nullable: false),
                    MotivoId = table.Column<int>(nullable: false),
                    DecisionCalidadId = table.Column<int>(nullable: false),
                    DescripcionProblema = table.Column<string>(nullable: true),
                    DescripcionSolucion = table.Column<string>(nullable: true),
                    Finalizada = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FichasCalidad", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FichasCalidad_Areas_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Areas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasCalidad_TiposDecisionSeccion_DecisionCalidadId",
                        column: x => x.DecisionCalidadId,
                        principalTable: "TiposDecisionSeccion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasCalidad_EmpresaAreaSeccionUsuarios_EmisorId1",
                        column: x => x.EmisorId1,
                        principalTable: "EmpresaAreaSeccionUsuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasCalidad_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasCalidad_Motivos_MotivoId",
                        column: x => x.MotivoId,
                        principalTable: "Motivos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasCalidad_EmpresaAreaSeccionUsuarios_ResponsableCalidadId",
                        column: x => x.ResponsableCalidadId,
                        principalTable: "EmpresaAreaSeccionUsuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasCalidad_Secciones_SeccionId",
                        column: x => x.SeccionId,
                        principalTable: "Secciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FichasCompras",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FichaReferencia = table.Column<string>(nullable: true),
                    EmpresaId = table.Column<int>(nullable: false),
                    EmisorId = table.Column<string>(nullable: true),
                    EmisorId1 = table.Column<int>(nullable: true),
                    AreaId = table.Column<int>(nullable: false),
                    SeccionId = table.Column<int>(nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    FechaModificacion = table.Column<DateTime>(nullable: false),
                    FechaCompras = table.Column<DateTime>(nullable: false),
                    ResponsableComprasId = table.Column<int>(nullable: false),
                    PropuestaId = table.Column<int>(nullable: false),
                    PropuestaComprasId = table.Column<int>(nullable: true),
                    DecisionComprasId = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    Finalizada = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FichasCompras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FichasCompras_Areas_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Areas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasCompras_TiposDecisionSeccion_DecisionComprasId",
                        column: x => x.DecisionComprasId,
                        principalTable: "TiposDecisionSeccion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasCompras_EmpresaAreaSeccionUsuarios_EmisorId1",
                        column: x => x.EmisorId1,
                        principalTable: "EmpresaAreaSeccionUsuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasCompras_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasCompras_TiposDecisionSeccion_PropuestaComprasId",
                        column: x => x.PropuestaComprasId,
                        principalTable: "TiposDecisionSeccion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasCompras_EmpresaAreaSeccionUsuarios_ResponsableComprasId",
                        column: x => x.ResponsableComprasId,
                        principalTable: "EmpresaAreaSeccionUsuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasCompras_Secciones_SeccionId",
                        column: x => x.SeccionId,
                        principalTable: "Secciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FichasEjecucion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FichaReferencia = table.Column<string>(nullable: true),
                    EmpresaId = table.Column<int>(nullable: false),
                    EmisorId = table.Column<string>(nullable: true),
                    EmisorId1 = table.Column<int>(nullable: true),
                    AreaId = table.Column<int>(nullable: false),
                    SeccionId = table.Column<int>(nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    FechaModificacion = table.Column<DateTime>(nullable: false),
                    FechaEjecucion = table.Column<DateTime>(nullable: false),
                    ResponsableEjecucionId = table.Column<int>(nullable: false),
                    EsDecision = table.Column<bool>(nullable: false),
                    PropuestaEjecucionId = table.Column<int>(nullable: false),
                    DecisionEjecucionId = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    Finalizada = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FichasEjecucion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FichasEjecucion_Areas_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Areas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasEjecucion_TiposDecisionSeccion_DecisionEjecucionId",
                        column: x => x.DecisionEjecucionId,
                        principalTable: "TiposDecisionSeccion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasEjecucion_EmpresaAreaSeccionUsuarios_EmisorId1",
                        column: x => x.EmisorId1,
                        principalTable: "EmpresaAreaSeccionUsuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasEjecucion_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasEjecucion_TiposDecisionSeccion_PropuestaEjecucionId",
                        column: x => x.PropuestaEjecucionId,
                        principalTable: "TiposDecisionSeccion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasEjecucion_EmpresaAreaSeccionUsuarios_ResponsableEjecucionId",
                        column: x => x.ResponsableEjecucionId,
                        principalTable: "EmpresaAreaSeccionUsuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasEjecucion_Secciones_SeccionId",
                        column: x => x.SeccionId,
                        principalTable: "Secciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FichasIncidencia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FichaReferencia = table.Column<string>(nullable: true),
                    EmpresaId = table.Column<int>(nullable: false),
                    EmisorId = table.Column<string>(nullable: true),
                    EmisorId1 = table.Column<int>(nullable: true),
                    AreaId = table.Column<int>(nullable: false),
                    SeccionId = table.Column<int>(nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    FechaModificacion = table.Column<DateTime>(nullable: false),
                    EsGrave = table.Column<bool>(nullable: false),
                    DescripcionIncidencia = table.Column<string>(nullable: true),
                    AfectaProduccion = table.Column<bool>(nullable: false),
                    EsPropuesta = table.Column<bool>(nullable: false),
                    DecisionIncidenciaId = table.Column<int>(nullable: false),
                    PropuestaIncidenciaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FichasIncidencia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FichasIncidencia_Areas_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Areas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasIncidencia_TiposDecisionSeccion_DecisionIncidenciaId",
                        column: x => x.DecisionIncidenciaId,
                        principalTable: "TiposDecisionSeccion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasIncidencia_EmpresaAreaSeccionUsuarios_EmisorId1",
                        column: x => x.EmisorId1,
                        principalTable: "EmpresaAreaSeccionUsuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasIncidencia_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasIncidencia_TiposDecisionSeccion_PropuestaIncidenciaId",
                        column: x => x.PropuestaIncidenciaId,
                        principalTable: "TiposDecisionSeccion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasIncidencia_Secciones_SeccionId",
                        column: x => x.SeccionId,
                        principalTable: "Secciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FichasLogistica",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FichaReferencia = table.Column<string>(nullable: true),
                    EmpresaId = table.Column<int>(nullable: false),
                    EmisorId = table.Column<string>(nullable: true),
                    EmisorId1 = table.Column<int>(nullable: true),
                    AreaId = table.Column<int>(nullable: false),
                    SeccionId = table.Column<int>(nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    FechaModificacion = table.Column<DateTime>(nullable: false),
                    FechaLogistica = table.Column<DateTime>(nullable: false),
                    ResponsableLogisticaId = table.Column<int>(nullable: false),
                    DecisionLogisticaId = table.Column<int>(nullable: false),
                    DescripcionLogistica = table.Column<string>(nullable: true),
                    Finalizada = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FichasLogistica", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FichasLogistica_Areas_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Areas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasLogistica_TiposDecisionSeccion_DecisionLogisticaId",
                        column: x => x.DecisionLogisticaId,
                        principalTable: "TiposDecisionSeccion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasLogistica_EmpresaAreaSeccionUsuarios_EmisorId1",
                        column: x => x.EmisorId1,
                        principalTable: "EmpresaAreaSeccionUsuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasLogistica_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasLogistica_EmpresaAreaSeccionUsuarios_ResponsableLogisticaId",
                        column: x => x.ResponsableLogisticaId,
                        principalTable: "EmpresaAreaSeccionUsuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasLogistica_Secciones_SeccionId",
                        column: x => x.SeccionId,
                        principalTable: "Secciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FichasPlanificacion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FichaReferencia = table.Column<string>(nullable: true),
                    EmpresaId = table.Column<int>(nullable: false),
                    EmisorId = table.Column<string>(nullable: true),
                    EmisorId1 = table.Column<int>(nullable: true),
                    AreaId = table.Column<int>(nullable: false),
                    SeccionId = table.Column<int>(nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    FechaModificacion = table.Column<DateTime>(nullable: false),
                    FechaPlanificacion = table.Column<DateTime>(nullable: false),
                    ResponsablePlanificacionId = table.Column<int>(nullable: false),
                    DecisionPlanificacionId = table.Column<int>(nullable: false),
                    CantidadDevuelta = table.Column<int>(nullable: false),
                    CantidadConforme = table.Column<int>(nullable: false),
                    GastosACargoDe = table.Column<string>(nullable: true),
                    ComentarioProveedor = table.Column<string>(nullable: true),
                    DescripcionDecision = table.Column<string>(nullable: true),
                    Finalizada = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FichasPlanificacion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FichasPlanificacion_Areas_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Areas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasPlanificacion_TiposDecisionSeccion_DecisionPlanificacionId",
                        column: x => x.DecisionPlanificacionId,
                        principalTable: "TiposDecisionSeccion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasPlanificacion_EmpresaAreaSeccionUsuarios_EmisorId1",
                        column: x => x.EmisorId1,
                        principalTable: "EmpresaAreaSeccionUsuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasPlanificacion_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasPlanificacion_EmpresaAreaSeccionUsuarios_ResponsablePlanificacionId",
                        column: x => x.ResponsablePlanificacionId,
                        principalTable: "EmpresaAreaSeccionUsuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasPlanificacion_Secciones_SeccionId",
                        column: x => x.SeccionId,
                        principalTable: "Secciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FichasNoConformidad",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FichaReferencia = table.Column<string>(nullable: true),
                    EmpresaId = table.Column<int>(nullable: false),
                    EmisorId = table.Column<string>(nullable: true),
                    EmisorId1 = table.Column<int>(nullable: true),
                    AreaId = table.Column<int>(nullable: false),
                    SeccionId = table.Column<int>(nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    FechaModificacion = table.Column<DateTime>(nullable: false),
                    Estado = table.Column<int>(nullable: false),
                    FichaNoConformidadId = table.Column<string>(nullable: true),
                    FichaAnalisisId1 = table.Column<int>(nullable: true),
                    FichaAnalisisId = table.Column<string>(nullable: true),
                    FichaEjecucionId1 = table.Column<int>(nullable: true),
                    FichaEjecucionId = table.Column<string>(nullable: true),
                    FichaArticuloEFIMEDId1 = table.Column<int>(nullable: true),
                    FichaArticuloEFIMEDId = table.Column<string>(nullable: true),
                    FichaIncidenciaId1 = table.Column<int>(nullable: true),
                    FichaIncidenciaId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FichasNoConformidad", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FichasNoConformidad_Areas_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Areas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasNoConformidad_EmpresaAreaSeccionUsuarios_EmisorId1",
                        column: x => x.EmisorId1,
                        principalTable: "EmpresaAreaSeccionUsuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasNoConformidad_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasNoConformidad_FichasAnalisis_FichaAnalisisId1",
                        column: x => x.FichaAnalisisId1,
                        principalTable: "FichasAnalisis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasNoConformidad_FichasArticuloEFIMED_FichaArticuloEFIMEDId1",
                        column: x => x.FichaArticuloEFIMEDId1,
                        principalTable: "FichasArticuloEFIMED",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasNoConformidad_FichasEjecucion_FichaEjecucionId1",
                        column: x => x.FichaEjecucionId1,
                        principalTable: "FichasEjecucion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasNoConformidad_FichasIncidencia_FichaIncidenciaId1",
                        column: x => x.FichaIncidenciaId1,
                        principalTable: "FichasIncidencia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasNoConformidad_Secciones_SeccionId",
                        column: x => x.SeccionId,
                        principalTable: "Secciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FichasNoConformidadMedioAmbiente",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FichaReferencia = table.Column<string>(nullable: true),
                    EmpresaId = table.Column<int>(nullable: false),
                    EmisorId = table.Column<string>(nullable: true),
                    EmisorId1 = table.Column<int>(nullable: true),
                    AreaId = table.Column<int>(nullable: false),
                    SeccionId = table.Column<int>(nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    FechaModificacion = table.Column<DateTime>(nullable: false),
                    Estado = table.Column<int>(nullable: false),
                    FichaAnalisisId = table.Column<string>(nullable: true),
                    FichaAnalisisId1 = table.Column<int>(nullable: true),
                    FichaEjecucionId = table.Column<string>(nullable: true),
                    FichaEjecucionId1 = table.Column<int>(nullable: true),
                    FichaArticuloEFIMEDId = table.Column<string>(nullable: true),
                    FichaArticuloEFIMEDId1 = table.Column<int>(nullable: true),
                    FichaIncidenciaId1 = table.Column<int>(nullable: true),
                    FichaIncidenciaId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FichasNoConformidadMedioAmbiente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FichasNoConformidadMedioAmbiente_Areas_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Areas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasNoConformidadMedioAmbiente_EmpresaAreaSeccionUsuarios_EmisorId1",
                        column: x => x.EmisorId1,
                        principalTable: "EmpresaAreaSeccionUsuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasNoConformidadMedioAmbiente_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasNoConformidadMedioAmbiente_FichasAnalisis_FichaAnalisisId1",
                        column: x => x.FichaAnalisisId1,
                        principalTable: "FichasAnalisis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasNoConformidadMedioAmbiente_FichasArticuloEFIMED_FichaArticuloEFIMEDId1",
                        column: x => x.FichaArticuloEFIMEDId1,
                        principalTable: "FichasArticuloEFIMED",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasNoConformidadMedioAmbiente_FichasEjecucion_FichaEjecucionId1",
                        column: x => x.FichaEjecucionId1,
                        principalTable: "FichasEjecucion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasNoConformidadMedioAmbiente_FichasIncidencia_FichaIncidenciaId1",
                        column: x => x.FichaIncidenciaId1,
                        principalTable: "FichasIncidencia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasNoConformidadMedioAmbiente_Secciones_SeccionId",
                        column: x => x.SeccionId,
                        principalTable: "Secciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FichasNoConformidadServicio",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FichaReferencia = table.Column<string>(nullable: true),
                    EmpresaId = table.Column<int>(nullable: false),
                    EmisorId = table.Column<string>(nullable: true),
                    EmisorId1 = table.Column<int>(nullable: true),
                    AreaId = table.Column<int>(nullable: false),
                    SeccionId = table.Column<int>(nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    FechaModificacion = table.Column<DateTime>(nullable: false),
                    Estado = table.Column<int>(nullable: false),
                    FichaAnalisisId = table.Column<string>(nullable: true),
                    FichaAnalisisId1 = table.Column<int>(nullable: true),
                    FichaComprasId = table.Column<string>(nullable: true),
                    FichaComprasId1 = table.Column<int>(nullable: true),
                    FichaEjecucionId = table.Column<string>(nullable: true),
                    FichaEjecucionId1 = table.Column<int>(nullable: true),
                    FichaArticuloEFIMEDId = table.Column<string>(nullable: true),
                    FichaArticuloEFIMEDId1 = table.Column<int>(nullable: true),
                    FichaIncidenciaId = table.Column<string>(nullable: true),
                    FichaIncidenciaId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FichasNoConformidadServicio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FichasNoConformidadServicio_Areas_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Areas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasNoConformidadServicio_EmpresaAreaSeccionUsuarios_EmisorId1",
                        column: x => x.EmisorId1,
                        principalTable: "EmpresaAreaSeccionUsuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasNoConformidadServicio_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasNoConformidadServicio_FichasAnalisis_FichaAnalisisId1",
                        column: x => x.FichaAnalisisId1,
                        principalTable: "FichasAnalisis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasNoConformidadServicio_FichasArticuloEFIMED_FichaArticuloEFIMEDId1",
                        column: x => x.FichaArticuloEFIMEDId1,
                        principalTable: "FichasArticuloEFIMED",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasNoConformidadServicio_FichasCompras_FichaComprasId1",
                        column: x => x.FichaComprasId1,
                        principalTable: "FichasCompras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasNoConformidadServicio_FichasEjecucion_FichaEjecucionId1",
                        column: x => x.FichaEjecucionId1,
                        principalTable: "FichasEjecucion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasNoConformidadServicio_FichasIncidencia_FichaIncidenciaId1",
                        column: x => x.FichaIncidenciaId1,
                        principalTable: "FichasIncidencia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasNoConformidadServicio_Secciones_SeccionId",
                        column: x => x.SeccionId,
                        principalTable: "Secciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TiposIncidenciaSeccion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeccionId = table.Column<int>(nullable: true),
                    IncidenciaId = table.Column<int>(nullable: false),
                    FichaIncidenciaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposIncidenciaSeccion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TiposIncidenciaSeccion_FichasIncidencia_FichaIncidenciaId",
                        column: x => x.FichaIncidenciaId,
                        principalTable: "FichasIncidencia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TiposIncidenciaSeccion_Incidencias_IncidenciaId",
                        column: x => x.IncidenciaId,
                        principalTable: "Incidencias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TiposIncidenciaSeccion_Secciones_SeccionId",
                        column: x => x.SeccionId,
                        principalTable: "Secciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FichasNoConformidadProductoAcabado",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FichaReferencia = table.Column<string>(nullable: true),
                    EmpresaId = table.Column<int>(nullable: false),
                    EmisorId = table.Column<string>(nullable: true),
                    EmisorId1 = table.Column<int>(nullable: true),
                    AreaId = table.Column<int>(nullable: false),
                    SeccionId = table.Column<int>(nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    FechaModificacion = table.Column<DateTime>(nullable: false),
                    Estado = table.Column<int>(nullable: false),
                    FichaCalidadId = table.Column<string>(nullable: true),
                    FichaCalidadId1 = table.Column<int>(nullable: true),
                    FichaPlanificacionId = table.Column<string>(nullable: true),
                    FichaPlanificacionId1 = table.Column<int>(nullable: true),
                    FichaLogisticaId = table.Column<string>(nullable: true),
                    FichaLogisticaId1 = table.Column<int>(nullable: true),
                    FichaArticuloId = table.Column<string>(nullable: true),
                    FichaArticuloId1 = table.Column<int>(nullable: true),
                    FichaIncidenciaId = table.Column<string>(nullable: true),
                    FichaIncidenciaId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FichasNoConformidadProductoAcabado", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FichasNoConformidadProductoAcabado_Areas_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Areas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasNoConformidadProductoAcabado_EmpresaAreaSeccionUsuarios_EmisorId1",
                        column: x => x.EmisorId1,
                        principalTable: "EmpresaAreaSeccionUsuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasNoConformidadProductoAcabado_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasNoConformidadProductoAcabado_FichasArticulo_FichaArticuloId1",
                        column: x => x.FichaArticuloId1,
                        principalTable: "FichasArticulo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasNoConformidadProductoAcabado_FichasCalidad_FichaCalidadId1",
                        column: x => x.FichaCalidadId1,
                        principalTable: "FichasCalidad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasNoConformidadProductoAcabado_FichasIncidencia_FichaIncidenciaId1",
                        column: x => x.FichaIncidenciaId1,
                        principalTable: "FichasIncidencia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasNoConformidadProductoAcabado_FichasLogistica_FichaLogisticaId1",
                        column: x => x.FichaLogisticaId1,
                        principalTable: "FichasLogistica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasNoConformidadProductoAcabado_FichasPlanificacion_FichaPlanificacionId1",
                        column: x => x.FichaPlanificacionId1,
                        principalTable: "FichasPlanificacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichasNoConformidadProductoAcabado_Secciones_SeccionId",
                        column: x => x.SeccionId,
                        principalTable: "Secciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Documentos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(nullable: true),
                    FichaAnalisisId = table.Column<int>(nullable: true),
                    FichaArticuloEFIMEDId = table.Column<int>(nullable: true),
                    FichaArticuloId = table.Column<int>(nullable: true),
                    FichaCalidadId = table.Column<int>(nullable: true),
                    FichaComprasId = table.Column<int>(nullable: true),
                    FichaEjecucionId = table.Column<int>(nullable: true),
                    FichaIncidenciaId = table.Column<int>(nullable: true),
                    FichaLogisticaId = table.Column<int>(nullable: true),
                    FichaNoConformidadEficienciaEnergeticaId = table.Column<int>(nullable: true),
                    FichaNoConformidadMedioAmbienteId = table.Column<int>(nullable: true),
                    FichaNoConformidadProductoAcabadoId = table.Column<int>(nullable: true),
                    FichaNoConformidadServicioId = table.Column<int>(nullable: true),
                    FichaPlanificacionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Documentos_FichasAnalisis_FichaAnalisisId",
                        column: x => x.FichaAnalisisId,
                        principalTable: "FichasAnalisis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Documentos_FichasArticuloEFIMED_FichaArticuloEFIMEDId",
                        column: x => x.FichaArticuloEFIMEDId,
                        principalTable: "FichasArticuloEFIMED",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Documentos_FichasArticulo_FichaArticuloId",
                        column: x => x.FichaArticuloId,
                        principalTable: "FichasArticulo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Documentos_FichasCalidad_FichaCalidadId",
                        column: x => x.FichaCalidadId,
                        principalTable: "FichasCalidad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Documentos_FichasCompras_FichaComprasId",
                        column: x => x.FichaComprasId,
                        principalTable: "FichasCompras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Documentos_FichasEjecucion_FichaEjecucionId",
                        column: x => x.FichaEjecucionId,
                        principalTable: "FichasEjecucion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Documentos_FichasIncidencia_FichaIncidenciaId",
                        column: x => x.FichaIncidenciaId,
                        principalTable: "FichasIncidencia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Documentos_FichasLogistica_FichaLogisticaId",
                        column: x => x.FichaLogisticaId,
                        principalTable: "FichasLogistica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Documentos_FichasNoConformidad_FichaNoConformidadEficienciaEnergeticaId",
                        column: x => x.FichaNoConformidadEficienciaEnergeticaId,
                        principalTable: "FichasNoConformidad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Documentos_FichasNoConformidadMedioAmbiente_FichaNoConformidadMedioAmbienteId",
                        column: x => x.FichaNoConformidadMedioAmbienteId,
                        principalTable: "FichasNoConformidadMedioAmbiente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Documentos_FichasNoConformidadProductoAcabado_FichaNoConformidadProductoAcabadoId",
                        column: x => x.FichaNoConformidadProductoAcabadoId,
                        principalTable: "FichasNoConformidadProductoAcabado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Documentos_FichasNoConformidadServicio_FichaNoConformidadServicioId",
                        column: x => x.FichaNoConformidadServicioId,
                        principalTable: "FichasNoConformidadServicio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Documentos_FichasPlanificacion_FichaPlanificacionId",
                        column: x => x.FichaPlanificacionId,
                        principalTable: "FichasPlanificacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Areas_EmpresaId1",
                table: "Areas",
                column: "EmpresaId1");

            migrationBuilder.CreateIndex(
                name: "IX_Documentos_FichaAnalisisId",
                table: "Documentos",
                column: "FichaAnalisisId");

            migrationBuilder.CreateIndex(
                name: "IX_Documentos_FichaArticuloEFIMEDId",
                table: "Documentos",
                column: "FichaArticuloEFIMEDId");

            migrationBuilder.CreateIndex(
                name: "IX_Documentos_FichaArticuloId",
                table: "Documentos",
                column: "FichaArticuloId");

            migrationBuilder.CreateIndex(
                name: "IX_Documentos_FichaCalidadId",
                table: "Documentos",
                column: "FichaCalidadId");

            migrationBuilder.CreateIndex(
                name: "IX_Documentos_FichaComprasId",
                table: "Documentos",
                column: "FichaComprasId");

            migrationBuilder.CreateIndex(
                name: "IX_Documentos_FichaEjecucionId",
                table: "Documentos",
                column: "FichaEjecucionId");

            migrationBuilder.CreateIndex(
                name: "IX_Documentos_FichaIncidenciaId",
                table: "Documentos",
                column: "FichaIncidenciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Documentos_FichaLogisticaId",
                table: "Documentos",
                column: "FichaLogisticaId");

            migrationBuilder.CreateIndex(
                name: "IX_Documentos_FichaNoConformidadEficienciaEnergeticaId",
                table: "Documentos",
                column: "FichaNoConformidadEficienciaEnergeticaId");

            migrationBuilder.CreateIndex(
                name: "IX_Documentos_FichaNoConformidadMedioAmbienteId",
                table: "Documentos",
                column: "FichaNoConformidadMedioAmbienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Documentos_FichaNoConformidadProductoAcabadoId",
                table: "Documentos",
                column: "FichaNoConformidadProductoAcabadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Documentos_FichaNoConformidadServicioId",
                table: "Documentos",
                column: "FichaNoConformidadServicioId");

            migrationBuilder.CreateIndex(
                name: "IX_Documentos_FichaPlanificacionId",
                table: "Documentos",
                column: "FichaPlanificacionId");

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
                name: "IX_FichasAnalisis_AreaId",
                table: "FichasAnalisis",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasAnalisis_DecisionId",
                table: "FichasAnalisis",
                column: "DecisionId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasAnalisis_EmisorId1",
                table: "FichasAnalisis",
                column: "EmisorId1");

            migrationBuilder.CreateIndex(
                name: "IX_FichasAnalisis_EmpresaId",
                table: "FichasAnalisis",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasAnalisis_PropuestaId",
                table: "FichasAnalisis",
                column: "PropuestaId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasAnalisis_ResponsableAnalisisId",
                table: "FichasAnalisis",
                column: "ResponsableAnalisisId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasAnalisis_SeccionId",
                table: "FichasAnalisis",
                column: "SeccionId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasArticulo_AreaId",
                table: "FichasArticulo",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasArticulo_ArticuloId",
                table: "FichasArticulo",
                column: "ArticuloId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasArticulo_EmisorId1",
                table: "FichasArticulo",
                column: "EmisorId1");

            migrationBuilder.CreateIndex(
                name: "IX_FichasArticulo_EmpresaId",
                table: "FichasArticulo",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasArticulo_ProveedorId",
                table: "FichasArticulo",
                column: "ProveedorId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasArticulo_SeccionId",
                table: "FichasArticulo",
                column: "SeccionId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasArticuloEFIMED_AreaId",
                table: "FichasArticuloEFIMED",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasArticuloEFIMED_ArticuloId",
                table: "FichasArticuloEFIMED",
                column: "ArticuloId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasArticuloEFIMED_EmisorId1",
                table: "FichasArticuloEFIMED",
                column: "EmisorId1");

            migrationBuilder.CreateIndex(
                name: "IX_FichasArticuloEFIMED_EmpresaId",
                table: "FichasArticuloEFIMED",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasArticuloEFIMED_ProveedorId",
                table: "FichasArticuloEFIMED",
                column: "ProveedorId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasArticuloEFIMED_SeccionId",
                table: "FichasArticuloEFIMED",
                column: "SeccionId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasCalidad_AreaId",
                table: "FichasCalidad",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasCalidad_DecisionCalidadId",
                table: "FichasCalidad",
                column: "DecisionCalidadId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasCalidad_EmisorId1",
                table: "FichasCalidad",
                column: "EmisorId1");

            migrationBuilder.CreateIndex(
                name: "IX_FichasCalidad_EmpresaId",
                table: "FichasCalidad",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasCalidad_MotivoId",
                table: "FichasCalidad",
                column: "MotivoId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasCalidad_ResponsableCalidadId",
                table: "FichasCalidad",
                column: "ResponsableCalidadId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasCalidad_SeccionId",
                table: "FichasCalidad",
                column: "SeccionId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasCompras_AreaId",
                table: "FichasCompras",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasCompras_DecisionComprasId",
                table: "FichasCompras",
                column: "DecisionComprasId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasCompras_EmisorId1",
                table: "FichasCompras",
                column: "EmisorId1");

            migrationBuilder.CreateIndex(
                name: "IX_FichasCompras_EmpresaId",
                table: "FichasCompras",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasCompras_PropuestaComprasId",
                table: "FichasCompras",
                column: "PropuestaComprasId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasCompras_ResponsableComprasId",
                table: "FichasCompras",
                column: "ResponsableComprasId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasCompras_SeccionId",
                table: "FichasCompras",
                column: "SeccionId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasEjecucion_AreaId",
                table: "FichasEjecucion",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasEjecucion_DecisionEjecucionId",
                table: "FichasEjecucion",
                column: "DecisionEjecucionId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasEjecucion_EmisorId1",
                table: "FichasEjecucion",
                column: "EmisorId1");

            migrationBuilder.CreateIndex(
                name: "IX_FichasEjecucion_EmpresaId",
                table: "FichasEjecucion",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasEjecucion_PropuestaEjecucionId",
                table: "FichasEjecucion",
                column: "PropuestaEjecucionId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasEjecucion_ResponsableEjecucionId",
                table: "FichasEjecucion",
                column: "ResponsableEjecucionId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasEjecucion_SeccionId",
                table: "FichasEjecucion",
                column: "SeccionId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasIncidencia_AreaId",
                table: "FichasIncidencia",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasIncidencia_DecisionIncidenciaId",
                table: "FichasIncidencia",
                column: "DecisionIncidenciaId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasIncidencia_EmisorId1",
                table: "FichasIncidencia",
                column: "EmisorId1");

            migrationBuilder.CreateIndex(
                name: "IX_FichasIncidencia_EmpresaId",
                table: "FichasIncidencia",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasIncidencia_PropuestaIncidenciaId",
                table: "FichasIncidencia",
                column: "PropuestaIncidenciaId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasIncidencia_SeccionId",
                table: "FichasIncidencia",
                column: "SeccionId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasLogistica_AreaId",
                table: "FichasLogistica",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasLogistica_DecisionLogisticaId",
                table: "FichasLogistica",
                column: "DecisionLogisticaId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasLogistica_EmisorId1",
                table: "FichasLogistica",
                column: "EmisorId1");

            migrationBuilder.CreateIndex(
                name: "IX_FichasLogistica_EmpresaId",
                table: "FichasLogistica",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasLogistica_ResponsableLogisticaId",
                table: "FichasLogistica",
                column: "ResponsableLogisticaId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasLogistica_SeccionId",
                table: "FichasLogistica",
                column: "SeccionId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasNoConformidad_AreaId",
                table: "FichasNoConformidad",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasNoConformidad_EmisorId1",
                table: "FichasNoConformidad",
                column: "EmisorId1");

            migrationBuilder.CreateIndex(
                name: "IX_FichasNoConformidad_EmpresaId",
                table: "FichasNoConformidad",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasNoConformidad_FichaAnalisisId1",
                table: "FichasNoConformidad",
                column: "FichaAnalisisId1");

            migrationBuilder.CreateIndex(
                name: "IX_FichasNoConformidad_FichaArticuloEFIMEDId1",
                table: "FichasNoConformidad",
                column: "FichaArticuloEFIMEDId1");

            migrationBuilder.CreateIndex(
                name: "IX_FichasNoConformidad_FichaEjecucionId1",
                table: "FichasNoConformidad",
                column: "FichaEjecucionId1");

            migrationBuilder.CreateIndex(
                name: "IX_FichasNoConformidad_FichaIncidenciaId1",
                table: "FichasNoConformidad",
                column: "FichaIncidenciaId1");

            migrationBuilder.CreateIndex(
                name: "IX_FichasNoConformidad_SeccionId",
                table: "FichasNoConformidad",
                column: "SeccionId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasNoConformidadMedioAmbiente_AreaId",
                table: "FichasNoConformidadMedioAmbiente",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasNoConformidadMedioAmbiente_EmisorId1",
                table: "FichasNoConformidadMedioAmbiente",
                column: "EmisorId1");

            migrationBuilder.CreateIndex(
                name: "IX_FichasNoConformidadMedioAmbiente_EmpresaId",
                table: "FichasNoConformidadMedioAmbiente",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasNoConformidadMedioAmbiente_FichaAnalisisId1",
                table: "FichasNoConformidadMedioAmbiente",
                column: "FichaAnalisisId1");

            migrationBuilder.CreateIndex(
                name: "IX_FichasNoConformidadMedioAmbiente_FichaArticuloEFIMEDId1",
                table: "FichasNoConformidadMedioAmbiente",
                column: "FichaArticuloEFIMEDId1");

            migrationBuilder.CreateIndex(
                name: "IX_FichasNoConformidadMedioAmbiente_FichaEjecucionId1",
                table: "FichasNoConformidadMedioAmbiente",
                column: "FichaEjecucionId1");

            migrationBuilder.CreateIndex(
                name: "IX_FichasNoConformidadMedioAmbiente_FichaIncidenciaId1",
                table: "FichasNoConformidadMedioAmbiente",
                column: "FichaIncidenciaId1");

            migrationBuilder.CreateIndex(
                name: "IX_FichasNoConformidadMedioAmbiente_SeccionId",
                table: "FichasNoConformidadMedioAmbiente",
                column: "SeccionId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasNoConformidadProductoAcabado_AreaId",
                table: "FichasNoConformidadProductoAcabado",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasNoConformidadProductoAcabado_EmisorId1",
                table: "FichasNoConformidadProductoAcabado",
                column: "EmisorId1");

            migrationBuilder.CreateIndex(
                name: "IX_FichasNoConformidadProductoAcabado_EmpresaId",
                table: "FichasNoConformidadProductoAcabado",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasNoConformidadProductoAcabado_FichaArticuloId1",
                table: "FichasNoConformidadProductoAcabado",
                column: "FichaArticuloId1");

            migrationBuilder.CreateIndex(
                name: "IX_FichasNoConformidadProductoAcabado_FichaCalidadId1",
                table: "FichasNoConformidadProductoAcabado",
                column: "FichaCalidadId1");

            migrationBuilder.CreateIndex(
                name: "IX_FichasNoConformidadProductoAcabado_FichaIncidenciaId1",
                table: "FichasNoConformidadProductoAcabado",
                column: "FichaIncidenciaId1");

            migrationBuilder.CreateIndex(
                name: "IX_FichasNoConformidadProductoAcabado_FichaLogisticaId1",
                table: "FichasNoConformidadProductoAcabado",
                column: "FichaLogisticaId1");

            migrationBuilder.CreateIndex(
                name: "IX_FichasNoConformidadProductoAcabado_FichaPlanificacionId1",
                table: "FichasNoConformidadProductoAcabado",
                column: "FichaPlanificacionId1");

            migrationBuilder.CreateIndex(
                name: "IX_FichasNoConformidadProductoAcabado_SeccionId",
                table: "FichasNoConformidadProductoAcabado",
                column: "SeccionId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasNoConformidadServicio_AreaId",
                table: "FichasNoConformidadServicio",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasNoConformidadServicio_EmisorId1",
                table: "FichasNoConformidadServicio",
                column: "EmisorId1");

            migrationBuilder.CreateIndex(
                name: "IX_FichasNoConformidadServicio_EmpresaId",
                table: "FichasNoConformidadServicio",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasNoConformidadServicio_FichaAnalisisId1",
                table: "FichasNoConformidadServicio",
                column: "FichaAnalisisId1");

            migrationBuilder.CreateIndex(
                name: "IX_FichasNoConformidadServicio_FichaArticuloEFIMEDId1",
                table: "FichasNoConformidadServicio",
                column: "FichaArticuloEFIMEDId1");

            migrationBuilder.CreateIndex(
                name: "IX_FichasNoConformidadServicio_FichaComprasId1",
                table: "FichasNoConformidadServicio",
                column: "FichaComprasId1");

            migrationBuilder.CreateIndex(
                name: "IX_FichasNoConformidadServicio_FichaEjecucionId1",
                table: "FichasNoConformidadServicio",
                column: "FichaEjecucionId1");

            migrationBuilder.CreateIndex(
                name: "IX_FichasNoConformidadServicio_FichaIncidenciaId1",
                table: "FichasNoConformidadServicio",
                column: "FichaIncidenciaId1");

            migrationBuilder.CreateIndex(
                name: "IX_FichasNoConformidadServicio_SeccionId",
                table: "FichasNoConformidadServicio",
                column: "SeccionId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasPlanificacion_AreaId",
                table: "FichasPlanificacion",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasPlanificacion_DecisionPlanificacionId",
                table: "FichasPlanificacion",
                column: "DecisionPlanificacionId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasPlanificacion_EmisorId1",
                table: "FichasPlanificacion",
                column: "EmisorId1");

            migrationBuilder.CreateIndex(
                name: "IX_FichasPlanificacion_EmpresaId",
                table: "FichasPlanificacion",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasPlanificacion_ResponsablePlanificacionId",
                table: "FichasPlanificacion",
                column: "ResponsablePlanificacionId");

            migrationBuilder.CreateIndex(
                name: "IX_FichasPlanificacion_SeccionId",
                table: "FichasPlanificacion",
                column: "SeccionId");

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
                name: "IX_TiposIncidenciaSeccion_FichaIncidenciaId",
                table: "TiposIncidenciaSeccion",
                column: "FichaIncidenciaId");

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
                name: "TiposIncidenciaSeccion");

            migrationBuilder.DropTable(
                name: "FichasNoConformidad");

            migrationBuilder.DropTable(
                name: "FichasNoConformidadMedioAmbiente");

            migrationBuilder.DropTable(
                name: "FichasNoConformidadProductoAcabado");

            migrationBuilder.DropTable(
                name: "FichasNoConformidadServicio");

            migrationBuilder.DropTable(
                name: "Incidencias");

            migrationBuilder.DropTable(
                name: "FichasArticulo");

            migrationBuilder.DropTable(
                name: "FichasCalidad");

            migrationBuilder.DropTable(
                name: "FichasLogistica");

            migrationBuilder.DropTable(
                name: "FichasPlanificacion");

            migrationBuilder.DropTable(
                name: "FichasAnalisis");

            migrationBuilder.DropTable(
                name: "FichasArticuloEFIMED");

            migrationBuilder.DropTable(
                name: "FichasCompras");

            migrationBuilder.DropTable(
                name: "FichasEjecucion");

            migrationBuilder.DropTable(
                name: "FichasIncidencia");

            migrationBuilder.DropTable(
                name: "Motivos");

            migrationBuilder.DropTable(
                name: "Articulo");

            migrationBuilder.DropTable(
                name: "Proveedores");

            migrationBuilder.DropTable(
                name: "TiposDecisionSeccion");

            migrationBuilder.DropTable(
                name: "EmpresaAreaSeccionUsuarios");

            migrationBuilder.DropTable(
                name: "Decisiones");

            migrationBuilder.DropTable(
                name: "Secciones");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Areas");

            migrationBuilder.DropTable(
                name: "Empresas");
        }
    }
}
