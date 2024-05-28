﻿using PhisilyncFinal.ViewModels;
using Plugin.Maui.Calendar.Models;
using PhisilyncFinal.Models;
using CommunityToolkit.Mvvm.Input;



namespace PhisilyncFinal.Views;

public partial class AthleteDash : ContentPage
{
    

    public AthleteDash(AthleteDashVM athleteDashVM)
    {
        InitializeComponent();
        BindingContext = athleteDashVM;
    }

    
}