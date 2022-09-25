namespace Facture.Teacher.Domain.Entity
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Identification { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
        public string Nationality { get; set; }
        public string paymentCurrency { get; set; }
        public string commensal { get; set; }
        public string hourlyRate { get; set; }

    }
}