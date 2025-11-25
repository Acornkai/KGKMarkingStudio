using System;
using KGKMarkingStudio.ViewModels.Containers;

namespace KGKMarkingStudio.Model.Renderer;

public interface IContainerPresenter
{
    void Render(object? dc, IShapeRenderer? renderer, ISelection? selection, FrameContainerViewModel? container, double dx, double dy);
}
