using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alquiler.BD.Data.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Alquiler.BD
{
    public class BdContext : DbContext
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region creacion de categoria
            modelBuilder.Entity<Categoria>().HasData(
                new Categoria
                {
                    Id = 1,
                    nombre = "Electrodomestico",
                    Url = "electrodomestico"
                },
                new Categoria
                {
                    Id = 2,
                    nombre = "Herramientas",
                    Url = "herramientas"
                },
                new Categoria
                {
                    Id = 3,
                    nombre = "Tecnologia",
                    Url = "tecnologia"
                },
                new Categoria
                {
                    Id = 4,
                    nombre = "Juguetes",
                    Url = "juguete"
                }

                );
            #endregion

            #region creacion de estado
            modelBuilder.Entity<Estado>().HasData(
                 new Estado
                {
                    Id = 1,
                    Estados = "En envio",
               
                },
                new Estado
                {
                    Id = 2,
                    Estados = "En preparacion",
              
                },
                new Estado
                {
                    Id = 3,
                    Estados = "En local",
              
                },
                new Estado
                {
                    Id = 4,
                    Estados = "Entregado",
               
                }

                );
            #endregion



            #region creacion de TIPO DOCUMENTO
            modelBuilder.Entity<TipoDocumento>().HasData(
                 new TipoDocumento
                 {
                     Id = 1,
                     NombreTipoDocumento = "DNU",

                 },
                new TipoDocumento
                {
                    Id = 2,
                    NombreTipoDocumento = "PASAPORTE NACIONAL",

                },
                new TipoDocumento
                {
                    Id = 3,
                    NombreTipoDocumento = "DNI",

                },
                new TipoDocumento
                {
                    Id = 4,
                    NombreTipoDocumento = "TARJETA DE RESIDENCIA",

                },

                 new TipoDocumento
                 {
                     Id = 5,
                     NombreTipoDocumento = "PASAPORTE EXTRANJERO",

                 }

                );
            #endregion


            #region creacion de DIRECCION
            modelBuilder.Entity<Direccion>().HasData(
                 new Direccion
                 {
                     Id = 1,
                     Localidad = "Cordoba ",
                     Departamento = " Capital ",
                     Provincia = " Cordoba " ,
                 },
                new Direccion
                {
                    Id = 2,
                    Localidad = " Rio Cuarto",
                    Departamento = " Rio Cuarto ",
                    Provincia = " Cordoba ",
                },
                new Direccion
                {
                    Id = 3,
                    Localidad = "Almafuerte",
                    Departamento = " Rio Tercero ",
                    Provincia = " Cordoba ",
                },

                   new Direccion
                   {
                       Id = 4,
                       Localidad = "Oliva",
                       Departamento = " Rio Tercero ",
                       Provincia = " Cordoba ",
                   },

                      new Direccion
                      {
                          Id = 5,
                          Localidad = "Rio Tercero",
                          Departamento = " Rio Tercero ",
                          Provincia = " Cordoba ",
                      },
                new Direccion
                {
                    Id = 6,
                    Localidad = "Pilar",
                    Departamento = " Rio Segundo ",
                    Provincia = " Cordoba ",
                },

                  new Direccion
                  {
                      Id = 7,
                      Localidad = "Oncativo",
                      Departamento = " Rio Segundo ",
                      Provincia = " Cordoba ",
                  },

                    new Direccion
                    {
                        Id = 8,
                        Localidad = "Rio Segundo",
                        Departamento = " Rio Segundo ",
                        Provincia = " Cordoba ",
                    },

                   new Direccion
                   {
                       Id = 9,
                       Localidad = "La Quinta",
                       Departamento = " Rio Primero ",
                       Provincia = " Cordoba ",
                   },

                      new Direccion
                      {
                          Id = 10,
                          Localidad = "Villa Tulumba",
                          Departamento = " Tulumba ",
                          Provincia = " Cordoba ",
                      },

                         new Direccion
                         {
                             Id = 11,
                             Localidad = "San Francisco Del Chañar",
                             Departamento = " Sobremonte ",
                             Provincia = " Cordoba ",
                         },

                            new Direccion
                            {
                                Id = 12,
                                Localidad = "Cerro Colorado",
                                Departamento = " Rio Seco ",
                                Provincia = " Cordoba ",
                            },


                               new Direccion
                               {
                                   Id = 13,
                                   Localidad = "San Marcos Sierras",
                                   Departamento = " Cruz del Eje ",
                                   Provincia = " Cordoba ",
                               },

                                  new Direccion
                                  {
                                      Id = 14,
                                      Localidad = "Parroquia",
                                      Departamento = " Ischilín ",
                                      Provincia = " Cordoba ",
                                  },

                                     new Direccion
                                     {
                                         Id = 15,
                                         Localidad = "Las Peñas",
                                         Departamento = " Totoral ",
                                         Provincia = " Cordoba ",
                                     },


                                        new Direccion
                                        {
                                            Id = 16,
                                            Localidad = "Arroyito",
                                            Departamento = " San Justo ",
                                            Provincia = " Cordoba ",
                                        },


                                        new Direccion
                                        {
                                            Id = 17,
                                            Localidad = "San Carlos Minas",
                                            Departamento = " Minas ",
                                            Provincia = " Cordoba ",
                                        },


                                        new Direccion
                                        {
                                            Id = 18,
                                            Localidad = "Villa Carlos Paz",
                                            Departamento = " Punilla ",
                                            Provincia = " Cordoba ",
                                        },


                                          new Direccion
                                          {
                                              Id = 19,
                                              Localidad = "Cosquin",
                                              Departamento = " Punilla ",
                                              Provincia = " Cordoba ",
                                          },

                                            new Direccion
                                            {
                                                Id = 20,
                                                Localidad = "La Falda",
                                                Departamento = " Punilla ",
                                                Provincia = " Cordoba ",
                                            },

                                              new Direccion
                                              {
                                                  Id = 21,
                                                  Localidad = "Bialet Massé",
                                                  Departamento = " Punilla ",
                                                  Provincia = " Cordoba ",
                                              },

                                                new Direccion
                                                {
                                                    Id = 22,
                                                    Localidad = "Huerta Grande",
                                                    Departamento = " Punilla ",
                                                    Provincia = " Cordoba ",
                                                },


                                        new Direccion
                                        {
                                            Id = 23,
                                            Localidad = "Jesus Maria",
                                            Departamento = " Colon ",
                                            Provincia = " Cordoba ",
                                        },

                                          new Direccion
                                          {
                                              Id = 24,
                                              Localidad = "La Calera",
                                              Departamento = " Colon ",
                                              Provincia = " Cordoba ",
                                          },

                                            new Direccion
                                            {
                                                Id = 25,
                                                Localidad = "Unquillo",
                                                Departamento = " Colon ",
                                                Provincia = " Cordoba ",
                                            },

                                        new Direccion
                                        {
                                            Id = 26,
                                            Localidad = "Salsacate",
                                            Departamento = " Pocho ",
                                            Provincia = " Cordoba ",
                                        },


                                        new Direccion
                                        {
                                            Id = 27,
                                            Localidad = "Mina Clavero",
                                            Departamento = " San Alberto ",
                                            Provincia = " Cordoba ",
                                        },


                                        new Direccion
                                        {
                                            Id = 28,
                                            Localidad = " Villa Cura Brochero",
                                            Departamento = " San Alberto ",
                                            Provincia = " Cordoba ",
                                        },


                                        new Direccion
                                        {
                                            Id = 29,
                                            Localidad = "San Vicente",
                                            Departamento = " San Alberto ",
                                            Provincia = " Cordoba ",
                                        },


                                        new Direccion
                                        {
                                            Id = 30,
                                            Localidad = "Alta Gracia",
                                            Departamento = " Santa Maria ",
                                            Provincia = " Cordoba ",
                                        },

                                           new Direccion
                                           {
                                               Id = 31,
                                               Localidad = "Anisacate",
                                               Departamento = " Santa Maria ",
                                               Provincia = " Cordoba ",
                                           },


                                              new Direccion
                                              {
                                                  Id = 32,
                                                  Localidad = "Las Quintas",
                                                  Departamento = " Santa Maria ",
                                                  Provincia = " Cordoba ",
                                              },


                                        new Direccion
                                        {
                                            Id = 33,
                                            Localidad = "Villa Dolores",
                                            Departamento = " San Javier ",
                                            Provincia = " Cordoba ",
                                        },


                                          new Direccion
                                          {
                                              Id = 34,
                                              Localidad = "Villa De Las Rosas",
                                              Departamento = " San Javier ",
                                              Provincia = " Cordoba ",
                                          },

                                            new Direccion
                                            {
                                                Id = 35,
                                                Localidad = "La Paz",
                                                Departamento = " San Javier ",
                                                Provincia = " Cordoba ",
                                            },

                                        new Direccion
                                        {
                                            Id = 36,
                                            Localidad = "Santa Rosa De Calamuchita",
                                            Departamento = " Calamuchita ",
                                            Provincia = " Cordoba ",
                                        },


                                          new Direccion
                                          {
                                              Id = 37,
                                              Localidad = "Embalse",
                                              Departamento = " Calamuchita ",
                                              Provincia = " Cordoba ",
                                          },
                                          
                                          
                                          new Direccion
                                          {
                                          Id = 38,
                                          Localidad = "Villa General Belgrano",
                                          Departamento = " Calamuchita ",
                                          Provincia = " Cordoba ",
                                          },




                                        new Direccion
                                        {
                                            Id = 39,
                                            Localidad = "Villa Maria",
                                            Departamento = " San Martin ",
                                            Provincia = " Cordoba ",
                                        },



                                        new Direccion
                                        {
                                            Id = 40,
                                            Localidad = "Arias",
                                            Departamento = " Marcos Juarez ",
                                            Provincia = " Cordoba ",
                                        },

                                         new Direccion
                                         {
                                             Id = 41,
                                             Localidad = " Marcos Juarez",
                                             Departamento = " Marcos Juarez ",
                                             Provincia = " Cordoba ",
                                         },


                                        new Direccion
                                        {
                                            Id = 42,
                                            Localidad = "La Carlota",
                                            Departamento = " Juarez Celman ",
                                            Provincia = " Cordoba ",
                                        },


                                          new Direccion
                                          {
                                              Id = 43,
                                              Localidad = "General Cabrera",
                                              Departamento = " Juarez Celman ",
                                              Provincia = " Cordoba ",
                                          },

                                        new Direccion
                                        {
                                            Id = 44,
                                            Localidad = "Laboulaye",
                                            Departamento = " Roque Saenz Peña ",
                                            Provincia = " Cordoba ",
                                        },

                                          new Direccion
                                          {
                                              Id = 45,
                                              Localidad = "General Levalle",
                                              Departamento = " Roque Saenz Peña ",
                                              Provincia = " Cordoba ",
                                          },

                                            new Direccion
                                            {
                                                Id = 46,
                                                Localidad = "Serrano",
                                                Departamento = " Roque Saenz Peña ",
                                                Provincia = " Cordoba ",
                                            },

                                              new Direccion
                                              {
                                                  Id = 47,
                                                  Localidad = "Rosales",
                                                  Departamento = " Roque Saenz Peña ",
                                                  Provincia = " Cordoba ",
                                              },

                                                 new Direccion
                                                 {
                                                     Id = 48,
                                                     Localidad = "Villa Valeria",
                                                     Departamento = " General Roca ",
                                                     Provincia = " Cordoba ",
                                                 }
                );

            #endregion

        }

        public BdContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Persona> Personas { get; set; }

        public DbSet<ProductoPublicado> ProductosPublicados { get; set; }



        public DbSet<Direccion> Direcciones { get; set; }

        public DbSet<TipoDocumento> TipoDocumentos { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Estado> Estados { get; set; }
    }


       


    }


