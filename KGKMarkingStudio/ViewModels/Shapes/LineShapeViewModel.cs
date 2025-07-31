using System;
using System.Collections.Generic;

namespace KGKMarkingStudio.ViewModels.Shapes;

public partial class LineShapeViewModel :ViewModelBase
{
    public LineShapeViewModel(IServiceProvider? serviceProvider) : base(serviceProvider)
    {
    }

    public override object Copy(IDictionary<object, object>? source)
    {
        throw new NotImplementedException();
    }
}