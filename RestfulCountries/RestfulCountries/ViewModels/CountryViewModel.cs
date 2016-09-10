﻿using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace RestfulCountries
{
	public class CountryViewModel
	{
		public Country Model { get; set; }
		public ImageSource FlagSource { get; set; }
		public ICommand BrowseCommand { get; set; }

		public CountryViewModel(Country model)
		{
			Model = model;
		}
	}
}