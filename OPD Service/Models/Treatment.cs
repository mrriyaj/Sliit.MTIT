﻿namespace OPD_Service.Models
{
    public class Treatment
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DrugType { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
