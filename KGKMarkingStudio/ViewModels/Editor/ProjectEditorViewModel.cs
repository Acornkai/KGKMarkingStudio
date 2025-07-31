using System;
using KGKMarkingStudio.Model.Renderer;
using KGKMarkingStudio.ViewModels.Renderer;

namespace KGKMarkingStudio.ViewModels.Editor;

public class ProjectEditorViewModel
{
    private readonly Lazy<IShapeRenderer?>? _renderer;

    public IShapeRenderer? Renderer => _renderer?.Value;

    public ShapeRendererStateViewModel? PageState => _renderer?.Value?.State;
}