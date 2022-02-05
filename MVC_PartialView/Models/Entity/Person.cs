﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MVC_PartialView.Models
{
    //Persons Information. Each person should have a name,
    //phonenumber, city and Id(generated by the system)
    public class Person
    {
       
        public int Id { get; set; }

        
        public string Name { get; set; }
     
        public long PhoneNumber { get; set; }
     
        public string City { get; set; }
        
    }
}