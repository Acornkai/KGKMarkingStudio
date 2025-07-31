using System.Collections.Generic;
using KGKMarkingStudio.ViewModels;

namespace KGKMarkingStudio.Model;

public interface ISelection
{
    ISet<BaseShapeViewModel>? SelectedShapes { get; set; }
}