using OnlinePlatform.Domain.Common;

namespace OnlinePlatform.Domain.Entities.Users
{
    public class Person : Auditable
    {
        /// <summary>
        /// Required on register
        /// </summary>
        public string Phone { get; set; } = string.Empty;

        public bool ComfirmPhone { get; set; } = false;

        public string PasswordHash { get; set; } = string.Empty;

        public string Salt { get; set; } = string.Empty;

        /// <summary>
        /// Optional on update
        /// </summary>
        public string ImagePath { get; set; } = string.Empty;

        public string FullName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public bool ConfirmEmail { get; set; } = false;

        public string UserName { get; set; } = string.Empty;
    }
}
