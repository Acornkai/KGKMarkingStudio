using System;
using System.Collections.Generic;

namespace KGKMarkingStudio.ViewModels.Containers;

public abstract partial class BaseContainerViewModel : ViewModelBase
{
    [AutoNotify] private bool _isVisible;
    [AutoNotify] private bool _isExpanded;

    public BaseContainerViewModel(IServiceProvider? serviceProvider, bool isVisible, bool isExpanded) : base(serviceProvider)
    {
        _isVisible = isVisible;
        _isExpanded = isExpanded;
    }

    
}