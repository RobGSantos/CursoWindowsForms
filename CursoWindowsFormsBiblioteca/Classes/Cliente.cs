
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CursoWindowsFormsBibliotecas.Classes
{
    public class Cliente
    {
        public class Unit
        {
            [Required(ErrorMessage = "Código do cliente é obrigatório!")]
            public string Id { get; set; }

            public string Nome { get; set; }
            public string NomePai { get; set; }
            public string NomeMae { get; set; }
            public bool TemPai { get; set; }
            public string CPF { get; set; }
            public int Genero { get; set; }
            public string CEP { get; set; }
            public string Logradouro { get; set; }
            public string Complemento { get; set; }
            public string Bairro { get; set; }
            public string Cidade { get; set; }
            public string Estado { get; set; }
            public string Telefone { get; set; }
            public string Profissao { get; set; }
            public double RendaFamiliar { get; set; }

            public void ValidaClasse()
            {
                ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
                List<ValidationResult> results = new List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(this, context, results, true);

                if (isValid == false)
                {
                    StringBuilder sbrErrors = new StringBuilder();
                    foreach (var validationResult in results)
                    {
                        sbrErrors.AppendLine(validationResult.ErrorMessage);
                    }
                    throw new ValidationException(sbrErrors.ToString());
                }
            }

        }

        public class List
        {
            public List<Unit> ListUnit { get; set; }
        }
    }
}
