using System.ComponentModel.DataAnnotations;

namespace MSUFRIBCodeTest.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string? MessageBody { get; set; }

        [DataType(DataType.Date)]
        public DateTime SentDate { get; set; }
    }
}
