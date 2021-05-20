using ProjetoAppStartupOne.Model;
using SQLite;
using System;

namespace ProjetoAppStartupOne.Services
{
    public class UsuarioService : IUsuarioNovoService
    {
        string pasta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        public int Adicionar(UsuarioNovo usuario)
        {
            try
            {
                using (var conexao = new SQLiteConnection(System.IO.Path.Combine(pasta, "Usuario.db")))
                {
                    return conexao.Insert(usuario);
                }
            }
            catch
            {
                throw new ArgumentException("Erro ao cadastrar.");
            }
        }
    }
}
