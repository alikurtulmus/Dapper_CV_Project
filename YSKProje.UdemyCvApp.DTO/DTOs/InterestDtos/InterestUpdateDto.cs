using System;
using System.Collections.Generic;
using System.Text;
using DTO.Interfaces;

namespace DTO.DTOs.InterestDtos
{
    public class InterestUpdateDto : IDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
