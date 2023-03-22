using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Navigation.ViewModels
{
    public partial class MainWindowViewModel : ObservableObject
    {
        //https://devblogs.microsoft.com/dotnet/announcing-the-dotnet-community-toolkit-800/

        [ObservableProperty]
        private string? _firstName = "Robert";

        [ObservableProperty]
        private string? _lastName = "Johansson";


        [RelayCommand]
        private async void Click()
        {
            await Task.Delay(1_000);
           
            FirstName = "Dennis";

        }
    }
}
