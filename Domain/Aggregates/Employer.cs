using System.Data;

namespace Domain.Aggregates
{
    public class Employer
    {
        public long Id { get; set; }
        public string BrandName { get; }
        public string Description { get; }
        public string Email { get; }
        public string Place { get; }
        public string Country { get; }
        public List<Vacancy> Vacancies { get; }
        public List<byte[]> Photos { get; }


       //an employer 

        //can create
        // update brand name
        //update description'
        //update email
        // update place
        // update country
        // add vaccancy ???????
        // upload photo
    }
}
