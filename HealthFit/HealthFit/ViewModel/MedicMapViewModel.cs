using System.Collections.Generic;
using System.Threading.Tasks;

namespace HealthFit.ViewModel
{
    public class MedicMapViewModel : BaseViewModel
    {
        public MedicMapViewModel()
        {
            Title = "Medic Map";
        }
        public class MedicLocation
        {
            public string Name { get; set; }  
            public string Address { get; set; }
            public double Latitude { get; set; }
            public double Longitude { get; set; }

        }

        public class PharmacyLocation
        {
            public string Name { get; set; }
            public string Address { get; set; }
            public double Latitude { get; set; }
            public double Longitude { get; set; }
        }
        public class EyeLocation
        {
            public string Name { get; set; }
            public string Address { get; set; }
            public double Latitude { get; set; }
            public double Longitude { get; set; }
        }

        #region lista oftalmologice
        //  new EyeLocation { Name = "", Address = "", Latitude = , Longitude =  },

        internal Task<List<EyeLocation>> LoadEyes()
        {
            List<EyeLocation> eyeLocations = new List<EyeLocation>
            {
                new EyeLocation { Name = "Clinica oftalmologică Gauss", Address = "Bulevardul Ioniță Sandu Sturza, nr. 39, Bacău", Latitude = 46.56479, Longitude = 26.90599 },
                new EyeLocation { Name = "Cabinet Oftalmologic Asioptic", Address = "Strada 9 Mai, nr. 36, Bacău", Latitude = 46.56278, Longitude =  26.91483},
                new EyeLocation { Name = "Centrul oftalmologic Oculux", Address = "Strada Pictor Theodor Aman, nr. 40, Bacău", Latitude = 46.56278, Longitude = 26.91260 },
                new EyeLocation { Name = "Clinica oftalmologică Eurooptik", Address = "strada Ștefan cel Mare, nr. 7, Bacău", Latitude = 46.57594, Longitude = 26.91543 },
                new EyeLocation { Name = "Centrul oftalmologic Gauss", Address = "Strada Mioriței, nr. 29B, Bacău", Latitude = 46.57164, Longitude = 26.89689 },
                new EyeLocation { Name = "Centrul ofalmologic Gauss", Address = "Strada Luminii, nr. 3, Bacău", Latitude = 46.56526, Longitude = 26.91303 },
                new EyeLocation { Name = "Clinică oftalmologică Eurooptik", Address = "Strada Războieni, nr. 7, Bacău", Latitude = 46.56638, Longitude = 26.90977 },
                new EyeLocation { Name = "Cabinet optică medicală Opticlass", Address = "Strada 9 Mai, nr. 29, Bacău", Latitude = 46.57217, Longitude = 26.91423 },
                new EyeLocation { Name = "Clinică oftalmologică Optic Plus", Address = "Strada Ștefan cel Mare, nr. 1, Bacău", Latitude = 46.57500, Longitude = 26.91560 },
                new EyeLocation { Name = "Optica Marco", Address = "Strada 9 Mai, nr. 31, Bacău", Latitude = 46.57429, Longitude = 26.91483 },
                new EyeLocation { Name = "Optica Medicală Optimoda", Address = "Calea Mărășești, nr. 11, Bacău", Latitude = 46.56267, Longitude = 26.91260 },
                new EyeLocation { Name = "Cabinel oftalmologic Laser Optica", Address = "Calea Mărășești, nr. 4, Bacău", Latitude = 46.56396, Longitude = 26.91200 },
                new EyeLocation { Name = "Microoptic - Optică medicală", Address = "Strada Miron Costin, nr. 4, Bacău", Latitude = 46.56272, Longitude = 26.91844 },
                new EyeLocation { Name = "Medoptic Eye", Address = "Calea Republicii, nr. 11, Bacău", Latitude = 46.53870, Longitude = 26.91775 },
                new EyeLocation { Name = "Clinică oftalmologică Optic Plus", Address = "Calea Mărășești, nr. 32-34, Bacău", Latitude = 46.55641, Longitude = 26.91131 }
            };
            return Task.FromResult(eyeLocations);
        }
        #endregion
       
        #region lista farmacii

        //  new PharmacyLocation { Name = "", Address = "", Latitude = , Longitude =  },

        internal Task<List<PharmacyLocation>> LoadPharmacy()
        {
            List<PharmacyLocation> pharmacyLocations = new List<PharmacyLocation>
            {
                new PharmacyLocation { Name = "Farmacia Sensiblu", Address = "Strada Milcov, nr. 5B, Bacău", Latitude = 46.556210, Longitude = 26.911133 },
                new PharmacyLocation { Name = "Emifarm", Address = "Calea Romanului, nr. 46, Bacău", Latitude = 46.576969, Longitude = 26.930929 },
                new PharmacyLocation { Name = "Farmacia Ropharma", Address = "Strada Mărășești, nr. 104, Bacău", Latitude = 46.549713, Longitude = 26.913343 },
                new PharmacyLocation { Name = "Farmacia Ropharma", Address = "Strada Theodor Aman, nr. 1, Bacău", Latitude = 46.56176, Longitude = 26.91844 },
                new PharmacyLocation { Name = "Farmacia Ropharma", Address = "Strada 9 Mai, nr. 25, Bacău", Latitude = 46.57014, Longitude = 26.91501 },
                new PharmacyLocation { Name = "Farmacia Ropharma", Address = "Calea Mărășești, nr. 98, Bacău", Latitude = 46.55303, Longitude = 26.91226 },
                new PharmacyLocation { Name = "Farmacia Ropharma", Address = "Strada Nicolae Bălcescu, nr. 1, Bacău", Latitude = 46.56637, Longitude = 26.91089 },
                new PharmacyLocation { Name = "Farmacia Sf. Spiridon", Address = "Strada Energiei, nr. 36, Bacău", Latitude = 46.57092, Longitude = 26.89667 },
                new PharmacyLocation { Name = "Catena", Address = "Pasajul Revoluției, nr. 3, Bacău", Latitude = 46.56608, Longitude = 26.91297 },
                new PharmacyLocation { Name = "Farmacia Dr. Max", Address = "Strada Piața Centrală, nr. 1, Bacău", Latitude = 46.56826, Longitude = 26.91443 },
                new PharmacyLocation { Name = "Farmacia Sf. Spiridon", Address = "Calea Republicii, nr. 76, Bacău", Latitude = 46.53318, Longitude = 26.91927 },
                new PharmacyLocation { Name = "Farmacia Majefarm", Address = "Strada Miron Costin, nr. 85, Bacău", Latitude = 46.55848, Longitude = 26.92130 },
                new PharmacyLocation { Name = "Farmacia Malvi", Address = "Strada 9 Mai, nr. 28, Bacău", Latitude = 46.56236, Longitude = 26.91426 },
                new PharmacyLocation { Name = "Catena", Address = "Strada Miron Costin, nr. 28, Bacău", Latitude = 46.56198, Longitude = 26.91905 },
                new PharmacyLocation { Name = "Farmacia Dr. Max", Address = "Calea Mărășești, nr. 32-34, Bacău", Latitude = 46.55656, Longitude = 26.91134 },
                new PharmacyLocation { Name = "Farmacia Iris", Address = "Strada Nicolae Bălcescu, nr. 12, Bacău", Latitude = 46.56749, Longitude = 26.91159 },
                new PharmacyLocation { Name = "Farmacia Pro Natura", Address = "Bulevardul Alexandru cel Bun, nr. 2, Bacău", Latitude = 46.56461, Longitude = 26.91761 },
                new PharmacyLocation { Name = "Farmacia Elvaruj", Address = "Strada Banca Națională, nr. 3, Bacău", Latitude = 46.57093, Longitude = 26.90851 },
                new PharmacyLocation { Name = "Farmacia Dr. Max", Address = "Strada Milcov, nr. 5, Bacău", Latitude = 46.55665, Longitude = 26.92585 },
            };
            return Task.FromResult(pharmacyLocations);
        }

        #endregion

        #region Lista Dentisti

        // new MedicLocation { Name = "", Address = "", Latitude = , Longitude = },

        internal Task<List<MedicLocation>> LoadDentists()
        {
            List<MedicLocation> dentistLocations = new List<MedicLocation>
            {
                new MedicLocation { Name = "ProfiSmile", Address = "Strada Miron Costin, nr. 1, Bacău", Latitude = 46.563803063967015, Longitude = 26.918324415541115 },
                new MedicLocation { Name = "Denti Service", Address = "Strada Ștefan cel Mare, nr. 34, Bacău",Latitude = 46.58378419485356, Longitude = 26.913057248666373 },
                new MedicLocation { Name = "Oradent - Clinică Dentară", Address = "Strada Valea Albă, nr. 2, Bacău", Latitude = 46.565842735901725, Longitude = 26.917379110247268 },
                new MedicLocation { Name = "Clinica LifeDent", Address = "Strada Războieni, nr. 21, Bacău", Latitude = 46.561746483498595, Longitude = 26.9107358454233 },
                new MedicLocation { Name = "Dent Design", Address = "Strada Valea Albă, nr. 5, Bacău", Latitude = 46.566477267845066, Longitude = 26.919457001294596 },
                new MedicLocation { Name = "Clinica Stomadas", Address = "Strada Miron Costin, nr. 66, Bacău", Latitude = 46.55768411439993, Longitude = 26.92138819183702 },
                new MedicLocation { Name = "Clinica Dental Vision", Address = "Strada Mihai Eminescu, nr. 33, Bacău", Latitude = 46.565887167887695, Longitude = 26.898299736926482 },
                new MedicLocation { Name = "Clinica Stomatologica Denta", Address = "Strada Lucrețiu Pătrășcanu, nr. 2, Bacău", Latitude = 46.57125684048293, Longitude = 26.91332010722144 },
                new MedicLocation { Name = "Dianet Dent", Address = "Strada Miron Costin, nr. 2, Bacău", Latitude = 46.56385127392462, Longitude = 26.917912048997326 },
                new MedicLocation { Name = "HappyDent", Address = "Strada Cornișa Bistriței, nr. 40 bis, Bacău", Latitude = 46.550344884071244, Longitude = 26.91463339978033 },
                new MedicLocation { Name = "Dental Avenue", Address = "Strada Energiei, nr. 36, Bacău", Latitude = 46.57075425887836, Longitude = 26.896623984436633 },
                new MedicLocation { Name = "Mediclinic", Address = "Strada Mioriței, nr. 7c, Bacău", Latitude = 46.574496194330486, Longitude = 26.911182403536923 }
            };
            return Task.FromResult(dentistLocations);
        }

        #endregion

        #region Lista Clinici Medicale
        internal Task<List<MedicLocation>> LoadAnalize()
        {
            List<MedicLocation> analizeLocations = new List<MedicLocation>
            {
                new MedicLocation { Name = "Laborator Analize Synevo", Address = "Bulevardul Unirii, nr. 41, Bacău", Latitude = 46.57366, Longitude = 26.92760 },
                new MedicLocation { Name = "Clinica Sante", Address = "Strada Carpați, nr. 23, Bacău", Latitude = 46.55132301322589, Longitude = 26.91121516944589 },
                new MedicLocation { Name = "Laborator Analize Synevo 1", Address = "Calea Mărășești, nr. 151, Bacău", Latitude = 46.55560, Longitude = 26.91215 },
                new MedicLocation { Name = "Laborator Analize Margarit", Address = "Calea Mărășești, nr. 159, Bacaău", Latitude = 46.5532818595003, Longitude = 26.912660015503313 },
                new MedicLocation { Name = "Laborator Analize Synevo 2", Address = "Strada 9 Mai, nr. 56B, Bacău", Latitude = 46.56542368026223, Longitude = 26.917253186389676 },
                new MedicLocation { Name = "Regina Maria", Address = "Bulevardul Ioniță Sandu Sturza, nr. 3, Bacău", Latitude = 46.56507, Longitude = 26.91001 },
                new MedicLocation { Name = "Mediclinic", Address = "Strada Mioriței, nr. 7c, Bacău", Latitude = 46.574496194330486, Longitude = 26.911182403536923 },
                new MedicLocation { Name = "Centrul Medical - New Central Med", Address = "Strada Buciumului, nr. 4a, Bacău", Latitude = 46.57763, Longitude = 26.90837 },
                new MedicLocation { Name = "Synevo Mioriței", Address = "Strada Mioriței, nr. 16, Bacău", Latitude = 46.575878908816065, Longitude = 26.907862703688668 },
                new MedicLocation { Name = "Medisense", Address = "Strada Ștefan cel Mare, nr. 24D, Bacău", Latitude = 46.57899, Longitude = 26.91538 },
                new MedicLocation { Name = "Centrum Test S.R.L.", Address = "Calea Mărășești, nr. 13, Bacău", Latitude = 46.56180, Longitude = 26.91265 },
                new MedicLocation { Name = "Echo-Lab", Address = "Strada Erou Ciprian Pintea, nr. 25, Bacău", Latitude = 46.55571, Longitude = 26.91508 },
                new MedicLocation { Name = "Centrul Medical Anastasios Bacău", Address = "Strada Vadul Bistriței, nr. 29, Bacău", Latitude = 46.57302, Longitude = 26.91594 },
                new MedicLocation { Name = "Medicina Muncii Bacău", Address = "Bulevardul Ioniță Sandu Sturza, nr. 29, Bacău", Latitude = 46.56450, Longitude = 26.90701 },
                new MedicLocation { Name = "Laurus Medical Bacău", Address = "Strada Erou pintea, nr. 12, Bacău", Latitude = 46.55583 , Longitude = 26.91281 },
                new MedicLocation { Name = "Spinal Care Bacău", Address = "Strada Mihai Eminescu, nr. 1, Bacău", Latitude = 46.56682, Longitude = 26.90263 }

            };
            return Task.FromResult(analizeLocations);
        }
        #endregion

        #region Spitale
        internal Task<List<MedicLocation>> LoadSpitale()
        {
            List<MedicLocation> spitaleLocations = new List<MedicLocation>
            {
                new MedicLocation { Name = "Spitalul Județean de Urgență Bacău", Address = "Strada Spiru Haret, nr. 2-4, Bacău", Latitude = 46.556248, Longitude = 26.911238 },
                new MedicLocation { Name = "Spitalul Municipal Sfânta Maria Bacău", Address = "Calea Mărășești, Bacău", Latitude = 46.55737, Longitude = 26.91007 },
                new MedicLocation { Name = "Spitalul de Pediatrie Bacău", Address = "Strada Spiru Haret, nr. 2-4, Bacău", Latitude = 46.558071, Longitude = 26.910816 },
                new MedicLocation { Name = "Spitalul de Pneumoftiziologie Bacău", Address = "Strada Oituz, nr. 72, Bacău", Latitude = 46.56418, Longitude = 26.89997 }
                
            };
            return Task.FromResult(spitaleLocations);
        }
        #endregion
    }
}
