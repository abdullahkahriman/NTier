using NTier.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace NTier.Data.Model.Entity
{
    public class Book : Table
    {
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
    }
}