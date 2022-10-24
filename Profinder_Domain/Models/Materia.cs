using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Profinder_Domain.Models
{
    public class Materia
    {

        [Key]
        public int Id { get; set; }


        [Display(Name = "MateriaNome", ResourceType = typeof(Profinder_Domain.Utility.Language.Fields))]
        [Required(ErrorMessageResourceType = typeof(Profinder_Domain.Utility.Language.Messages), ErrorMessageResourceName = "MSG_E001")]
        public string MateriaNome { get; set; }

        [Display(Name = "MateriaDescrition", ResourceType = typeof(Profinder_Domain.Utility.Language.Fields))]
        [Required(ErrorMessageResourceType = typeof(Profinder_Domain.Utility.Language.Messages), ErrorMessageResourceName = "MSG_E001")]
        public string MateriaDescription { get; set; }

        [Required(ErrorMessageResourceType = typeof(Profinder_Domain.Utility.Language.Messages), ErrorMessageResourceName = "MSG_E001")]
        public string Cidade { get; set; }

        [Required(ErrorMessageResourceType = typeof(Profinder_Domain.Utility.Language.Messages), ErrorMessageResourceName = "MSG_E001")]
        [EmailAddress(ErrorMessageResourceType = typeof(Profinder_Domain.Utility.Language.Messages), ErrorMessageResourceName = "MSG_E002")]

        public string Contato { get; set; }

        public DateTime Publicacao { get; set; }

        
        public int UserId { get; set; }
            
        [ForeignKey("UserId")]
        public User User { get; set; }

    }
}
