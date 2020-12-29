using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WEBPOS_Reports.Models
{
    public class FileModel
    {
        [Required(ErrorMessage = "Παρακαλώ, επιλέξτε αρχείο !")]
        public HttpPostedFileBase File { get; set; }
        [Required(ErrorMessage = "Παρακαλώ, συμπληρώστε το όνομα της εκτύπωσης")]
        public string Url { get; set; }
        
    }
}