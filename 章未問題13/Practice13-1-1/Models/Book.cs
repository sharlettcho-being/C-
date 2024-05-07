﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice13_1_1.Models {
    public class Book {
        public int Id { get; set; }
        public string Title { get; set; }
        public int PublishedYear { get; set; }
        public virtual Author Author { get; set; }
    }
}
