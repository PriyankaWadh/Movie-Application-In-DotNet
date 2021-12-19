using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyFirstApplication.Models;
namespace MyFirstApplication.ViewModel
{
    public class RandomViewmodel
    {
        public Movie movie { get; set; }
        public List<Customer> customers { get; set; }
    }
}