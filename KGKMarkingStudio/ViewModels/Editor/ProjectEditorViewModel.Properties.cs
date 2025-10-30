using System;
using System.Collections.Generic;
using KGKMarkingStudio.Model.Editor;

namespace KGKMarkingStudio.ViewModels.Editor;

public partial class ProjectEditorViewModel
{
    [AutoNotify] private object? _rootDock;

    [AutoNotify] ProjectContainerViewModel? _project;

    [AutoNotify] private IEditorTool? _currentTool;

    [AutoNotify] private IList<DialogViewModel>? _dialogs;
}
