using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoWindowsFormsBiblioteca.DataBases
{
    public class Fichario
    {

        public string diretorio;
        public string mensagem;
        public bool status;

        public Fichario(string Diretorio)
        {
            status = true;
            try
            {
                if (!Directory.Exists(Diretorio))
                    Directory.CreateDirectory(Diretorio);

                diretorio = Diretorio;

                mensagem = "Conexão com o fichário criado com sucesso";
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = $"Conexão com o fichário gerou erro: {ex.Message}";
            }
        }

        public void Incluir(string Id, string jsonUnit)
        {
            try
            {
                status = true;

                if (File.Exists($"{diretorio}\\{Id}.json"))
                {
                    status = false;
                    mensagem = $"Inclusão não permitida. O Identificador {Id} já existe na pasta";
                    return;
                }

                File.WriteAllText($"{diretorio}\\{Id}.json", jsonUnit);
                status = true;
                mensagem = $"Inclusão efetuada com sucesso. Identificador {Id}";

            }
            catch (Exception ex)
            {
                status = false;
                mensagem = $"Conexão com o fichário gerou erro: {ex.Message}";
            }
        }

        public string Buscar(string Id)
        {
            status = true;

            try
            {
                if (!File.Exists($"{diretorio}\\{Id}.json"))
                {
                    status = false;
                    mensagem = $"Não foi encontrado o formulário do  Identificador {Id}!";
                    return string.Empty;
                }
                status = true;

                var jsonUnit = File.ReadAllText($"{diretorio}\\{Id}.json");
                mensagem = $"Formulário encontrado com sucesso. Identificador {Id}";
                return jsonUnit;

            }
            catch (Exception ex)
            {
                status = false;
                mensagem = $"Erro ao buscar o conteúdo do identificador {Id}: {ex.Message}";
                return string.Empty;
            }
        }

        public void Excluir(string Id)
        {
            status = true;

            try
            {
                if (!File.Exists($"{diretorio}\\{Id}.json"))
                {
                    status = false;
                    mensagem = $"Não foi encontrado o formulário do  Identificador {Id}!";
                    return;
                }
                status = true;

                File.Delete($"{diretorio}\\{Id}.json");
                mensagem = $"Formulário excluído com sucesso. Identificador {Id}";

            }
            catch (Exception ex)
            {
                status = false;
                mensagem = $"Erro ao buscar o conteúdo do identificador {Id}: {ex.Message}";
            }
            return;
        }
    }
}
