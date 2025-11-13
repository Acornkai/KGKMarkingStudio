using System;
using System.Collections.Generic;
using System.Data;
using KGKMarkingStudio.Model.Editor;
using KGKMarkingStudio.Model.Renderer;
using KGKMarkingStudio.ViewModels.Containers;
using KGKMarkingStudio.ViewModels.Renderer;

namespace KGKMarkingStudio.ViewModels.Editor;

public partial class ProjectEditorViewModel
{

    [AutoNotify] ProjectContainerViewModel? _project;

    [AutoNotify] private string? _projectName; 
    [AutoNotify] private bool _isProjectDirty; 
    [AutoNotify] private IDisposable? _observer; 
    [AutoNotify] private bool _isToolIdle;
    [AutoNotify] private IEditorTool? _currentTool;
    [AutoNotify] private IPathTool? _currentPathTool;
    [AutoNotify] private IList<DialogViewModel>? _dialogs;


    private readonly Lazy<IShapeRenderer?>? _renderer;
     private readonly Lazy<IEditorCanvasPlatform?>? _canvasPlatform;

    public ShapeRendererStateViewModel? PageState => _renderer?.Value?.State;

    public IEditorCanvasPlatform? CanvasPlatform => _canvasPlatform?.Value;

}

