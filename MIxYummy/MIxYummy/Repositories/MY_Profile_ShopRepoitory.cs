using System;
using MIxYummy.Controllers;
using Dapper;
using System.Linq;
using MySqlConnector;
using MIxYummy.Models;
using System.Collections.Generic;

namespace MIxYummy.Repositories
{
    public class MY_Profile_ShopRepoitory
    {
        private string connectionString = "Server=localhost;Port=3306;Database=Yummy;Uid=root;Pwd=;";

        public MY_Profile_ShopRepoitory()
        {
        }

        public IEnumerable<MY_Profile_Shop>GetAll()
        {
            var models = new List<MY_Profile_Shop>();
            using (var db = new MySqlConnection(connectionString))
            {
                models = db.Query<MY_Profile_Shop>("SELECT * FROM MY_Profile_Shop").ToList();
            }
            return models;
        }

        public int Add(MY_Profile_Shop mY_Profile_Shop)
        {
            var response = 0;
            var sqlCommand = string.Format(@"INSERT INTO MY_Profile_Shop
                                                       (Shop_Email
                                                       ,Shop_Password)
                                                 VALUES
                                                       (@Shop_Email
                                                       ,@Shop_Password)");
            using (var db = new MySqlConnection(connectionString))
            {
                response = db.Execute(sqlCommand, new
                {
                    Shop_Email = mY_Profile_Shop.Shop_Email,
                    Shop_Password = mY_Profile_Shop.Shop_Password
                });
            }
            return response;
        }

        public MY_Profile_Shop GetById(int id)
        {
            var models = new MY_Profile_Shop();
            using (var db = new MySqlConnection(connectionString))
            {
                models = db.Query<MY_Profile_Shop>("SELECT * FROM MY_Profile_Shop WHERE Id = @Id", new
                {
                    Id = id
                }).FirstOrDefault();
            }
            return models;
        } // run เลือกดูอย่าง detail 


        public int Update(MY_Profile_Shop mY_Profile_Shop,int id)
        {

            var models = 0;
            var sqlCommand = string.Format(@"UPDATE MY_Profile_Shop SET Shop_Email=@Shop_Email ,Shop_Password=@Shop_Password WHERE Id = @Id");

            using (var db = new MySqlConnection(connectionString))
            {
                models = db.Execute(sqlCommand, new
                {
                    Shop_Email = mY_Profile_Shop.Shop_Email,
                    Shop_Password = mY_Profile_Shop.Shop_Password,
                    Id = id
                });
            }
            return models;
        }// แก้ไขได้

       





    }
}
