﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ViewManagerDemo.Dialogs
{
    /// <summary>
    /// NormalDialog.xaml 的交互逻辑
    /// </summary>
    public partial class NormalDialog
    {
        public Visibility SetModalResultBtVisibility
        {
            get
            {
                return (Visibility)GetValue(SetModalResultBtVisibilityProperty);
            }
            set
            {
                SetValue(SetModalResultBtVisibilityProperty, value);
            }
        }
        public static readonly DependencyProperty SetModalResultBtVisibilityProperty = DependencyProperty.Register("SetModalResultBtVisibility", typeof(Visibility), typeof(NormalDialog), new PropertyMetadata(Visibility.Collapsed));


        public NormalDialog()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.ModalResult = new Unicorn.ViewManager.ModalResult
            {
                Result=$"你输入了 \" {_text.Text} \""
            };
        }
    }
}
