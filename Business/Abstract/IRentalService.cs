﻿using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<RentalDetailDto>> GetByRentalDetail();
        IDataResult<List<Rental>> GetAllRental();
        IResult RentalAdd(Rental rental);
        IResult RentalDelete(Rental rental);
        IResult RentalUpdate(Rental rental);

    }
}
