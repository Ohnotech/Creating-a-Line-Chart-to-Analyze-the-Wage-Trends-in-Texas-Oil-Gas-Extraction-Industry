# Creating a Line Chart to Analysis the Wage Trends in Texas Oil Gas Extraction Industry
This blog demonstrates the trend of employed individuals in the Texas Oil Gas Extraction Industry over the past fifteen years using a Syncfusion .NET MAUI Line Chart.

Line chart is used to represent the data trends at equal intervals by connecting points on a plot with straight lines. Here, we have analyse percentage of employment growth or decline over the last fifteen years in the Texas Oil Gas Extraction Industry.

## Customizing axis

### Axis crossing

The chart allows you to customize the origin, by default the axis will be rendered with (0,0) as the origin in x and y-axes. An axis can be positioned anywhere in the chart area by using the CrossesAt property. This property specifies where the horizontal axis intersects or crosses the vertical axis, and vice versa. 

The RenderNextToCrossingValue property is used to determine whether the crossing axis should be placed at crossing position or not. The default value of RenderNextToCrossingValue property is true.

### Label format in Label styles
The LabelFormat property in the label style of a Syncfusion .NET MAUI chart axis allows you to customize the format of the labels displayed along the axis. You can use this property to specify how the values on the axis should be formatted, such as displaying them as currency, percentages, dates, or custom strings.

### Display grid lines
The ShowMajorGridLines and ShowMinorGridLines properties control the visibility of the major and minor grid lines on the chart axis, respectively. When set to true, these properties display grid lines along the major and minor tick marks of the axis, providing visual reference points to help interpret the data plotted on the chart. When set to false, the grid lines are hidden. Adjusting these properties allows you to control the appearance of the grid lines based on your specific chart design and requirements

![OutputImage](https://github.com/SyncfusionExamples/Creating-a-Line-Chart-to-Analysis-the-Wage-Trends-in-Texas-Oil-Gas-Extraction-Industry/assets/105482474/c8593c82-cbca-492b-9bdd-a621880c2017)