using System.ComponentModel;
using Xamarin.Forms;
using XFApp.ViewModels;

namespace XFApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}