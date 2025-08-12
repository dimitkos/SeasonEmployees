namespace Domain.Aggregates
{
    public class Employee
    {
        public long Id { get; set; }
        public string FirstName { get; }
        public string LastName { get; }
        public string Description { get; }
        public string Email { get; }
        public string Mobile { get; }
        public DateTime Birthday { get; }
        public DateTime Created { get; }
        public DateTime Updated { get; }
        public byte[] CV { get; }
        public byte[] Photo { get; }
        public string Country { get; }
        public List<Specialty> Specialties { get; }
        public List<string> Reccomendations { get; }
        public List<string> PreferredPlaces { get; }
        public List<long> Applies { get; }


        // an employee

        //can create
        //upload cv
        //upload photo
        //update specialty
        //update reccomendations ??
        //update mobile
        //update fisrt laste name
        //update descreiption
        //upload cv
        //apply

    }


    public enum Specialty
    {
        Barista,
        Bartender,
        Cleanser,
        Service,
        Chef,
        Manager,
        General,
    }
}
