﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChatApp_PARDO
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SampleTabbedPage : TabbedPage
	{
		DataClass dataClass = DataClass.GetInstance;
		public SampleTabbedPage()
		{
			InitializeComponent();
			NavigationPage.SetHasNavigationBar(this, false);
			profilePage.Name = dataClass.loggedInUser.name;
			profilePage.Email = dataClass.loggedInUser.email;
		}
	}
}