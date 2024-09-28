using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using Ursa.Controls;
using UrsaAvaloniaTest1.Views;

namespace UrsaAvaloniaTest1.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [RelayCommand]
    private async Task OnTest()
    {
        await OverlayDialog.ShowCustomModal<MessageDialog, MessageDialogModel, object>(
            hostId: null,
            vm: new MessageDialogModel(),
            options: new OverlayDialogOptions
            {
                FullScreen = true,
                IsCloseButtonVisible = true,
                CanLightDismiss = false,
            });
    }
}