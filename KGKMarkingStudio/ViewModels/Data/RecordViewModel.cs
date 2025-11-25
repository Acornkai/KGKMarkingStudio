using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Reactive.Disposables;

namespace KGKMarkingStudio.ViewModels.Data;

public partial class RecordViewModel : ViewModelBase
{
    [AutoNotify] private string _id = Guid.NewGuid().ToString();

    [AutoNotify] private ImmutableArray<ValueViewModel> _values = ImmutableArray.Create<ValueViewModel>();

    public RecordViewModel(IServiceProvider? serviceProvider) : base(serviceProvider)
    {
        
    }

    public override object Copy(IDictionary<object, object>? source)
    {
        var values = _values.CopyShared(source).ToImmutable();

        var copy = new RecordViewModel(ServiceProvider)
        {
            Name = Name,
            Values = values
        };
        return copy;
    }

    public override bool IsDirty()
    {
        var isDirty = base.IsDirty();

        foreach(var value in _values)
        {
            isDirty |= value.IsDirty(); 
        }
        return isDirty;
    }

    public override void Invalidate()
    {
        base.Invalidate();

        foreach(var value in _values)
        {
            value.Invalidate();
        }

    }

    public override IDisposable? Subscribe(IObserver<(object? sender, PropertyChangedEventArgs e)> observer)
    {
        var mainDisposable = new CompositeDisposable();
        var dispoablePropertyChanged = default(IDisposable);
        var diaposableValues = default(CompositeDisposable);

        ObserverSelf(Handler, ref dispoablePropertyChanged, mainDisposable);
        ObserveList(_values, ref diaposableValues, mainDisposable, observer);

        void Handler(object? sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName == nameof(Values))
            {
                ObserveList(_values, ref diaposableValues, mainDisposable, observer);
            }

            observer.OnNext((sender, e));
        }

        return mainDisposable;
    }


}
