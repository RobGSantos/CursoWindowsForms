
using CursoWindowsFormsBiblioteca.DataBases;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Globalization;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;

namespace CursoWindowsFormsBiblioteca.Classes
{
    public class Cliente
    {
        public class Unit
        {
            [Required(ErrorMessage = "Código do Cliente é obrigatório!")]
            [RegularExpression("([0-9]+)", ErrorMessage = "Código do Cliente somente aceita valores numéricos.")]
            [StringLength(6, MinimumLength = 6, ErrorMessage = "Código do Cliente deve ter 6 dígitos")]
            public string Id { get; set; }

            [Required(ErrorMessage = "Nome do cliente é obrigatório!")]
            [StringLength(50, ErrorMessage = "Nome do Cliente deve ter no máximo 50 caracteres")]
            public string Nome { get; set; }

            [StringLength(50, ErrorMessage = "Nome do Pai do Cliente deve ter no máximo 50 caracteres")]
            public string NomePai { get; set; }

            [Required(ErrorMessage = "Nome da Mãe do Cliente é obrigatório!")]
            [StringLength(50, ErrorMessage = "Nome da Mãe do Cliente deve ter no máximo 50 caracteres")]
            public string NomeMae { get; set; }
            public bool NaoTemPai { get; set; }

            [Required(ErrorMessage = "CPF do Cliente é obrigatório!")]
            [RegularExpression("([0-9]+)", ErrorMessage = "CPF do Cliente somente aceita valores numéricos.")]
            [StringLength(11, MinimumLength = 11, ErrorMessage = "CPF do Cliente deve ter 11 dígitos")]
            public string CPF { get; set; }

            [Required(ErrorMessage = "Gênero do Cliente é obrigatório!")]
            public int Genero { get; set; }

            [Required(ErrorMessage = "CEP do Cliente é obrigatório!")]
            [RegularExpression("([0-9]+)", ErrorMessage = "CEP do Cliente somente aceita valores numéricos.")]
            [StringLength(8, MinimumLength = 8, ErrorMessage = "CEP do Cliente deve ter 8 dígitos")]
            public string CEP { get; set; }

            [Required(ErrorMessage = "Logradouro do cliente é obrigatório!")]
            [StringLength(100, ErrorMessage = "Logradouro do Cliente deve ter no máximo 100 caracteres")]
            public string Logradouro { get; set; }

            [Required(ErrorMessage = "Complemento do cliente é obrigatório!")]
            [StringLength(100, ErrorMessage = "Complemento do Cliente deve ter no máximo 100 caracteres")]
            public string Complemento { get; set; }

            [Required(ErrorMessage = "Bairro do cliente é obrigatório!")]
            [StringLength(50, ErrorMessage = "Bairro do Cliente deve ter no máximo 50 caracteres")]
            public string Bairro { get; set; }

            [Required(ErrorMessage = "Cidade do cliente é obrigatório!")]
            [StringLength(50, ErrorMessage = "Cidade do Cliente deve ter no máximo 50 caracteres")]
            public string Cidade { get; set; }

            [Required(ErrorMessage = "Estado do cliente é obrigatório!")]
            [StringLength(50, ErrorMessage = "Estado do Cliente deve ter no máximo 50 caracteres")]
            public string Estado { get; set; }

            [Required(ErrorMessage = "Telefone do Cliente é obrigatório!")]
            [RegularExpression("([0-9]+)", ErrorMessage = "Telefone do Cliente somente aceita valores numéricos.")]
            public string Telefone { get; set; }
            public string Profissao { get; set; }

            [Required(ErrorMessage = "Renda Familiar do Cliente é obrigatório!")]
            [Range(0, double.MaxValue, ErrorMessage = "Renda Familiar deve ser um valor positivo")]
            public double RendaFamiliar { get; set; }

            public void ValidaClasse()
            {
                ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
                List<ValidationResult> results = new List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(this, context, results, true);

                if (isValid == true) return;

                StringBuilder sbrErrors = new StringBuilder();
                foreach (var validationResult in results)
                {
                    sbrErrors.AppendLine(validationResult.ErrorMessage);
                }
                throw new ValidationException(sbrErrors.ToString());
            }

            public void ValidaComplemento()
            {
                if (NomePai == NomeMae)
                    throw new Exception("Nome do Pai e da Mãe não podem ser iguais.");

                if (NaoTemPai == false && NomePai == "") throw new Exception("Nome do Pai não pode estar vazio quando a propriedade Pai Desconhecido não estiver marcada.");
                
                bool validaCPF = Cls_Uteis.Valida(CPF);
            }

            #region "CRUD do Fichario"

            public void IncluirFichario(string conexao)
            {
                string clienteJson = SerializedUnit(this);
                Fichario F = new Fichario(conexao);

                if (!F.status) throw new Exception(F.mensagem);

                F.Incluir(Id, clienteJson);

                if (!F.status) throw new Exception(F.mensagem);

            }

            public Unit BuscarFichario(string conexao, string vId)
            {
                Fichario F = new Fichario(conexao);
                if (!F.status) throw new Exception(F.mensagem);

                var clienteJson = F.Buscar(vId);
                if (!F.status) throw new Exception(F.mensagem);

                var cliente = DesSerializedUnit(clienteJson);

                return cliente;

            }

            public void AlterarFormulario(string conexao)
            {
                Fichario F = new Fichario(conexao);
                if (!F.status) throw new Exception(F.mensagem);

                string clienteJson = SerializedUnit(this);

                F.Alterar(Id, clienteJson);
                if (!F.status) throw new Exception(F.mensagem);
            }

            public void ApagarFormulario(string conexao)
            {
                Fichario F = new Fichario(conexao);
                if (!F.status) throw new Exception(F.mensagem);

                F.Excluir(Id);
                if (!F.status) throw new Exception(F.mensagem);

            }

            public List<string> ListaFichario(string conexao)
            {
                Fichario F = new Fichario(conexao);
                if (!F.status) throw new Exception(F.mensagem);

                List<string> todosJson = F.BuscarTodos();
                if (!F.status) throw new Exception(F.mensagem);

                return todosJson;

            }

            #endregion

            #region "CRUD do Fichario LocalDB"

            public void IncluirFicharioDB(string tabela)
            {
                string clienteJson = SerializedUnit(this);

                FicharioDB F = new FicharioDB(tabela);
                if (!F.status) throw new Exception(F.mensagem);

                var buscaID = F.Buscar(Id);
                if (!string.IsNullOrEmpty(buscaID)) throw new Exception($"Já existe um registro com o identificador {Id}");
 
                F.Incluir(Id, clienteJson);

                if (!F.status) throw new Exception(F.mensagem);

            }

            public Unit BuscarFicharioDB(string tabela, string vId)
            {
                FicharioDB F = new FicharioDB(tabela);
                if (!F.status) throw new Exception(F.mensagem);

                var clienteJson = F.Buscar(vId);
                if (!F.status) throw new Exception(F.mensagem);
                Console.WriteLine(clienteJson);
                clienteJson = clienteJson.Replace("\"{{", "{{").Replace("}}\"", "}}");
                var cliente = DesSerializedUnit(clienteJson);

                return cliente;

            }

            public void AlterarFormularioDB(string tabela)
            {
                FicharioDB F = new FicharioDB(tabela);
                if (!F.status) throw new Exception(F.mensagem);

                string clienteJson = SerializedUnit(this);

                F.Alterar(Id, clienteJson);
                if (!F.status) throw new Exception(F.mensagem);
            }

            public void ApagarFormularioDB(string tabela)
            {
                FicharioDB F = new FicharioDB(tabela);
                if (!F.status) throw new Exception(F.mensagem);

                F.Excluir(Id);
                if (!F.status) throw new Exception(F.mensagem);

            }

            public List<string> ListaFicharioDB(string tabela)
            {
                FicharioDB F = new FicharioDB(tabela);
                if (!F.status) throw new Exception(F.mensagem);

                List<string> todosJson = F.BuscarTodos();
                if (!F.status) throw new Exception(F.mensagem);

                return todosJson;

            }

            #endregion

            #region "CRUD do Fichario SQLServer"

            public void IncluirFicharioSQLServer(string tabela)
            {
                string clienteJson = SerializedUnit(this);

                FicharioSQLServer F = new FicharioSQLServer(tabela);
                if (!F.status) throw new Exception(F.mensagem);

                var buscaID = F.Buscar(Id);
                if (!string.IsNullOrEmpty(buscaID)) throw new Exception($"Já existe um registro com o identificador {Id}");

                F.Incluir(Id, clienteJson);

                if (!F.status) throw new Exception(F.mensagem);

            }

            public Unit BuscarFicharioSQLServer(string tabela, string vId)
            {
                FicharioSQLServer F = new FicharioSQLServer(tabela);
                if (!F.status) throw new Exception(F.mensagem);

                var clienteJson = F.Buscar(vId);
                if (!F.status) throw new Exception(F.mensagem);
                Console.WriteLine(clienteJson);
                clienteJson = clienteJson.Replace("\"{{", "{{").Replace("}}\"", "}}");
                var cliente = DesSerializedUnit(clienteJson);

                return cliente;

            }

            public void AlterarFormularioSQLServer(string tabela)
            {
                FicharioSQLServer F = new FicharioSQLServer(tabela);
                if (!F.status) throw new Exception(F.mensagem);

                string clienteJson = SerializedUnit(this);

                F.Alterar(Id, clienteJson);
                if (!F.status) throw new Exception(F.mensagem);
            }

            public void ApagarFormularioSQLServer(string tabela)
            {
                FicharioSQLServer F = new FicharioSQLServer(tabela);
                if (!F.status) throw new Exception(F.mensagem);

                F.Excluir(Id);
                if (!F.status) throw new Exception(F.mensagem);

            }

            public List<string> ListaFicharioSQLServer(string tabela)
            {
                FicharioSQLServer F = new FicharioSQLServer(tabela);
                if (!F.status) throw new Exception(F.mensagem);

                List<string> todosJson = F.BuscarTodos();
                if (!F.status) throw new Exception(F.mensagem);

                return todosJson;

            }

            #endregion

            #region "CRUD do Fichario SQLServer relacional"

            #region "Funções Auxíliares"
            public string ToInsert()
            {
                string sql = $@"INSERT INTO TB_Cliente
                                (Id, 
                                Nome, 
                                NomePai, 
                                NomeMae,
                                NaoTemPai, 
                                CPF, 
                                Genero, 
                                CEP, 
                                Logradouro, 
                                Complemento, 
                                Bairro, 
                                Cidade, 
                                Estado, 
                                Telefone, 
                                Profissao, 
                                RendaFamiliar) 
                                VALUES ";
                sql += $@"( '{Id}', 
                            '{Nome}', 
                            '{NomePai}', 
                            '{NomeMae}',
                            {NaoTemPai}, 
                            '{CPF}', 
                            {Genero}, 
                            '{CEP}', 
                            '{Logradouro}', 
                            '{Complemento}', 
                            '{Bairro}', 
                            '{Cidade}', 
                            '{Estado}', 
                            '{Telefone}', 
                            '{Profissao}', 
                            {RendaFamiliar})";
                return sql;
            }

            public string ToUpdate(string pId)
            {
                string sql = $@"UPDATE TB_Cliente 
                                SET 
                                Nome = '{Nome}',
                                NomePai = '{NomePai}',
                                NomeMae = '{NomeMae}',
                                NaoTemPai = {NaoTemPai},
                                CPF = '{CPF}',
                                Genero = {Genero},
                                CEP = '{CEP}',
                                Logradouro = '{Logradouro}',
                                Complemento = '{Complemento}',
                                Bairro = '{Bairro}',
                                Cidade = '{Cidade}',
                                Estado = '{Estado}',
                                Telefone = {Telefone},
                                Profissao = '{Profissao}',
                                RendaFamiliar = {RendaFamiliar} 
                                WHERE Id= '{pId}'";
                return sql;
            }

            public Unit DataRowToUnit(DataRow dr)
            {
                Unit u = new Unit();
                u.Nome = dr["Nome"].ToString();
                u.NomePai = dr["NomePai"].ToString();
                u.NomeMae = dr["NomeMae"].ToString();
                u.NaoTemPai = Convert.ToBoolean(dr["NaoTemPai"]);
                u.CPF = dr["CPF"].ToString() ;
                u.Genero = Convert.ToInt32(dr["Genero"]);
                u.CEP = dr["CEP"].ToString();
                u.Logradouro = dr["Logradouro"].ToString();
                u.Complemento = dr["Complemento"].ToString();
                u.Bairro = dr["Bairro"].ToString();
                u.Cidade = dr["Cidade"].ToString();
                u.Estado = dr["Estado"].ToString();
                u.Telefone = dr["Telefone"].ToString();
                u.Profissao = dr["Profissao"].ToString();
                u.RendaFamiliar = Convert.ToDouble(dr["RendaFamiliar"]);
                return u;
            }
            #endregion

            public void IncluirFicharioSQLRel()
            {
                try
                {
                    var sql = ToInsert();
                    var db = new SQLServerClass();
                    db.SQLCommand(sql);
                    db.Close();

                }
                catch (Exception ex)
                {
                    throw new Exception($"Inclusão não permitida para o identificador {Id}. Erro: {ex.Message}");
                }
            }

            public Unit BuscarFicharioSQLRel(string pId)
            {
                try
                {
                    var sql = $@"SELECT (Id, 
                                Nome, 
                                NomePai, 
                                NomeMae,
                                NaoTemPai, 
                                CPF, 
                                Genero, 
                                CEP, 
                                Logradouro, 
                                Complemento, 
                                Bairro, 
                                Cidade, 
                                Estado, 
                                Telefone, 
                                Profissao, 
                                RendaFamiliar)
                                FROM TB_CLIENTE 
                                WHERE ID = {pId}";

                    var db = new SQLServerClass();
                    var dt = db.SQLQuery(sql);

                    if (dt.Rows.Count.Equals(0))
                    {
                        db.Close();
                        throw new Exception();
                    }
                    Unit C = DataRowToUnit(dt.Rows[0]);
                    return C;
                }
                catch (Exception ex)
                {
                    
                    throw new Exception($"Nenhum registro encontrado para o identificador {pId}. Erro: {ex.Message}");   
                }
            }

            public void AlterarFormularioSQLRel(string pId)
            {
                try
                {
                    var sql = $@"SELECT (Id, 
                                Nome, 
                                NomePai, 
                                NomeMae,
                                NaoTemPai, 
                                CPF, 
                                Genero, 
                                CEP, 
                                Logradouro, 
                                Complemento, 
                                Bairro, 
                                Cidade, 
                                Estado, 
                                Telefone, 
                                Profissao, 
                                RendaFamiliar)
                                FROM TB_CLIENTE 
                                WHERE ID = {pId}";

                    var db = new SQLServerClass();
                    var dt = db.SQLQuery(sql);

                    if (dt.Rows.Count.Equals(0))
                    {
                        db.Close(); 
                        throw new Exception($"Nenhum registro encontrado para o identificador {pId}");
                    }
                    sql = ToUpdate(pId);
                    db.SQLCommand(sql);
                    db.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception($"Não foi possível alterar o formulário do identificador {pId}. Erro: {ex.Message}");
                }
            }

            public void ApagarFormularioSQLRel()
            {
                try
                {
                    var sql = $@"SELECT (Id, 
                                    Nome, 
                                    NomePai, 
                                    NomeMae,
                                    NaoTemPai, 
                                    CPF, 
                                    Genero, 
                                    CEP, 
                                    Logradouro, 
                                    Complemento, 
                                    Bairro, 
                                    Cidade, 
                                    Estado, 
                                    Telefone, 
                                    Profissao, 
                                    RendaFamiliar)
                                    FROM TB_CLIENTE 
                                    WHERE ID = {Id}";

                    var db = new SQLServerClass();
                    var dt = db.SQLQuery(sql);

                    if (dt.Rows.Count.Equals(0))
                    {
                        db.Close();
                        throw new Exception($"Nenhum registro encontrado para o identificador {Id}");
                    }

                    sql = $"DELETE FROM [TB_CLIENTE] WHERE ID = '{Id}'";
                    db.SQLCommand(sql);
                    db.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception($"Não foi possível excluir o formulário do identificador {Id}. Erro: {ex.Message}");
                }
                
            }

            public List<List<string>> ListaFicharioSQLServer()
            {
                try
                {
                    var sql = $@"SELECT [ID], [NOME] FROM [TB_CLIENTE]";
                    var db = new SQLServerClass();
                    var dt = db.SQLQuery(sql);
                    
                    if (dt.Rows.Count.Equals(0))
                    {
                        db.Close();
                        throw new Exception("Nenhum registro encontrado no Banco de Dados!");
                    }

                    var listBusca = new List<List<string>>();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        listBusca.Add(new List<string>{dt.Rows[i]["ID"].ToString(), dt.Rows[i]["Nome"].ToString()});
                    }
                    db.Close();
                    return listBusca;
                }
                catch (Exception ex)
                {
                    throw new Exception($"Erro ao buscar registros no Banco de Dados: {ex.Message}");
                }

            }


            #endregion

        }

        public class Lista
        {
            public List<Unit> ListUnit { get; set; }
        }

        public static Unit DesSerializedUnit(string Json)
        {
            //string corrigido = Encoding.UTF8.GetString(
            //    Encoding.GetEncoding("ISO-8859-1").GetBytes(Json));
            var settings = new JsonSerializerSettings
            {
                Formatting = Formatting.None,                 // ou Formatting.Indented
                NullValueHandling = NullValueHandling.Include,
                DefaultValueHandling = DefaultValueHandling.Include,
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = DateTimeZoneHandling.RoundtripKind,
                Culture = CultureInfo.InvariantCulture
            };

            return JsonConvert.DeserializeObject<Unit>(Json, settings);
        }

        public static string SerializedUnit(Unit unit)
        {
            var settings = new JsonSerializerSettings
            {
                Formatting = Formatting.None,                 // ou Formatting.Indented
                NullValueHandling = NullValueHandling.Include,
                DefaultValueHandling = DefaultValueHandling.Include,
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = DateTimeZoneHandling.RoundtripKind,
                Culture = CultureInfo.InvariantCulture
            };
            return JsonConvert.SerializeObject(unit, settings);
        }
    }
}
