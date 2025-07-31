
using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.PanAndZoom;
using KGKMarkingStudio.Editor;
using KGKMarkingStudio.Model.Input;
using KGKMarkingStudio.ViewModels;
using KGKMarkingStudio.ViewModels.Editor;

namespace KGKMarkingStudio.Behaviors;

public class AttachEditor
{
    //目标控件
    private readonly Control _control;
    private AvaloniaInputSource? _inputSource;
    private ProjectEditorInputTarget? _inputTarget;
    private InputProcessor? _inputProcessor;

    public AttachEditor(Control control)
    {
        _control = control;
        _control.GetObservable(StyledElement.DataContextProperty).Subscribe(Changed);
    }

    public void InvalidateChild(double zoomX, double zoomY, double offsetX, double offsetY)
    {
        if(_control.DataContext is not ProjectEditorViewModel projectEditor)
            return;

        var state = projectEditor.PageState;
        if (state is { })
        {
            state.ZoomX = zoomX;
            state.ZoomY = zoomY;
            state.PanX = offsetX;
            state.PanY = offsetY;
        }
    }

    private void Changed(object? context)
    {
        Detach();
        Attach();
    }

    public void Attach()
    {
        if(!(_control.DataContext is DesignerViewModel designerViewModel))
            return;

        var presenterViewData = _control.FindControl<Control>("RenderViewData");
        var presenterViewTemplate = _control.FindControl<Control>("RenderViewTemplate");
        var presenterViewEditor = _control.FindControl<Control>("RenderViewEditor");
        var zoomBorder = _control.FindControl<ZoomBorder>("PageZoomBorder");

        if (designerViewModel.CanvasPlatform is { } canvasPlatform)
        {
            canvasPlatform.InvalidateControl = () =>
            {
                presenterViewData?.InvalidateVisual();
                presenterViewTemplate?.InvalidateVisual();
                presenterViewEditor?.InvalidateVisual(); 
            };

            canvasPlatform.ResetZoom = () => zoomBorder?.ResetMatrix();
            canvasPlatform.FillZoom = () => zoomBorder?.Fill();
            canvasPlatform.UniformZoom = () => zoomBorder?.Uniform();
            canvasPlatform.UniformToFillZoom = () => zoomBorder?.UniformToFill();
            canvasPlatform.AutoFitZoom = () => zoomBorder?.AutoFit();
            canvasPlatform.InZoom = () => zoomBorder?.ZoomIn();
            canvasPlatform.OutZoom = () => zoomBorder?.ZoomOut();
            canvasPlatform.Zoom = zoomBorder;
        }

        if (zoomBorder is { })
        {
            zoomBorder.ZoomChanged += ZoomBorder_ZoomChanged; 
        }

        if (zoomBorder is null || presenterViewEditor is null) 
            return;
        _inputSource = new AvaloniaInputSource(zoomBorder, presenterViewEditor, p => p);
        _inputTarget = new ProjectEditorInputTarget(designerViewModel);
        _inputProcessor = new InputProcessor();
        _inputProcessor.Connect(_inputSource, _inputTarget);
    }


    public void Detach()
    {
        if(!(_control.DataContext is DesignerViewModel designerViewModel))
            return;

        if (designerViewModel.CanvasPlatform is { } canvasPlatform)
        {
            canvasPlatform.InvalidateControl = null;
            canvasPlatform.ResetZoom = null;
            canvasPlatform.FillZoom = null;
            canvasPlatform.UniformZoom = null;
            canvasPlatform.UniformToFillZoom = null;
            canvasPlatform.AutoFitZoom = null;
            canvasPlatform.InZoom = null;
            canvasPlatform.OutZoom = null;
            canvasPlatform.Zoom = null;
        }

        var zoomBorder = _control.FindControl<ZoomBorder>("PageZoomBorder");
        if (zoomBorder is { })
        {
            zoomBorder.ZoomChanged -= ZoomBorder_ZoomChanged;
        }

        _inputProcessor?.Dispose();
        _inputProcessor = null;
        _inputTarget = null;
        _inputSource = null;
    }
    
    private void ZoomBorder_ZoomChanged(object? sender, ZoomChangedEventArgs e)
    {
        InvalidateChild(e.ZoomX, e.ZoomY, e.OffsetX, e.OffsetY);
    }

}