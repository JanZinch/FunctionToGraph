﻿using System;
using System.Windows;
using System.Windows.Media;

namespace FunctionToGraph.Resources.Logical;

public static class AppResources
{
    private static App AppContext => (App)Application.Current;
    
    private const string GraphColorKey = "GraphColor";

    public static event Action<Color> OnGraphColorCahnged; 
    
    public static Color GraphColor
    {
        get => (Color)AppContext.LogicalResources[GraphColorKey];
        set
        {
            AppContext.LogicalResources[GraphColorKey] = value; 
            OnGraphColorCahnged?.Invoke(value);
        }
        
    }
}