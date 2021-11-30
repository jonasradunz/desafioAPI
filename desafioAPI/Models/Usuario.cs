using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace desafioAPI.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "É necessário informar um nome, com até 50 caracteres."), MaxLength(50)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "É necessário informar um e-mail.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "É necessário informar um celular (somente números: DDD + telefone)."), MinLength(11), MaxLength(11)]
        public string Telefone { get; set; }

    }
}