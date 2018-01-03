
namespace PedidosAlfa.Views
{
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainMasterDetail : MasterDetailPage
    {
        public MainMasterDetail()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            //Declaramos la Master en la app
            App.Master = this;
            //Declaramos el Navigator ne la app
            App.Navigator = this.Navigation;
        }
    }
}