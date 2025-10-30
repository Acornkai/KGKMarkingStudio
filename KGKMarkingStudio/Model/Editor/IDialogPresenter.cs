using System;
using System.Collections.Generic;
using KGKMarkingStudio.ViewModels.Editor; 

namespace KGKMarkingStudio.Model.Editor;

public interface IDialogPresenter
{
    IList<DialogViewModel>? Dialogs { get; set; }
    void ShowDialog(DialogViewModel? dialogViewModel);
    void CloseDialog(DialogViewModel? dialogViewModel);
}
