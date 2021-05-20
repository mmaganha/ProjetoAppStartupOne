using ProjetoAppStartupOne.Model;
using SQLite;

namespace ProjetoAppStartupOne.Resources
{
    public class DataBaseHelper
    {
        string pasta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

        public bool CriarBancoDeDados()
        {
            try
            {
                using (var conexao = new SQLiteConnection(System.IO.Path.Combine(pasta, "Usuario.db")))
                {
                    conexao.CreateTable<UsuarioNovo>();
                    return true;
                }
            }
            catch 
            {                
                return false;
            }
        }
    }
}
