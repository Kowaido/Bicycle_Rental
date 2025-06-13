using BicycleRental.Domain.Entities;
using BicycleRental.WebAPI.Models;

namespace BicycleRental.WebAPI.Mapping;

public static class DutyMapper
{
    public static Duty ToDomain(this DutyDb db)
    {
        return new Duty
        {
            IdDuty = db.IdDuty,
            SumDuty = db.SumDuty,
            Status = db.Status,
            DateDuty = db.DateDuty
        };
    }

    public static DutyDb ToDb(this Duty duty)
    {
        return new DutyDb
        {
            IdDuty = duty.IdDuty,
            SumDuty = duty.SumDuty,
            Status = duty.Status,
            DateDuty = duty.DateDuty
        };
    }
}