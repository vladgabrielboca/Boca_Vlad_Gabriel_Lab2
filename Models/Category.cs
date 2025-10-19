namespace Boca_Vlad_Gabriel_Lab2.Models
{
    public class Category
    {
        public int ID { set; get; }
        public string CategoryName { set; get; }
        public ICollection<BookCategory>? BookCategories { set; get; }
    }
}
