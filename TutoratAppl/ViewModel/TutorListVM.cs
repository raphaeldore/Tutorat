namespace TutoratAppl.ViewModel
{
    public class TutorListVM
    {
        public string EmailAddress { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Id { get; set; }

        public override string ToString()
        {
            return "Courriel: " + EmailAddress + ", Nom: " + FirstName + " " + LastName + ", ID: " + Id.ToString();
        }
    }
}