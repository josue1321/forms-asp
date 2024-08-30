using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
	public class Formulario
	{
		[Key]
		public int id { get; set; }

		[Required(ErrorMessage = "O nome é obrigatório.")]
		public string nome { get; set; }

		[Required(ErrorMessage = "A data de nascimento é obrigatória.")]
		[DataType(DataType.Date)]
        [Display(Name = "data de nascimento")]
        public DateOnly dataNasc { get; set; }

		[Required(ErrorMessage = "O telefone é obrigatório.")]
		[RegularExpression(@"^\d{10}$", ErrorMessage = "O telefone deve ter exatamente 10 dígitos.")]
		[DataType(DataType.PhoneNumber)]
		public string telefone { get; set; }  // Alterado para string para validação com regex

		[Required(ErrorMessage = "O e-mail é obrigatório.")]
		[EmailAddress(ErrorMessage = "O e-mail fornecido não é válido.")]
		public string email { get; set; }

		[Required(ErrorMessage = "O CEP é obrigatório.")]
		public string cep { get; set; }

		[Required(ErrorMessage = "O endereço é obrigatório.")]
		public string endereco { get; set; }

		[Required(ErrorMessage = "O número é obrigatório.")]
		[Range(1, int.MaxValue, ErrorMessage = "O número deve ser um valor positivo e maior que zero.")]
		public int numero { get; set; }

		[Required(ErrorMessage = "O complemento é obrigatório.")]
		public string complemento { get; set; }

		[Required(ErrorMessage = "O bairro é obrigatório.")]
		public string bairro { get; set; }

		[Required(ErrorMessage = "A cidade é obrigatória.")]
		public string cidade { get; set; }

		[Required(ErrorMessage = "O UF é obrigatório.")]
		public string uf { get; set; }
	}
}
