using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LonghornCinemaProject.Models
{
    public class Reviews
    {
        // Primary Key
        [Required(ErrorMessage = "Reviewer ID is required")]
        [Display(Name = "Reviewer ID")]
        public Int32 ReviewID { get; set; }

        // Foreign Key
        [Required(ErrorMessage = "Movie ID is required")]
        [Display(Name = "Movie ID")]
        public Int32 MovieID { get; set; }

        //Foreign Key
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Enter a valid customer email address")]
        [Display(Name = "Email Address")]
        public String CustomerEmail { get; set; }

        [Display(Name = "Score")]
        public Decimal ReviewScore { get; set; }

        [Display(Name = "Review")]
        public String WrittenReview { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Please enter a valid time of review")]
        [Display(Name = "Written on")]
        [DisplayFormat(DataFormatString = "{0:mm/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ReviewTime { get; set; }

        [Display(Name = "")]
        public Boolean ReviewerVote { get; set; }
    }
}