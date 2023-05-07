using System.Collections.Generic;
using OPD_Service.Models;

namespace OPD_Service.Services
{
    public interface IOpdService
    {
        List<Treatment> GetTreatmentList();
        Treatment GetTreatmentById(int id);
        void CreateTreatment(Treatment treatment);
        void UpdateTreatment(Treatment treatment);
        void DeleteTreatment(int id);
    }
}
