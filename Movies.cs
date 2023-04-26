namespace API_Design_and_Construction
{
    public class Movies
    {
        public string? Title { get; set; }
        public string? Director { get; set; }
        public string? Description { get; set; }
        public List<string> Stars { get; set; }

        public Movies(string Title, string Director, string Description, List<string> Stars) { 
            this.Title = Title;
            this.Director = Director;   
            this.Description = Description;
            this.Stars = Stars;
        }
    }
}
