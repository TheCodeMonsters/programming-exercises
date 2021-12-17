using DevExpress.XamarinForms.Navigation;
using DXAppUI.ViewModels;
using System;
using System.Linq;

namespace DXAppUI.Views
{
    public partial class MainPage : TabPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }
    }
}
