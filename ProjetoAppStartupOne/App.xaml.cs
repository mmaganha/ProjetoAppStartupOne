﻿using ProjetoAppStartupOne.Resources;
using ProjetoAppStartupOne.Services;
using ProjetoAppStartupOne.View;
using Xamarin.Forms;

namespace ProjetoAppStartupOne
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            DependencyService.Register<ILoginService, LoginService>();
            DependencyService.Register<IUsuarioNovoService, UsuarioService>();
            MainPage = new NavigationPage(new LoginPage());
        }

        protected override void OnStart()
        {
            DataBaseHelper dataBaseHelper = new DataBaseHelper();
            dataBaseHelper.CriarBancoDeDados();
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
