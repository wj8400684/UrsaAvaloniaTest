using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using Ursa.Controls;
using Ursa.Controls.Options;
using UrsaAvaloniaTest1.Views;

namespace UrsaAvaloniaTest1.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [RelayCommand]
    private async Task OnTest()
    {
        var options = new OverlayDialogOptions
        {
            CanDragMove = false,
            FullScreen = true,
            IsCloseButtonVisible = true,
            CanLightDismiss = false,
        };

        await OverlayDialog.ShowCustomModal<MessageDialog, MessageDialogModel, object>(
            hostId: null,
            vm: new MessageDialogModel(),
            options: options);
    }
}