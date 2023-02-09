﻿using System;

namespace RestApiDDD.Domain.Entitys
{
    public class Cliente : Base
    {
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool IsAtivo { get; set; }
    }
}
