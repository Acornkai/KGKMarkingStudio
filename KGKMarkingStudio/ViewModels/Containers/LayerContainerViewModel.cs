using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using LiveChartsCore.Drawing.Layouts;

namespace KGKMarkingStudio.ViewModels.Containers;



public partial class LayerContainerViewModel : BaseContainerViewModel
{

    [AutoNotify] private ImmutableArray<BaseShapeViewModel> _shapes;

    public LayerContainerViewModel(IServiceProvider? serviceProvider) : base(serviceProvider)
    {
    }

    public override object Copy(IDictionary<object, object>? source)
    {
        throw new NotImplementedException();
    }
}