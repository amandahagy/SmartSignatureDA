using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartSignature.Models
{
    [Table("T_SSS_DEVICE")]
    public class Device
    {
        [Key]
        [Column("ID_DEVICE")]
        public int DeviceId { get; set; }
        [Column("NM_DEVICE_NAME")]
        public string DeviceName { get; set; }
        [Column("CD_ACTIVATION")]
        public int ActivationCode { get; set; }
        [Column("DT_ACTIVATION")]
        public DateTime ActivationDate { get; set; }
        [Column("DS_CAIXA_ACCOUNT")]
        public int CaixaAccount { get; set; }
        public User Account { get; set; }
    }
}