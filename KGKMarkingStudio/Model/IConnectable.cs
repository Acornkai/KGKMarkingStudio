using System;
using KGKMarkingStudio.ViewModels.Shapes;

namespace KGKMarkingStudio.Model;

public interface IConnectable
{
    bool Connect(PointShapeViewModel? point, PointShapeViewModel? target);

    bool Disconnect(PointShapeViewModel? point, out PointShapeViewModel? result);

    bool Disconnect();
}
