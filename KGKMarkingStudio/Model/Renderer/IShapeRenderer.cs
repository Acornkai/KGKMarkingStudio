using KGKMarkingStudio.ViewModels.Renderer;
using KGKMarkingStudio.ViewModels.Shapes;
using KGKMarkingStudio.ViewModels.Style;

namespace KGKMarkingStudio.Model.Renderer;

public interface IShapeRenderer
{
    ShapeRendererStateViewModel? State { get; set; }
    
    void ClearCache();
    
    void Fill(object? dc, double x, double y, double width, double height, BaseColorViewModel? color);
    
    void Grid(object? dc, IGrid grid, double x, double y, double width, double height);
    
    void DrawPoint(object? dc, PointShapeViewModel point, ShapeStyleViewModel? style);
    
    void DrawLine(object? dc, LineShapeViewModel line, ShapeStyleViewModel? style);

    void DrawRectangle(object? dc, RectangleShapeViewModel rectangle, ShapeStyleViewModel? style);

    void DrawEllipse(object? dc, EllipseShapeViewModel ellipse, ShapeStyleViewModel? style); 

    void DrawText(object? dc, TextShapeViewModel text, ShapeStyleViewModel? style);

    void DrawImage(object? dc, ImageShapeViewModel image, ShapeStyleViewModel? style);

    void DrawPath(object? dc, PathShapeViewModel path, ShapeStyleViewModel? style);
}