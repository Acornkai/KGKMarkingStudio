using System;
using System.Collections.Generic;

namespace KGKMarkingStudio.ViewModels.Data;

public partial class ValueViewModel : ViewModelBase
{
    [AutoNotify] private string? _content;

    public ValueViewModel(IServiceProvider? serviceProvider) : base(serviceProvider)
    {
        
    }

    public override object Copy(IDictionary<object, object>? source)
    {
        var copy = new ValueViewModel(ServiceProvider)
        {
            Name = Name,
            Content = Content  
        };

        return copy;
    }

    public override bool IsDirty()
    {
        return base.IsDirty();
    }  

}
