using System.Collections.Generic;
using OPD_Service.Services;
using OPD_Service.Models;
using OPD_Service.Data;

namespace OPD_Service.Services
{
    public class OpdService : IOpdService
    {
        private readonly OpdMockDataService _opdDataService;

        public OpdService(OpdMockDataService opdDataService)
        {
            _opdDataService = opdDataService;
        }

        public List<Treatment> GetTreatmentList()
        {
            return _opdDataService.GetTreatmentList();
        }

        public Treatment GetTreatmentById(int id)
        {
            return _opdDataService.GetTreatmentById(id);
        }

        public void CreateTreatment(Treatment treatment)
        {
            _opdDataService.CreateTreatment(treatment);
        }

        public void UpdateTreatment(Treatment treatment)
        {
            _opdDataService.UpdateTreatment(treatment);
        }

        public void DeleteTreatment(int id)
        {
            _opdDataService.DeleteTreatment(id);
        }
    }
}
