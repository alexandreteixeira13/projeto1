﻿namespace projeto1.Models
{
    public class Usuario
    {
        public int Id { get; set; } //encapsulamento (acessores)

        public string? Nome { get; set; }

        public string? Email {  get; set; }

        public string? Senha { get; set; }
    }
}
