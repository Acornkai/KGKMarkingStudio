using Avalonia.Controls;
using Avalonia.Xaml.Interactivity;

namespace KGKMarkingStudio.Behaviors;

/// <summary>
/// 附加编辑器行为
/// </summary>
public class AttachEditorBehavior : Behavior<Control>
{
    private AttachEditor? _input;

    protected override void OnAttached()
    {
        base.OnAttached();

        if (AssociatedObject is not null)
        {
            _input = new AttachEditor(AssociatedObject);
        }
    }

    protected override void OnDetaching()
    {
        base.OnDetaching();

        if (AssociatedObject is not null)
        {
            _input?.Detach();
        }
    }
}