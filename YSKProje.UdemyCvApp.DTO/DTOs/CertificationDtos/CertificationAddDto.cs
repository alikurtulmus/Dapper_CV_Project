using System;
using System.Collections.Generic;
using System.Text;
using DTO.Interfaces;

namespace DTO.DTOs.CertificationDtos
{
    public  class CertificationAddDto :IDto
    {
        public string Description { get; set; }
    }
}
