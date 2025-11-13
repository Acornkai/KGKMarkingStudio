using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using KGKMarkingStudio.Model;

namespace KGKMarkingStudio.ViewModels.Containers;

public partial class ProjectContainerViewModel : BaseContainerViewModel, ISelection
{

    [AutoNotify] private ImmutableArray<DocumentContainerViewModel> _documents;

    [AutoNotify] private FrameContainerViewModel? _currentContainer;

    [AutoNotify(IgnoreDataMember = true)] private ISet<BaseShapeViewModel>? _selectedShapes;

    public ProjectContainerViewModel(IServiceProvider? serviceProvider) : base(serviceProvider)
    {
    }
 
    public override object Copy(IDictionary<object, object>? source)
    {
        throw new NotImplementedException();
    }
}
