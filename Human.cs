namespace PhoneBook
{
    public class Human
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThrityName{ get; set; }
        public string Address{ get; set; }
        public List<Phone> Phones { get; set; } = new();
        public string ImagePath { get; set; }
    }
}