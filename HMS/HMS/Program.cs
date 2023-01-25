using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HMS.bl;
using HMS.dl;

namespace HMS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            EmployeeDL.LoadEmpData("Employees.txt");
            DoctorDL.LoadDocData("Doctors.txt");
            ReceptionistDL.LoadReceptData("Receptionists.txt");
            MedicineDL.LoadMedData("Medicines.txt");
            DeptDL.LoadDeptData("Depts.txt");
            RoomDL.LoadRoomData("Rooms.txt");
            PrescriptionDL.LoadPrescriptions("Prescriptions.txt");
            PatientDL.LoadPatientData("Patients.txt");
            AppointmentDL.LoadAppointmentsData("Appointments.txt");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm1());

        }
    }
}
