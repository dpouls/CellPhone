using System.ComponentModel;
using Xamarin.Forms;
using CellPhone.ViewModels;

namespace CellPhone.Views
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