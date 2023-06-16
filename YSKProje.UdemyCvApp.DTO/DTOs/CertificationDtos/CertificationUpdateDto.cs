using System;
using System.Collections.Generic;
using System.Text;
using DTO.Interfaces;

namespace DTO.DTOs.CertificationDtos
{
    public class CertificationUpdateDto : IDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
