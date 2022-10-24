using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Profinder_Domain.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Display(Name="Name", ResourceType = typeof(Profinder_Domain.Utility.Language.Fields))]
        [Required(ErrorMessageResourceType =typeof(Profinder_Domain.Utility.Language.Messages), ErrorMessageResourceName = "MSG_E001")]
        [MinLength(6, ErrorMessageResourceType = typeof(Profinder_Domain.Utility.Language.Messages), ErrorMessageResourceName = "MSG_E003") ]
        public String Name { get; set; }

        [Required(ErrorMessageResourceType = typeof(Profinder_Domain.Utility.Language.Messages), ErrorMessageResourceName = "MSG_E001")]
        [EmailAddress (ErrorMessageResourceType = typeof(Profinder_Domain.Utility.Language.Messages), ErrorMessageResourceName = "MSG_E002")]
        public String Email { get; set; }


        [Display(Name = "Password", ResourceType = typeof(Profinder_Domain.Utility.Language.Fields))]
        [Required(ErrorMessageResourceType = typeof(Profinder_Domain.Utility.Language.Messages), ErrorMessageResourceName = "MSG_E001")]
        [MinLength(6, ErrorMessageResourceType = typeof(Profinder_Domain.Utility.Language.Messages), ErrorMessageResourceName = "MSG_E003")]
        public String Password { get; set; }



    }
}
