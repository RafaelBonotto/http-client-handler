﻿using System;
using System.Net.Http;

namespace ApliClient.Infra.Impl
{
    public class RespostaServico<T>
    {
        public string HttpStatus { get; set; }
        public bool Sucesso { get; set; }
        public string Mensagem { get; set; }
        public T Resposta { get; set; }
    }
}

