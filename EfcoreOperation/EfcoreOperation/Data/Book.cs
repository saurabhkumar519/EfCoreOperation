namespace EfcoreOperation.Data
{
    public class Book
    {
        public int Id  { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int LanguageId { get; set; }
        public DateTime CreatedOn { get; set; }

        public Language language { get; set; }
    }
}
