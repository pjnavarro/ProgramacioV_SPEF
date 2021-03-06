﻿// <auto-generated />
using ACTI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace ACTI.Migrations
{
    [DbContext(typeof(ACTIContext))]
    partial class ACTIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ACTI.Models.Alumno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apellido")
                        .IsRequired();

                    b.Property<string>("Dirección")
                        .IsRequired();

                    b.Property<int>("Dni");

                    b.Property<string>("Email");

                    b.Property<bool>("Estado");

                    b.Property<DateTimeOffset>("FechaCreacion");

                    b.Property<DateTimeOffset>("FechaModificacion");

                    b.Property<DateTime>("Nacimiento");

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<int?>("ProfesorId");

                    b.Property<int>("Teléfono");

                    b.Property<string>("UsuarioCreacion");

                    b.Property<string>("UsuarioModificacion");

                    b.HasKey("Id");

                    b.HasIndex("ProfesorId");

                    b.ToTable("Alumno");
                });

            modelBuilder.Entity("ACTI.Models.Profesor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apellido")
                        .IsRequired();

                    b.Property<string>("Dirección")
                        .IsRequired();

                    b.Property<int>("Dni");

                    b.Property<string>("Email");

                    b.Property<bool>("Estado");

                    b.Property<DateTimeOffset>("FechaCreacion");

                    b.Property<DateTimeOffset>("FechaModificacion");

                    b.Property<DateTime>("Nacimiento");

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<int>("Teléfono");

                    b.Property<string>("UsuarioCreacion");

                    b.Property<string>("UsuarioModificacion");

                    b.HasKey("Id");

                    b.ToTable("Profesor");
                });

            modelBuilder.Entity("ACTI.Models.Alumno", b =>
                {
                    b.HasOne("ACTI.Models.Profesor", "Profesor")
                        .WithMany()
                        .HasForeignKey("ProfesorId");
                });
#pragma warning restore 612, 618
        }
    }
}
