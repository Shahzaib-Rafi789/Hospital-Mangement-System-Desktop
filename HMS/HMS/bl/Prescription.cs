using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.bl
{
    public class Prescription
    {
        private string patientId;
        private List<Medicine> medicines;
        private List<string> pattern;

        public Prescription(string patientId, List<Medicine> medicines, List<string> pattern)
        {
            this.PatientId = patientId;
            this.Medicines = medicines;
            this.Pattern = pattern;
        }

        public string PatientId { get => patientId; set => patientId = value; }
        public List<string> Pattern { get => pattern; set => pattern = value; }
        public List<Medicine> Medicines { get => medicines; set => medicines = value; }
    }
}
