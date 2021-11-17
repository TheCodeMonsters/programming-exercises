using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PagesDemos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : FlyoutPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void Profile_Page(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Profile());
        }
    }
}