﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AbhisBooks.Models
{
    public class Category
    {
        [Key]
        public object Id { get; set; }
        [Display(Name ="Category Name")]
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
