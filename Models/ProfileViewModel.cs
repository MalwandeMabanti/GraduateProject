namespace NewProject.Models
{
    public class ProfileViewModel


    {

        private string name = "John";
        private string surname = "Smith";
        private string dateOfBirth = "01/01/1950";
        private int age = 73;
        private string country = "South Africa";
        private string city = "Johannesburg";

        

        public string Name 
        { 
            get { return name; } 
            set { name = value; } 
        }
        public string Surname 
        {   
            get { return surname; }
            set { surname = value; } 
        }
        public string DateOfBirth 
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; } 
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Country 
        {
            get { return country; } 
            set { country = value; } 
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
    }
}
