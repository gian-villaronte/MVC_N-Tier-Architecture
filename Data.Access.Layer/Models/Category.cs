﻿using System;
using System.Collections.Generic;

namespace Data.Access.Layer.Models
{
    public partial class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; }
    }
}
