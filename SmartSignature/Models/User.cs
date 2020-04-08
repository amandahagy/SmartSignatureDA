using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace SmartSignature.Models
{
    [Table("T_SSS_USER")]
    public class User
    {
        [Key]
        [Column("DS_CAIXA_ACCOUNT")]
        [Required(ErrorMessage = "The Caixa's account is mandatory.")]
        [Display(Name="Caixa's account:")]
        public int CaixaAccount { get; set; } //Caixa's the national bank account
        [Required(ErrorMessage = "The password is mandatory.")]
        [Display(Name = "Password:")]
        [Column("DS_PASSWORD")]
        public int Password { get; set; }
        [Display(Name = "Full name:")]
        [Column("NM_NAME")]
        public string Name { get; set; }
        [Display(Name = "RG:")]
        [Column("DS_RG")]
        public int Rg { get; set; } //RG is the national ID number
        [Display(Name = "CPF:")]
        [Column("DS_CPF")]
        public long Cpf { get; set; } //CPF is another ID number for Brazilian citizens
        public IList<Device> Devices { get; set; }
    }
}