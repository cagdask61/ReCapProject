using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<RentalDetailDto>> GetRentalDetail();
        IDataResult<List<Rental>> GetAllRental();
        IDataResult<Rental> GetRentalById(int rentalId);

        IResult RentalAdd(Rental rental);
        IResult RentalDelete(Rental rental);
        IResult RentalUpdate(Rental rental);

    }
}
