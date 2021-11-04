﻿using System;
using System.Collections.Generic;
using Gogo.ModelData;

namespace Gogo.Service
{
    public interface IExperienceService
    {
        public List<ExperienceDTO> GetAllDTO();
    }

    public class ExperienceService : IExperienceService
    {
        private List<Experience> list = new List<Experience>();

        public ExperienceService()
        {
            Inizialize();
        }

        private void Inizialize()
        {
            Experience e1;
            e1 = new Experience("Halloween Città della Domenica");
            e1.SetDate(DateTime.Parse("2021-10-31 00:00:00"), DateTime.Parse("2021-10-31 23:00:00"));
            e1.SetLocation("Perugia (PG)");
            e1.SetDescription("Si svolge a merda!");
            list.Add(e1);

            Experience e2 = new Experience("Capodanno Tenerife");
            e2.SetDate(DateTime.Parse("2021-12-31 21:00:00"), DateTime.Parse("2022-01-01 04:00:00"));
            e2.SetLocation("Spagna (TF)");
            e2.SetDescription("Si svolge con puttane!");
            list.Add(e2);
        }

        public List<ExperienceDTO> GetAllDTO()
        {
            var listDTO = new List<ExperienceDTO>();

            list.ForEach(exp => listDTO.Add(exp.ToDTO()));

            return listDTO;
        }
    }
}