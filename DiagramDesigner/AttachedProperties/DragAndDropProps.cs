/*using Avalonia;
using Avalonia.Data;
using Avalonia.Input;

namespace DiagramDesigner.AttachedProperties;

public class DragAndDropProps
{
    #region EnabledForDrag

    public static readonly AttachedProperty<bool> EnabledForDragProperty =
        AvaloniaProperty.RegisterAttached<DragAndDropProps, AvaloniaObject, bool>(
            "EnabledForDrag", 
            false, 
            false, 
            BindingMode.Default, 
            b => true,
            (o, b) =>
            {
                DragDrop. 
            });

    public static void SetEnabledForDrag(AvaloniaObject obj, bool value) => obj.SetValue(EnabledForDragProperty, value);
    public static bool GetEnabledForDrag(AvaloniaObject obj) => obj.GetValue(EnabledForDragProperty);
    
    

    #endregion
    
    

    #region DragStartPoint

    public static readonly AttachedProperty<Point> DragStartPointProperty =
        AvaloniaProperty.RegisterAttached<DragAndDropProps, AvaloniaObject, Point>("DragStartPoint");

    public static void SetDragStartPoint(AvaloniaObject obj, Point value) => obj.SetValue(DragStartPointProperty, value);
    public static Point GetDragStartPoint(AvaloniaObject obj) => obj.GetValue(DragStartPointProperty);

    #endregion
    
    
}*/