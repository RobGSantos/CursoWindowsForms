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
                mensagem = $"Conexão com o fichário gerou erro: {ex.Message}" ;
            }
        }


    }
}
