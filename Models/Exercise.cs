using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace vrgoserver.Models 
{
    public class Exercise{
        public string description {get;set;}
        public string[] instruction {get;set;}
        public string images {get;set;}
        }
}