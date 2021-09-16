using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace projeto01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class pagina02 : ContentView
    {
        public pagina02()
        {
            InitializeComponent();
            StackLayout stk = new StackLayout()
            {
                Orientation = StackOrientation.Vertical
            };

        }
    }
}