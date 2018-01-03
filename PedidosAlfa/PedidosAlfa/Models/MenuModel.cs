


namespace PedidosAlfa.Models
{
    using GalaSoft.MvvmLight.Command;
    using System.Windows.Input;
    using Services;

    public class MenuModel
    {
        #region Servicio
        NavigationService navegationService;
        #endregion
        public string Icono { get; set; }
        public string Title { get; set; }
        public string PageName { get; set; }

        #region Constructor
        public MenuModel()
        {
            navegationService = new NavigationService();
        }
        #endregion


        #region Comando de los item del menu
        public ICommand NavigationCommand
        {
            get { return new RelayCommand(
                () => navegationService.Navigate(PageName)
                ); }
        }
        #endregion

    }


}
