using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ОООТехносервис.Classes; //Для сокращения

namespace ОООТехносервис
{
    public partial class Autorisation : Form
    {
        public Autorisation()
        {
            InitializeComponent();

            // Создали подключение к БД. 
            try
            {
                Classes.Helper.DBRequest = new Model.ConnectDBRequest();
                MessageBox.Show("Подключение к БД выполнено");
            }
            catch 
            {
                MessageBox.Show("Не удалось подключиться к БД!");
                Environment.Exit(-1); //Аварийный выход из приложения
            }
        }

       /// <summary>
       /// выход из приложения
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Autorisation_Load(object sender, EventArgs e)
        {
            

        }

        /// <summary>
        /// Вход в систему по логину и паролю
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInput_Click(object sender, EventArgs e)
        {
            string login, pass;
            //Получили данный от пользователя из интерфейса
            login = textBoxLogin.Text;
            pass = textBoxPass.Text;
            ////один пользователь
            //Model.User user = null;

            //Результат запроса на получение всех пользователей

            ////В List содержатся объекты пользователей
            //List<Model.User> users= Classes.Helper.DBRequest.User.ToList();

            ////список отфильтрованных пользователей
            //List<Model.User> usersWhere = users.Where(u => u.UserLogin == login && u.UserPassword == pass).ToList();
            //user=usersWhere.FirstOrDefault();

          Helper.user = Helper.DBRequest.User.Where(u => u.UserLogin == login && u.UserPassword == pass).FirstOrDefault();
            //перебор всех пользователей
            //foreach (Model.User u in users)
            //{
            //    if (u.UserLogin == login && u.UserPassword==pass)
            //    {
            //        user = u;

            //        break;
            //    }                
            //}


            if (Helper.user != null)
            {
                MessageBox.Show("Нашли. Вы вошли с ролью " + Helper.user.Role.RoleName);
                 //Отобразить окно
                 View.ListRequest listRequest = new View.ListRequest(); //Создали дополнительное окно
                this.Hide(); //Временно скрыли окно авторизации. this - ссылка на окно в котором сейчас находимся
                listRequest.ShowDialog(); //Открыть окно списка
                this.Show(); //показать окно авторизации после закрытия окна списка

            }
            else
            {
                MessageBox.Show("не нашли");
            }

        }
        

    }
}
