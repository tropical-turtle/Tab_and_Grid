﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace TabTest
{
    public partial class CertificateType
    {
        public CertificateType()
        {
            Submissions = new HashSet<Submission>();
        }

        public int CertificateTypeId { get; set; }
        public string CertificateTypeCd { get; set; }
        public string NameEnglish { get; set; }
        public string NameFrench { get; set; }

        public virtual ICollection<Submission> Submissions { get; set; }
    }
}