# 3D Chart with DepthAxis (Z Axis)

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
