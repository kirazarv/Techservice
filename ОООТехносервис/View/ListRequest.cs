using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ОООТехносервис.Classes;

namespace ОООТехносервис.View
{
    public partial class ListRequest : Form
    {
        public ListRequest()
        {
            InitializeComponent();
        }
        
        //void означает что метод ничего не возвращает
        //метод отображения заявок с учетом фильтрации
        public void ShowRequests()
        {
            //Получить из бд все заявки (с подключением к бд)
            List<Model.Request> list = Classes.Helper.DBRequest.Request.ToList();
            //Фильтрация по заявкам для заказчика для отображения заявок конкретного клиента


           //Анализ вошедшей роли
           switch(Helper.user.UserRoleId)
            {
                case 1:
                  //Заказчик 
                        list = list.Where(r => r.RequestClientId == Helper.user.UserId).ToList();
                    break;
                case 2:
                        list = list.Where(r => r.RequestMasterId == Helper.user.UserId).ToList();
                    editButton.Visible = true;
                    break;
                case 3:
            
                    editButton.Visible = true;
                    addButton.Visible = true;

                    break;
                case 4:
                    reportButton.Visible = true;
                    break;
            }
            
           
          
            //фильтровать по статусу 
            int numberStatus = (int)comboBoxStatus.SelectedIndex;
            if(numberStatus > 0 )
            {
                list=list.Where(r => r.RequestStatusId == numberStatus).ToList();
            }

            //поиск по номеру
            if(textBoxNumber.Text != "" )
            {
                list=list.Where(r=>r.RequestId.ToString().Contains(textBoxNumber.Text)).ToList();
            }
            


            this.dataGridViewRequest.Rows.Clear();

            int i = 0;
            //Цикл для перебора заявок и добавили кол=во пустых строк согласно количеству элементов в бд.
            foreach (Model.Request request in list)
            {
                this.dataGridViewRequest.Rows.Add();
                dataGridViewRequest.Rows[i].Cells[0].Value = request.RequestId;
                dataGridViewRequest.Rows[i].Cells[1].Value = request.RequestDate.ToLongDateString();
                dataGridViewRequest.Rows[i].Cells[2].Value = request.Device.DeviceName;
                dataGridViewRequest.Rows[i].Cells[3].Value = request.User1.UserFullName;
                dataGridViewRequest.Rows[i].Cells[4].Value = request.Status.StatusName;
                dataGridViewRequest.Rows[i].Cells[5].Value = request.User.UserFullName;
                dataGridViewRequest.Rows[i].Cells[6].Value = request.Stage.StageName;

                i++;
            }


        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// При загрузке окна отобразить список заявок
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListRequest_Load(object sender, EventArgs e)
        {
            //Заполнение комбо бокса статусами
            List<Model.Status> statuses = Classes.Helper.DBRequest.Status.ToList();
            //новый статус 
            Model.Status status = new Model.Status();
            //присвоили id которого нету:)
            status.StatusId = 0;
            status.StatusName = "Все статусы";
            //Add(status) добавляет в конец очереди
            //добавить новый статус в позицию 0 к статусам из бд
            statuses.Insert(0,status);
            //Перенос списка статусов в комбоБокс
            comboBoxStatus.DataSource = statuses;

            // Какое поле будет видеть пользователь
            comboBoxStatus.DisplayMember = "StatusName";
            //Получаем StatusId когда будем выбирать из списка элемент
            comboBoxStatus.ValueMember = "StatusId";
            comboBoxStatus.SelectedIndex = 0;

            ShowRequests();

        }
        /// <summary>
        /// событие Выбор статуса для фильтрации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowRequests();
        }

    /// <summary>
    /// Ввод номер заявки для поиска
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
        private void textBoxNumber_TextChanged(object sender, EventArgs e)
        {
            ShowRequests();
        }
        /// <summary>
        /// добавить заявку для роли оператора
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            View.WorkRequest workRequest = new View.WorkRequest(0);
            this.Hide();
            workRequest.ShowDialog();
            this.Show();
        }
        /// <summary>
        /// Редактировать выбранную запись
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editButton_Click(object sender, EventArgs e)
        {
            //проверили что есть выбранная заявка
            if (dataGridViewRequest.SelectedRows.Count > 0)
            {
          

                //номер выбранной заявки
                int id = (int)dataGridViewRequest.CurrentRow.Cells[0].Value;
                MessageBox.Show("Номер " + dataGridViewRequest.CurrentRow.Cells[0].Value);
                //открыли окна и передали в него номер выбранной заявки
                View.WorkRequest workRequest = new View.WorkRequest(id);
                this.Hide();
                workRequest.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("не выбрана заявка для редактирования");
            }
      
        }

        private void ListRequest_Activated(object sender, EventArgs e)
        {
            ShowRequests();
        }
    }
}
