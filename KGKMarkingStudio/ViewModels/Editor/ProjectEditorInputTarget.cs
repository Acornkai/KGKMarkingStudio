
using KGKMarkingStudio.Model.Input;


namespace KGKMarkingStudio.ViewModels.Editor;

public class ProjectEditorInputTarget : InputTarget
{
    private readonly ProjectEditorViewModel _editor;
    
    
    public ProjectEditorInputTarget(ProjectEditorViewModel editor)
    {
        _editor = editor;
    }


    public override void BeginDown(InputArgs args) =>  _editor.CurrentTool?.BeginDown(args);

    public override void BeginUp(InputArgs args) => _editor.CurrentTool?.BeginUp(args);

    public override void EndDown(InputArgs args) => _editor.CurrentTool?.EndDown(args);

    public override void EndUp(InputArgs args) => _editor.CurrentTool?.EndUp(args);

    public override void Move(InputArgs args) => _editor.CurrentTool?.Move(args);

    public override bool IsBeginDownAvailable()
    {
        return _editor.Project?.CurrentContainer?.CurrentLayer is { }
             && _editor.Project.CurrentContainer.CurrentLayer.IsVisible;
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