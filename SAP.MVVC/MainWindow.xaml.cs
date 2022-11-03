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

namespace SAP.MVVC {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public UserViewModel CharViewModel { get; set; }
        public MainWindow() {
            CharViewModel = new UserViewModel();
            UpdateViewModel();
            InitializeComponent();
        }

        private void addToList(object sender, RoutedEventArgs e) {
            CharViewModel.AddUser();
            UpdateViewModel();
        }

        private void UpdateViewModel() {
            DataContext = this.CharViewModel;
        }

    }
}
