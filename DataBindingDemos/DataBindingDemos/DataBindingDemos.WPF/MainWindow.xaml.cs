﻿using Xamarin.Forms.Platform.WPF;

namespace DataBindingDemos.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : FormsApplicationPage
    {
        public MainWindow()
        {
            InitializeComponent();
            Xamarin.Forms.Forms.Init();
            LoadApplication(new DataBindingDemos.App());
        }
    }
}
