using System;
using System.Collections.Generic;
using System.ComponentModel;
using Forms.Models;
using Forms.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Forms.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}