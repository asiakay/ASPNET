using System;
using System.Collections.Generic;
using Dapper;
using Dapper.Contrib.Extensions;
using ASPNET;
using ASPNET.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNET.Models
{
    public class Review
    {
        public Review()
        { 
        }
        [Dapper.Contrib.Extensions.Key]
        public int ReviewID { get; set; }
        public int ProductID { get; set; }
        public string Reviewer { get; set; }
        public IEnumerable<Rating>Ratings { get; set; }
        public string Comment { get; set; }
        public IEnumerable<Category>Categories { get; set; }


    }
}
