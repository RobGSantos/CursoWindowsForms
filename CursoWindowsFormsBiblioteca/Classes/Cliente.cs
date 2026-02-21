
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
                    throw new Exception("Nome do Pai e da Mãe não podem ser iguais");

                if (NaoTemPai == false && NomePai == "") throw new Exception("Nome do Pai não pode estar vazio quando a propriedade Pai Desconhecido não estiver marcada");
                
                bool validaCPF = Cls_Uteis.Valida(CPF);
            }

        }

        public class List
        {
            public List<Unit> ListUnit { get; set; }
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
