using System;

namespace SmartSignature.Models
{
    public class Device
    {
        int DeviceId { get; set; }
        int DeviceName { get; set; }
        int ActivationCode { get; set; }
        DateTime ActivationDate { get; set; }
        User CaixaAccount { get; set; }
    }
}