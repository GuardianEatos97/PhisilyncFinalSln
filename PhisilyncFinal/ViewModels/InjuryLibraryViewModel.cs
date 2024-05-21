//using CoreML;
using PhisilyncFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Maui;
using System.Windows.Input;
//using Android.Content.Res;
//using AndroidX.Navigation;

namespace PhisilyncFinal.ViewModels
{
    public class InjuryLibraryViewModel
    {
        public ObservableCollection<InjuryLibrary> Injury { get; private set; }

        public InjuryLibraryViewModel()
        {
            Injury =
            [
                new InjuryLibrary
                {
                    InjuryName = "Neck Side Flexion (Neck Side Strain)",
                    Prompt = "Tap to see more info",
                    InjuryDescription = "Get on thou knees you insufferable plebian!",
                    InjuryImage = "moerat.jpg",
                },
                new InjuryLibrary
                {
                    InjuryName = "Neck Flexion (Frontal Neck Strain)",
                    Prompt = "Tap to see more info",
                    InjuryDescription = "off with the dog's head!",
                    InjuryImage = "moerat.jpg"
                },
                new InjuryLibrary
                {
                    InjuryName = "Neck Rotation (Full Neck Strain)",
                    Prompt = "Tap to see more info",
                    InjuryDescription = "off with the dog's head!",
                    InjuryImage = "moerat.jpg"
                },
                new InjuryLibrary
                {
                    InjuryName = "Trunk Rotation (Abdomen Strain)",
                    Prompt = "Tap to see more info",
                    InjuryDescription = "off with the dog's head!",
                    InjuryImage = "moerat.jpg"
                },
                new InjuryLibrary
                {
                    InjuryName = "Hip Abduction",
                    Prompt = "Tap to see more info",
                    InjuryDescription = "off with the dog's head!",
                    InjuryImage = "moerat.jpg"
                },
                new InjuryLibrary
                {
                    InjuryName = "Hip Adduction",
                    Prompt = "Tap to see more info",
                    InjuryDescription = "off with the dog's head!",
                    InjuryImage = "moerat.jpg"
                },
                new InjuryLibrary
                {
                    InjuryName = "Knee Extension (Pulled Hamstring)",
                    Prompt = "Tap to see more info",
                    InjuryDescription = "off with the dog's head!",
                    InjuryImage = "moerat.jpg"
                },
                new InjuryLibrary
                {
                    InjuryName = "Ankle Flexion (Pulled Calves)",
                    Prompt = "Tap to see more info",
                    InjuryDescription = "off with the dog's head!",
                    InjuryImage = "moerat.jpg"
                },
                new InjuryLibrary
                {
                    InjuryName = "Ankle Eversion",
                    Prompt = "Tap to see more info",
                    InjuryDescription = "off with the dog's head!",
                    InjuryImage = "moerat.jpg"
                },
                new InjuryLibrary
                {
                    InjuryName = "Ankle Inversion",
                    Prompt = "Tap to see more info",
                    InjuryDescription = "off with the dog's head!",
                    InjuryImage = "moerat.jpg"
                },
                new InjuryLibrary
                {
                    InjuryName = "Toe Extension",
                    Prompt = "Tap to see more info",
                    InjuryDescription = "off with the dog's head!",
                    InjuryImage = "moerat.jpg"
                },
                new InjuryLibrary
                {
                    InjuryName = "The LAT Test",
                    Prompt = "Tap to see more info",
                    InjuryDescription = "off with the dog's head!",
                    InjuryImage = "moerat.jpg"
                },
                new InjuryLibrary
                {
                    InjuryName = "The HBB Test",
                    Prompt = "Tap to see more info",
                    InjuryDescription = "off with the dog's head!",
                    InjuryImage = "moerat.jpg"
                },
            ];


        }
    }
}

