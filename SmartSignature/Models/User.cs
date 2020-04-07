using System;
using System.ComponentModel.DataAnnotations;

namespace SmartSignature.Models
{
    public class User
    {
        [Required(ErrorMessage = "The Caixa's account is mandatory.")]
        [Display(Name="Caixa's account:")]
        public int CaixaAccount { get; set; } //Caixa's account is the national bank account
        [Required(ErrorMessage = "The password is mandatory.")]
        [Display(Name = "Password:")]
        public int Password { get; set; }
        [Display(Name = "Full name:")]
        public string Name { get; set; }
        [Display(Name = "RG:")]
        public int Rg { get; set; } //RG is the national ID number
        [Display(Name = "CPF:")]
        public long Cpf { get; set; } //CPF is another ID number for Brazilian citizens
    }
}