﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entity
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string VoterName { get; set; }
        public int StarCount { get; set; }
        public string Comment { get;set; }
        public int BookId { get; set; }
    }
}
