
using System.Collections.Immutable;
using System.Windows.Input;
using KGKMarkingStudio.ViewModels.Data;

namespace KGKMarkingStudio.Model;

public interface IDataObject
{
    ImmutableArray<PropertiyViewModel> Properties { get; set; }

    RecordViewModel? Record { get; set;}

    ICommand AddProperty { get; }

    ICommand RemoveProperty { get; }

    ICommand ResetRecord { get; }

}
