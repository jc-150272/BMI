﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XAMARIN010
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void Button_Click(object sender, EventArgs e)
        {
            DisplayAlert("A", this.messageText.Text, "C");
        }
    }
}
