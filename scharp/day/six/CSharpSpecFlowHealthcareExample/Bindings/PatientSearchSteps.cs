
using CSharpSpecFlowHealthcareExample.Domain;
using NUnit.Framework;
using System.Globalization;
using TechTalk.SpecFlow;

namespace CSharpSpecFlowHealthcareExample.Bindings
{
    [Binding]
    public sealed class PatientSearchSteps
    {
        private PatientDirectory _patientDirectory = null!;

        private IReadOnlyList<Patient> _searchResults =
            Array.Empty<Patient>();

        [Given(@"^the patient directory contains:$")]
        public void GivenThePatientDirectoryContains(
            Table table)
        {
            _patientDirectory = new PatientDirectory();

            foreach (var row in table.Rows)
            {
                var patient = new Patient(
                    Id: row["id"],
                    FirstName: row["firstName"],
                    LastName: row["lastName"],
                    DateOfBirth: DateTime.ParseExact(
                        row["dateOfBirth"],
                        "yyyy-MM-dd",
                        CultureInfo.InvariantCulture));

                _patientDirectory.AddPatient(patient);
            }
        }

        [When(
            @"^I search for patients with last name ""([^""]*)""$")]
        public void WhenISearchForPatientsWithLastName(
            string lastName)
        {
            _searchResults =
                _patientDirectory.SearchByLastName(lastName);
        }

        [Then(@"^(\d+) patients should be returned$")]
        public void ThenPatientsShouldBeReturned(
            int expectedCount)
        {
            Assert.That(
                _searchResults,
                Has.Count.EqualTo(expectedCount));
        }

        [Then(
            @"^the returned patient IDs should be ""([^""]*)""$")]
        public void ThenTheReturnedPatientIdsShouldBe(
            string commaSeparatedIds)
        {
            var expectedIds = commaSeparatedIds
                .Split(
                    ',',
                    StringSplitOptions.TrimEntries |
                    StringSplitOptions.RemoveEmptyEntries);

            var actualIds = _searchResults
                .Select(patient => patient.Id)
                .ToArray();

            Assert.That(
                actualIds,
                Is.EqualTo(expectedIds));
        }
    }
}
