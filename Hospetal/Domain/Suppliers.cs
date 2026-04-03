using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Suppliers
    {
        public Suppliers() { }
        [Key]
        public int supplierId { get; private set; }
        public string name { get; private set; }
        public string contactInfo { get; private set; }
        public IEnumerable<Medicines> medicines { get; private set; }
    }
}