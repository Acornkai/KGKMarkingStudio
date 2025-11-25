using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Windows.Input;

namespace KGKMarkingStudio.ViewModels.Data;

public partial class PropertiyViewModel : ViewModelBase
{
    [AutoNotify] private string? _value;

    public PropertiyViewModel(IServiceProvider? serviceProvider) : base(serviceProvider)
    {
        
    }

    [IgnoreDataMember]
    public ICommand AddProperty { get; }

    [IgnoreDataMember]
    public ICommand RemoveProperty { get; }


    public override object Copy(IDictionary<object, object>? source)
    {
        var copy = new PropertiyViewModel(ServiceProvider)
        {
            Name = Name,
            Value = Value 
        };

        return copy;
    }

    public override bool IsDirty()
    {
        return base.IsDirty();
    }

    public override string ToString() => _value ?? "";

}
