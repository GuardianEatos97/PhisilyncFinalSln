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
    public class GlossaryViewModel
    {
        public ObservableCollection<Glossary> Glossarys { get; private set; }

        public GlossaryViewModel()
        {
            Glossarys =
                [
                new Glossary
                {
                    GlossaryWord = "Abdominals (Abs)",
                    WordDescription = "The muscles in your stomach area that help you bend forward and stabilize your core",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Adductors",
                    WordDescription = "The muscles on the inside of your thigh that help bring your legs together",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Aponeurosis",
                    WordDescription = "A flat, sheet-like type of fascia that connects muscles to the parts they move, similar to a tendon but broader and flatter",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Biceps",
                    WordDescription = "the muscle on the front of your upper arm that helps you bend your elbow.",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Calves",
                    WordDescription = "The muscles on the back of your lower leg that help you stand on your toes and push off when walking or running",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Deep Fascia",
                    WordDescription = "A thicker, tougher layer of fascia that surrounds your muscles, bones, nerves, helping to support and separate them",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Deltoids",
                    WordDescription = "The shoulder muscles that help you lift your arm in different directions",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Endomysium",
                    WordDescription = "A very thin layer of fascia that wraps around individual muscle fibres within a muscle",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Epimysium",
                    WordDescription = "The outer layer of fascia that wraps around an entire muscle, keeping all the smaller parts together",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Erector Spinae",
                    WordDescription = "The muscles along your spine that help you stand up straight and bend backward.",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Fascia",
                    WordDescription = "A thin, stretchy tissue that wraps around all your muscles, organs, and blood vessels, holding them in place",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Fascial Compartment",
                    WordDescription = "Sections of muscles, nerves, and blood vessels that are grouped together within a layer of deep fascia, usually in the arms and legs",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Fascial Planes",
                    WordDescription = "Layers or sections of fascia that can glide over one another, allowing smooth movement between muscles and other structures",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Fascial Release",
                    WordDescription = "A type of therapy or treatment aimed at easing tension and tightness in the fascia, often used to relieve pain or improve movement",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Forearm Muscles",
                    WordDescription = "The muscles in your forearm that help you move your wrists, hands, and fingers",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Gastrocnemius",
                    WordDescription = "The main muscle of your calf that helps you push off when walking or running",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Gluteals (Glutes)",
                    WordDescription = "The muscles in your buttocks that help you move your hips and thighs",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Hamstrings",
                    WordDescription = "The muscles on the back of your thigh that help you bend your knee.",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Hips Flexors",
                    WordDescription = "The muscles in front of your hips that help you lift your knees and bend at the waist",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Intermuscular Septa",
                    WordDescription = "Walls of deep fascia that separate different muscle groups, helping to organize and support them",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Latissimus Dorsi (Lats)",
                    WordDescription = "The large muscles in your mid-back that help you pull your arms down and back",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Myofascia",
                    WordDescription = "The combined unit of muscle and fascia that surrounds and supports it, helping with the movement and flexibility",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Obliques",
                    WordDescription = "The muscles on the sides of your abdomen that help you twist your torso",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Pectorals (Pecs)",
                    WordDescription = "The chest muscles that help you move your arms across your body and push things away",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Perimysium",
                    WordDescription = "A slightly thicker layer of fascia that wraps around bundles of muscle fibres, called fascicles, within a muscle",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Plantar Fascia",
                    WordDescription = "The thick band of fascia on the bottom of your foot that supports the arch and helps with walking",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Quadriceps (Quads)",
                    WordDescription = "The muscles on the front of your thigh that help you straighten your knee",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Retinaculum",
                    WordDescription = "A band of thickened deep fascia that holds tendons in place, especially around your wrists and ankles",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Rhomboids",
                    WordDescription = "The muscles between your shoulder blades that help pull your shoulders back",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Serratus Anterior",
                    WordDescription = "The muscles on the side of your rib cage that help move your shoulder blades forward and up",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Soleus",
                    WordDescription = "The muscle underneath the gastrocnemius that also helps you stand on your toes",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Superficial Fascia",
                    WordDescription = "The layer of fascia just under your skin that helps store fat and water, and lets your skin move over muscles",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Trapezius (Traps)",
                    WordDescription = "The muscles in your upper back and neck that help you lift your shoulders and move your shoulder blades",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Triceps",
                    WordDescription = "The muscle on the back of your upper arm that helps you straighten your elbow",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Visceral Fascia",
                    WordDescription = "The fascia that wraps around your internal organs, keeping them in place and helping them work properly",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                /*new Glossary
                {
                    GlossaryWord = "",
                    WordDescription = "",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },*/

                ];
        }
    }
}
