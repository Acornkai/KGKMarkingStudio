using System;
using System.Collections.Generic;

namespace KGKMarkingStudio.ViewModels;

public class UsersViewModel : ViewModelBase
{
    public UsersViewModel(IServiceProvider? serviceProvider) : base(serviceProvider)
    {
    }

    public override object Copy(IDictionary<object, object>? source)
    {
        throw new NotImplementedException();
    }
}