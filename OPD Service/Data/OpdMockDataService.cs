using System.Collections.Generic;
using System.Linq;
using OPD_Service.Models;

namespace OPD_Service.Data
{
    public class OpdMockDataService
    {
        private readonly List<Treatment> _treatments = new List<Treatment>()
        {
            new Treatment() { Id = 1, PatientId = 1, Name = "Checkup", Description = "Basic medical checkup", DrugType = "Tablet", Quantity = 1, Price = 100 },
            new Treatment() { Id = 2, PatientId = 2, Name = "X-Ray", Description = "Medical imaging test", DrugType = "Injection", Quantity = 1, Price = 250 },
            new Treatment() { Id = 3, PatientId = 3, Name = "Blood Test", Description = "Blood analysis", DrugType = "Syrup", Quantity = 2, Price = 50 }
        };

        public List<Treatment> GetTreatmentList()
        {
            return _treatments;
        }

        public Treatment GetTreatmentById(int id)
        {
            return _treatments.FirstOrDefault(t => t.Id == id);
        }

        public void CreateTreatment(Treatment treatment)
        {
            int newId = _treatments.Count + 1;
            treatment.Id = newId;
            _treatments.Add(treatment);
        }

        public void UpdateTreatment(Treatment treatment)
        {
            Treatment existingTreatment = GetTreatmentById(treatment.Id);
            if (existingTreatment != null)
            {
                existingTreatment.PatientId = treatment.PatientId;
                existingTreatment.Name = treatment.Name;
                existingTreatment.Description = treatment.Description;
                existingTreatment.DrugType = treatment.DrugType;
                existingTreatment.Quantity = treatment.Quantity;
                existingTreatment.Price = treatment.Price;
            }
        }

        public void DeleteTreatment(int id)
        {
            Treatment existingTreatment = GetTreatmentById(id);
            if (existingTreatment != null)
            {
                _treatments.Remove(existingTreatment);
            }
        }
    }
}
