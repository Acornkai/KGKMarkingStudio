using System;
using Avalonia;
using KGKMarkingStudio.Model;
using KGKMarkingStudio.Model.Renderer;

namespace KGKMarkingStudio.Views.Renderer;

public class RendererOptions
{
    /// <summary>
    /// Renderer AttachedProperty definition
    /// indicates .
    /// </summary>
    public static readonly AttachedProperty<IShapeRenderer> RendererProperty =
        AvaloniaProperty.RegisterAttached<RendererOptions, AvaloniaObject ,IShapeRenderer>("Renderer");
    
    /// <summary>
    /// <param name="element">Target element</param>
    /// <param name="value">The value to set  <see cref="RendererProperty"/>.</param>
    /// </summary>
    
    public static void SetRenderer(AvaloniaObject element, IShapeRenderer value) =>
        element.SetValue(RendererProperty, value);
    
    /// <summary>
    /// Accessor for Attached property <see cref="RendererProperty"/>.
    /// <param name="element">Target element</param>
    /// </summary>
    public static IShapeRenderer GetRenderer(AvaloniaObject element) =>
        element.GetValue(RendererProperty);
    

    /// <summary>
    /// Selection AttachedProperty definition
    /// indicates .
    /// </summary>
    public static readonly AttachedProperty<ISelection?> SelectionProperty =
        AvaloniaProperty.RegisterAttached<RendererOptions, AvaloniaObject ,ISelection?>("Selection");
    
    /// <summary>
    /// <param name="element">Target element</param>
    /// <param name="value">The value to set  <see cref="SelectionProperty"/>.</param>
    /// </summary>
    
    public static void SetSelection(AvaloniaObject element, ISelection? value) =>
        element.SetValue(SelectionProperty, value);
    
    /// <summary>
    /// Accessor for Attached property <see cref="SelectionProperty"/>.
    /// <param name="element">Target element</param>
    /// </summary>
    public static ISelection? GetSelection(AvaloniaObject element) =>
        element.GetValue(SelectionProperty);
    

    

}
