using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace API_testing51
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPage1 : TabbedPage
    {
        public TabbedPage1()
        {
            this.Children.Add(new Page1());
            this.Children.Add(new Page2());
            this.Children.Add(new Page3());

            InitializeComponent();
        }
    }
}