using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using KGKMarkingStudio.Model;
using KGKMarkingStudio.Model.Renderer;
using KGKMarkingStudio.ViewModels.Containers;

namespace KGKMarkingStudio.Views.Renderer;

public partial class RenderView : UserControl
{
    public RenderView()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Container StyledProperty definition
    /// indicates .
    /// </summary>
    public static readonly StyledProperty<FrameContainerViewModel?> ContainerProperty =
        AvaloniaProperty.Register<RenderView, FrameContainerViewModel?>(nameof(Container));
    
    /// <summary>
    /// Gets or sets the Container property. This StyledProperty
    /// indicates .
    /// </summary>
    public FrameContainerViewModel? Container
    {
       get => this.GetValue(ContainerProperty);
       set => SetValue(ContainerProperty, value);
    }
    

    /// <summary>
    /// Renderer StyledProperty definition
    /// indicates .
    /// </summary>
    public static readonly StyledProperty<IShapeRenderer?> RendererProperty =
        AvaloniaProperty.Register<RenderView, IShapeRenderer?>(nameof(Renderer));
    
    /// <summary>
    /// Gets or sets the Renderer property. This StyledProperty
    /// indicates .
    /// </summary>
    public IShapeRenderer? Renderer
    {
       get => this.GetValue(RendererProperty);
       set => SetValue(RendererProperty, value);
    }
    

    /// <summary>
    /// Selection StyledProperty definition
    /// indicates .
    /// </summary>
    public static readonly StyledProperty<ISelection?> SelectionProperty =
        AvaloniaProperty.Register<RenderView, ISelection?>(nameof(Selection));
    
    /// <summary>
    /// Gets or sets the Selection property. This StyledProperty
    /// indicates .
    /// </summary>
    public ISelection? Selection
    {
       get => this.GetValue(SelectionProperty);
       set => SetValue(SelectionProperty, value);
    }
    

    // /// <summary>
    // /// DataFlow StyledProperty definition
    // /// indicates .
    // /// </summary>
    // public static readonly StyledProperty<DataFlow?> DataFlowProperty =
    //     AvaloniaProperty.Register<RenderView, DataFlow?>(nameof(DataFlow));
    
    // /// <summary>
    // /// Gets or sets the DataFlow property. This StyledProperty
    // /// indicates .
    // /// </summary>
    // public DataFlow? DataFlow
    // {
    //    get => this.GetValue(DataFlowProperty);
    //    set => SetValue(DataFlowProperty, value);
    // }
    

    /// <summary>
    /// RenderType StyledProperty definition
    /// indicates .
    /// </summary>
    public static readonly StyledProperty<RenderType> RenderTypeProperty =
        AvaloniaProperty.Register<RenderView, RenderType>(nameof(RenderType));
    
    /// <summary>
    /// Gets or sets the RenderType property. This StyledProperty
    /// indicates .
    /// </summary>
    public RenderType RenderType
    {
       get => this.GetValue(RenderTypeProperty);
       set => SetValue(RenderTypeProperty, value);
    }



    public override void Render(DrawingContext context)
    {
        base.Render(context);

        var drawState = new RenderState
        {
            Container = Container,
            Renderer = Renderer ?? GetValue(RendererOptions.RendererProperty),
            Selection = Selection ?? GetValue(RendererOptions.SelectionProperty),
            RenderType = RenderType

        };

        // TODO:
        // var customDrawOperation = new RenderDrawOperation
        // {
        //     RenderState = drawState,
        //     Bounds = Bounds
        // };
        // context.Custom(customDrawOperation);

        RenderDrawOperation.Draw(drawState, context);

    }



}