using System;
using System.Collections.Generic;

namespace KGKMarkingStudio.ViewModels;

public class SettingsViewModel : ViewModelBase
{
    public SettingsViewModel(IServiceProvider? serviceProvider) : base(serviceProvider)
    {
    }

    public override object Copy(IDictionary<object, object>? source)
    {
        throw new NotImplementedException();
    }
}