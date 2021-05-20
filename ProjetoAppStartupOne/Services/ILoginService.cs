using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoAppStartupOne.Services
{
    public interface ILoginService
    {
        bool Login(string usuario, string senha);
    }
}
