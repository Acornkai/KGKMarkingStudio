using System;
using System.Collections.Generic;
using KGKMarkingStudio.ViewModels.Editor;
using KGKMarkingStudio.ViewModels.Shapes;

namespace KGKMarkingStudio.ViewModels.Editors;

public partial class TextBindingEditorViewModel : ViewModelBase
{
    [AutoNotify] private ProjectEditorViewModel? _editor;
    [AutoNotify] private TextShapeViewModel? _text;

    public TextBindingEditorViewModel(IServiceProvider? serviceProvider) : base(serviceProvider)
    {

    }

    public override object Copy(IDictionary<object, object>? source)
    {
        throw new NotImplementedException();
    }

    

}
