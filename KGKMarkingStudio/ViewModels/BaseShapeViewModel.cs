

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.Serialization;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using KGKMarkingStudio.Model;
using KGKMarkingStudio.Model.Renderer;
using KGKMarkingStudio.ViewModels.Containers;
using KGKMarkingStudio.ViewModels.Data;
using KGKMarkingStudio.ViewModels.Editor;
using KGKMarkingStudio.ViewModels.Shapes;
using KGKMarkingStudio.ViewModels.Style;

namespace KGKMarkingStudio.ViewModels;

/// <summary>
/// 形状viewmodel基类
/// </summary>
public abstract partial class BaseShapeViewModel : ViewModelBase, IDataObject, ISelectable, IConnectable, IDrawable
{
    private readonly IDictionary<string, object?> _propertyCache = new Dictionary<string, object?>();

    [AutoNotify] protected ShapeStateFlags _state;

    [AutoNotify] protected ShapeStyleViewModel? _style;

    [AutoNotify] protected bool _isStroked;

    [AutoNotify] protected bool _isFilled;

    [AutoNotify] protected ImmutableArray<PropertiyViewModel> _properties;

    [AutoNotify] protected RecordViewModel? _record;

    [AutoNotify(SetterModifier = AccessModifier.None)] protected readonly Type _targetType;


    public BaseShapeViewModel(IServiceProvider? serviceProvider, Type targetType) : base(serviceProvider)
    {
        _targetType = targetType;

        AddProperty = new RelayCommand<ViewModelBase?>(x => GetProject()?.OnAddProperty(x));

        RemoveProperty = new RelayCommand<PropertiyViewModel?>(x => GetProject()?.OnRemoveProperty(x));

        ResetRecord = new RelayCommand<IDataObject?>(x => GetProject()?.OnResetRecord(x));
 
        ProjectContainerViewModel? GetProject() => serviceProvider.GetService<ProjectEditorViewModel>()?.Project;
    }

    [IgnoreDataMember]
    public ICommand AddProperty { get; }

    [IgnoreDataMember]
    public ICommand RemoveProperty { get; }

    [IgnoreDataMember]
    public ICommand ResetRecord { get; }
    public ShapeStyleViewModel? style { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public override bool IsDirty()
    {
        var isDirty = base.IsDirty();

        foreach(var property in _properties)
        {
            isDirty |= property.IsDirty();
        }

        if(Record is {})
        {
            isDirty |= Record.IsDirty();
        }

        return isDirty;
    }

    public override void Invalidate()
    {
        base.Invalidate();

        foreach(var property in _properties)
        {
            property.Invalidate();
        }
        Record?.Invalidate();
    }

    public virtual void DrawShape(object? dc, IShapeRenderer? renderer, ISelection? selection)
    {
        throw new NotImplementedException();
    }

    public virtual void DrawPoints(object? dc, IShapeRenderer? renderer, ISelection? selection)
    {
        throw new NotImplementedException();
    }

    public virtual bool Invalidate(IShapeRenderer? renderer)
    {
        return false;
    }

    public virtual void SetProperty(string name, object? value)
    {
        
    }

    public virtual object? GetProperty(string name)
    {
        
        return null;
    }

    public virtual void Move(ISelection? selection, decimal dx, decimal dy)
    {
        throw new NotImplementedException();
    }

    public virtual void Select(ISelection? selection)
    {
        if(selection?.SelectedShapes is null)
        {
            return;
        }

        if(!selection.SelectedShapes.Contains(this))
        {
            selection.SelectedShapes.Add(this);
        } 
    }

    public virtual void Deselect(ISelection? selection)
    {
        if(selection?.SelectedShapes is null)
        {
            return;
        }

        if(!selection.SelectedShapes.Contains(this))
        {
            selection.SelectedShapes.Remove(this);
        }
    }

    public virtual bool Connect(PointShapeViewModel? point, PointShapeViewModel? target)
    {
        throw new NotImplementedException();
    }

    public virtual bool Disconnect(PointShapeViewModel? point, out PointShapeViewModel? result)
    {
        throw new NotImplementedException();
    }

    public virtual bool Disconnect()
    {
        throw new NotImplementedException(); 
    }

}