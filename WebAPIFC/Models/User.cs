using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIFC.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public string Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório")] // obrigatoriedade do campo
        [StringLength(200, MinimumLength = 3, ErrorMessage = "O campo Nome deve ter entre 3 e 200 caracteres")] //informação de erro da obrigatoriedade

        public string nameUser { get; set; }
        
        public string loginUser { get; set; }

        public string passwordUser { get; set; }

        public string email { get; set; }

        public string phone { get; set; }

        public string CPF { get; set; }

        public string birthDate { get; set; }

        public string mothersName { get; set; }

        public string statusUser { get; set; }

        public string created_at { get; set; }

        public string updated_at { get; set; }
    }
}
