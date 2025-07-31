using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reactive.Disposables;
using KGKMarkingStudio.Model.Renderer;
using KGKMarkingStudio.ViewModels.Style;

namespace KGKMarkingStudio.ViewModels.Renderer;

public partial class ShapeRendererStateViewModel : ViewModelBase
{
    [AutoNotify] private double _panX;  //X方向平移大小
    [AutoNotify] private double _panY;
    [AutoNotify] private double _zoomX; //X方向缩放大小
    [AutoNotify] private double _zoomY;
    [AutoNotify] private ShapeStateFlags _drawShapeState;
    [AutoNotify] private IImageCache? _imageCache;
    [AutoNotify] private bool _drawDecorators;    //装饰器
    [AutoNotify] private bool _drawPoints;
    [AutoNotify] private ShapeStyleViewModel? _pointStyle;
    [AutoNotify] private ShapeStyleViewModel? _selectedPointStyle;
    [AutoNotify] private double _pointSize;
    [AutoNotify] private ShapeStyleViewModel? _selectionStyle;
    [AutoNotify] private ShapeStyleViewModel? _helperStyle;
    [AutoNotify] private IDecorator? _decorator;


    public ShapeRendererStateViewModel(IServiceProvider? serviceProvider) : base(serviceProvider)
    {
    }

    public override object Copy(IDictionary<object, object>? source)
    {
        throw new NotImplementedException();
    }

    public override bool IsDirty()
    {
        return base.IsDirty();  
    }

    public override void Invalidate()
    {
        base.Invalidate();
        
        _pointStyle?.Invalidate();
        _selectedPointStyle?.Invalidate();
        _selectionStyle?.Invalidate();
        _helperStyle?.Invalidate();
    }

    public override IDisposable Subscribe(IObserver<(object? sender, PropertyChangedEventArgs? e)> observer)
    {
        var mainDisposable = new CompositeDisposable();
        var disposablePropertyChanged = default(IDisposable);
        var disposablePointStyle = default(IDisposable);
        var disposableSelectedPointStyle = default(IDisposable);
        var disposableSelectionStyle = default(IDisposable);
        var disposableHelperStyle = default(IDisposable);
        
        ObserverSelf(Handler, ref disposablePropertyChanged, mainDisposable);
        ObserveObject(_pointStyle, ref disposablePointStyle, mainDisposable, observer);
        ObserveObject(_selectedPointStyle, ref disposableSelectedPointStyle, mainDisposable, observer);
        ObserveObject(_selectionStyle, ref disposableSelectionStyle, mainDisposable, observer);
        ObserveObject(_helperStyle, ref disposableHelperStyle, mainDisposable, observer);

        void Handler(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(PointStyle))
            {
                ObserveObject(_pointStyle, ref disposablePointStyle, mainDisposable, observer);
            }

            if (e.PropertyName == nameof(SelectedPointStyle))
            {
                ObserveObject(_selectedPointStyle, ref disposableSelectedPointStyle, mainDisposable, observer);
            }

            if (e.PropertyName == nameof(SelectionStyle))
            {
                ObserveObject(_selectionStyle, ref disposableSelectionStyle, mainDisposable, observer);
            }

            if (e.PropertyName == nameof(HelperStyle))
            {
                ObserveObject(_helperStyle, ref disposableHelperStyle, mainDisposable, observer);
            }
            
            observer.OnNext((sender, e));
        }

        return mainDisposable;
    }

}