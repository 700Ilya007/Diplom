using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvAc.Forms
{
    public partial class ADDDefectiveInventory : Form
    {
        public readonly checkUser _user;
        DataBase dataBase = new DataBase();
        public ADDDefectiveInventory(checkUser user)
        {
            _user = user;
            InitializeComponent();
        }

        
        private void LeftBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        
        }

        private void ButtonADD_Click(object sender, EventArgs e)
        {
            if (TextBoxNameDefectiveInventory.Text != string.Empty && TextBoxNumberOfDefectiveInventory.Text != string.Empty && TextBoxReasonOfDefective.Text != string.Empty)
            {
                dataBase.openConnection();
            var name = TextBoxNameDefectiveInventory.Text;
            int number;
            var reason = TextBoxReasonOfDefective.Text;
          


            if (int.TryParse(TextBoxNumberOfDefectiveInventory.Text, out number))
               
            {
                var addQuery = $"Insert into DefectiveInventory (NameDefectiveInventory, NumberOfDefectiveInventory, ReasonOfDefective) values ('{name}', '{number}', '{reason}')";

                var command = new SqlCommand(addQuery, dataBase.getConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Не удалось создать новую запись!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            dataBase.closeConnection();
        }
            else
            {
                MessageBox.Show("Одно из полей незаполнено");
            }


}

private void TextBoxNumberOfDefectiveInventory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)

                {
                    e.Handled = true;
                }
            }
        }
    }
}
