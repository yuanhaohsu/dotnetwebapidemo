using System;

namespace API.Extensions
{
    public static class DateTimeExtensions  
    {
      public static int CalcuateAge(this DateOnly dob)
      {
            // https://stackoverflow.com/questions/9/how-do-i-calculate-someones-age-based-on-a-datetime-type-birthday
            var today = DateObnly.FromDateTime(DateTime.UtcNow); 
            var age = today.Year - dob.Year;
            if (dob > today.AddYears(-age)) age--;
            return age;
      }
    }
}