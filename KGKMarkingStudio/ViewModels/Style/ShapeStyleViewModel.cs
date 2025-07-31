using System;
using System.Collections.Generic;

namespace KGKMarkingStudio.ViewModels.Style;

public partial class ShapeStyleViewModel :ViewModelBase
{
    public ShapeStyleViewModel(IServiceProvider? serviceProvider) : base(serviceProvider)
    {
    }

    public override object Copy(IDictionary<object, object>? source)
    {
        throw new NotImplementedException();
    }
}