# Depth axis in WPF 3D Chart

[ChartAxis](https://help.syncfusion.com/cr/cref_files/wpf/Syncfusion.SfChart.WPF~Syncfusion.UI.Xaml.Charts.ChartAxis.html#) is used to locate a data point inside the chart area. Charts typically have two axes that are used to measure and categorize data: a vertical (Y) axis and a horizontal (X) axis. 

[PrimaryAxis](https://help.syncfusion.com/cr/cref_files/wpf/Syncfusion.SfChart.WPF~Syncfusion.UI.Xaml.Charts.SfChart3D~PrimaryAxis.html) – Gets or sets the horizontal x axis for the chart.

[SecondaryAxis](https://help.syncfusion.com/cr/cref_files/wpf/Syncfusion.SfChart.WPF~Syncfusion.UI.Xaml.Charts.SfChart3D~SecondaryAxis.html) – Gets or sets the vertical y axis for the chart.

Additionally, SfChart3D have horizontal (z) Axis called Depth axis.

# Depth axis

[DepthAxis](https://help.syncfusion.com/cr/cref_files/wpf/Syncfusion.SfChart.WPF~Syncfusion.UI.Xaml.Charts.SfChart3D~DepthAxis.html) helps us to plot chart data based on X, Y and Z Co – ordinates. This feature is supported in [Line](https://help.syncfusion.com/cr/cref_files/wpf/Syncfusion.SfChart.WPF~Syncfusion.UI.Xaml.Charts.LineSeries3D.html), [Column](https://help.syncfusion.com/cr/cref_files/wpf/Syncfusion.SfChart.WPF~Syncfusion.UI.Xaml.Charts.ColumnSeries3D.html), [Bar](https://help.syncfusion.com/cr/cref_files/wpf/Syncfusion.SfChart.WPF~Syncfusion.UI.Xaml.Charts.BarSeries3D.html), [StackingColumnSeries](https://help.syncfusion.com/cr/cref_files/wpf/Syncfusion.SfChart.WPF~Syncfusion.UI.Xaml.Charts.StackingColumnSeries3D.html), [StackingBarSeries](https://help.syncfusion.com/cr/cref_files/wpf/Syncfusion.SfChart.WPF~Syncfusion.UI.Xaml.Charts.StackingBarSeries3D.html) and [Scatter series](https://help.syncfusion.com/cr/cref_files/wpf/Syncfusion.SfChart.WPF~Syncfusion.UI.Xaml.Charts.StackingBarSeries3D.html). 

The depth axis is implemented by defining the required axis type to the [DepthAxis](https://help.syncfusion.com/cr/cref_files/wpf/Syncfusion.SfChart.WPF~Syncfusion.UI.Xaml.Charts.SfChart3D~DepthAxis.html) property of the SfChart3D and by mapping the  Z data points to the series using the [ZBindingPath](https://help.syncfusion.com/cr/cref_files/wpf/Syncfusion.SfChart.WPF~Syncfusion.UI.Xaml.Charts.XyzDataSeries3D~ZBindingPath.html) of the series. When DepthAxis is not defined, by default it is created based on the ZBindingPath data type.

The following code example illustrates how to create Depth Axis.

**[XAML]**
```
<chart:SfChart3D>
 
    …
    <chart:SfChart3D.DepthAxis>
        <chart:NumericalAxis3D Interval="1"/>
    </chart:SfChart3D.DepthAxis>

    <chart:ColumnSeries3D XBindingPath="XValue"                                
                          YBindingPath="YValue"
                          ZBindingPath="ZValue"
                          ItemsSource="{Binding Data}"/>

</chart:SfChart3D>
```
**[C#]**

```
 SfChart3D chart = new SfChart3D();

        chart.Rotation = 43;
        chart.Tilt = 10;
        chart.Margin = new Thickness(120, 20, 120, 30);
        chart.PerspectiveAngle = 100;
        chart.EnableRotation = true;

        NumericalAxis3D depthAxis = new NumericalAxis3D();
        depthAxis.Interval = 1;
        chart.DepthAxis = depthAxis;

        ColumnSeries3D series1 = new ColumnSeries3D();
        series1.ItemsSource = (new ViewModel()).Data;
        series1.XBindingPath = "XValue";
        series1.YBindingPath = "YValue";
        series1.ZBindingPath = "ZValue";
        chart.Series.Add(series1);
        this.Content = chart;
```
[3D Chart with Z axis](SfChart3D_ZAxis.png)

#3D Manhattan Chart

In this type of chart, multiple series can be plotted in [DepthAxis](https://help.syncfusion.com/cr/cref_files/wpf/Syncfusion.SfChart.WPF~Syncfusion.UI.Xaml.Charts.SfChart3D~DepthAxis.html). To enable Manhattan chart add the required number of series and define the DepthAxis. The Manhattan axis is of type category with the axis labels mapped to the [Label](https://help.syncfusion.com/cr/cref_files/wpf/Syncfusion.SfChart.WPF~Syncfusion.UI.Xaml.Charts.ChartSeriesBase~Label.html) property of the series. If the Label property of the series is not defined, the labels are displayed as Series1, Series2 and so on.

**[XAML]**

```
  . . . 
        <chart:SfChart3D.DepthAxis>
            <chart:NumericalAxis3D Interval="1"/>
        </chart:SfChart3D.DepthAxis>

        <chart:LineSeries3D XBindingPath="XValue"                                
                            YBindingPath="YValue"                         
                            ItemsSource="{Binding Data1}" 
                            Label="First"/>

        <chart:LineSeries3D XBindingPath="XValue"                                
                            YBindingPath="YValue"                         
                            ItemsSource="{Binding Data2}" 
                            Label="Second"/>

    </chart:SfChart3D>
```

**[C#]**

```
  chart.Rotation = 43;
        . . . 

        NumericalAxis3D depthAxis = new NumericalAxis3D();
        depthAxis.Interval = 1;
        chart.DepthAxis = depthAxis;


        LineSeries3D series1 = new LineSeries3D();
        series1.ItemsSource = (new ViewModel()).Data1;
        series1.XBindingPath = "XValue";
        series1.YBindingPath = "YValue";
        series1.Label = "First";


        LineSeries3D series2 = new LineSeries3D();
        series2.ItemsSource = (new ViewModel()).Data2;
        series2.XBindingPath = "XValue";
        series2.YBindingPath = "YValue";
        series2.Label = "Second";

        chart.Series.Add(series1);
        chart.Series.Add(series2);
        this.Content = chart;

```
[3D chart in WPF](Manhattan_Chart.png)
