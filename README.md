# XamlAdorner

[![NuGet](https://img.shields.io/nuget/v/MinimalAvalonia.svg)](https://www.nuget.org/packages/XamlAdorner)
[![NuGet](https://img.shields.io/nuget/dt/MinimalAvalonia.svg)](https://www.nuget.org/packages/XamlAdorner)

Set control adorner from xaml in Avalonia

# Usage


```XAML
<Button Content="Adorned Button" 
        HorizontalAlignment="Stretch" HorizontalContentAlignment="Center"
        VerticalContentAlignment="Center" VerticalAlignment="Stretch" 
        Width="200" Height="42">
  <XamlAdornerLayer.Adorner>
    <Canvas x:Name="AdornerCanvas"
            HorizontalAlignment="Stretch"
            VerticalAlignment="Stretch"
            Background="Cyan"
            IsHitTestVisible="False"
            Opacity="0.3"
            IsVisible="True">
      <Line StartPoint="-10000,0" EndPoint="10000,0" Stroke="Cyan" StrokeThickness="1" />
      <Line StartPoint="-10000,42" EndPoint="10000,42" Stroke="Cyan" StrokeThickness="1" />
      <Line StartPoint="0,-10000" EndPoint="0,10000" Stroke="Cyan" StrokeThickness="1" />
      <Line StartPoint="200,-10000" EndPoint="200,10000" Stroke="Cyan" StrokeThickness="1" />
    </Canvas>
  </XamlAdornerLayer.Adorner>
</Button>
```
