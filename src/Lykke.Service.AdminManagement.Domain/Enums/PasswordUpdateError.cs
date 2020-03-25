namespace Lykke.Service.AdminManagement.Domain.Enums
{
    public enum PasswordUpdateError
    {
        None,

        LoginNotFound,

        PasswordMismatch,

        InvalidEmailOrPasswordFormat,
        
        NewPasswordInvalid,
        
        AdminNotActive
    }
}