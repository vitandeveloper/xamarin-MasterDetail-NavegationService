
namespace PedidosAlfa.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using Models;
    using Services;
    using Views;
    using System.Collections.ObjectModel;
    using System.Windows.Input;

    public class MainViewModel
    {
        #region Services
        NavigationService navigationService;
        #endregion

        #region Property
        public ObservableCollection<MenuModel> Menu { get; set; }
        #endregion

        #region Constructor
        public MainViewModel()
        {
            LoadMenu();
            navigationService = new NavigationService();
        }

        #endregion

        #region Methods
        void LoadMenu()
        {
            Menu = new ObservableCollection<MenuModel>();
            Menu.Add(new MenuModel()
            {
                Title="Home",
                Icono="ic_person",
                PageName="MainPage",
            });

            Menu.Add(new MenuModel()
            {
                Title = "Ajustes",
                Icono = "ic_setting",
                PageName = "SettingPage",
            });

            Menu.Add(new MenuModel()
            {
                Title = "Salir",
                Icono = "ic_salir",
                PageName = "Salir",
            });
        }
        #endregion

        #region Commands
        public ICommand GoToNotePage
        {
            get { return new RelayCommand<string>(GoTo); }
        }

        private void GoTo(string pageName)
        {
           navigationService.Navigate(pageName);
        }
        #endregion
    }
}
        