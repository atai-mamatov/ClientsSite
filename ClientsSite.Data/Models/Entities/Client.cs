using ClientsSite.Data.Models.Common;

namespace ClientsSite.Data.Models.Entities
{
    public class Client : BaseEntity
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int PhoneNum { get; set; }
    }
}
