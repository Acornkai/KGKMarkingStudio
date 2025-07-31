using System;
using System.Collections.Generic;

namespace KGKMarkingStudio.ViewModels;

public class MaterialViewModel : ViewModelBase
{
    public MaterialViewModel(IServiceProvider? serviceProvider) : base(serviceProvider)
    {
    }

    public override object Copy(IDictionary<object, object>? source)
    {
        throw new NotImplementedException();
    }
}