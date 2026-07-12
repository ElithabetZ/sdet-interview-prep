
namespace CSharpSpecFlowHealthcareExample.Domain
{
    public sealed class PatientDirectory
    {
        private readonly List<Patient> _patients = new();

        public void AddPatient(Patient patient)
        {
            ArgumentNullException.ThrowIfNull(patient);

            _patients.Add(patient);
        }

        public IReadOnlyList<Patient> SearchByLastName(
            string lastName)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(lastName);

            return _patients
                .Where(patient =>
                    patient.LastName.Equals(
                        lastName,
                        StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
    }
}
