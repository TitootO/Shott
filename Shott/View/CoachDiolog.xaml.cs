﻿using Shott.Model;
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
using System.Windows.Shapes;

namespace Shott.View
{
    /// <summary>
    /// Логика взаимодействия для CoachDiolog.xaml
    /// </summary>
    public partial class CoachDiolog : Window
    {
        public CoachDiolog(Coach coach)
        {
            InitializeComponent();
            DataContext = coach;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
