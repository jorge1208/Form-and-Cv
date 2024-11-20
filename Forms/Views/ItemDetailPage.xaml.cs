using System.ComponentModel;
using Forms.ViewModels;
using Xamarin.Forms;

namespace Forms.Views
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