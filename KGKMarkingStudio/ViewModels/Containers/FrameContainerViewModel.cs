using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace KGKMarkingStudio.ViewModels.Containers;

public partial class FrameContainerViewModel : BaseContainerViewModel
{
    [AutoNotify] protected ImmutableArray<LayerContainerViewModel> _layers;
    [AutoNotify] protected LayerContainerViewModel? _currentLayer;
    [AutoNotify] protected LayerContainerViewModel? _workingLayer;
    [AutoNotify] protected LayerContainerViewModel? _helperLayer;
    [AutoNotify] protected BaseShapeViewModel? _currentShape;

    public FrameContainerViewModel(IServiceProvider? serviceProvider) : base(serviceProvider)
    {
    }

    public override object Copy(IDictionary<object, object>? source)
    {
        throw new NotImplementedException();
    }
}
