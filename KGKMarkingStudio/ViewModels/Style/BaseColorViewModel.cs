using System;

namespace KGKMarkingStudio.ViewModels.Style;

public abstract partial class BaseColorViewModel : ViewModelBase
{
    protected BaseColorViewModel(IServiceProvider? serviceProvider) : base(serviceProvider)
    {
    }
}