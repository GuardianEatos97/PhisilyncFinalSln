using SQLite;
using SQLiteNetExtensions.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using PhisilyncFinal.Models;
//using ThreadNetwork;

namespace PhisilyncFinal.Services
{
    public class LocalDb
    {

        public SQLiteConnection _dbConnection;

        public string GetDataBasePath()
        {
            string filename = "LocalDb.db";
            string pathToDb = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            return pathToDb + filename;
        }


        public LocalDb()
        {
            _dbConnection = new SQLiteConnection(GetDataBasePath());

            _dbConnection.CreateTable<User>(); //Created a dummy user
            _dbConnection.CreateTable<Sport>(); //Completed
            _dbConnection.CreateTable<UserType>(); //Completed
            _dbConnection.CreateTable<Club>(); //Created a dummy club
            _dbConnection.CreateTable<BodyPart>(); //Created some dummy body parts
            _dbConnection.CreateTable<AddressLocation>(); //Craeted a dummy location
            _dbConnection.CreateTable<ProviderInjury>(); //K
            _dbConnection.CreateTable<Provider>(); //K
            _dbConnection.CreateTable<ServiceType>(); //Created a dummy service type
            _dbConnection.CreateTable<Treatment>(); //K?
            _dbConnection.CreateTable<TreatmentAction>(); //K
            _dbConnection.CreateTable<TreatmentDashboard>(); //K
            _dbConnection.CreateTable<TreatmentFrequency>(); //K?
            _dbConnection.CreateTable<TreatmentType>(); //Created a dummy treatment type

            SeedClient();
        }

        public List<string> sports = new List<string> { "Cricket", "Soccer", "Netball", "Athletics", "Rugby" };
        public List<string> bodyParts = new List<string> { "Ankle", "Wrist", "Neck", "Back", "Knee" };
        public void SeedClient()
        {
            if (_dbConnection.Table<TreatmentType>().Count()==0) 
            {
                TreatmentType type = new()
                {
                    treatmentTypeName = "Treatment Type 1", treatmentTypeDescription = "It's treatment type 1"
                };
                _dbConnection.Insert(type);
            }

            if (_dbConnection.Table<ServiceType>().Count() == 0)
            {
                ServiceType service = new()
                {
                    serviceTypeName = "Service Type 1", serviceTypeDescription = "It's type 1"
                };
                _dbConnection.Insert(service);
            }
            if (_dbConnection.Table<AddressLocation>().Count() == 0)
            {
                AddressLocation location = new()
                {
                    locationBuildingNumber = 1, 
                    locationUnitNumber = 1, 
                    locationStreetNumber = 1, 
                    locationStreetName = "One Street", 
                    locationSuburb = "The Burb", 
                    locationTown = "Townsville", 
                    locationProvince = "Western Cape", 
                    locationZipCode = "4321"
                };
                _dbConnection.Insert(location);
            }

            if (_dbConnection.Table<BodyPart>().Count() == 0)
            {
                foreach (var x in bodyParts)
                {
                    BodyPart bodyPart = new()
                    { bodyPartName = x, bodyPartDescription = $"It's the {x}" };
                    _dbConnection.Insert(bodyPart);
                }
            }

            if (_dbConnection.Table<Club>().Count() == 0)
            {    
                Club club = new()
                {
                    clubName = "The Club", clubDescription = "It's the Club", clubLocation = 1
                };
                _dbConnection.Insert(club);
            }

            if (_dbConnection.Table<UserType>().Count() == 0)
            {
                UserType userType = new()
                {
                    userTypeName = "Athlete", 
                    userTypeDetails = "Is Athlete", 
                    isCoach = false
                };
                _dbConnection.Insert(userType);

                userType = new()
                {
                    userTypeName = "Coach",
                    userTypeDetails = "Is Coach",
                    isCoach = true
                };
                _dbConnection.Insert(userType);
            }

            if (_dbConnection.Table<User>().Count() == 0)
            {
                User user = new()
                {
                    userName = "John", 
                    userSurname = "Doe", 
                    userGender = "Male", 
                    userPhoneNumber = "0115551234", 
                    userEmail = "email@website.com", 
                    userDateOfBirth = new DateTime(1970,01,01), 
                    userPassword = "Pa$$word1!",
                    userType = 1, 
                    userClub = 1
                };
                _dbConnection.Insert(user);
            }

            if (_dbConnection.Table<Sport>().Count() < sports.Count)
            {
                foreach (var x in sports)
                {
                    Sport sport = new()
                    {
                        sportName = x,
                        sportDescription = $"It's {x}"
                    };
                    _dbConnection.Insert(sport);
                }
            }

        }

        public Sport GetSportById(int id)
        {
            Sport sport = _dbConnection.Table<Sport>().Where(x => x.sportID == id).FirstOrDefault();
            if (sport != null)
            {
                _dbConnection.GetChildren(sport,true);
            }
           return sport;
        }
        public User GetUserById(int id)
        {
            User user = _dbConnection.Table<User>().Where(x => x.userID == id).FirstOrDefault();
            if (user != null)
            {
                _dbConnection.GetChildren(user, true);
            }
            return user;
        }


        public void UpdateClient(User user)
        {

            SeedClient();
            _dbConnection.Update(user);
        }


    }
}
