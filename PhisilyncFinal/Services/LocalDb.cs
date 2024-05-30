using PhisilyncFinal.Models;
using SQLite;
using System.Reflection;
using SQLiteNetExtensions.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhisilyncFinal.Services
{
    public class LocalDb
    {
        public SQLiteConnection _dbConnection;

        public string GetDataBasePath()
        {
            string filename = "AppDataDB.db";
            string pathToDb = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            return Path.Combine(pathToDb, filename);
        }

        public LocalDb()
        {
            _dbConnection = new SQLiteConnection(GetDataBasePath());

            _dbConnection.CreateTable<User>();
            _dbConnection.CreateTable<TreatmentFeedback>();
            _dbConnection.CreateTable<TreatmentDashboard>();
            _dbConnection.CreateTable<ProviderInjury>();
            _dbConnection.CreateTable<Treatment>();
            _dbConnection.CreateTable<TreatmentAction>();
            _dbConnection.CreateTable<ServiceType>();
            _dbConnection.CreateTable<Provider>();
            _dbConnection.CreateTable<BodyPart>();
            _dbConnection.CreateTable<TreatmentFrequency>();
            _dbConnection.CreateTable<UserType>();
            SeedDatabase();
        }

        public void SeedDatabase()
        {
            if (_dbConnection.Table<UserType>().Count() == 0)
            {
                UserType userType = new UserType()
                {
                    userTypeName = "Athlete",
                    userTypeDetails = "It's the Athlete"
                };

                _dbConnection.Insert(userType);

                userType = new UserType()
                {
                    userTypeName = "Coach",
                    userTypeDetails = "It's the Coach"
                };
                _dbConnection.Insert(userType);
            }

            if (_dbConnection.Table<ServiceType>().Count() == 0)
            {
                ServiceType serviceType = new ServiceType()
                {
                    serviceTypeName = "Lyno Therapy",
                    serviceTypeDescription = "Lynotherapy is a complementary modality that aims at reducing restrictions in fascial tissue in order to restore movement and function."
                };
                _dbConnection.Insert(serviceType);

                serviceType = new ServiceType()
                {
                    serviceTypeName = "Massage Therapy",
                    serviceTypeDescription = "Massage therapy is used to help manage a health condition or enhance wellness. It involves manipulating the soft tissues of the body."
                };
                _dbConnection.Insert(serviceType);
            }

            if (_dbConnection.Table<BodyPart>().Count() == 0)
            {
                BodyPart bodyPart = new BodyPart()
                {
                    bodyPartName = "Neck",
                    bodyPartDescription = "It's the neck"
                };
                _dbConnection.Insert(bodyPart);

                bodyPart = new BodyPart()
                {
                    bodyPartName = "Hamstring",
                    bodyPartDescription = "It's the Hamstring"
                };
                _dbConnection.Insert(bodyPart);

                bodyPart = new BodyPart()
                {
                    bodyPartName = "Calf",
                    bodyPartDescription = "It's the Calf"
                };
                _dbConnection.Insert(bodyPart);

                bodyPart = new BodyPart()
                {
                    bodyPartName = "Full-Body",
                    bodyPartDescription = "The whole body"
                };
                _dbConnection.Insert(bodyPart);

                bodyPart = new BodyPart()
                {
                    bodyPartName = "Abdomen",
                    bodyPartDescription = "It's the abdomen"
                };
                _dbConnection.Insert(bodyPart);

                bodyPart = new BodyPart()
                {
                    bodyPartName = "Hip",
                    bodyPartDescription = "It's the hip"
                };
                _dbConnection.Insert(bodyPart);

                bodyPart = new BodyPart()
                {
                    bodyPartName = "Ankle",
                    bodyPartDescription = "It's the ankle"
                };
                _dbConnection.Insert(bodyPart);

                bodyPart = new BodyPart()
                {
                    bodyPartName = "Toe",
                    bodyPartDescription = "It's the Toe"
                };
                _dbConnection.Insert(bodyPart);

                bodyPart = new BodyPart()
                {
                    bodyPartName = "foot",
                    bodyPartDescription = "It's the foot"
                };
                _dbConnection.Insert(bodyPart);

                bodyPart = new BodyPart()
                {
                    bodyPartName = "Trapezius",
                    bodyPartDescription = "The trapezius is a large muscle in your back. It starts at the base of your neck and extends across your shoulders and down to the middle of your back"
                };
                _dbConnection.Insert(bodyPart);

                bodyPart = new BodyPart()
                {
                    bodyPartName = "Tricep",
                    bodyPartDescription = "Underside muscle of the arm between the armpit and elbow"
                };
                _dbConnection.Insert(bodyPart);

                bodyPart = new BodyPart() 
                {
                    bodyPartName="Knee",
                    bodyPartDescription = "It's the knee"

                };
            }

            if (_dbConnection.Table<ProviderInjury>().Count() == 0)
            {
                ProviderInjury providerInjury = new ProviderInjury()
                {
                    providerInjuryName = "Neck Side Flexion (Neck Side Strain)",
                    providerInjuryDescription = "Tension on the neck when the muscle does not fully release after contracting",
                    providerInjuryAnatomy = "The sternocleidomastoid runs from the top of the sternum and medial end of the clavicle to the mastoid process behind the ear. The upper trapezius runs from the occiput and cervical spinous processes to the superior scapula and clavicle. The scaleni runs from the processes of cervical vertebrae to the front of the 1st rib and lateral of 2nd rib.\r\n",
                    providerInjuryImage = "sideflexremovebg",
                    providerInjuryBodyPart = 1,
                    providerInjuryServiceProvider = 1

                };
                _dbConnection.Insert(providerInjury);

                providerInjury = new ProviderInjury()
                {
                    providerInjuryName = "Neck Flexion (Frontal Neck Strain)",
                    providerInjuryDescription = "Tension on the neck when the muscle does not fully release after contracting",
                    providerInjuryAnatomy = "The splenius capitis runs from the nuchal ligament and the spinous processes of C7 to T6 to the mastoid process and occipital bone. The upper trapezius runs from the clavicle and top of the scapula to the cervical vertebrae and the occipital bone.\r\n",
                    providerInjuryImage = "neckflexioncapture",
                    providerInjuryBodyPart = 1,
                    providerInjuryServiceProvider = 1

                };
                _dbConnection.Insert(providerInjury);

                providerInjury = new ProviderInjury()
                {
                    providerInjuryName = "Neck Rotation (Full Neck Strain)",
                    providerInjuryDescription = "Tension on the neck when the muscle does not fully release after contracting",
                    providerInjuryAnatomy = "The spenius capitis runs from the spinous processes of c7 to t6 to the mastoid process and the occipital bone. When it contracts it rotates the head to the same side. The sternocleidmastoid runs from the top sternum and the medial end of the clavicle to the mastoid process behind the ear. When it contracts it rotates the head away in the opposite direction.\r\n",
                    providerInjuryImage = "neckrotation",
                    providerInjuryBodyPart = 1,
                    providerInjuryServiceProvider = 1

                };
                _dbConnection.Insert(providerInjury);

                providerInjury = new ProviderInjury()
                {
                    providerInjuryName = "Trunk Rotation (Abdomen Strain)",
                    providerInjuryDescription = "An abdominal muscle strain, or pulled stomach muscle, is an injury that occurs when muscles in the stomach stretch or tear",
                    providerInjuryAnatomy = "The Anterior Upper Spiral Line:\r\nThe rhomboids run from the spinous processes of c7 to t5 to the medial border of the scapula. The serratus anterior runs from the medial border of the scapula to the upper 8 ribs. The external oblique runs from 5-12 to the linea alba and the inguinal ligament. The internal oblique runs from the lower ribs and the linea alba to the inguinal ligament, the iliac crest and the thoraco-lumbar fascia in the back.\r\n\r\nThe Posterior Upper Spiral Line:\r\nThe pectoralis major runs from the medial clavicle, the sternum and the costal cartilages 1-6 to the lateral aspect to bicipital groove on the humerus. The latissimus dorsi runs from the bicipital groove on the humerus and cuts underneath the arm towards the spinous processes of T7-T12, the thoracolumbar fascia and the iliac and the sacral crest.\r\n",
                    providerInjuryImage = "trunkrotation",
                    providerInjuryBodyPart = 2,
                    providerInjuryServiceProvider = 1

                };

                _dbConnection.Insert(providerInjury);

                providerInjury = new ProviderInjury()
                {
                    providerInjuryName = "Hip Abduction",
                    providerInjuryDescription = "Hip abduction refers to the movement of the leg away from the midline of the body. We use this action daily when stepping to the side, getting out of bed, or exiting a car.",
                    providerInjuryAnatomy = "The adductor magnus runs from the back of the ischio-pubic ramus to the posterior shaft of the femur. The adductor longus runs from the medial pubis to the supero-posterior shaft of the femur. The adductor brervis runs from the medial pubis to the supero-posterior shaft of the femur. The pectineus runs from the lateral pubis to supero-posterior shaft of the femur. The gracilis runs from the infero-medial pubis to below the medial tibial condyle.\r\n\r\n Note that due to its origin on the posterior aspect of the pubis (the other adductors all originate from the anterior part of the pubis), it is also a hip extensor.",
                    providerInjuryImage = "hipabduction",
                    providerInjuryBodyPart = 5,
                    providerInjuryServiceProvider = 1

                };

                _dbConnection.Insert(providerInjury);

                providerInjury = new ProviderInjury()
                {

                    providerInjuryName = "Hip Adduction",
                    providerInjuryDescription = "Hip adduction refers to the movement of the leg toward the midline of the body. We use this action daily when crossing one leg over the other or bringing the legs together.",
                    providerInjuryAnatomy = "The tensor fascia lata and itb runs from the asis and terminates at the supero-lateral tibia and head of the fibula. The gluteus medius runs from the external iliac fossa to the greater trochanter. The gluteus minimus runs from the lateral part of the external iliac fossa to the greater trochanter.\r\n",
                    providerInjuryImage = "tensorcapture",
                    providerInjuryBodyPart = 5,
                    providerInjuryServiceProvider = 1,

                };
                _dbConnection.Insert(providerInjury);

                providerInjury = new ProviderInjury()
                {
                    providerInjuryName = "Knee Extension (Pulled Hamstring)",
                    providerInjuryDescription = "A pulled hamstring is a common muscle injury that occurs when one or more of the hamstring muscles are stretched or contracted beyond their limit, resulting in tearing of the muscle fibers.",
                    providerInjuryAnatomy = "The biceps femoris runs from the ischial tuberosity to the head of the fibula. The semimbranosus runs from the ischial tuberosity to the posteromedial aspect of the tibial condyle. The semitendinosus runs from the ischial tuberosity to the supero-medial tibial shaft.\r\n",
                    providerInjuryImage = "kneeextensioncapture",
                    providerInjuryBodyPart = 5,
                    providerInjuryServiceProvider = 1

                };
                _dbConnection.Insert(providerInjury);

                providerInjury = new ProviderInjury()
                {
                    providerInjuryName = "Ankle Dorsiflexion (Pulled Calves)",
                    providerInjuryDescription = "A calf strain is a common injury that occurs when the calf muscle is stretched beyond its limits, resulting in tearing of the muscle fibers.",
                    providerInjuryAnatomy = "The biceps femoris runs from the ischial tuberosity to the head of the fibula. The semimbranosus runs from the ischial tuberosity to the posteromedial aspect of the tibial condyle. The semitendinosus runs from the ischial tuberosity to the supero-medial tibial shaft.\r\n",
                    providerInjuryImage = "ankledorsiflexion",
                    providerInjuryBodyPart = 7,
                    providerInjuryServiceProvider = 1
                };
                _dbConnection.Insert(providerInjury);

                providerInjury = new ProviderInjury()
                {
                    providerInjuryName = "Ankle Eversion",
                    providerInjuryDescription = "An eversion ankle sprain is an injury to the ligaments on the inside of the ankle. It’s a common injury that can happen when the foot twists inward.",
                    providerInjuryAnatomy = "The tibialis anterior runs from the supero-lateral shaft of the shaft of the tibia to the base of the 1st metatarsal. The tibialis posterior runs from the postero-superior shafts of the tibia and fibula to the navicular, cuboid, cuneiform and 2nd to 5th metatarsals. The flexor digitorium longus runs from the postero-medial shaft of the tibia to the bottom of the distal 2nd to 5th phalanges. The flexor hallucis longus runs from the postero-inferior shaft of the fibula to the bottom of the 1st distal phalanx. The extensor hallucis longus runs from the central medial shaft of the fibula to the top of the 1st distal phalanx.\r\n",
                    providerInjuryImage = "ankleeversiontwo",
                    providerInjuryServiceProvider = 1,
                    providerInjuryBodyPart = 7
                };
                _dbConnection.Insert(providerInjury);

                providerInjury = new ProviderInjury()
                {
                    providerInjuryName = "Ankle Inversion",
                    providerInjuryDescription = "An inversion ankle sprain is an injury to the ligaments on the outside of the ankle. It’s a common injury that can happen when the foot twists outward.",
                    providerInjuryAnatomy = "The peroneus longus runs from the head and supero-lateral shaft of the fibula to the medial cuneiform and base of the first metatarsal. The peroneus brevis runs from the infero-lateral fibular shaft to the lateral tubercle of the 5th metatarsal.\r\n",
                    providerInjuryImage = "ankleinversioncapture",
                    providerInjuryServiceProvider = 1,
                    providerInjuryBodyPart = 7
                };
                _dbConnection.Insert(providerInjury);

                providerInjury = new ProviderInjury()
                {
                    providerInjuryName = "Toe Extension",
                    providerInjuryDescription = "A toe sprain is an injury to the ligaments around the toe joint. It’s a common injury that can happen when the toe is bent or jammed.",
                    providerInjuryAnatomy = "The Extensor hallucis longus (EHL) muscle is a key muscle located in the anterior compartment of the lower leg. It is responsible for extending the big toe at both the metatarsophalangeal and interphalangeal joints.",
                    providerInjuryImage = "toeextension",
                    providerInjuryServiceProvider = 1,
                    providerInjuryBodyPart = 8
                };
                _dbConnection.Insert(providerInjury);
            }

            if (_dbConnection.Table<Treatment>().Count() == 0)
            {
                Treatment treatment = new Treatment()
                {
                    treatmentName = "Neck Side Flexion (Neck Side Strain)",
                    treatmentDescription = "A neck strain occurs when one or more fibers in a neck muscle or tendon stretch too far and tear.",
                    treatmentInjury = 1,

                };
                _dbConnection.Insert(treatment);

                treatment = new Treatment()
                {
                    treatmentName = "Neck Flexion (Frontal Neck Strain)",
                    treatmentDescription = "A neck strain occurs when one or more fibers in a neck muscle or tendon stretch too far and tear.",
                    treatmentInjury = 2,

                };
                _dbConnection.Insert(treatment);

                treatment = new Treatment()
                {
                    treatmentName = "Neck Rotation (Full Neck Strain)",
                    treatmentDescription = "A neck strain occurs when one or more fibers in a neck muscle or tendon stretch too far and tear.",
                    treatmentInjury = 3,

                };
                _dbConnection.Insert(treatment);

                treatment = new Treatment()
                {
                    treatmentName = "Trunk Rotation (Abdomen Strain)",
                    treatmentDescription = "An abdominal muscle strain, or pulled stomach muscle, is an injury that occurs when muscles in the stomach stretch or tear",
                    treatmentInjury = 4,

                };
                _dbConnection.Insert(treatment);

                treatment = new Treatment()
                {
                    treatmentName = "Hip Abduction",
                    treatmentDescription = "Hip abduction refers to the movement of the leg away from the midline of the body. We use this action daily when stepping to the side, getting out of bed, or exiting a car.",
                    treatmentInjury = 5,

                };
                _dbConnection.Insert(treatment);

                treatment = new Treatment()
                {
                    treatmentName = "Hip Adduction",
                    treatmentDescription = "Hip adduction refers to the movement of the leg toward the midline of the body. We use this action daily when crossing one leg over the other or bringing the legs together.",
                    treatmentInjury = 6,

                };
                _dbConnection.Insert(treatment);

                treatment = new Treatment()
                {
                    treatmentName = "Knee Extension (Pulled Hamstring)",
                    treatmentDescription = "A pulled hamstring is a common muscle injury that occurs when one or more of the hamstring muscles are stretched or contracted beyond their limit, resulting in tearing of the muscle fibers.",
                    treatmentInjury = 7,

                };
                _dbConnection.Insert(treatment);

                treatment = new Treatment()
                {
                    treatmentName = "Ankle Dorsiflexion (Pulled Calves)",
                    treatmentDescription = "A calf strain is a common injury that occurs when the calf muscle is stretched beyond its limits, resulting in tearing of the muscle fibers.",
                    treatmentInjury = 8,

                };
                _dbConnection.Insert(treatment);

                treatment = new Treatment()
                {
                    treatmentName = "Ankle Eversion",
                    treatmentDescription = "An eversion ankle sprain is an injury to the ligaments on the inside of the ankle. It’s a common injury that can happen when the foot twists inward.",
                    treatmentInjury = 9,

                };

                _dbConnection.Insert(treatment);

                treatment = new Treatment()
                {
                    treatmentName = "Ankle Inversion",
                    treatmentDescription = "An inversion ankle sprain is an injury to the ligaments on the outside of the ankle. It’s a common injury that can happen when the foot twists outward.",
                    treatmentInjury = 10,

                };
                _dbConnection.Insert(treatment);

                treatment = new Treatment()
                {
                    treatmentName = "Toe Extension",
                    treatmentDescription = "A toe sprain is an injury to the ligaments around the toe joint. It’s a common injury that can happen when the toe is bent or jammed.",
                    treatmentInjury = 11,

                };
                _dbConnection.Insert(treatment);
            }

            if (_dbConnection.Table<TreatmentAction>().Count() == 0)
            {
                TreatmentAction treatmentAction = new TreatmentAction()
                {
                    treatmentActionName = "Neck Side Flexion Test",
                    treatmentActionStepAction =  "Position:\r\nThe client stands with his back against the wall. Make sure that his shoulders are pushed flat against the wall. He then drops his chin down towards his chest Measure:\r\nMeasure in fingers from the chin to the chest \r\n\r\nFull range:\r\n3 fingers between the chin and the chest\r\n " ,
                    treatmentActionTreatment = 1,
                    treatmentActionStepOrder = 1,
                    
                    treatmentActionCategory = "Test"

                };
                _dbConnection.Insert(treatmentAction);

                treatmentAction = new TreatmentAction()
                {
                    treatmentActionName = "Neck Side Flexion Release",
                    treatmentActionStepAction =  "Step 1:The client sits over the side of the bed. The client will actively move her head from neutral position towards the fully lengthened position, while you move your fingers from below her ear towards the clavicle (Sternocleidomastoid and Scaleni) and towards the clavicle, acromion and spine of the scapula (Trapezius). \r\n\r\nStep 2: Move your fingers from the top of the scalp, down towards the ear and then down the neck to top the shoulder, while the client laterally flexes her head in the opposite direction. Make sure you cover the area of the upper Traps and the SCM. \r\n" ,
                    treatmentActionStepOrder = 1,
                    treatmentActionTreatment = 1,
                    treatmentActionCategory = "Release"


                };
                _dbConnection.Insert(treatmentAction);

                treatmentAction = new TreatmentAction()
                {
                    treatmentActionName = "Neck Flexion (Frontal Neck Strain) Test",
                    treatmentActionStepAction = "Position:\r\nThe client stands with his back against the wall. Make sure that his shoulders are pushed flat against the wall. He then drops his chin down towards his chestMeasure:\r\nMeasure in fingers from the chin to the chest \r\n\r\nFull range:\r\n3 fingers between the chin and the chest\r\n " ,
                    treatmentActionTreatment = 2,
                    treatmentActionStepOrder = 1,
                    treatmentActionCategory = "Test"
                };
                _dbConnection.Insert(treatmentAction);

                treatmentAction = new TreatmentAction()
                {
                    treatmentActionName = "Neck Flexion (Frontal Neck Strain) Release",
                    treatmentActionStepAction = "Step 1:The client sits with his neck in the neutral position. He then slowly tucks his chin in and then bends the neck forward towards full flexion \r\n\r\nStep 2: Place your fingers on his scalp, just above the forehead and move all the way over the head towards the end of the cervical spine. Make sure you cover the full posterior aspect of the neck. \r\n" ,
                    treatmentActionTreatment = 2,
                    treatmentActionCategory = "Release"
                };

                _dbConnection.Insert(treatmentAction);

                treatmentAction = new TreatmentAction()
                {
                    treatmentActionName = "Neck Rotation (Full Neck Strain) Test",
                    treatmentActionStepAction = "Position:\r\nThe client stands with his back against the wall, shoulders pulled back against the wall. Rotate his head in the vertical plane (no side flexion) towards full range.\r\n\r\nMeasure:\r\nCalibrate your phone against the wall and then measure the angle between the chin and the wall by placing the phone at a right angle on the chin.\r\n\r\nFull range:\r\n80◦\r\n\r\nMake sure that you record it correctly on an assessment form. If rotation is limited towards the left, it could be the R Splenius or the L Sternocleidomastoid.\r\n " ,
                    treatmentActionTreatment = 3,
                    treatmentActionCategory = "Test"
                };
                _dbConnection.Insert(treatmentAction);

                treatmentAction = new TreatmentAction()
                {
                    treatmentActionName = "Neck Rotation (Full Neck Strain) Release",
                    treatmentActionStepAction =  "Step 1:\r\n Splenius Capitus (Anterior Upper Spiral Line):\r\nThe client is in the sitting position. Place your fingers on the occiput. Ask the client to rotate his neck away from your hand while you move your fingers downwards towards the spine.\r\n\r\nSternocleidomastoid (Posterior Upper Spiral Line):\r\nPlace your fingers on the occiput with the client’s head in the neutral position. Move your fingers downwards along the Sternocleidomastoid while the client rotates his head towards your hand.\r\n\r\n NB! If rotation is limited to the left, release the right Splenius Capitis and the left Sternocleidomastoid and the opposite if rotation is limited to the right." ,
                    treatmentActionTreatment = 3,
                    treatmentActionCategory = "Release"

                };
                _dbConnection.Insert(treatmentAction);

                treatmentAction = new TreatmentAction()
                {
                    treatmentActionName = "Trunk Rotation (Abdomen Strain) Test",
                    treatmentActionStepAction = "Position:\r\nThe client sits with his hips and knees at 90◦, his feet supported, and his elbows bent 90◦. Place your mobile phone on his shoulder, in line with his ear and make sure you are in the neutral position before you set the app on 0◦. Gently rotate his body until you feel the fascia end-feel. Make sure that he does not assist the motion by doing active neck rotation.\r\n\r\nFull range:\r\n60◦\r\n" ,
                    treatmentActionTreatment = 4,
                    treatmentActionCategory = "Test"
                };
                _dbConnection.Insert(treatmentAction);

                treatmentAction = new TreatmentAction()
                {
                    treatmentActionName = "Trunk Rotation (Abdomen Strain) Release",
                    treatmentActionStepAction = "The left Anterior Upper Spiral Line:\r\nThe client is in standing position. Start the release by placing your fingers on the mastoid process behind the left ear. Move your fingers towards the spinous processes of the C7 to T5 while the client rotates his neck towards the right.\r\n\r\nNext follow the sling with your fingers along the Rhomboids, across the right scapula and under the armpit over the right Serratus Anterior. While you move the fascia in small sections, the client rotates his neck and body towards the right, while he reaches towards the HBB position with the right arm and towards the full Lat position with the left arm. (The Ballerina Move!).Continue the release along the External and Internal Obliques while the client continues with the full ballerina movement, ending up touching his hands behind his back.\r\n\r\nThe Left Posterior Upper Spiral Line:\r\nThe client is in a standing position. Place your fingers on the mastoid process behind the left ear. Slowly move your fingers along the SCM towards the top of the sternum, while the client moves his head to the left. Now move your fingers across Pectoralis Major, aiming to meet up with the Latissimus Dorsi below the armpit. At this point the client starts to rotate the trunk towards the left, and he brings his right arm forward and upwards towards the LAT TEST position, while his left arm moves backwards towards the HBB TEST position.\r\n\r\nWith your fingers, follow the Lats across the thoraco-lumbar fascia towards the left iliac. At the same time the client rotates the neck and body to the left, aiming to touch his hands behind his back (The Ballerina Move).\r\n" ,
                    treatmentActionTreatment = 4,
                    treatmentActionCategory = "Release"
                };
                _dbConnection.Insert(treatmentAction);

                treatmentAction = new TreatmentAction()
                {
                    treatmentActionName = "Hip Abduction Test",
                    treatmentActionStepAction =  "Position:\r\nThe client lies on his back. Lift the one leg from the table, high enough to allow the other leg to move underneath. Hold the ankle of the other in neutral position and then move the leg into adduction until you feel the fascia end-feel.\r\n\r\nMeasure:\r\nMeasure the angle of the hip from neutral to full adduction. Measure in degrees.\r\n\r\nFull Range:\r\nThe leg should be able to move to 30° of adduction.\r\n" ,
                    treatmentActionTreatment = 5,
                    treatmentActionCategory = "Test"
                };
                _dbConnection.Insert(treatmentAction);

                treatmentAction = new TreatmentAction()
                {
                    treatmentActionName = "Hip Abduction Release",
                    treatmentActionStepAction = "Non-weight bearing release:\r\nThe client lies on her side on the edge of bed and with the bottom knee slightly bent. She then slowly drops her top leg off the bed towards the fully adducted position. Place your fingers just below the knee and release upwards towards the iliac crest.\r\n\r\nWeight Bearing Release:\r\nThe client stands with his legs slightly apart. He moves his hip outwards without lifting the feet off the floor. Place your hands on the iliac crest and move downwards towards the knee, as he moves his hip outwards.\r\n" ,
                    treatmentActionTreatment = 5,
                    treatmentActionCategory = "Release"
                };

                _dbConnection.Insert(treatmentAction);

                treatmentAction = new TreatmentAction()
                {
                    treatmentActionName = "Hip Adduction Test",
                    treatmentActionStepAction =  "Position:\r\nThe client lies on his back. Lift the one leg from the table, high enough to allow the other leg to move underneath. Hold the ankle of the other in neutral position and then move the leg into adduction until you feel the fascia end-feel.\r\n\r\nMeasure:\r\nMeasure the angle of the hip from neutral to full adduction. Measure in degrees. \r\n\r\nFull Range:\r\nThe leg should be able to move to 30° of adduction.\r\n" ,
                    treatmentActionTreatment = 6,
                    treatmentActionCategory = "Test"
                };
                _dbConnection.Insert(treatmentAction);

                treatmentAction = new TreatmentAction()
                {
                    treatmentActionName = "Hip Adduction Release",
                    treatmentActionStepAction =  "Non-weight bearing release:\r\nThe client lies on her side on the edge of bed and with the bottom knee slightly bent. She then slowly drops her top leg off the bed towards the fully adducted position. Place your fingers just below the knee and release upwards towards the iliac crest.\r\n\r\nWeight Bearing Release:\r\nThe client stands with his legs slightly apart. He moves his hip outwards without lifting the feet off the floor. Place your hands on the iliac crest and move downwards towards the knee, as he moves his hip outwards.\r\n",
                    treatmentActionTreatment = 6,
                    treatmentActionCategory = "Release"
                };
                _dbConnection.Insert(treatmentAction);

                treatmentAction = new TreatmentAction()
                {
                    treatmentActionName = "Knee Extension (Pulled Hamstring) Test",
                    treatmentActionStepAction =  "Position:\r\nThe client lies on his back. He places both hands under his lumbar spine, in order to maintain the lumbar lordosis. Lift his leg upwards while keeping the knee straight. Make sure his leg is completely relaxed and that he does not contract the hip flexor or the Quadriceps.\r\n\r\nMeasure:\r\nMeasure the angle between the bed and his leg. Ask the client to tell you as soon as he feels the back pushing down towards his hands. That is the point where you do the measurement.\r\n\r\nFull range:\r\n80° hip flexion\r\n" ,
                    treatmentActionTreatment = 7,
                    treatmentActionCategory = "Test"
                };
                _dbConnection.Insert(treatmentAction);

                treatmentAction = new TreatmentAction()
                {
                    treatmentActionName = "Knee Extension (Pulled Hamstring) Release",
                    treatmentActionStepAction =  "Non-weight bearing release:\r\nThe client lies on his side with both legs straight. He places his top hand on the top iliac crest to help him focus to keep the pelvis in a neutral position. He then dorsiflexes his top ankle and then moves the top leg forward towards full hip flexion, while keeping the knee straight and the pelvis in neutral.\r\n\r\nPlace your fingers just below the knee and move upwards towards the Gluteal fold, on his side with both his hips and knees bent 90°. The client straightens the top leg as far as he can.\r\n\r\nPlace your fingers just below the knee and move upwards the Gluteal fold.\r\n\r\nWeight Bearing release: \r\nThe client stands with feet slightly apart. He places his hands on his iliac crests and tilts the pelvis anteriorly (hollow back). While maintaining the pelvis position, he bends forward making sure that the knees stays in full extension.\r\n\r\nPlace your hands on the gluteal fold and then move downwards towards the knee, ending the movement just below the knee on the medial and lateral side.\r\n" ,
                    treatmentActionTreatment = 7,
                    treatmentActionCategory = "Release"
                };
                _dbConnection.Insert(treatmentAction);

                treatmentAction = new TreatmentAction()
                {
                    treatmentActionName = "Ankle Dorsiflexion (Pulled Calves) Test",
                    treatmentActionStepAction =  "Position:\r\nThe client lies in the prone position with his feet over the side of the bed. Make sure his neck remains in the neutral position with his arms by his side. Keep the calcaneus in the neutral position while you push down on the front foot to move the into dorsiflexion.\r\n\r\nMeasure:\r\nMeasure the angle of the ankle.\r\n\r\nFull range:\r\n90°\r\n" ,
                    treatmentActionTreatment = 8,
                    treatmentActionCategory = "Test"
                };
                _dbConnection.Insert(treatmentAction);

                treatmentAction = new TreatmentAction()
                {
                    treatmentActionName = "Ankle Dorsiflexion (Pulled Calves) Release",
                    treatmentActionStepAction =  "Non-weight bearing release:\r\nThe client lies in the prone position with his feet off the bed. He slowly moves the foot towards full dorsiflexion. Place your fingers at the bottom end of the Achilles and move upwards just beyond the knee.\r\n\r\nWeight-bearing release:\r\nThe client stands facing a wall with his hands on the wall. He places his foot a step in front of the other foot. He then leans forward, bending the front knee but keeping the back knee straight until the Gastrocnemius reaches the fully lengthened position.\r\n\r\nPlace your hands above the knee and move downwards along the calf to the bottom of the Achilles.\r\n" ,
                    treatmentActionTreatment = 8,
                    treatmentActionCategory = "Release"

                };
                _dbConnection.Insert(treatmentAction);

                treatmentAction = new TreatmentAction()
                {
                    treatmentActionName = "Ankle Eversion Test",
                    treatmentActionStepAction = "Position:\r\nPlace the client in the prone position on the bed with the hips in neutral position. Bend the one knee up to 90° flexion. Place your one hand around the calcaneus, while the other hand holds the front foot on either side. Make sure that the ankle is in 90° dorsiflexion. Now tilt both calcaneus and the front outwards at the same time, until you reach full eversion.\r\nMeasure:\r\nEversion is a very small movement and again not easy to measure due to the spiral movement. Most books speak about 10 degrees.\r\n" ,
                    treatmentActionTreatment = 9,
                    treatmentActionCategory = "Test"
                };
                _dbConnection.Insert(treatmentAction);

                treatmentAction = new TreatmentAction()
                {
                    treatmentActionName = "Ankle Eversion Release",
                    treatmentActionStepAction =  "Non-weight bearing release:\r\nThe client lies on his side with the bottom knee bent and the knee and ankle on the edge of the bed with foot free to move downwards over the side of the bed.\r\n\r\nThe client moves his foot from the neutral position towards full eversion.\r\n\r\nPlace your fingers on the medial side of the foot, just below the big toe and move along the medial aspect of the foot, around the front and back of the medial malleolus and upwards along the medial aspect of the leg, as well as the anterior along the fibers of the Tibialis Anterior, and all the way up to the knee.\r\n\r\nWeight Bearing release:\r\nThe client stands with his feet apart. He places his full weight on one foot and tilts the foot over to reach full eversion.\r\n\r\nPlace your fingers just below the knee on the medial aspect of the leg and move downwards until you reach the medial aspect of the foot.\r\n" ,
                    treatmentActionTreatment = 9,
                    treatmentActionCategory = "Release"
                };
                _dbConnection.Insert(treatmentAction);

                treatmentAction = new TreatmentAction()
                {
                    treatmentActionName = "Ankle Inversion Test",
                    treatmentActionStepAction = "Position:\r\nPlace the client in the prone position on the bed with the hips in neutral position. Bend then one knee up to 90° flexion. Place your one hand around the calcaneus, while the other hand holds the front foot on either side. Now tilt both the calcaneus and the front foot inwards at the same time, until you reach full Inversion.\r\nMeasure:\r\nInversion and eversion is very difficult to measure since it involves a Spiral movement in the foot. For inversion, there are 3 possibilities. There is either hardly any movement (locked short), or free but controlled movement to full range (neutral) or finally an uncontrolled movement where it seems like the ankle just rolls inwards without any muscle control (locked long). In this instance, we are interested in the ‘locked short’ scenario.\r\n\r\n" ,
                    treatmentActionTreatment = 10,
                    treatmentActionCategory = "Test"
                };
                _dbConnection.Insert(treatmentAction);

                treatmentAction = new TreatmentAction()
                {
                    treatmentActionName = "Ankle Inversion Release",
                    treatmentActionStepAction =  "Non-weight bearing release:\r\nPlace the client on his side with the bottom leg straight and the top knee bent over. The knee and the ankle of the top leg should be supported on the edge of the bed with the foot free to move off the bed towards full inversion. The client moves the foot from the neutral position, downwards over the side of the bed to full inversion. Place your fingers on the lateral side of the foot, just above the little toe and move upwards along the lateral aspect of the foot, around the lateral malleolus and up along the lateral aspect of the leg towards the fibula head.\r\nWeight-bearing release:\r\nThe client stands with his feet slightly apart. Place your fingers just below the fibula on the lateral side of the left knee. The client places his full weight on the foot and then rolls the foot outwards until he stands on the outside of the foot. As he moves through the range, move your fingers downwards towards the lateral aspect of the foot.\r\n." ,
                    treatmentActionTreatment = 10,
                    treatmentActionCategory = "Release"
                };
                _dbConnection.Insert(treatmentAction);

                treatmentAction = new TreatmentAction()
                {
                    treatmentActionName = "Toe Extension Test",
                    treatmentActionStepAction =  "Position:\r\nThe client sits with his feet slightly apart. Place your fingers on the sides of each toe and then lift the whole toe off the floor. Make sure that the client does not try to do it actively. It must be passive.\r\n\r\nMeasure:\r\nNote if the toes can all be lifted off the floor with ease.\r\n\r\nFull range:\r\nA clear and easy lift off the floor.\r\n" ,
                    treatmentActionTreatment = 11,
                    treatmentActionCategory = "Test"
                };
                _dbConnection.Insert(treatmentAction);

                treatmentAction = new TreatmentAction()
                {
                    treatmentActionName = "Toe Extension Release",
                    treatmentActionStepAction = "The client lies on his tummy with a foam roller under his shins. The toes should not touch the bed. In this release it is easier to do the movement passively as it is difficult to move the toes separately.\r\n\r\nPlace your fingers at the bottom end of the toe and move towards the heel, focusing on the tendon of the specific toe that has restricted movement, while moving the toe towards full extension.\r\n" ,
                    treatmentActionTreatment = 11,
                    treatmentActionCategory = "Release"
                };
                _dbConnection.Insert(treatmentAction);
            }
        }


        public void SaveUser(User user)
        {
            try
            {
                _dbConnection.Insert(user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void SaveDash(TreatmentDashboard dash, User user)
        {
            try
            {
                dash.UserId = user.userID;
                _dbConnection.Insert(dash);
                user.userTreatment = dash.treatmentDashID;
                _dbConnection.Update(user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ProviderInjury> GetInjuriesList()
        {
            return _dbConnection.Table<ProviderInjury>().ToList();
        }

        public List<TreatmentAction> GetTestTreatmentAction(int id) 
        {
            return _dbConnection.Table<TreatmentAction>().Where(x=>x.treatmentActionTreatment==id && x.treatmentActionCategory=="Test").ToList();

        }

        public List<TreatmentAction> GetReleaseTreatmentAction(int id)
        {
            return _dbConnection.Table<TreatmentAction>().Where(x => x.treatmentActionTreatment == id && x.treatmentActionCategory == "Release").ToList();

        }

        public List<Treatment> GetTreatmentsList()
        {
            return _dbConnection.Table<Treatment>().ToList();
        }

        public List<TreatmentAction> GetTreatmentActionsList()
        {
            return _dbConnection.Table<TreatmentAction>().ToList();
        }

        public User GetUserByID(int id)
        {
            return _dbConnection.Table<User>().Where(x => x.userID == id).FirstOrDefault();
        }

        public User GetUserByEmail(string email)
        {
            return _dbConnection.Table<User>().Where(x => x.userEmail == email).FirstOrDefault();
        }

        public User GetFirstUser()
        {
            return _dbConnection.Table<User>().FirstOrDefault();
        }

        public User UpdateUser(User user)
        {             
            _dbConnection.Update(user);
            return user;
        }

    }
} 
