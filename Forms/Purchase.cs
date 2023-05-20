using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace InvAc.Forms
{
    public partial class Purchase : Form
    {
        public readonly checkUser _user;
        public Purchase(checkUser user)

         
        {
          
            _user = user;
            InitializeComponent();

            TextBoxSumm1.Text = "0";
            TextBoxSumm2.Text = "0";
            TextBoxSumm3.Text = "0";
            TextBoxSumm4.Text = "0";
            TextBoxSumm5.Text = "0";
            TextBoxSumm6.Text = "0";
            TextBoxSumm7.Text = "0";
            TextBoxSumm8.Text = "0";
            TextBoxSumm9.Text = "0";
            TextBoxSumm10.Text = "0";

            TextBoxSumm1.TextChanged += TextBoxItog_TextChanged;
            TextBoxSumm2.TextChanged += TextBoxItog_TextChanged;
            TextBoxSumm3.TextChanged += TextBoxItog_TextChanged;
            TextBoxSumm4.TextChanged += TextBoxItog_TextChanged;
            TextBoxSumm5.TextChanged += TextBoxItog_TextChanged;
            TextBoxSumm6.TextChanged += TextBoxItog_TextChanged;
            TextBoxSumm7.TextChanged += TextBoxItog_TextChanged;
            TextBoxSumm8.TextChanged += TextBoxItog_TextChanged;
            TextBoxSumm9.TextChanged += TextBoxItog_TextChanged;
            TextBoxSumm10.TextChanged += TextBoxItog_TextChanged;

        }

        int a = 0;
        int b = 0;
        int c = 0;
        private void Purchase_Load(object sender, EventArgs e)
        {
          
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vedenie_UchetaDataSet1.Provider". При необходимости она может быть перемещена или удалена.
            this.providerTableAdapter.Fill(this.vedenie_UchetaDataSet1.Provider);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vedenie_UchetaDataSet1.Purchase". При необходимости она может быть перемещена или удалена.
            this.purchaseTableAdapter.Fill(this.vedenie_UchetaDataSet1.Purchase);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vedenie_UchetaDataSet1.Inventory". При необходимости она может быть перемещена или удалена.
            this.inventoryTableAdapter.Fill(this.vedenie_UchetaDataSet1.Inventory);

        }


        private void PictureExit_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите выйти?", "Предупреждение", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }

            else if (dialogResult == DialogResult.No)
            {

                return;
            }

        }

        private void LeftBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainmenu = new MainMenu(_user);
            mainmenu.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                if (TextBoxOrganization.Text != string.Empty && TextBoxNomer.Text != string.Empty && TextBoxPrice1.Text != string.Empty)
         
            {
               
                var helper = new WordHelper("Шаблон накладной.docx");

                var items = new Dictionary<string, string>
            {
                { "<NOMER>", TextBoxNomer.Text},
                { "<NAME1>", TextBoxNameInventory1.Text },
                { "<NAME2>", TextBoxNameInventory2.Text },
                { "<NAME3>", TextBoxNameInventory3.Text },
                { "<NAME4>", TextBoxNameInventory4.Text },
                { "<NAME5>", TextBoxNameInventory5.Text },
                { "<NAME6>", TextBoxNameInventory6.Text },
                { "<NAME7>", TextBoxNameInventory7.Text },
                { "<NAME8>", TextBoxNameInventory8.Text },
                { "<NAME9>", TextBoxNameInventory9.Text },
                { "<NAME10>", TextBoxNameInventory10.Text },
                { "<KOLVO1>", TextBoxKolvo1.Text },
                { "<KOLVO2>", TextBoxKolvo2.Text },
                { "<KOLVO3>", TextBoxKolvo3.Text },
                { "<KOLVO4>", TextBoxKolvo4.Text },
                { "<KOLVO5>", TextBoxKolvo5.Text },
                { "<KOLVO6>", TextBoxKolvo6.Text },
                { "<KOLVO7>", TextBoxKolvo7.Text },
                { "<KOLVO8>", TextBoxKolvo8.Text },
                { "<KOLVO9>", TextBoxKolvo9.Text },
                { "<KOLVO10>", TextBoxKolvo10.Text },
                { "<PRICE1>", TextBoxPrice1.Text },
                { "<PRICE2>", TextBoxPrice2.Text },
                { "<PRICE3>", TextBoxPrice3.Text },
                { "<PRICE4>", TextBoxPrice4.Text },
                { "<PRICE5>", TextBoxPrice5.Text },
                { "<PRICE6>", TextBoxPrice6.Text },
                { "<PRICE7>", TextBoxPrice7.Text },
                { "<PRICE8>", TextBoxPrice8.Text },
                { "<PRICE9>", TextBoxPrice9.Text },
                { "<PRICE10>", TextBoxPrice10.Text },
                { "<SUMM1>", TextBoxSumm1.Text },
                { "<SUMM2>", TextBoxSumm2.Text },
                { "<SUMM3>", TextBoxSumm3.Text },
                { "<SUMM4>", TextBoxSumm4.Text },
                { "<SUMM5>", TextBoxSumm5.Text },
                { "<SUMM6>", TextBoxSumm6.Text },
                { "<SUMM7>", TextBoxSumm7.Text },
                { "<SUMM8>", TextBoxSumm8.Text },
                { "<SUMM9>", TextBoxSumm9.Text },
                { "<SUMM10>", TextBoxSumm10.Text },
                { "<PROVIDER>", ComboBoxProvider.Text },
                { "<ORGANIZATION>", TextBoxOrganization.Text},
                { "<DATE>", DateTimePicker.Value.ToString("dd.MM.yyyy") },
                { "<ITOG>", TextBoxItog.Text },
            };
                helper.Process(items);

   
                MessageBox.Show("Накладная на поставку инвентаря успешно создана");
            }
            else
            {
                MessageBox.Show("Одно из полей незаполнено");
            }

            
        }

        private void ButtonNew2_Click(object sender, EventArgs e)
        {
            if (TextBoxNameInventory1.Text != string.Empty && TextBoxKolvo1.Text != string.Empty && TextBoxPrice1.Text != string.Empty)
            {
                TextBoxNameInventory1.Visible = false;
                TextBoxNameInventory2.Visible = true;
                TextBoxKolvo1.Visible = false;
                TextBoxKolvo2.Visible = true;
                TextBoxPrice1.Visible = false;
                TextBoxPrice2.Visible = true;
                ButtonNew2.Visible = false;
                ButtonNew3.Visible = true;
                a = Convert.ToInt32(TextBoxKolvo1.Text);
                b = Convert.ToInt32(TextBoxPrice1.Text);
                c = a * b;
                TextBoxSumm1.Text = c.ToString();
           
            }
            else
            {
                MessageBox.Show("Одно из полей незаполнено");
            }
        }
        private void ButtonNew3_Click(object sender, EventArgs e)
        {
            if (TextBoxNameInventory2.Text != string.Empty && TextBoxKolvo2.Text != string.Empty && TextBoxPrice2.Text != string.Empty)
            {
            TextBoxNameInventory2.Visible = false;
            TextBoxNameInventory3.Visible = true;
            TextBoxPrice2.Visible = false;
            TextBoxPrice3.Visible = true;
            TextBoxKolvo2.Visible = false;
            TextBoxKolvo3.Visible = true;
            ButtonNew3.Visible = false;
            ButtonNew4.Visible = true;
            a = Convert.ToInt32(TextBoxKolvo2.Text);
            b = Convert.ToInt32(TextBoxPrice2.Text);
            c = a * b;
            TextBoxSumm2.Text = c.ToString();
            }
            else
            {
                MessageBox.Show("Одно из полей незаполнено");
            }
        }



        private void ButtonNew4_Click(object sender, EventArgs e)
        {
            if (TextBoxNameInventory3.Text != string.Empty && TextBoxKolvo3.Text != string.Empty && TextBoxPrice3.Text != string.Empty)
            {
            TextBoxNameInventory3.Visible = false;
            TextBoxNameInventory4.Visible = true;
            TextBoxPrice3.Visible = false;
            TextBoxPrice4.Visible = true;
            TextBoxKolvo3.Visible = false;
            TextBoxKolvo4.Visible = true;
            ButtonNew4.Visible = false;
            ButtonNew5.Visible = true;
            a = Convert.ToInt32(TextBoxKolvo3.Text);
            b = Convert.ToInt32(TextBoxPrice3.Text);
            c = a * b;
            TextBoxSumm3.Text = c.ToString();
            }
            else
            {
                MessageBox.Show("Одно из полей незаполнено");
            }
        }

        private void ButtonNew5_Click(object sender, EventArgs e)
        {
            if (TextBoxNameInventory4.Text != string.Empty && TextBoxKolvo4.Text != string.Empty && TextBoxPrice4.Text != string.Empty)
            {
            TextBoxNameInventory4.Visible = false;
            TextBoxNameInventory5.Visible = true;
            TextBoxPrice4.Visible = false;
            TextBoxPrice5.Visible = true;
            TextBoxKolvo4.Visible = false;
            TextBoxKolvo5.Visible = true;
            ButtonNew5.Visible = false;
            ButtonNew6.Visible = true;
            a = Convert.ToInt32(TextBoxKolvo4.Text);
            b = Convert.ToInt32(TextBoxPrice4.Text);
            c = a * b;
            TextBoxSumm4.Text = c.ToString();
            }
            else
            {
                MessageBox.Show("Одно из полей незаполнено");
            }
        }

        private void ButtonNew6_Click(object sender, EventArgs e)
        {
            if (TextBoxNameInventory5.Text != string.Empty && TextBoxKolvo5.Text != string.Empty && TextBoxPrice5.Text != string.Empty)
            {
            TextBoxNameInventory5.Visible = false;
            TextBoxNameInventory6.Visible = true;
            TextBoxPrice5.Visible = false;
            TextBoxPrice6.Visible = true;
            TextBoxKolvo5.Visible = false;
            TextBoxKolvo6.Visible = true;
            ButtonNew6.Visible = false;
            ButtonNew7.Visible = true;
            a = Convert.ToInt32(TextBoxKolvo5.Text);
            b = Convert.ToInt32(TextBoxPrice5.Text);
            c = a * b;
            TextBoxSumm5.Text = c.ToString();
            }
            else
            {
                MessageBox.Show("Одно из полей незаполнено");
            }
        }

        private void ButtonNew7_Click(object sender, EventArgs e)
        {
            if (TextBoxNameInventory6.Text != string.Empty && TextBoxKolvo6.Text != string.Empty && TextBoxPrice6.Text != string.Empty)
            {
            TextBoxNameInventory6.Visible = false;
            TextBoxNameInventory7.Visible = true;
            TextBoxPrice6.Visible = false;
            TextBoxPrice7.Visible = true;
            TextBoxKolvo6.Visible = false;
            TextBoxKolvo7.Visible = true;
            ButtonNew7.Visible = false;
            ButtonNew8.Visible = true;
            a = Convert.ToInt32(TextBoxKolvo6.Text);
            b = Convert.ToInt32(TextBoxPrice6.Text);
            c = a * b;
            TextBoxSumm6.Text = c.ToString();
            }
            else
            {
                MessageBox.Show("Одно из полей незаполнено");
            }
        }

        private void ButtonNew8_Click(object sender, EventArgs e)
        {
            if (TextBoxNameInventory7.Text != string.Empty && TextBoxKolvo7.Text != string.Empty && TextBoxPrice7.Text != string.Empty)
            {
            TextBoxNameInventory7.Visible = false;
            TextBoxNameInventory8.Visible = true;
            TextBoxPrice7.Visible = false;
            TextBoxPrice8.Visible = true;
            TextBoxKolvo7.Visible = false;
            TextBoxKolvo8.Visible = true;
            ButtonNew8.Visible = false;
            ButtonNew9.Visible = true;
            a = Convert.ToInt32(TextBoxKolvo7.Text);
            b = Convert.ToInt32(TextBoxPrice7.Text);
            c = a * b;
            TextBoxSumm7.Text = c.ToString();
            }
            else
            {
                MessageBox.Show("Одно из полей незаполнено");
            }
        }

        private void ButtonNew9_Click(object sender, EventArgs e)
        {
            if (TextBoxNameInventory8.Text != string.Empty && TextBoxKolvo8.Text != string.Empty && TextBoxPrice8.Text != string.Empty)
            {
            TextBoxNameInventory8.Visible = false;
            TextBoxNameInventory9.Visible = true;
            TextBoxPrice8.Visible = false;
            TextBoxPrice9.Visible = true;
            TextBoxKolvo8.Visible = false;
            TextBoxKolvo9.Visible = true;
            ButtonNew9.Visible = false;
            ButtonNew10.Visible = true;
            a = Convert.ToInt32(TextBoxKolvo8.Text);
            b = Convert.ToInt32(TextBoxPrice8.Text);
            c = a * b;
            TextBoxSumm8.Text = c.ToString();
            }
            else
            {
                MessageBox.Show("Одно из полей незаполнено");
            }
        }

        private void ButtonNew10_Click(object sender, EventArgs e)
        {
            if (TextBoxNameInventory9.Text != string.Empty && TextBoxKolvo9.Text != string.Empty && TextBoxPrice9.Text != string.Empty)
            {
            TextBoxNameInventory9.Visible = false;
            TextBoxNameInventory10.Visible = true;
            TextBoxPrice9.Visible = false;
            TextBoxPrice10.Visible = true;
            TextBoxKolvo9.Visible = false;
            TextBoxKolvo10.Visible = true;
            ButtonNew10.Visible = false;
            a = Convert.ToInt32(TextBoxKolvo9.Text);
            b = Convert.ToInt32(TextBoxPrice9.Text);
            c = a * b;
            TextBoxSumm9.Text = c.ToString();
            }
            else
            {
                MessageBox.Show("Одно из полей незаполнено");
            }
        }

        private void TextBoxKolvo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)

                {
                    e.Handled = true;
                }
            }
        }

        private void TextBoxKolvo2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)

                {
                    e.Handled = true;
                }
            }
        }

        private void TextBoxKolvo3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)

                {
                    e.Handled = true;
                }
            }
        }

        private void TextBoxKolvo4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)

                {
                    e.Handled = true;
                }
            }
        }

        private void TextBoxKolvo5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)

                {
                    e.Handled = true;
                }
            }
        }

        private void TextBoxKolvo6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)

                {
                    e.Handled = true;
                }
            }
        }

        private void TextBoxKolvo7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)

                {
                    e.Handled = true;
                }
            }
        }

        private void TextBoxKolvo8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)

                {
                    e.Handled = true;
                }
            }
        }

        private void TextBoxKolvo9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)

                {
                    e.Handled = true;
                }
            }
        }

        private void TextBoxKolvo10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)

                {
                    e.Handled = true;
                }
            }
        }

        private void TextBoxPrice1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)

                {
                    e.Handled = true;
                }
            }
        }

        private void TextBoxPrice2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)

                {
                    e.Handled = true;
                }
            }
        }

        private void TextBoxPrice3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)

                {
                    e.Handled = true;
                }
            }
        }

        private void TextBoxPrice4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)

                {
                    e.Handled = true;
                }
            }
        }

        private void TextBoxPrice5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)

                {
                    e.Handled = true;
                }
            }
        }

        private void TextBoxPrice6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)

                {
                    e.Handled = true;
                }
            }
        }

        private void TextBoxPrice7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)

                {
                    e.Handled = true;
                }
            }
        }

        private void TextBoxPrice8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)

                {
                    e.Handled = true;
                }
            }
        }

        private void TextBoxPrice9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)

                {
                    e.Handled = true;
                }
            }
        }

        private void TextBoxPrice10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)

                {
                    e.Handled = true;
                }
            }
        }

 
        private void TextBoxItog_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TextBoxItog.Text = (Double.Parse(TextBoxSumm1.Text) + Double.Parse(TextBoxSumm2.Text) + Double.Parse(TextBoxSumm3.Text) + Double.Parse(TextBoxSumm4.Text) + Double.Parse(TextBoxSumm5.Text) + Double.Parse(TextBoxSumm6.Text) + Double.Parse(TextBoxSumm7.Text) + Double.Parse(TextBoxSumm8.Text) + Double.Parse(TextBoxSumm9.Text) + Double.Parse(TextBoxSumm10.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TextBoxNomer_KeyPress(object sender, KeyPressEventArgs e)
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

