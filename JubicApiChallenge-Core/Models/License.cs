namespace JubicApiChallenge_Core.Models
{
    public class License
    {
        private LicenseContext context;
        public int Id { get; set; }
        public string Name { get; set; }
        public string ExpiresAt { get; set; }
        public string QueriedAt { get; set; }
        public string Error { get; set; }

        /*public License(int Id, string Name, string Expiry, string Queried, string Error)
        {
            this.Id = Id;
            this.Name = Name;
            this.Expiry = Expiry;
            this.Queried = Queried;
            this.Error = Error;
        }*/
    }
}