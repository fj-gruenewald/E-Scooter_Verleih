﻿using System;
using System.Collections.Generic;
using System.Text;

//
using RentNScoot.Domain;

namespace RentNScoot
{
    public interface IAppQueries
    {
        int CountScooters();

        ICollection<Scooter> GetAllScooters();

        ICollection<Location> GetAllLocations();
    }
}
