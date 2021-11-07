﻿using System;

namespace APICatalogoJosos.Exceptions
{
    public class JogoJaCadastradoException:Exception
    {
        public JogoJaCadastradoException()
    : base("Este já jogo está cadastrado")
        { }
    }
}
