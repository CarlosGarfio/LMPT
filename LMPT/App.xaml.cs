using LMPT.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LMPT
{
    public partial class App : Application
    {
        #region Constructores
        public App()
        {
            InitializeComponent();

            this.MainPage = new LoginPage();
        }
        #endregion
        #region Metodos
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        } 
        #endregion
    }
}
