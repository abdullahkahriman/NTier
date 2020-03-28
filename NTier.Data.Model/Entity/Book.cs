using NTier.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NTier.Data.Model.Entity
{
    public class Book : Table
    {
        [Required]
        public string Title { get; set; }
        [StringLength(250)]
        public string ShortDescription { get; set; }
        public string Description { get; set; }
    }
}