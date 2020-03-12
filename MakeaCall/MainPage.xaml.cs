﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace MakeaCall
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            try
            {
                PhoneDialer.Open(EntryNumber.Text);

            }
            catch(Exception )
            {
                DisplayAlert("Empty number", "Please enter the correct number", "ok");
            }

        }
    }
}
