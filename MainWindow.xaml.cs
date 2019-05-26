using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using AvaloniaDataGrid.Models;
using AvaloniaDataGrid.ViewModels;

namespace AvaloniaDataGrid
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            var viewModel = new MainWindowViewModel();

            for (int i = 0; i < 100; i++)
            {
                viewModel.Items.Add(new Person($"Person {i.ToString()}"));
            }

            this.DataContext = viewModel;
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
