using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLogin
{
    static class CadastroUsuarios
    {
        private static Usuario[] usuarios =
        {
            new Usuario(){Nome = "João", Senha = "jo0710ar"},
            new Usuario(){Nome = "Amanda", Senha = "Am2601da"},
            new Usuario() {Nome ="Aelson", Senha = "Ae2501son"}
        };

        private static Usuario _userLogado = null;

        public static Usuario UsuarioLogado
        {

            get { return _userLogado; }
            private set { _userLogado=value; }
        }

        public static bool Login(string nome, string senha)
        {
            foreach (Usuario usuario in usuarios)
            {
                if(usuario.Nome == nome && usuario.Senha == senha)
                {
                    UsuarioLogado = usuario;
                    return true;
                }
            }
            return false;
        }
    }
}
