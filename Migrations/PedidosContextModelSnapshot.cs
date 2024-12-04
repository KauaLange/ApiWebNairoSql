﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using api_LojaClientes.BancoDeDados;

#nullable disable

namespace api_LojaClientes.Migrations
{
    [DbContext(typeof(PedidosContext))]
    partial class PedidosContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("api_LojaClientes.Modelos.Cliente", b =>
                {
                    b.Property<int>("idCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("cepCliente")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("cidadeCliente")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("dataCadastroCliente")
                        .HasColumnType("TEXT");

                    b.Property<string>("emailCliente")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("enderecoCliente")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("estadoCliente")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("nomeCliente")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("sobrenomeCliente")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("telefoneCliente")
                        .HasColumnType("TEXT");

                    b.HasKey("idCliente");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("api_LojaCliente.Modelos.ItemPedido", b =>
                {
                    b.Property<int>("idItemPedido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("idPedido")
                        .HasColumnType("INTEGER");

                    b.Property<int>("idProduto")
                        .HasColumnType("INTEGER");

                    b.Property<float>("precoUnitarioItemPedido")
                        .HasColumnType("REAL");

                    b.Property<int>("quantidadeItemPedido")
                        .HasColumnType("INTEGER");

                    b.HasKey("idItemPedido");

                    b.HasIndex("idPedido");

                    b.HasIndex("idProduto");

                    b.ToTable("ItemPedidos");
                });

            modelBuilder.Entity("api_LojaClientes.Modelos.Pedido", b =>
                {
                    b.Property<int>("idPedido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("dataPedido")
                        .HasColumnType("TEXT");

                    b.Property<int>("idCliente")
                        .HasColumnType("INTEGER");

                    b.Property<string>("observacoesPedido")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("statusPedido")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("valorTotalPedido")
                        .HasColumnType("TEXT");

                    b.HasKey("idPedido");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("api_LojaClientes.Modelos.Produto", b =>
                {
                    b.Property<int>("idProduto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("dataProduto")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("descricaoProduto")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("estoqueProduto")
                        .HasColumnType("INTEGER");

                    b.Property<string>("nomeProduto")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("idProduto");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("api_LojaClientes.Modelos.ItemPedido", b =>
                {
                    b.HasOne("api_LojaClientes.Modelos.Pedido", "Pedido")
                        .WithMany("itemPedidos")
                        .HasForeignKey("idPedido")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("api_LojaClientes.Modelos.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("idProduto")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Pedido");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("api_LojaClientes.Modelos.Pedido", b =>
                {
                    b.HasOne("api_LojaClientes.Modelos.Cliente", null)
                        .WithMany("Pedidos")
                        .HasForeignKey("idPedido")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("api_LojaClientes.Modelos.Cliente", b =>
                {
                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("api_LojaClientes.Modelos.Pedido", b =>
                {
                    b.Navigation("itemPedidos");
                });
#pragma warning restore 612, 618
        }
    }
}