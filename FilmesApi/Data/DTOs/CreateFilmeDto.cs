﻿using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.DTOs;

public class CreateFilmeDto
{
    [Required(ErrorMessage = "O titulo do filme é obrigatório")]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "O gênero do filme é obrigatório")]
    [StringLength(50, ErrorMessage = "O tamanho do gênero nao pode ser maior que 50 caracteres")]
    public string Genero { get; set; }

    [Required(ErrorMessage = "A duração do filme é obrigatória")]
    [Range(70, 600, ErrorMessage = "A duração deve ter entre 70 e 600 min")]
    public int Duracao { get; set; }
}
