using System;
using KGKMarkingStudio.Model.Input;
using KGKMarkingStudio.Model.Renderer;
using KGKMarkingStudio.ViewModels.Renderer;

namespace KGKMarkingStudio.ViewModels.Editor;

public class ProjectEditorInputTarget : InputTarget
{
    private readonly DesignerViewModel _editor;
    
    
    public ProjectEditorInputTarget(DesignerViewModel editor)
    {
        _editor = editor;
    }


    public override void BeginDown(InputArgs args)
    {
        //_editor.CurrentTool?.BeginDown(args);
    }

    public override void BeginUp(InputArgs args)
    {
        //_editor.CurrentTool?.BeginUp(args);
    }

    public override void EndDown(InputArgs args)
    {
        //_editor.CurrentTool?.EndDown(args);
    }

    public override void EndUp(InputArgs args)
    {
        //_editor.CurrentTool?.EndUp(args);
    }

    public override void Move(InputArgs args)
    {
        //_editor.CurrentTool?.Move(args);
    }

    public override bool IsBeginDownAvailable()
    {
        throw new System.NotImplementedException();
    }

    public override bool IsBeginUpAvailable()
    {
        throw new System.NotImplementedException();
    }

    public override bool IsEndDownAvailable()
    {
        throw new System.NotImplementedException();
    }

    public override bool IsEndUpAvailable()
    {
        throw new System.NotImplementedException();
    }

    public override bool IsMoveAvailable()
    {
        throw new System.NotImplementedException();
    }
}