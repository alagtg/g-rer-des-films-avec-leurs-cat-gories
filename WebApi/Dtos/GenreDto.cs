﻿using System.ComponentModel.DataAnnotations;

namespace WebApi.Dtos
{
    public class GenreDto
    {
        [MaxLength(100)]
        public string Name { get; set; }
    }
}
