﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRpgEtecs
{
    public class AboutView : ContentPage
    {
        public AboutView()
        {
            Content = new VerticalStackLayout
            {
                Children = {
                new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Welcome to .NET MAUI!"
                }
            }
            };
        }
    }
    
}
