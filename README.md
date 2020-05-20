# Depth axis in WPF 3D Chart

(ChartAxis)[https://help.syncfusion.com/cr/cref_files/wpf/Syncfusion.SfChart.WPF~Syncfusion.UI.Xaml.Charts.ChartAxis.html#] is used to locate a data point inside the chart area. Charts typically have two axes that are used to measure and categorize data: a vertical (Y) axis and a horizontal (X) axis. 

(PrimaryAxis)[https://help.syncfusion.com/cr/cref_files/wpf/Syncfusion.SfChart.WPF~Syncfusion.UI.Xaml.Charts.SfChart3D~PrimaryAxis.html] – Gets or sets the horizontal x axis for the chart.

(SecondaryAxis)[https://help.syncfusion.com/cr/cref_files/wpf/Syncfusion.SfChart.WPF~Syncfusion.UI.Xaml.Charts.SfChart3D~SecondaryAxis.html] – Gets or sets the vertical y axis for the chart.

Additionally, SfChart3D have horizontal (z) Axis called Depth axis.

# Depth axis

DepthAxis - Gets or sets the horizontal z axis for the chart.

DepthAxis helps us to plot chart data based on X, Y and Z Co – ordinates. This feature is supported in Line, Column, Bar, StackingColumnSeries, StackingBarSeries and Scatter series. 

The depth axis is implemented by defining the required axis type to the DepthAxis property of the SfChart3D and by mapping the  Z data points to the series using the ZBindingPath of the series. When DepthAxis is not defined, by default it is created based on the ZBindingPath’s data type.

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
