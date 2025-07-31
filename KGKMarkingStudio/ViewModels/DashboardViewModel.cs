using System;
using System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;
using LiveChartsCore;
using LiveChartsCore.Defaults;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Extensions;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;

namespace KGKMarkingStudio.ViewModels;

public partial class DashboardViewModel : ViewModelBase
{
    private readonly Random _random = new();
    private readonly List<DateTimePoint> _values = [];
    private readonly DateTimeAxis _customAxis;

     private IEnumerable<ISeries> _series;

     private Axis[] _xAxes;

     private object _sync = new object();
    
     private SolidColorPaint _legendTextPaint = 
        new SolidColorPaint 
        { 
            Color = new SKColor(50, 50, 50), 
            SKTypeface = SKTypeface.FromFamilyName("Courier New") 
        }; 
    
     private SolidColorPaint _ledgendBackgroundPaint = 
        new SolidColorPaint(new SKColor(255, 255, 255)); 
    
     private ISeries[] _officeSeries = [
        new ColumnSeries<double>
        {
            Values = [ 2, 5, 4, 40, 8, 3, 12, 30, 5, 4, 15, 26, 20 ],
            

            // Defines the distance between every bars in the series
            Padding = 10,

            // Defines the max width a bar can have
            MaxBarWidth = double.MaxValue
        }
    ];
    
    private Axis[] _officeXAxes =
    [
        new Axis
        {
            Labels = ["Beijing", "Changsha", "Chengdu", "Guangzhou", "Hangzhou", "Nanchang", "Nanjin", "Qingdao", "Shanghai", "Shenyang", "Shijiazhuang", "Xiamen", "Zhenzhou", "Wuhan"],
            LabelsRotation = -30,
            SeparatorsPaint = new SolidColorPaint(new SKColor(200, 200, 200)),
            SeparatorsAtCenter = false,
            TicksPaint = new SolidColorPaint(new SKColor(35, 35, 35)),
            TicksAtCenter = false,
            // By default the axis tries to optimize the number of 
            // labels to fit the available space, 
            // when you need to force the axis to show all the labels then you must: 
            ForceStepToMin = true, 
            MinStep = 1
        }
    ];

    private bool IsReading { get; set; } = true;
    
    public DashboardViewModel() : base(null)
    {
        _series =  new[] { 2, 4, 1, 4, 3 }.AsPieSeries((value, series) =>
        {
            series.Name = $"S{value}";
            series.MaxRadialColumnWidth = 40;
            
        });
        

        _customAxis = new DateTimeAxis(TimeSpan.FromSeconds(1), Formatter)
        {
            CustomSeparators = GetSeparators(),
            AnimationsSpeed = TimeSpan.FromMilliseconds(0),
            SeparatorsPaint = new SolidColorPaint(SKColors.Black.WithAlpha(100))
        };

        _xAxes = [_customAxis];

        //_ = ReadData();
    }
    
   
    private static double[] GetSeparators()
    {
        var now = DateTime.Now;

        return
        [
            now.AddSeconds(-25).Ticks,
            now.AddSeconds(-20).Ticks,
            now.AddSeconds(-15).Ticks,
            now.AddSeconds(-10).Ticks,
            now.AddSeconds(-5).Ticks,
            now.Ticks
        ];
    }

    private static string Formatter(DateTime date)
    {
        var secsAgo = (DateTime.Now - date).TotalSeconds;

        return secsAgo < 1
            ? "now"
            : $"{secsAgo:N0}s ago";
    }


    public override object Copy(IDictionary<object, object>? source)
    {
        throw new NotImplementedException();
    }
}