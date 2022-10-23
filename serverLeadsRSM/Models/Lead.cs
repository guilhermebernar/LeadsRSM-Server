using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rsmapp.Model
{   
    [Table("Pessoa")]
    public class Lead
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Column("Name")]
        [Required(ErrorMessage = "Nome do solicitante requerido.")]
        public string Name { get; set; }
        
        [Column("CompanyName")]
        [Required(ErrorMessage = "Nome da empresa requerido.")]
        public string CompanyName { get; set; }
        
        [Column("CompanySize")]
        [Required(ErrorMessage = "Tamanho da empresa requerido.")]
        public string CompanySize { get; set; }
        
        [Column("TypeRequest")]
        [Required(ErrorMessage = "Tipo de serviço requerido.")]
        public string TypeRequest { get; set; }
        
        [Column("description")]
        [Required(ErrorMessage = "Descrição requerida.")]
        public string Description { get; set; }

        [Column("PhoneNumber")]
        [Required(ErrorMessage = "Numero de telefone requerido.")]
        [RegularExpression(
            @"^\(?(?:[14689][1-9]|2[12478]|3[1234578]|5[1345]|7[134579])\)? ?(?:[2-8]|9[1-9])[0-9]{3}\-?[0-9]{4}$",
            ErrorMessage = "Entered phone format is not valid.")]
        public string PhoneNumber { get; set; }
        
        [Column("CreateAt")]
        [Required(ErrorMessage = "DataTime da criação requerido")]
        public DateTime CreateAt { get; set; }
    }
}
