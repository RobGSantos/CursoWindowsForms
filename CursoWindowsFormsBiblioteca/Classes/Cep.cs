
using Newtonsoft.Json;
using System.Text;

namespace CursoWindowsFormsBiblioteca.Classes
{
    public class Cep
    {
        public class Unit
        {
            public string cep { get; set; }
            public string logradouro { get; set; }
            public string complemento { get; set; }
            public string unidade { get; set; }
            public string bairro { get; set; }
            public string localidade { get; set; }
            public string uf { get; set; }
            public string estado { get; set; }
            public string regiao { get; set; }
            public string ibge { get; set; }
            public string gia { get; set; }
            public string ddd { get; set; }
            public string siafi { get; set; }
        }

        public static Unit DesSerializedUnit(string Json)
        {
            string corrigido = Encoding.UTF8.GetString(
                Encoding.GetEncoding("ISO-8859-1").GetBytes(Json));
            return JsonConvert.DeserializeObject<Unit>(corrigido);
        }

        public static string SerializedUnit(Unit unit)
        {
            return JsonConvert.SerializeObject(unit);
        }
    }
}
