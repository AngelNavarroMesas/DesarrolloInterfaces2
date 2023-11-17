using Ej2.Models;

namespace Ej2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            clsPersona persona = new clsPersona();
            BindingContext = persona;
        }

    }
}