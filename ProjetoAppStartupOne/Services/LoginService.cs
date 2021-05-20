using ProjetoAppStartupOne.Model;
using SQLite;
using System.Collections.Generic;

namespace ProjetoAppStartupOne.Services
{
    public class LoginService : ILoginService
    {
        string pasta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        public bool Login(string usuario, string senha)
        {
            try
            {
                using (var conexao = new SQLiteConnection(System.IO.Path.Combine(pasta, "Usuario.db")))
                {
                    UsuarioNovo resultado = conexao.FindWithQuery<UsuarioNovo>("SELECT * FROM UsuarioNovo Where Usuario=? AND Senha=?", usuario, senha);
                    if (resultado != null)
                    {
                        return true;
                    }
                    else
                        return false;                    
                }
            }
            catch (SQLiteException ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
    }
}
