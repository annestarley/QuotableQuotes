using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace QuotableQuotes.Models
{
    public class Quotes
    {
        [Display(Name="Your name:")]
        public string YourName { get; set; }
        [Display(Name="Your quote:")]
        public string YourQuote { get; set; }
    }
}