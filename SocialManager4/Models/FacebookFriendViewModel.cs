using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using SocialManager4.Attributes;

namespace SocialManager4.Models
{
    public class FacebookFriendViewModel
    {
        [Required]
        [FacebookMapping("id")]
        public string TaggingId { get; set; }

        [Required]
        [Display(Name = "Friend's Name")]
        [FacebookMapping("name")]
        public string Name { get; set; }

        [FacebookMapping("url", parent = "picture")]
        public string ImageURL { get; set; }
    }
}