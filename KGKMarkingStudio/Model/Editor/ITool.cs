using KGKMarkingStudio.Model.Input;
using KGKMarkingStudio.ViewModels;

namespace KGKMarkingStudio.Model.Editor;


public interface ITool
{
    string Title { get; }

    void BeginDown(InputArgs args);
    
    void BeginUp(InputArgs args);
    
    void EndDown(InputArgs args);
    
    void EndUp(InputArgs args);
    
    void Move(InputArgs args);
    
    void BeginDown(BaseShapeViewModel? shape);

    void Finalize(BaseShapeViewModel? shape);

    void Reset();
}