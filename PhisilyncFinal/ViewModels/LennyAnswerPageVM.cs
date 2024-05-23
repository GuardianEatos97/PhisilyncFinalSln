using PhisilyncFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhisilyncFinal.ViewModels
{
    public class LennyAnswerPageVM:BaseViewModel
    {
        private LennyAIChatMessage _questionResponseModel;

        public LennyAIChatMessage Response
        {
            get { return _questionResponseModel; }
            set { _questionResponseModel = value; OnPropertyChanged(); }
        }
    
    
        public LennyAnswerPageVM()
        {
           
        }

    }
}
