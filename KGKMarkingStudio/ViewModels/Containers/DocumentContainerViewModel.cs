using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace KGKMarkingStudio.ViewModels.Containers;

public partial class DocumentContainerViewModel : BaseContainerViewModel
{
    [AutoNotify] private ImmutableArray<PageContainerViewModel> _pages;

    public DocumentContainerViewModel(IServiceProvider? serviceProvider) : base(serviceProvider)
    {
    }

    public override object Copy(IDictionary<object, object>? source)
    {
        throw new NotImplementedException();
    }
}
