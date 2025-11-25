using System;
using Avalonia;
using Avalonia.Media;
using Avalonia.Rendering.SceneGraph;
using KGKMarkingStudio.Model.Renderer;
using KGKMarkingStudio.ViewModels.Renderer.Presenters;

namespace KGKMarkingStudio.Views.Renderer;

public class RenderDrawOperation : ICustomDrawOperation
{
    private static readonly IContainerPresenter s_editorPresenter = new EditorPresenter();

    private static void DrawData(RenderState renderState, object context)
    {
        
    }

    private static void DrawTemplate(RenderState renderState, object context)
    {
        
    }

    private static void DrawEditor(RenderState renderState, object context)
    {
        
    }

    private static void DrawExport(RenderState renderState, object context)
    {
        
    }
    
    public static void Draw(RenderState? renderState, object context)
    {
        switch(renderState?.RenderType)
        {
            case RenderType.None:
                break;
            case RenderType.Data:
                DrawData(renderState, context);
                break;
            case RenderType.Template:
                DrawTemplate(renderState, context);
                break;
            case RenderType.Editor:
                DrawEditor(renderState, context);
                break;
            case RenderType.Export:
                DrawExport(renderState, context);
                break;
        }
    }


    public RenderState? RenderState { get; set; }
    public Rect Bounds { get; set; }
 
    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public bool Equals(ICustomDrawOperation? other)
    {
        throw new NotImplementedException();
    }

    public bool HitTest(Point p)
    {
        throw new NotImplementedException();
    }

    public void Render(ImmediateDrawingContext context)
    {
        Draw(RenderState, context);
    }
}
