

namespace PedidosAlfa.Infrastructure
{
    using ViewModels;

    public class InstanceLocator
    {
        public MainViewModel Main{ get; set; }
        public LoginViewModel Login { get; set; }


        public InstanceLocator()
        {
            Main = new MainViewModel();
            Login = new LoginViewModel();
        }
    }
}
