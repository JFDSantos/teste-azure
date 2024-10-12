﻿// <auto-generated />
using System;
using Fiap.Web.Ocorrencias.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace Fiap.Web.Ocorrencias.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20240630140145_AdicionandoRolesPadrao")]
    partial class AdicionandoRolesPadrao
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Fiap.Web.Ocorrencias.Models.AtendimentoModel", b =>
                {
                    b.Property<int>("id_atendimento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_atendimento"));

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("id_ocorrencia")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("id_serv_emergencia")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("id_veic")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("id_atendimento");

                    b.HasIndex("id_ocorrencia");

                    b.HasIndex("id_serv_emergencia");

                    b.HasIndex("id_veic");

                    b.ToTable("TBL_ATENDIMENTO", (string)null);
                });

            modelBuilder.Entity("Fiap.Web.Ocorrencias.Models.BoletimModel", b =>
                {
                    b.Property<int>("id_boletim")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_boletim"));

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("id_atendimento")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("id_email")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("id_boletim");

                    b.HasIndex("id_atendimento");

                    b.HasIndex("id_email");

                    b.ToTable("TBL_BOLETIM", (string)null);
                });

            modelBuilder.Entity("Fiap.Web.Ocorrencias.Models.EmailModel", b =>
                {
                    b.Property<int>("id_email")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_email"));

                    b.Property<string>("cpf")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("id_email");

                    b.ToTable("TBL_EMAIL", (string)null);
                });

            modelBuilder.Entity("Fiap.Web.Ocorrencias.Models.GravidadeModel", b =>
                {
                    b.Property<int>("id_gravidade")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_gravidade"));

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("id_gravidade");

                    b.ToTable("TBL_GRAVIDADE", (string)null);
                });

            modelBuilder.Entity("Fiap.Web.Ocorrencias.Models.LocalizacaoModel", b =>
                {
                    b.Property<int>("id_loc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_loc"));

                    b.Property<string>("cep")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("cidade")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("endereco")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("id_loc");

                    b.ToTable("TBL_LOCALIZACAO", (string)null);
                });

            modelBuilder.Entity("Fiap.Web.Ocorrencias.Models.OcorrenciaModel", b =>
                {
                    b.Property<int>("id_ocorrencia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_ocorrencia"));

                    b.Property<DateTime>("data_hora")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("id_atendimento")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("id_gravidade")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("id_loc")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("id_ocorrencia");

                    b.HasIndex("id_gravidade");

                    b.HasIndex("id_loc");

                    b.ToTable("TBL_OCORRENCIA", (string)null);
                });

            modelBuilder.Entity("Fiap.Web.Ocorrencias.Models.ServicoEmergenciaModel", b =>
                {
                    b.Property<int>("id_serv_emergencia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_serv_emergencia"));

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("gravidade_atendida")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("telefone")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("id_serv_emergencia");

                    b.HasIndex("gravidade_atendida");

                    b.ToTable("TBL_SERVICO_EMERGENCIA", (string)null);
                });

            modelBuilder.Entity("Fiap.Web.Ocorrencias.Models.UsuarioModel", b =>
                {
                    b.Property<int>("id_usuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_usuario"));

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int?>("id_role")
                        .IsRequired()
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("senha")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("id_usuario");

                    b.HasIndex("id_role");

                    b.ToTable("TBL_USUARIO", (string)null);
                });

            modelBuilder.Entity("Fiap.Web.Ocorrencias.Models.UsuarioRoleModel", b =>
                {
                    b.Property<int>("id_role")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_role"));

                    b.Property<string>("role")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("id_role");

                    b.ToTable("TBL_ROLES", (string)null);
                });

            modelBuilder.Entity("Fiap.Web.Ocorrencias.Models.VeiculoModel", b =>
                {
                    b.Property<int>("id_veic")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_veic"));

                    b.Property<string>("disponivel")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(1)");

                    b.Property<int>("id_atendimento")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("id_serv_emergencia")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("placa")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("id_veic");

                    b.HasIndex("id_serv_emergencia");

                    b.ToTable("TBL_VEICULOS_DISPONIVEIS", (string)null);
                });

            modelBuilder.Entity("Fiap.Web.Ocorrencias.Models.AtendimentoModel", b =>
                {
                    b.HasOne("Fiap.Web.Ocorrencias.Models.OcorrenciaModel", "Ocorrencia")
                        .WithMany()
                        .HasForeignKey("id_ocorrencia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Fiap.Web.Ocorrencias.Models.ServicoEmergenciaModel", "ServicoEmergencia")
                        .WithMany()
                        .HasForeignKey("id_serv_emergencia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Fiap.Web.Ocorrencias.Models.VeiculoModel", "Veiculo")
                        .WithMany()
                        .HasForeignKey("id_veic")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ocorrencia");

                    b.Navigation("ServicoEmergencia");

                    b.Navigation("Veiculo");
                });

            modelBuilder.Entity("Fiap.Web.Ocorrencias.Models.BoletimModel", b =>
                {
                    b.HasOne("Fiap.Web.Ocorrencias.Models.AtendimentoModel", "Atendimento")
                        .WithMany()
                        .HasForeignKey("id_atendimento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Fiap.Web.Ocorrencias.Models.EmailModel", "Email")
                        .WithMany()
                        .HasForeignKey("id_email")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Atendimento");

                    b.Navigation("Email");
                });

            modelBuilder.Entity("Fiap.Web.Ocorrencias.Models.OcorrenciaModel", b =>
                {
                    b.HasOne("Fiap.Web.Ocorrencias.Models.GravidadeModel", "Gravidade")
                        .WithMany()
                        .HasForeignKey("id_gravidade")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Fiap.Web.Ocorrencias.Models.LocalizacaoModel", "Localizacao")
                        .WithMany()
                        .HasForeignKey("id_loc")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gravidade");

                    b.Navigation("Localizacao");
                });

            modelBuilder.Entity("Fiap.Web.Ocorrencias.Models.ServicoEmergenciaModel", b =>
                {
                    b.HasOne("Fiap.Web.Ocorrencias.Models.GravidadeModel", "Gravidade")
                        .WithMany()
                        .HasForeignKey("gravidade_atendida")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gravidade");
                });

            modelBuilder.Entity("Fiap.Web.Ocorrencias.Models.UsuarioModel", b =>
                {
                    b.HasOne("Fiap.Web.Ocorrencias.Models.UsuarioRoleModel", "Role")
                        .WithMany()
                        .HasForeignKey("id_role")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Fiap.Web.Ocorrencias.Models.VeiculoModel", b =>
                {
                    b.HasOne("Fiap.Web.Ocorrencias.Models.ServicoEmergenciaModel", "ServicoEmergencia")
                        .WithMany()
                        .HasForeignKey("id_serv_emergencia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ServicoEmergencia");
                });
#pragma warning restore 612, 618
        }
    }
}
