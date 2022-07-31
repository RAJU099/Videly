using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Videly.Models;

namespace Videly.ViewModel
{
    public class RandomViewModel
    {
        public Movies movies { set; get; }

        public List<Customer> Customers { get; set; }
    }
}