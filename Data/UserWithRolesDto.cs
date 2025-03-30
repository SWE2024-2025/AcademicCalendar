namespace AcademicYearCalendar.Data
{
    public class UserWithRolesDto
    {
        public string UserId { get; set; }
        
        public string UserEmail { get; set; }
        
        public string UserName { get; set; }

        public string FullName { get; set; }

        public IEnumerable<RoleDto> Roles { get; set; } = Array.Empty<RoleDto>();
    }


    public class RoleDto
    {
        public string RoleId { get; set; }
        public string RoleName { get; set; }
    }
}
