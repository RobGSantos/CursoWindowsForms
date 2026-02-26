

using System;
using System.Collections.Generic;
using System.IO;

namespace CursoWindowsFormsBiblioteca.DataBases
{
    public class FicharioDB
    {
        public string mensagem;
        public bool status;
        public string tabela;
        public LocalDBClass db;

        public FicharioDB(string pTabela)
        {
            status = true;
            tabela = pTabela;
            try
            {
                db = new LocalDBClass();
                
                mensagem = "Conexão com a Tabela criada com sucesso!";

            }
            catch (Exception ex)
            {
                status=false;
                mensagem = $"Conexão com a Tabela gerou um erro: {ex.Message}";
            }
        }


        public void Incluir(string Id, string jsonUnit)
        {
            status = true;
            try
            {
                var sql = $"INSERT INTO [{tabela}](Id, JSON) VALUES ('{Id}', '{jsonUnit}')";
                db.SQLCommand(sql);
                mensagem = $"Inclusão efetuada com sucesso. Identificador {Id}";

                sql = $@"SELECT JSON FROM [{tabela}] WHERE ID = '{Id}'";
                var dt = db.SQLQuery(sql);

                if (dt.Rows.Count == 0)
                    throw new Exception($"Nenhum registro com o identificador {Id} foi localizado!");

                jsonUnit = dt.Rows[0]["JSON"].ToString();
                mensagem += $"\n {jsonUnit}";


            }
            catch (Exception ex)
            {
                status = false;
                mensagem = $"A função gerou erro: {ex.Message}";
            }
        }

        public string Buscar(string Id)
        {
            status = true;
            try
            {

                var sql = $@"SELECT JSON FROM [{tabela}] WHERE ID = '{Id}'";
                var dt = db.SQLQuery(sql);

                if (dt.Rows.Count == 0)
                    throw new Exception($"Nenhum registro com o identificador {Id} foi localizado!");

                var jsonUnit = dt.Rows[0]["JSON"].ToString();

                mensagem = $"Formulário encontrado com sucesso. Identificador {Id}";
                return jsonUnit;

            }
            catch (Exception ex)
            {
                status = false;
                mensagem = ex.Message;
                return string.Empty;
            }
        }

        public List<string> BuscarTodos()
        {
            status = true;
            List<string> list = new List<string>();
            try
            {
                var sql = $@"SELECT JSON FROM [{tabela}]";
                var dt = db.SQLQuery(sql);

                if (dt.Rows.Count == 0)
                    throw new Exception ($"Nenhum registro foi localizado na Tabela {tabela}!");
                
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    var jsonUnit = dt.Rows[i]["JSON"].ToString();
                    list.Add(jsonUnit);
                }

            }
            catch (Exception ex)
            {
                status = false;
                mensagem = ex.Message;
            }

            return list;
        }

        public void Excluir(string Id)
        {
            status = true;
            try
            {
                var sql = $@"SELECT COUNT(*) AS [CONTAGEM] FROM [{tabela}] WHERE ID = '{Id}'";
                var dt = db.SQLQuery(sql);

                if (dt.Rows[0]["CONTAGEM"].Equals("0"))
                    throw new Exception($"Nenhum registro com o identificador {Id} foi localizado!");

                sql = $@"DELETE FROM [{tabela}] WHERE ID = '{Id}'";
                db.SQLCommand(sql);
                mensagem = $"Formulário excluído com sucesso. Identificador {Id}";

            }
            catch (Exception ex)
            {
                status = false;
                mensagem = $"Erro ao buscar o conteúdo do identificador {Id}: {ex.Message}";
            }
        }
        public void Alterar(string Id, string clienteJson)
        {
            status = true;
            tabela = "CLIENTE";
            try
            {
                var sql = $@"SELECT COUNT(*) AS [CONTAGEM] FROM [{tabela}] WHERE ID = '{Id}'";
                var dt = db.SQLQuery(sql);

                if (dt.Rows[0]["CONTAGEM"].Equals("0"))
                    throw new Exception($"Nenhum registro com o identificador {Id} foi localizado!");

                sql = $@"UPDATE [{tabela}] SET JSON = '{clienteJson}' WHERE ID = '{Id}'";
                db.SQLCommand(sql);

                mensagem = $"Alteração efetuada com sucesso. Identificador {Id}";

            }
            catch (Exception ex)
            {
                status = false;
                mensagem = $"Conexão com o fichário gerou erro: {ex.Message}";
            }
        }
    }
}
