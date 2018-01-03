
namespace PedidosAlfa.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using Services;
    using Views;
    using System.Windows.Input;

    public class LoginViewModel
    {

    #region Services
        NavigationService navigationService;
    #endregion

        public LoginViewModel()
        {
            navigationService = new NavigationService();
        }
        #region Commands
        public ICommand IngresarCommand
        {
           get { return new RelayCommand<string>(GoTo); } 
        }
        void GoTo(string pageName)
        {
            navigationService.SetMainPage(pageName);
            //navigationService.SetMainPage(new MainMasterDetail());
        }
    #endregion


}
}
