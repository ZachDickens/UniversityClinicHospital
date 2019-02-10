using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Patient 
    {
        int BloodLevel { get; set; }
        int HealthLevel { get; set; }
        string Name { get; set; }
        public Patient(int BloodLevel, int HealthLevel)
        {
            BloodLevel = 20;
            HealthLevel = 10;
        }
        public void DoctorDrawBlood()
        {
            
         BloodLevel = BloodLevel - 5;
         HealthLevel = HealthLevel - 1;
               
        }

        public void NurseDrawBlood()
        {
                       
         BloodLevel = BloodLevel - 3;
         HealthLevel = HealthLevel - 1;
            
        }

        public void GivePatientMedicine()
        {
            HealthLevel = HealthLevel + 1;
        }

    }
}