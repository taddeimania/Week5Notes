using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Day3MVCTemplate.Models
{
    public class Review
    {
        public int Id { get; set; }

        [DisplayName("What is your name?")]
        public string ReviewerName { get; set; }

        [DisplayName("How was your experience?")]
        public string Message { get; set; }

        public int Rating { get; set; }
    }

    public class ReviewContext : DbContext
    {
        public DbSet<Review> Reviews { get; set; }
    }
}