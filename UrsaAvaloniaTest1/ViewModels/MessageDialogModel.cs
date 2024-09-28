using System;
using Avalonia.Controls;
using Irihi.Avalonia.Shared.Contracts;

namespace UrsaAvaloniaTest1.ViewModels;

public partial class MessageDialogModel : ViewModelBase , IDialogContext
{
    public void Close()
    {
        RequestClose?.Invoke(this, EventArgs.Empty);
    }

    public event EventHandler<object?>? RequestClose;
    
  
}