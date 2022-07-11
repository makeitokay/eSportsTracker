using Microsoft.AspNetCore.Identity;

namespace eSportsTracker.Web.Areas.Identity
{
    public class RussianErrorDescriber : IdentityErrorDescriber
    {
        public override IdentityError DefaultError() => new() { Description = "Произошла неизвестная ошибка.", Code = nameof(DefaultError) };
        public override IdentityError ConcurrencyFailure() => new() { Description = "Сбой параллелизма.", Code = nameof(ConcurrencyFailure) };
        public override IdentityError PasswordMismatch() => new() { Description = "Неверный пароль.", Code = nameof(PasswordMismatch) };
        public override IdentityError InvalidToken() => new() { Description = "Неверный токен.", Code = nameof(InvalidToken)};
        public override IdentityError LoginAlreadyAssociated() => new() { Description = "Этот способ авторизации уже подключен.", Code = nameof(LoginAlreadyAssociated) };
        public override IdentityError InvalidUserName(string userName) => new() { Description = $"Имя пользователя может содержать только латинские буквы, цифры, и знаки -._@+", Code = nameof(InvalidUserName) };
        public override IdentityError InvalidEmail(string email) => new() { Description = $"Введена некорректная электронная почта.", Code = nameof(InvalidEmail) };
        public override IdentityError DuplicateUserName(string userName) => new() { Description = $"Пользователь с таким никнеймом уже существует.", Code = nameof(DuplicateUserName) };
        public override IdentityError DuplicateEmail(string email) => new() { Description = $"Пользователь с такой электронной почтой уже существует.", Code = nameof(DuplicateEmail) };
        public override IdentityError InvalidRoleName(string role) => new() { Description = $"Роль '{role}' некорректна.", Code = nameof(InvalidRoleName) };
        public override IdentityError DuplicateRoleName(string role) => new() { Description = $"Роль '{role}' уже существует.", Code = nameof(DuplicateRoleName) };
        public override IdentityError UserAlreadyHasPassword() => new() { Description = "У пользователя уже есть пароль.", Code = nameof(UserAlreadyHasPassword) };
        public override IdentityError UserLockoutNotEnabled() => new() { Description = "Блокировка пользователя не включена.", Code = nameof(UserLockoutNotEnabled) };
        public override IdentityError UserAlreadyInRole(string role) => new() { Description = $"У пользователя уже есть роль '{role}'.", Code = nameof(UserAlreadyInRole) };
        public override IdentityError UserNotInRole(string role) => new() { Description = $"У пользователя нет роли '{role}'.", Code = nameof(UserNotInRole) };
        public override IdentityError PasswordTooShort(int length) => new() { Description = $"Пароль должен состоять минимум из {length} символов.", Code = nameof(PasswordTooShort) };
        public override IdentityError PasswordRequiresNonAlphanumeric() => new() { Description = "Пароль должен содержать хотя бы один НЕ буквенно-цифровой символ.", Code = nameof(PasswordRequiresNonAlphanumeric) };
        public override IdentityError PasswordRequiresDigit() => new() { Description = "Пароль должен содержать хотя бы одну цифру.", Code = nameof(PasswordRequiresDigit) };
        public override IdentityError PasswordRequiresLower() => new() { Description = "Пароль должен содержать хотя бы одну букву в нижнем регистре.", Code = nameof(PasswordRequiresLower) };
        public override IdentityError PasswordRequiresUpper() => new() { Description = "Пароль должен содержать хотя бы одну букву в верхнем регистре.", Code = nameof(PasswordRequiresUpper) };

    }
}
