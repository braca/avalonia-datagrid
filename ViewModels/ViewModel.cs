using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AvaloniaDataGrid.ViewModels
{
    public abstract class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaiseAndSetIfChanged<TRet>(ref TRet backingField, TRet newValue, [CallerMemberName] string propertyName = null)
        {
            if (backingField != null && backingField.Equals(newValue) && !default(TRet).Equals(newValue))
            {
                return;
            }

            backingField = newValue;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected void RaisePropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
