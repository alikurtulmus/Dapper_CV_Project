using System;
using System.Collections.Generic;
using System.Text;
using DTO.Interfaces;

namespace DTO.DTOs.AppUserDtos
{
    public class AppUserPasswordDto : IDto
    {
        public int Id { get; set; }
        public string Password { get; set; }

        public string CofirmPassword { get; set; }
    }
}
