﻿namespace EfcoreOperation.Data
{
    public class Language
    {
        public int Id { get; set; }
        public int Title { get; set; }
        public int Decription { get; set; }


        public ICollection<Book> Books { get; set; }
    }
}
