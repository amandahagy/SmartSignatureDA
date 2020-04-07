using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartSignature.Models
{
    [Table("t_sss_user")]
    public class User
    {
        [Key]
        [Column("ds_caixa_account")]
        [Required(ErrorMessage = "The Caixa's account is mandatory.")]
        [Display(Name="Caixa's account:")]
        public int CaixaAccount { get; set; } //Caixa's account is the national bank account
        [Required(ErrorMessage = "The password is mandatory.")]
        [Display(Name = "Password:")]
        [Column("ds_password")]
        public int Password { get; set; }
        [Display(Name = "Full name:")]
        [Column("nm_name")]
        public string Name { get; set; }
        [Display(Name = "RG:")]
        [Column("ds_rg")]
        public int Rg { get; set; } //RG is the national ID number
        [Display(Name = "CPF:")]
        [Column("ds_cpf")]
        public long Cpf { get; set; } //CPF is another ID number for Brazilian citizens
    }
}