using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Windows;
using ООО__Товары_для_животных_.Database;
using ООО__Товары_для_животных_.Models;
using ООО__Товары_для_животных_.Tools.Interfaces;

namespace ООО__Товары_для_животных_.Tools;

internal static class Auth
{
    internal static string Username { get; set; } = string.Empty;

    internal static string UserRole { get; set; } = string.Empty;

    internal static bool IsUserAdmin { get; private set; } = false;

    internal static User ValidateUser(string pass, string login, IDbProvider dbProvider) //передаем интерфейс
    {
        User findedUser = null!;

        try
        {
            //findedUser = DB.Instance.Users.Include("UserRoleNavigation").FirstOrDefault(s => s.UserPassword == pass & s.UserLogin == login)!;
            //Строку 23 мы суем в файл ALProvidor (Класс интерфейса)
            dbProvider.Authorization(login, pass);
        }
        catch
        {
            MessageBox.Show("Ошибка связи с базой данных. Обратитесь к администратору");
            return null!;
        }

        if (findedUser == null)
        {
            MessageBox.Show("Пользователя с таким логином и паролем не существует!");
            return null!;
        }

        IsUserAdmin = findedUser.UserRoleNavigation.RoleName == "Администратор";

        return findedUser;
    }
}