


namespace PedidosAlfa.Services
{
    using System.Threading.Tasks;
    using Views;
    using Xamarin.Forms;

    public class NavigationService
    {
        public async Task Navigate(string pageName)
        {
            App.Master.IsPresented = false; // ciera el menu lateral de la MasterPage

            switch (pageName)
            {
                case "NotePage":
                    await Navigate(new NotePage());
                    break;
                case "MainPage":
                    await App.Navigator.PopToRootAsync();
                    break;

                case "SettingPage":
                    await Navigate(new SettingPage());
                    break;

                case "Salir":

                    break;

                default:
                    break;
            }
        }

        static async Task Navigate<T> (T page) where T : Page
        {
            NavigationPage.SetHasBackButton(page, false); // Elimina el boton back para android
            NavigationPage.SetBackButtonTitle(page, "Atras"); // Para IOS quita el titlo del a pagina y pone la palabra Atras
            await App.Navigator.PushAsync(page);
        }

        //Utiliza la instancia actual y cambia el main page por la nueva pagina
        internal void SetMainPage(string pageName)
        {
            //App.Current.MainPage = pageName;

            switch (pageName)
            {
                case "MasterDetailPage":
                    App.Current.MainPage = new MainMasterDetail();
                    break;

                default:
                    break;
            }
        }
    }
}
