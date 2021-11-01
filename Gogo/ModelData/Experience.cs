using System;
namespace Gogo.ModelData
{
    public class Experience
    {
        private DateTime StartDateTime;

        private DateTime EndDateTime;

        private string Name;

        private string Description;

        private string Location;

        public Experience(string n)
        {
            Name = n; 
        }

        public Experience(DateTime date)
        {
            StartDateTime = date;
        }

        public void SetDate(DateTime Start, DateTime End)
        {
            StartDateTime = Start;
            EndDateTime = End;
        }

        public void SetLocation(string Place)
        {
            Location = Place;
        }

        public void SetDescription(string D)
        {
            Description = D;
        }

        public ExperienceDTO ToDTO()
        {
            return new ExperienceDTO
            {
                Description = Description,
                Name = Name
            };
        }
    }

}
