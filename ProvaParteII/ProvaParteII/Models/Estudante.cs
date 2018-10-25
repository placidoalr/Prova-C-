using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProvaParteII.Models
{
	public class Estudante
	{
		public int id { get; set; }

		[Required(ErrorMessage = "Campo Obrigatório")]
		public string Nome { get; set; }

		[Required(ErrorMessage = "Campo Obrigatório")]
		[MinLength(5, ErrorMessage = " Matricula Deve conter no minimo 5 caracteres")]
		public string Matricula { get; set; }

		[Required(ErrorMessage = "Campo Obrigatório")]
		[Range(18, 150)]
		public int Idade { get; set; }

		[Required(ErrorMessage = "Campo Obrigatório")]
		[DisplayName("CPF")]
		public string Cpf { get; set; }
	}
}