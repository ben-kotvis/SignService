﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SignService.Models
{
    public class UpdateCreateSignServiceUserModel
    {
        [HiddenInput]
        public Guid ObjectId { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Display Name is required")]
        public string DisplayName { get; set; }
        public string Username { get; set; }
        public bool Configured { get; set; }
        public string KeyVaultUrl { get; set; }
        public string CertificateName { get; set; }
        public string TimestampUrl { get; set; }

        public IEnumerable<CertificateModel> CertificatesModels { get; set; }
    }
}
