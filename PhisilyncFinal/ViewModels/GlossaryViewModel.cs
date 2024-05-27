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
                    WordDescription = "The abdominal muscles support the trunk, allow movement and hold organs in place by regulating internal abdominal pressure. The deep abdominal muscles, together with muscles in the back, make up your core muscles. Your core muscles help keep your body stable and balanced, and protect your spine.",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Adductors",
                    WordDescription = "The adductors are an important muscle group located on your inner thighs that move your legs toward the center of your body. Their main functions include providing stability during daily activities and supporting explosive movements such as jumping and running for athletes.",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Aponeurosis",
                    WordDescription = "An aponeurosis is a thin sheath of connective tissue that helps connect your muscles to your bones. Aponeuroses are similar to tendons. They support your muscles and give your body strength and stability. Aponeuroses absorb energy when your muscles move.",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Biceps",
                    WordDescription = "The biceps is a large muscle situated on the front of the upper arm between the shoulder and the elbow. Also known by the Latin name biceps brachii (meaning two-headed muscle of the arm), the muscle's primary function is to flex the elbow and rotate the forearm.",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Calves",
                    WordDescription = "Your calf muscle is in the back of your lower leg, behind your shin bone (tibia). It actually consists of three different muscles: your gastrocnemius, soleus and plantaris. Together, these lower leg muscles help you walk, run, jump, stand on your toes and flex your foot (push your toes down toward the ground).",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Deep Fascia",
                    WordDescription = "The deep fascia is a dense, organized, connective tissue located deep to the skin and subcutaneous tissue. It surrounds muscles, viscera and related structures. Depending on its location, there are several types of deep fascia.",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Deltoids",
                    WordDescription = "The deltoid muscle is a large triangular intrinsic shoulder muscle, so named because its shape resembles the inverted Greek letter delta. This muscle forms the shoulder's rounded contour, being thick and spread out anteroposteriorly ",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Endomysium",
                    WordDescription = "The endomysium, meaning within the muscle, is a wispy layer of areolar connective tissue that ensheaths each individual muscle fiber. It also contains capillaries, nerves, and lymphatics.",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Epimysium",
                    WordDescription = "The epimysium is a thick connective tissue layer that is composed of coarse collagen fibers in a proteoglycan matrix. The epimysium surrounds the entire muscle and defines its volume. The arrangement of collagen fibers in the epimysium varies between muscles of different shapes and functions.",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Erector Spinae",
                    WordDescription = "The erector spinae or spinal erectors is a set of muscles that straighten and rotate the back. The spinal erectors work together with the glutes (gluteus maximus, gluteus medius and gluteus minimus) to maintain stable posture standing or sitting.",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Fascia",
                    WordDescription = "Fascia is a sheath of stringy connective tissue that surrounds every part of your body. It provides support to your muscles, tendons, ligaments, tissues, organs, nerves, joints and bones.",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Fascial Compartment",
                    WordDescription = "Fascial compartments are what we call groups of muscles and nerves wrapped in a layer of fascia. Usually, muscles within the same compartment are innervated by the same nerve or nerves. Compartments are separated from one another by special bands of fascia called intermuscular septa.",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Fascial Planes",
                    WordDescription = "The planes of fascia are defined as apart from those coverings of various structures such as muscles, tendons, bursae, vessels, ligaments, joints and bones. Two large systems of fascia occur, one subcutaneous and the other subserous.",
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
                    WordDescription = "The muscles of the forearm or antebrachium work together to move the elbow, forearm, wrist, and digits of the hand. They fall into two categories: intrinsic and extrinsic muscles. The intrinsic muscles function to move the forearm by pronating and supinating the radius and ulna.",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Gastrocnemius",
                    WordDescription = "The gastrocnemius muscle is a complex muscle that is fundamentally involved in walking and posture. It affects the entire lower limb and the movement of the hip and the lumbar area. It is a muscular district called to work during daily and sports activities and maintain orthostatism.",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Gluteal (Glutes)",
                    WordDescription = "The gluteal muscles are a group of muscles that make up the buttock area; the muscle group consists of the gluteus maximus, gluteus medius, and gluteus minimus. The gluteus maximus is the most superficial and largest of the three muscles and makes up the bulk of the shape and form of the buttock and hip area.",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Hamstrings",
                    WordDescription = "Any of the three muscles at the back of the thigh that begin at the pelvis (specifically originating on the ischial tuberosity) and attach below the knee or to their associated tendons. These muscles serve to flex and rotate the leg and extend the thigh.",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Hips Flexors",
                    WordDescription = "A hip flexor muscle is a muscle that functions in flexing the hip, ie bringing the knee closer to the chest. Hip flexion is maximal with a high, forward kick that brings the leg above the level of the waist. Every time you take a step, you are using your hip flexor muscles.",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Intermuscular Septa",
                    WordDescription = "The intermuscular septum of the extraocular muscles is a membrane located in the anterior portion of the orbit, composed by the expansions of the fascia covering the rectus muscles of the eyeball.",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Latissimus Dorsi (Lats)",
                    WordDescription = "The latissimus dorsi is a broad, flat muscle occupying most of the lower posterior thorax. The muscle's primary function is to move the upper extremity, but it is also considered an accessory muscle of respiration.",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Myofascia",
                    WordDescription = "The Myofascia connects all aspects of the body as one, so each stretch or contraction affects the whole being. For instance, when the body is stressed or injured in one spot, like a neck, shoulder, or knee injury – the trauma reverberates throughout the body via the sensitive myofascial tissue.",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Obliques",
                    WordDescription = "The obliques are two pairs of muscles that run along either side of your torso. Each consists of the external oblique, which is the closest to the surface and the largest abdominal muscle, and the internal oblique, which lies directly beneath. They are also the muscles on the sides of your abdomen that help you twist your torso.",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Pectorals (Pecs)",
                    WordDescription = "pectoralis muscle, any of the muscles that connect the front walls of the chest with the bones of the upper arm and shoulder. There are two such muscles on each side of the sternum (breastbone) in the human body: pectoralis major and pectoralis minor. The main function of this chest muscle as a whole is the adduction and internal rotation of the arm in the shoulder joint. Acting independently, the clavicular part helps to flex the extended arm up to 90°, while the sternocostal part facilitates the extension of the flexed arm by pulling it downwards.",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Perimysium",
                    WordDescription = "The perimysium also called interfascicular connective tissue, is a connective tissue sheath that surrounds individual muscle fascicles (bundles of muscle fibers), and separates them from other fascicles within the skeletal muscle.",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Plantar Fascia",
                    WordDescription = "The plantar fascia runs from the calcaneus to the phalanges. Utilizing its inherent tensile strength, it prevents the collapse of the arch of the foot upon vertical load transmission from the weight of the body.",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Quadriceps (Quads)",
                    WordDescription = "Your quad muscles, or quadriceps femoris, are a group of muscles at the front of your thigh. Together, they contain more mass than any other muscle group in your body. You use your quads to perform a variety of movements, including kicking, running, jumping and walking.",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Retinaculum",
                    WordDescription = "A retinaculum (plural retinacula) is a band of thickened deep fascia around tendons that holds them in place. It is not part of any muscle. Its function is mostly to stabilize a tendon. The term retinaculum is Neo-Latin, derived from the Latin verb retinere (to retain).",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Rhomboids",
                    WordDescription = "The rhomboids are a collective group of muscles formed by the rhomboid major and minor. The rhomboids are important in upper limb movement and stability of both the shoulder girdle and scapula. Both rhomboids receive innervation from the dorsal scapular nerve, and their vascular supply the dorsal scapular artery.",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Serratus Anterior",
                    WordDescription = "The serratus anterior is a fan-shaped muscle that originates on the superolateral surfaces of the first to eighth ribs or the first to ninth ribs at the lateral wall of the thorax and inserts along the superior angle, medial border, and inferior angle of the scapula.",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Soleus",
                    WordDescription = "The soleus is a calf muscle that is one of the two muscles making up the calf called the triceps surae. The soleus is located deep (and anterior) to the gastrocnemius. It is attached to the shin bone (tibia) calf bone (fibula), and to a tissue connection between the two bones.",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Superficial Fascia",
                    WordDescription = "Superficial fascia is found directly under the skin and superficial adipose layers. It can show stratification both grossly and microscopically. Traditionally, it is described as being made up of membranous layers with loosely packed interwoven collagen and elastic fibers.",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Trapezius (Traps)",
                    WordDescription = "The trapezius muscle is a large superficial back muscle that resembles a trapezoid. It extends from the external protuberance of the occipital bone to the lower thoracic vertebrae and laterally to the spine of the scapula. The trapezius has upper, middle, and lower groups of fibers.",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Triceps",
                    WordDescription = "The triceps brachii is a large, thick muscle on the dorsal part of the upper arm. It often appears in the shape of a horseshoe on the posterior aspect of the arm. The primary function of the triceps is the extension of the elbow joint.",
                    WordImage = "dic.png",
                    Prompt = "Tap here to see more",

                },
                new Glossary
                {
                    GlossaryWord = "Visceral Fascia",
                    WordDescription = "Fascia is a sheath of stringy connective tissue made mostly of collagen that wraps around and supports every structure in your body.",
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
