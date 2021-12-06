using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace DojoSurvey.Models.Home
{
    public class Survey
    {
        [Required(ErrorMessage = "Please provide a name")]
        [MinLength(2, ErrorMessage = "Please provide a name with at least 2 characters")]
        public string StudentName {get; set; }

        [Required(ErrorMessage = "Please provide a location")]
        public string Location {get; set; }

        [Required(ErrorMessage = "Please provide a favorite language")]
        public string FavLanguage {get; set; }

        [MinLength(20, ErrorMessage = "Please provide a comment with at least 20 characters")]
        public string Comment {get; set; }
    }
}