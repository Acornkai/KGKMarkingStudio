using System;
using System.Collections.Generic;
using LiveChartsCore.Drawing.Layouts;

namespace KGKMarkingStudio.ViewModels.Containers;



public partial class LayerContainerViewModel : BaseContainerViewModel
{
    public LayerContainerViewModel(IServiceProvider? serviceProvider, bool isVisible, bool isExpanded) : base(serviceProvider, isVisible, isExpanded)
    {
    }

    public override object Copy(IDictionary<object, object>? source)
    {
        throw new NotImplementedException();
    }
}