namespace Oops
{
    //encapsulation is nothing but wrapping data and methods into single unit or
    //capsulating the class memebers into a single unit
    //we can acheive encapsulation by making feilds as private and provide public methods to
    //access that feilds

    public class Encapsulation
    {
        public class MonthNameGetter
        {

            private string[] monthNames =
            {
               "January", "February", "March", "April", "May", "June",
               "July", "August", "September", "October", "November", "December"
            };

            public void GetMonthName(int monthNumber)
            {
                if (monthNumber >= 1 && monthNumber <= 12)
                {
                    string monthName= monthNames[monthNumber - 1];
                    Console.WriteLine($"Month {monthNumber} is {monthName}");
                }
                else
                {
                    Console.WriteLine( "Month number should be between 1 and 12.");
                }
            }
        }
    }
}
