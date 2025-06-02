using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models;

public class Filme
{   
    [Required]
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "O titulo e obrigatorio")]
    public string Titulo { get; set; }
    [Required(ErrorMessage = "O genero e obrigatorio")]
    [StringLength(50, ErrorMessage = "Tamanho maximo de 50 caracteres")]
    public string Genero { get; set; }
    [Required(ErrorMessage = "A duracao e obrigatorio")]
    [Range(70, 600, ErrorMessage = "A duracao preciisa ter entre 70 e 600 minutos")]
    public int Duracao { get; set; }
}
