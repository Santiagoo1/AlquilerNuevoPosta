using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Alquiler.BD.Migrations
{
    public partial class inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Direcciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Localidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Departamento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Provincia = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Direcciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estados = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoDocumentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreTipoDocumento = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDocumentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductosPublicados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreProducto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrecioProducto = table.Column<int>(type: "int", nullable: false),
                    DetallesProducto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    foto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoId = table.Column<int>(type: "int", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: false),
                    Alquilado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductosPublicados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductosPublicados_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductosPublicados_Estados_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DNI = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Contraseña = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CalleAltura = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TipoDocumentoId = table.Column<int>(type: "int", nullable: false),
                    DireccionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personas_Direcciones_DireccionId",
                        column: x => x.DireccionId,
                        principalTable: "Direcciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personas_TipoDocumentos_TipoDocumentoId",
                        column: x => x.TipoDocumentoId,
                        principalTable: "TipoDocumentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "Id", "Url", "nombre" },
                values: new object[,]
                {
                    { 1, "electrodomestico", "Electrodomestico" },
                    { 2, "herramientas", "Herramientas" },
                    { 3, "tecnologia", "Tecnologia" },
                    { 4, "juguete", "Juguetes" }
                });

            migrationBuilder.InsertData(
                table: "Direcciones",
                columns: new[] { "Id", "Departamento", "Localidad", "Provincia" },
                values: new object[,]
                {
                    { 1, " Capital ", "Cordoba ", " Cordoba " },
                    { 2, " Rio Cuarto ", " Rio Cuarto", " Cordoba " },
                    { 3, " Rio Tercero ", "Almafuerte", " Cordoba " },
                    { 4, " Rio Tercero ", "Oliva", " Cordoba " },
                    { 5, " Rio Tercero ", "Rio Tercero", " Cordoba " },
                    { 6, " Rio Segundo ", "Pilar", " Cordoba " },
                    { 7, " Rio Segundo ", "Oncativo", " Cordoba " },
                    { 8, " Rio Segundo ", "Rio Segundo", " Cordoba " },
                    { 9, " Rio Primero ", "La Quinta", " Cordoba " },
                    { 10, " Tulumba ", "Villa Tulumba", " Cordoba " },
                    { 11, " Sobremonte ", "San Francisco Del Chañar", " Cordoba " },
                    { 12, " Rio Seco ", "Cerro Colorado", " Cordoba " },
                    { 13, " Cruz del Eje ", "San Marcos Sierras", " Cordoba " },
                    { 14, " Ischilín ", "Parroquia", " Cordoba " },
                    { 15, " Totoral ", "Las Peñas", " Cordoba " },
                    { 16, " San Justo ", "Arroyito", " Cordoba " },
                    { 17, " Minas ", "San Carlos Minas", " Cordoba " },
                    { 18, " Punilla ", "Villa Carlos Paz", " Cordoba " },
                    { 19, " Punilla ", "Cosquin", " Cordoba " },
                    { 20, " Punilla ", "La Falda", " Cordoba " },
                    { 21, " Punilla ", "Bialet Massé", " Cordoba " },
                    { 22, " Punilla ", "Huerta Grande", " Cordoba " },
                    { 23, " Colon ", "Jesus Maria", " Cordoba " },
                    { 24, " Colon ", "La Calera", " Cordoba " },
                    { 25, " Colon ", "Unquillo", " Cordoba " },
                    { 26, " Pocho ", "Salsacate", " Cordoba " },
                    { 27, " San Alberto ", "Mina Clavero", " Cordoba " },
                    { 28, " San Alberto ", " Villa Cura Brochero", " Cordoba " },
                    { 29, " San Alberto ", "San Vicente", " Cordoba " },
                    { 30, " Santa Maria ", "Alta Gracia", " Cordoba " },
                    { 31, " Santa Maria ", "Anisacate", " Cordoba " },
                    { 32, " Santa Maria ", "Las Quintas", " Cordoba " },
                    { 33, " San Javier ", "Villa Dolores", " Cordoba " },
                    { 34, " San Javier ", "Villa De Las Rosas", " Cordoba " },
                    { 35, " San Javier ", "La Paz", " Cordoba " },
                    { 36, " Calamuchita ", "Santa Rosa De Calamuchita", " Cordoba " },
                    { 37, " Calamuchita ", "Embalse", " Cordoba " },
                    { 38, " Calamuchita ", "Villa General Belgrano", " Cordoba " }
                });

            migrationBuilder.InsertData(
                table: "Direcciones",
                columns: new[] { "Id", "Departamento", "Localidad", "Provincia" },
                values: new object[,]
                {
                    { 39, " San Martin ", "Villa Maria", " Cordoba " },
                    { 40, " Marcos Juarez ", "Arias", " Cordoba " },
                    { 41, " Marcos Juarez ", " Marcos Juarez", " Cordoba " },
                    { 42, " Juarez Celman ", "La Carlota", " Cordoba " },
                    { 43, " Juarez Celman ", "General Cabrera", " Cordoba " },
                    { 44, " Roque Saenz Peña ", "Laboulaye", " Cordoba " },
                    { 45, " Roque Saenz Peña ", "General Levalle", " Cordoba " },
                    { 46, " Roque Saenz Peña ", "Serrano", " Cordoba " },
                    { 47, " Roque Saenz Peña ", "Rosales", " Cordoba " },
                    { 48, " General Roca ", "Villa Valeria", " Cordoba " }
                });

            migrationBuilder.InsertData(
                table: "Estados",
                columns: new[] { "Id", "Estados" },
                values: new object[,]
                {
                    { 1, "En envio" },
                    { 2, "En preparacion" },
                    { 3, "En local" },
                    { 4, "Entregado" }
                });

            migrationBuilder.InsertData(
                table: "TipoDocumentos",
                columns: new[] { "Id", "NombreTipoDocumento" },
                values: new object[,]
                {
                    { 1, "DNU" },
                    { 2, "PASAPORTE NACIONAL" },
                    { 3, "DNI" },
                    { 4, "TARJETA DE RESIDENCIA" },
                    { 5, "PASAPORTE EXTRANJERO" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personas_DireccionId",
                table: "Personas",
                column: "DireccionId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_TipoDocumentoId",
                table: "Personas",
                column: "TipoDocumentoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductosPublicados_CategoriaId",
                table: "ProductosPublicados",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductosPublicados_EstadoId",
                table: "ProductosPublicados",
                column: "EstadoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "ProductosPublicados");

            migrationBuilder.DropTable(
                name: "Direcciones");

            migrationBuilder.DropTable(
                name: "TipoDocumentos");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Estados");
        }
    }
}
