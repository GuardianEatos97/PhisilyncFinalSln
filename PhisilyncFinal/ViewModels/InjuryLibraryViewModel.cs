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

namespace PhisilyncFinal.ViewModels
{
    public partial class InjuryLibraryViewModel : BaseViewModel
    {
        public ObservableCollection<InjuryLibrary> Injury { get; private set; }

        public InjuryLibraryViewModel() 
        {
            Injury = new ObservableCollection<InjuryLibrary>();

            Injury.Add(new InjuryLibrary
            {
                InjuryName = "Baboon",
                InjuryDescription = "Baboons are African and Arabian Old World monkeys belonging to the genus Papio, part of the subfamily Cercopithecinae.",
                InjuryImage = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg",
            });

            Injury.Add(new InjuryLibrary
            {
                InjuryName = "Seated Monkey",
                InjuryDescription = "This monkey is laid back and relaxed, and likes to watch the world go by. It doesn't make a lot of noise, often smiles mysteriously, and sleeps sitting up.",
                InjuryImage = "moerat.jpg"
            });
        }
    }
}
