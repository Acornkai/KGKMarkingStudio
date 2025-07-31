using System;
using System.Collections.Generic;

namespace KGKMarkingStudio.ViewModels.Shapes;

public partial class PointShapeViewModel : ViewModelBase
{
    public PointShapeViewModel(IServiceProvider? serviceProvider) : base(serviceProvider)
    {
    }

    public override object Copy(IDictionary<object, object>? source)
    {
        throw new NotImplementedException();
    }
}