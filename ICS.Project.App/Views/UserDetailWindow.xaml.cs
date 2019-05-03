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
using System.Windows.Shapes;
using ICS.Project.BL.Services;

namespace ICS.Project.App.Views
{
    /// <summary>
    /// Interaction logic for UserDetailWindow.xaml
    /// </summary>
    public partial class UserDetailWindow : Window
    {
        public UserDetailWindow()
        {
            InitializeComponent();
            Mediator mediator;
        }

        public void ShowThisWindow()
        {
            this.Show();
        }
    }
}
