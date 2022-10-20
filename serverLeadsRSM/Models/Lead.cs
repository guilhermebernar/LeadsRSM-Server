using System.ComponentModel.DataAnnotations.Schema;

namespace rsmapp.Model
{   
    [Table("Pessoa")]
    
    public class Lead
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("Name")]
        public string? Name { get; set; }
        [Column("CompanyName")]
        public string? CompanyName { get; set; }
        [Column("CompanySize")]
        public int CompanySize { get; set; }
        [Column("TypeRequest")]
        public string? TypeRequest { get; set; }
        [Column("Description")]
        public string? Description { get; set; }
        [Column("CreateAt")]
        public DateTime? CreateAt { get; set; }
        
    }
}
