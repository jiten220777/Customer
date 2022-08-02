namespace API.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; } 
        public string  Address { get; set; }       
        public string State { get; set; }
        public string City { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string PANNO { get; set; }
        public string GSTINNo { get; set; }
        
    }
}