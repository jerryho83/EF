using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;
using Alanda.Models;

namespace Alanda.ViewModels
{
    public class GigFormViewModel
    {
        [Required]
        public string Vanue { get; set; }
        [Required]
        public string Date { get; set; }
        [Required]
        public string Time { get; set; }
        [Required]
        public byte Genre { get; set; }
        public IEnumerable<Genre> Genres { get; set; }

        public DateTime? GetDateTime()
        {
            DateTime parsedValue;
            if (DateTime.TryParse(string.Format("{0} {1}", Date, Time), out parsedValue))
            {
                return parsedValue;
            }
            return null;
        }
    }
}