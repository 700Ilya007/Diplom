    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.Data.SqlClient;

    namespace InvAc.Forms
    {
        public partial class ADDInventory : Form
        {
            public readonly checkUser _user;
            DataBase dataBase = new DataBase();
            public ADDInventory(checkUser user)
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
            if (TextBoxNameInventory.Text != string.Empty && TextBoxNumberOfInventory.Text != string.Empty && TextBoxPrice.Text != string.Empty)
            {

                dataBase.openConnection();

                var name = TextBoxNameInventory.Text;
                int number;
                decimal price;



                if (int.TryParse(TextBoxNumberOfInventory.Text, out number))
                if(decimal.TryParse(TextBoxPrice.Text, out price))
                    {

                        var addQuery = $"Insert into Inventory (NameInventory, NumberOfInventory, Price) values ('{name}', '{number}', '{price}')";

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

        private void TextBoxNumberOfInventory_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (!(char.IsDigit(e.KeyChar)))
                {
                    if (e.KeyChar != (char)Keys.Back)

                    {
                        e.Handled = true;
                    }
                }
            }

            private void TextBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
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
