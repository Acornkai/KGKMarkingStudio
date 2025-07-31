using KGKMarkingStudio.Model.Renderer;
using KGKMarkingStudio.ViewModels.Style;

namespace KGKMarkingStudio.Model;

public interface IDrawable
{
    ShapeStyleViewModel? style { get; set; }
    
    bool IsStroked { get; set; }
    
    bool IsFilled { get; set; }
    
    void DrawShape(object? dc, IShapeRenderer? renderer, ISelection selection);

    void DrawPoints(object? dc, IShapeRenderer? renderer, ISelection selection);

    bool Invalidate(IShapeRenderer? renderer);
}