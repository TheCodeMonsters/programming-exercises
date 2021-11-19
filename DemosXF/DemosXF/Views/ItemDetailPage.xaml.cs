using DemosXF.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace DemosXF.Views
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