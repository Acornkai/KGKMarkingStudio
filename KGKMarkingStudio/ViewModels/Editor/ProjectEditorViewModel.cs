using System;
using KGKMarkingStudio.Model.Editor;
using System.Collections.Generic;
using KGKMarkingStudio.ViewModels.Shapes;
using KGKMarkingStudio.ViewModels.Editors;



namespace KGKMarkingStudio.ViewModels.Editor;

public partial class ProjectEditorViewModel : ViewModelBase, IDialogPresenter
{
    public ProjectEditorViewModel(IServiceProvider? serviceProvider) : base(serviceProvider)
    {

    }

    public override object Copy(IDictionary<object, object>? source)
    {
        throw new NotImplementedException();
    }

    public void ShowDialog(DialogViewModel? dialog)
    {
        if (dialog is { })
        {
            _dialogs?.Add(dialog);
        }
    }

    public void CloseDialog(DialogViewModel? dialog)
    {
        if (dialog is { })
        {
            _dialogs?.Remove(dialog);
        }
    }

    public DialogViewModel CreateTextBindingDialog(TextShapeViewModel text)
    {
        var textBindingEditor = new TextBindingEditorViewModel(ServiceProvider)
        {
            Editor = this,
            Text = text
        };

        return new DialogViewModel(ServiceProvider, this)
        {
            Title = "Text Binding",
            IsOverlayVisible = false,
            IsTitleBarVisible = true,
            IsCloseButtonVisible = true,
            ViewModel = textBindingEditor

        }; 
    }

}