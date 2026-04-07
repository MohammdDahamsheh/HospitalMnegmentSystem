using Appleacation.Responses;
using Appleacation.unitOfWork;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appleacation.service.query.Patient
{
    public class PatientQueryService
    {
        private readonly IUnitOfWork<Patients> patientUnitOfWork;

        public PatientQueryService(IUnitOfWork<Patients> patientUnitOfWork)
        {
            this.patientUnitOfWork = patientUnitOfWork;
        }


        public async Task<PatientResponse> GetPatientById(int id)
        {
            var patient = await patientUnitOfWork.ReadOnlyReposotory.GetByIdAsync(id);
            if (patient == null)
            {
                throw new Exception($"Patient with id {id} not found.");
            }
            var patientResponse = new PatientResponse
            {
                patientCode = patient.patientCode,
                name = patient.name,
                phone = patient.phone,
                addres = patient.addres,
                bloodType = patient.bloodType,
                dateOfBirth = patient.dateOfBirth,
                emergencyContact = patient.emergencyContact,
                createdAt = patient.createdAt,
                gender = patient.gender,
                allergies = patient.allergies,


            };


            return patientResponse;
        }
        public async Task<List<PatientResponse>> GetAllPatients()
        {
            var patients = await (
                from p in patientUnitOfWork.ReadOnlyReposotory.GetAll()
                select new PatientResponse
                {
                    patientCode = p.patientCode,
                    name = p.name,
                    phone = p.phone,
                    addres = p.addres,
                    bloodType = p.bloodType,
                    dateOfBirth = p.dateOfBirth,
                    emergencyContact = p.emergencyContact,
                    createdAt = p.createdAt
                }
            ).ToListAsync();

            if (patients.Count == 0)
            {
                throw new Exception("No patients found.");
            }

            return patients;
        }
    }
}
