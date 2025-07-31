using System.Collections;
using System.Collections.Generic;
using KGKMarkingStudio.Model.Input;
using KGKMarkingStudio.ViewModels;
using KGKMarkingStudio.ViewModels.Containers;

namespace KGKMarkingStudio.Model.Renderer;

public interface IDecorator : IDrawable
{
    LayerContainerViewModel? Layer { get; set; }
    
    IList<BaseShapeViewModel>? Shapes { get; set; }
    
    bool IsVisible { get; set; }    
    
    void Update(bool rebuild = true);

    void Show();
    
    void Hide();

    /// <summary>
    /// 命中测试
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    bool HitTest(InputArgs args);
    
    void Move(InputArgs args);
}