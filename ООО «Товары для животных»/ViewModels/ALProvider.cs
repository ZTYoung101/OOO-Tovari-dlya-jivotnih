﻿using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Windows;
using ООО__Товары_для_животных_.Database;
using ООО__Товары_для_животных_.Models;

namespace ООО__Товары_для_животных_
{
    public class ALProvider : IDbProvider
    {
        public void Authorization(string login, string pass)
        {
            //if(login == "admin" && pass == "admin")
            //{
            //    return;
            //}
            //else
            //{
            //    MessageBox.Show("Ошибка");
            //}
            User result = null;
            result = DB.Instance.Users.Include("UserRoleNavigation").FirstOrDefault(s => s.UserPassword == pass & s.UserLogin == login)!;
            return;
        }
    }
}