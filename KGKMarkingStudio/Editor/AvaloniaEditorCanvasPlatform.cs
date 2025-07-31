using System;
using System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;
using KGKMarkingStudio.Model.Editor;
using KGKMarkingStudio.ViewModels;

namespace KGKMarkingStudio.Editor;

public partial class AvaloniaEditorCanvasPlatform(IServiceProvider? serviceProvider)
    : ViewModelBase(serviceProvider), IEditorCanvasPlatform
{
     [AutoNotify] private Action? _invalidateControl;
     [AutoNotify] private Action? _resetZoom;
     [AutoNotify] private Action? _fillZoom;
     [AutoNotify] private Action? _uniformZoom;
     [AutoNotify] private Action? _uniformToFillZoom;
     [AutoNotify] private Action? _autoFitZoom;
     [AutoNotify] private Action? _inZoom;
     [AutoNotify] private Action? _outZoom;
     [AutoNotify] private object? _zoom;

    public override object Copy(IDictionary<object, object>? shared)
    {
        throw new NotImplementedException();
    }
}