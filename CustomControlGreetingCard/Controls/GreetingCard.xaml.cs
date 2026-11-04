using System;
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

namespace CustomControlGreetingCard.Controls
{
    /// <summary>
    /// Interaction logic for GreetingCard.xaml
    /// </summary>
    public partial class GreetingCard : UserControl
    {
        public GreetingCard()
        {
            InitializeComponent();
        }

        // 1. Define the Dependency Property
        public static readonly DependencyProperty CardTitleProperty =
            DependencyProperty.Register(
                nameof(CardTitle),
                typeof(string),
                typeof(GreetingCard),
                new PropertyMetadata(string.Empty));

        // 2. Wrap it in a standard C# property wrapper for easy access
        public string CardTitle
        {
            get => (string)GetValue(CardTitleProperty);
            set => SetValue(CardTitleProperty, value);
        }
    }
}
