﻿using Store.ViewModels.UCViewModels;
using Store.ViewModels.WindowsViewModels;
using System;
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

namespace Store.Views.UserControls
{
    /// <summary>
    /// Interaction logic for InsertUserControl.xaml
    /// </summary>
    public partial class InsertUserControl : UserControl
    {
        public InsertUserControl()
        {
            InitializeComponent();
            var vm = new InsertUCViewModel();
            this.DataContext = vm;
        }
    }
}
