﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Laboratorio11
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Views.Operacions();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}