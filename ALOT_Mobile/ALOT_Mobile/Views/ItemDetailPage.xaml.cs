﻿using ALOT_Mobile.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ALOT_Mobile.Views
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