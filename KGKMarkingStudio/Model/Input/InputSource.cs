using System;

namespace KGKMarkingStudio.Model.Input;

/// <summary>
/// 描述编辑行为的
/// </summary>
public abstract class InputSource
{
    public IObservable<InputArgs>? BeginDown { get; set; }

    public IObservable<InputArgs>? BeginUp { get; set; }

    public IObservable<InputArgs>? EndDown { get; set; }
    
    public IObservable<InputArgs>? EndUp { get; set; }
    
    public IObservable<InputArgs>? Move { get; set; }
}