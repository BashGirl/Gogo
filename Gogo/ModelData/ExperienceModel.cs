using System;
namespace Gogo.ModelData
{
    public class ExperienceModel
    {
        private DateTime StartDateTime;

        private DateTime EndDateTime;

        private string Name;

        private string Description;

        private string Location;

        public ExperienceModel(string n)
        {
            Name = n; 
        }

        public ExperienceModel(DateTime date)
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

        public Experience ToDTO()
        {
            return new Experience
            {
                Description = Description,
                Name = Name,
                Location = Location,
            };
        }
    }

}
