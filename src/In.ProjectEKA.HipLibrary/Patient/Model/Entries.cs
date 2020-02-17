namespace In.ProjectEKA.HipLibrary.Patient.Model
{
    using System.Collections.Generic;
    using Hl7.Fhir.Model;

    public class Entries
    {
        public Entries(IEnumerable<Bundle> bundles)
        {
            Bundles = bundles;
        }

        public IEnumerable<Bundle> Bundles { get; }
    }
}