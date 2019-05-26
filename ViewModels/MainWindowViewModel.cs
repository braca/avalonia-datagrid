using AvaloniaDataGrid.Models;
using System.Collections.ObjectModel;

namespace AvaloniaDataGrid.ViewModels
{
    public class MainWindowViewModel : ViewModel
    {
        private ObservableCollection<Person> items;

        public MainWindowViewModel()
        {
            this.Items = new ObservableCollection<Person>();
        }

        public ObservableCollection<Person> Items
        {
            get => this.items;
            set => this.RaiseAndSetIfChanged(ref this.items, value);
        }
    }
}
