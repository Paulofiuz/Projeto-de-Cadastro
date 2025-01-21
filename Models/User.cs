namespace Cadastro.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; } 
        public DateTime? DateTime { get; set; }
        public string Fate { get; set; }

        // Propriedade de navegação para Address
        public int AddressId { get; set; }
        public Address Address { get; set; }
    }
}
