﻿using SoftUniSpaceConsoleWebApp.Data.Entities;

namespace SoftUniSpaceConsoleWebApp.Repositories.Interfaces
{
    public interface ICrewRepository
    {
        void Add(Crew crew);



        IEnumerable<Crew> GetAll(); //138

    }
}
