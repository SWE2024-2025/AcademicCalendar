using Microsoft.AspNetCore.Components;
using Microsoft.FluentUI.AspNetCore.Components;
using System.IO;

namespace AcademicYearCalendar.Components
{
    public class MyIcons
    {
        public class Regular
        {
            public class Size16
            {
                public class Cancel : Icon
                {
                    public Cancel() : base("Cancel", IconVariant.Filled, IconSize.Size16, File.ReadAllText(@"wwwroot/Icons/cancel.svg"))
                    {

                    }
                }
                
            }
            public class Size20
            {
                public class Certificate : Icon
                {
                    public Certificate() : base("Certificate", IconVariant.Filled, IconSize.Size20, File.ReadAllText(@"wwwroot/Icons/certificate.svg"))
                    {

                    }
                }
                public class School : Icon
                {
                    public School() : base("School", IconVariant.Filled, IconSize.Size20, File.ReadAllText(@"wwwroot/Icons/school.svg"))
                    {

                    }
                }
                public class User : Icon
                {
                    public User() : base("User", IconVariant.Filled, IconSize.Size20, File.ReadAllText(@"wwwroot/Icons/user.svg"))
                    {

                    }
                }

                public class Settings : Icon
                {
                    public Settings() : base("Settings", IconVariant.Filled, IconSize.Size20, File.ReadAllText(@"wwwroot/Icons/settings.svg"))
                    {

                    }
                }
            }
        }
    }

}
