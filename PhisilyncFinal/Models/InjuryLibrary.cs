﻿//using Android.Hardware.Biometrics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Maui;

namespace PhisilyncFinal.Models
{
    public class InjuryLibrary
    {
        public string InjuryName { get; set; }
        public string InjuryAnatomy { get; set; }
        public string InjuryTest { get; set; }
        public string InjuryRelease { get; set; }
        public string InjuryImage {  get; set; }
        public string Prompt { get; set; }
        public string GlossaryPrompt { get; set; }
        public string GlossBtnImage { get; set; }
    }
}
