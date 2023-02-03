using System.ComponentModel.DataAnnotations;

namespace HTML_Tag_Helper.Models;

public class SportModel {
    [Required(ErrorMessage = "O nome é obrigatório!")]
    public string Name { get; set; }
    
    [Required(ErrorMessage = "A quantidade de anos é obrigatória!")]
    public int? Years { get; set; }
}