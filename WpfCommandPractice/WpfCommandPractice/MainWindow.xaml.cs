using System.Windows;
using System.Windows.Input;

namespace WpfCommandPractice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// ユーザーのアクションと、その処理を結びつけるもの
        /// </summary>
        public static RoutedCommand AlertCommand = new RoutedCommand();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Hello world");
        }

        private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = this.checkBox.IsChecked.Value;
        }
    }
}
