﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Chapter_2_XamlExamples
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NamespacePage : ContentPage
	{
		public NamespacePage ()
		{
			InitializeComponent ();
		}
	}
}