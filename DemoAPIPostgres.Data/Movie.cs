﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAPIPostgres.Data
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public int Year { get; set; }
        public string Summery { get; set; }

        public List<Actor> Actors { get; set; }
    }

    public class Actor
    {
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
    }
}
