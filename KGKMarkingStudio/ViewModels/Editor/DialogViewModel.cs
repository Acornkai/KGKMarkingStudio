using System;
using System.Collections.Generic;
using KGKMarkingStudio.Model.Editor;

namespace KGKMarkingStudio.ViewModels.Editor;

public class DialogViewModel : ViewModelBase
{
    private readonly IDialogPresenter _dialogPresenter;

    [AutoNotify] private string? _title;
    [AutoNotify] private bool _isOverlayVisible;
    [AutoNotify] private bool _isTitleBarVisible;
    [AutoNotify] private bool _isCloseButtonVisible;
    [AutoNotify] private ViewModelBase? _viewModel;

    public DialogViewModel(IServiceProvider? serviceProvider, IDialogPresenter dialogPresenter)
        : base(serviceProvider)
    {
        _dialogPresenter = dialogPresenter;
    }

    public override object Copy(IDictionary<object, object>? source)
    {
        throw new NotImplementedException();
    }

    public void Show()
    {
        _dialogPresenter.ShowDialog(this);
    }

    public void Close()
    {
        _dialogPresenter.CloseDialog(this);
    }

}
