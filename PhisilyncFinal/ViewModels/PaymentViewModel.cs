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

namespace PhisilyncFinal.ViewModels
{
    public class PaymentViewModel
    {
        public ObservableCollection<Payments> Payment { get; private set; }

        public PaymentViewModel()
        {
            Payment =
            [
                new Payments
                {
                    CourseDescription = "Access Our Premium features for 30 days",
                    CourseDuration = "1 Month",
                    CourseName = "Premium 30 Days",
                    CoursePrice = 50,
                    PaymentFrequency = "Monthly",
                    Savings = 0,
                    PremiumImage = "premium.webp",
                },
                new Payments
                {
                    CourseDescription = "Access Our Premium features for 6 months",
                    CourseDuration = "6 Months",
                    CourseName = "Premium 6 Months",
                    CoursePrice = 280,
                    PaymentFrequency = "Semi-Annually",
                    Savings = 20,
                    PremiumImage = "premium.webp",
                },
                new Payments
                {
                    CourseDescription = "Access Our Premium features for 1 year",
                    CourseDuration = "1 Year",
                    CourseName = "Premium 1 Year",
                    CoursePrice = 500,
                    PaymentFrequency = "Annually",
                    Savings = 100,
                    PremiumImage = "premium.webp",
                },
            ];
                
        }
    }
}
