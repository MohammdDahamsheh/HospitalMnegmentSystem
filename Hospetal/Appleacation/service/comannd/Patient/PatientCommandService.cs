using Appleacation.DTO;
using Appleacation.unitOfWork;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appleacation.service.comannd.Patient
{
    public class PatientCommandService
    {
        private readonly IUnitOfWork<Patients> patientUnitOfWork;

        public PatientCommandService(IUnitOfWork<Patients> patientUnitOfWork)
        {
            this.patientUnitOfWork = patientUnitOfWork;
        }

        public async Task addPatient(PatientDTO patientDTO) {
            var patient = new Patients
            {
                name = patientDTO.name,
                phone = patientDTO.phone,
                addres = patientDTO.addres,
                bloodType = patientDTO.bloodType,
                dateOfBirth = patientDTO.dateOfBirth,
                emergencyContact = patientDTO.emergencyContact,
                gender= patientDTO.gender,
                allergies = patientDTO.allergies,
                patientCode= Guid.NewGuid().ToString(),
                createdAt = DateTime.UtcNow

            };
             await patientUnitOfWork.Reposotory.AddAsync(patient);
             int numOfRecord=await patientUnitOfWork.SaveAsync();
            if (numOfRecord == 0) {
                throw new Exception("Failed to add patient");

            }
        }


    }
}
