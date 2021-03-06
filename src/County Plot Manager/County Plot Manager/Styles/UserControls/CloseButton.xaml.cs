﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PlotManager.UI.Styles.UserControls
{
	/// <summary>
	/// Interaction logic for CloseButton.xaml
	/// </summary>
	public partial class CloseButton : UserControl
	{
		public CloseButton()
		{
			InitializeComponent();
		}

		private void CloseWindow(object sender, RoutedEventArgs e)
		{
			SystemCommands.CloseWindow(Window.GetWindow((Button)sender));
		}

		private void _OnSystemCommandCloseWindow(object sender, ExecutedRoutedEventArgs e)
		{
			SystemCommands.CloseWindow((Window)e.Parameter);
		}


	}
}
