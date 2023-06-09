﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TintSysClass
{
    public class Cliente
    {
        // Atributos
        private int id;                                                                    
        private string nome;
        private string cpf;
        private string email;
        private DateTime dataCad;
        private bool ativo;
        private List<Endereco> enderecos;
        private List<Telefone> telefones;

        //Propriedades
        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Email { get => email; set => email = value; }
        public DateTime DataCad { get => dataCad; set => dataCad = value; }
        public bool Ativo { get => ativo; set => ativo = value; }
        public List<Endereco> Enderecos { get => enderecos; set => enderecos = value; }
        public List<Telefone> Telefones { get => telefones; set => telefones = value; }

        // Métodos Construtores
        public Cliente() { }

        public Cliente(int id, string nome, string cpf, string email, DateTime dataCad, bool ativo, List<Endereco> Enderecos, List<Telefone> Telefones)
        {
            this.Id = id;
            this.Nome = nome;
            this.Cpf = cpf;
            this.Email = email;
            this.DataCad = dataCad;
            this.Ativo = ativo;
            this.Enderecos = Enderecos;
            this.Telefones = Telefones;   
        }

        public Cliente(int id, string nome, string cpf, string email, DateTime dataCad, bool ativo)
        {
            this.Id = id;
            this.Nome = nome;
            this.Cpf = cpf;
            this.Email = email;
            this.DataCad = dataCad;
            this.Ativo = ativo;
        }

        public Cliente(int id, string nome, string cpf, string email, bool ativo, List<Endereco> Enderecos, List<Telefone> Telefones)
        {
            this.Id = id;
            this.Nome = nome;
            this.Cpf = cpf;
            this.Email = email;
            this.Ativo = ativo;
            this.Enderecos = Enderecos;
            this.Telefones = Telefones;
        }

        public Cliente(string nome, string cpf, string email, List<Endereco> Enderecos, List<Telefone> Telefones)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Email = email;
            this.Enderecos = Enderecos;
            this.Telefones = Telefones;
        }

        public Cliente(int cliente_id)
        {
            Enderecos = Endereco.ListarPorCliente(cliente_id);
            Telefones = Telefone.ListarPorCliente(cliente_id);
        }

        // Métodos
        public bool Inserir()
        {
            MySqlCommand cmd = null;
            bool teste = false;

            try
            {
                cmd = Banco.Abrir();

                cmd.CommandText = "insert clientes (nome, cpf, email, datacad, ativo) " +
                                   "values(@nome, @cpf, @email, default, default)";
                cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = Nome;
                cmd.Parameters.Add("@cpf", MySqlDbType.VarChar).Value = Cpf;
                cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = Email;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    cmd.CommandText = "select @@identity";
                    Id = Convert.ToInt32(cmd.ExecuteScalar());
                    teste = true;

                    foreach (var endereco in Enderecos)
                    {
                        endereco.Inserir(Id);
                    }

                    foreach (var telefone in Telefones)
                    {
                        telefone.Inserir(Id);
                    }
                }
            }
            catch (Exception)
            {
                // Mostra o erro
            }
            finally
            {
                Banco.Fechar(cmd);
            }

            return teste;
        }


        public void Atualizar()
        {
            var cmd = Banco.Abrir();

            cmd.CommandText = "update clientes set nome = @nome where id = " + Id;
            cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = Nome;
            cmd.ExecuteNonQuery();

            Banco.Fechar(cmd);
        }


        public static void Arquivar(int _id)
        {
            var cmd = Banco.Abrir();

            cmd.CommandText = "update clientes set ativo = 0 where id = " + _id;
            cmd.ExecuteNonQuery();

            Banco.Fechar(cmd);
        }


        public static void Restaurar(int _id)
        {
            var cmd = Banco.Abrir();

            cmd.CommandText = "update clientes set ativo = 1 where id = " + _id;
            cmd.ExecuteNonQuery();

            Banco.Fechar(cmd);
        }


        public int Excluir()
        {
            int msg = 0;
            var cmd = Banco.Abrir();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from clientes where id = " + Id;

            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    msg = 1;
                }
            }
            catch (Exception e)
            {
                if (e.Message.Contains("FOREIGN KEY"))
                    msg = 2;
            }

            Banco.Fechar(cmd);
            return msg;
        }


        public static List<Cliente> Listar(string nome = "", int ativo = 1) 
        {
            List<Cliente> lista = new List<Cliente>();

            var cmd = Banco.Abrir();

            if (nome.Length > 0)
                cmd.CommandText = "select * from clientes where nome like '%" + nome + "%' and ativo = " + ativo;
            else
                cmd.CommandText = "select * from clientes where ativo = " + ativo;

            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lista.Add(new Cliente(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetDateTime(4),
                        dr.GetBoolean(5),
                        Endereco.ListarPorCliente(),
                        Telefone.ListarPorCliente()
                   ));
            }

            Banco.Fechar(cmd);
            return lista;
        }


        public static Cliente ObterPorId(int _id)
        {
            Cliente cliente = null;
            var cmd = Banco.Abrir();

            cmd.CommandText = "select * from clientes where id = " + _id;
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cliente = new Cliente(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetDateTime(4),
                        dr.GetBoolean(5),
                        Endereco.ListarPorCliente(_id),
                        Telefone.ListarPorCliente(_id)
                    );
            }

            Banco.Fechar(cmd);
            return cliente;
        }

        public static List<Cliente> ObterPorIdLista(int _id)
        {
            Cliente item = null;
            List<Cliente> itens = new List<Cliente>();
            var cmd = Banco.Abrir();

            cmd.CommandText = "select * from clientes where id = @id";
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = _id;

            var dr = cmd.ExecuteReader();

            while (dr.Read())
            { 
                item = new Cliente(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetDateTime(4),
                        dr.GetBoolean(5)
                    );

                itens.Add(item);
            }

            Banco.Fechar(cmd);
            return itens;
        }
    }
}
