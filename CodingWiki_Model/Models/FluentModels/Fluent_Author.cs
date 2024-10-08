﻿namespace CodingWiki_Model.Models
{
    public class Fluent_Author
    {
        public int Author_Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public string Location { get; set; }
        public string FullName { get { return $"{FirstName} {LastName}"; } }

        public List<Fluent_BookAuthorMap> BookAuthorMap { get; set; }
    }
}
