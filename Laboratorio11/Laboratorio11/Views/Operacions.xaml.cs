using Laboratorio11.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Laboratorio11.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Operacions : ContentPage
    {
        public Operacions()
        {
            InitializeComponent();
            this.BindingContext = new ViewModelOperaciones();
        }
    }
}