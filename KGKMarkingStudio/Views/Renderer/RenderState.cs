using System;
using KGKMarkingStudio.Model;
using KGKMarkingStudio.Model.Renderer;
using KGKMarkingStudio.ViewModels.Containers;
using Microsoft.CodeAnalysis;

namespace KGKMarkingStudio.Views.Renderer;

public class RenderState
{
    public FrameContainerViewModel? Container { get; set; }

    public IShapeRenderer? Renderer { get; set; }

    public ISelection? Selection { get; set; }

    // public DataFlow? DataFlow { get; set; }

    public RenderType RenderType { get; set; }

}
