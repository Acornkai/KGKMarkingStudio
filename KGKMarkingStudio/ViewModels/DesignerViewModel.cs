using System;
using System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;
using KGKMarkingStudio.Model.Editor;

namespace KGKMarkingStudio.ViewModels;

public partial class DesignerViewModel : ViewModelBase
{
    private IEditorTool? _currentTool;

    public IEditorCanvasPlatform? CanvasPlatform;

    public DesignerViewModel(IServiceProvider? serviceProvider, IEditorTool? currentTool, IEditorCanvasPlatform? canvasPlatform) : base(serviceProvider)
    {
        _currentTool = currentTool;
        CanvasPlatform = canvasPlatform;
    }

    public override object Copy(IDictionary<object, object>? source)
    {
        throw new NotImplementedException();
    }
}