using System;

namespace KGKMarkingStudio.Model.Input;

/// <summary>
/// 描述修改状态的标记
/// </summary>
[Flags]
public enum ModifierFlags
{
    None = 0,
    Alt = 1,
    Control = 2,
    Shift = 4
}