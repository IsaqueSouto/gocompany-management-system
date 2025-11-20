using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GO
{
    public static class ClienteLogado
    {
        private static string emailClienteLogado = string.Empty;

        public static string EmailClienteLogado
        {
            get => emailClienteLogado;
            set => emailClienteLogado = value ?? string.Empty; 
        }
    }
}
