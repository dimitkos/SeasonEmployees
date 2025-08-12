namespace Domain.Aggregates
{
    public class Vacancy
    {
        public long Id { get; }
        public long EmployerId { get; }
        public Specialty Specialty { get; }
        public string Description { get; }
        public string? Salary { get; }
        public List<long> Applyers { get; }


        //a vaccancy

        //can created
        // update specialty
        // update decription
        // update Salary
        // apply

    }
}
