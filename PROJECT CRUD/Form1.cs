using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace PROJECT_CRUD
{
    public partial class Form1 : Form
    {
        private string id = "";
        private int intRow = 0;

        public Form1()
        {
            InitializeComponent();
            resetMe();
        }

        private void resetMe()
        {
            this.id = string.Empty;

            idbarang.Text = "";
            namabarang.Text = "";
            harga.Text = "";
            stock.Text = "";

            if (satuan.Items.Count > 0)
            {
                satuan.SelectedIndex = 0;
            }

            UPDATE.Text = "Update () ";
            DELETE.Text = "Delete () ";

            keyword.Clear();

            if (keyword.CanSelect)
            {

                keyword.Select();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadData("");
        }

        private void loadData(string keyword)
        {
            KoneksiCRUD.sql = "SELECT idbarang, namabarang, harga, stock, satuanbarang FROM public.warung " +
                               " ORDER BY idbarang ASC ";

            string strKeyword = string.Format("%{0}%", keyword);

            KoneksiCRUD.cmd = new NpgsqlCommand(KoneksiCRUD.sql, KoneksiCRUD.con);
            KoneksiCRUD.cmd.Parameters.Clear();
            KoneksiCRUD.cmd.Parameters.AddWithValue("keyword", strKeyword);

            DataTable dt = KoneksiCRUD.PerformCRUD(KoneksiCRUD.cmd);

            if (dt.Rows.Count > 0) 
            {
            
                intRow = Convert.ToInt32(dt.Rows.Count.ToString());

            }

            else
            {
                intRow = 0;
            }

            DataGridView dgv1 = dataGridView1;
            dgv1.MultiSelect = false;
            dgv1.AutoGenerateColumns = true;
            dgv1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv1.DataSource = dt;

            dgv1.Columns[0].HeaderText = "idbarang";
            dgv1.Columns[1].HeaderText = "namabarang";
            dgv1.Columns[2].HeaderText = "harga";
            dgv1.Columns[3].HeaderText = "stock";
            dgv1.Columns[4].HeaderText = "satuanbarang";

            dgv1.Columns[0].Width = 85;
            dgv1.Columns[1].Width = 170;
            dgv1.Columns[2].Width = 120;
            dgv1.Columns[3].Width = 120;
            dgv1.Columns[4].Width = 150;


        }

        private void execute(string mySQL, string param)
        {
            KoneksiCRUD.cmd = new NpgsqlCommand(mySQL, KoneksiCRUD.con);
            addParameters(param);
            KoneksiCRUD.PerformCRUD(KoneksiCRUD.cmd);
        }


        private void addParameters(string str)
        {
            KoneksiCRUD.cmd.Parameters.Clear();
            KoneksiCRUD.cmd.Parameters.AddWithValue("idbarang", idbarang.Text.Trim());
            KoneksiCRUD.cmd.Parameters.AddWithValue("namabarang", namabarang.Text.Trim());
            KoneksiCRUD.cmd.Parameters.AddWithValue("harga", harga.Text.Trim());
            KoneksiCRUD.cmd.Parameters.AddWithValue("stock", stock.Text.Trim());
            KoneksiCRUD.cmd.Parameters.AddWithValue("satuanbarang", satuan.SelectedItem.ToString());

            if (str == "Update" || str == "Delete" && string.IsNullOrEmpty(this.id))
            {

                KoneksiCRUD.cmd.Parameters.AddWithValue("id", this.id);

            }
        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idbarang.Text.Trim()) || string.IsNullOrEmpty(namabarang.Text.Trim()))
            {
                MessageBox.Show("Please Input Data.", "Please Input Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            KoneksiCRUD.sql = "INSERT INTO warung(idbarang, namabarang, harga, stock, satuanbarang) VALUES (@idbarang, @namabarang, @harga, @stock, @satuanbarang)";

            execute(KoneksiCRUD.sql, "SAVE");
            MessageBox.Show("The Record has been saved.", "Insert Data : ",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            loadData("");

            resetMe();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0)
            {

                DataGridView dgv1 = dataGridView1;
                this.id = Convert.ToString(dgv1.CurrentRow.Cells[0].Value);
                UPDATE.Text = "Update (" + this.id + ")";
                DELETE.Text = "Delete (" + this.id + ")";

                idbarang.Text = Convert.ToString(dgv1.CurrentRow.Cells[1].Value);
                namabarang.Text = Convert.ToString(dgv1.CurrentRow.Cells[2].Value);
                harga.Text = Convert.ToString(dgv1.CurrentRow.Cells[3].Value);
                stock.Text = Convert.ToString(dgv1.CurrentRow.Cells[4].Value);
                satuan.SelectedItem = Convert.ToString(dgv1.CurrentRow.Cells[5].Value);

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex == 0) 
            {

                DataGridView dgv1 = dataGridView1;
                this.id = Convert.ToString(dgv1.CurrentRow.Cells[0].Value);
                UPDATE.Text = "Update (" + this.id + ")";
                DELETE.Text = "Delete (" + this.id + ")";
                
                idbarang.Text = Convert.ToString(dgv1.CurrentRow.Cells[1].Value);
                namabarang.Text = Convert.ToString(dgv1.CurrentRow.Cells[2].Value);
                harga.Text = Convert.ToString(dgv1.CurrentRow.Cells[3].Value);
                stock.Text = Convert.ToString(dgv1.CurrentRow.Cells[4].Value);
                satuan.SelectedItem = Convert.ToString(dgv1.CurrentRow.Cells[5].Value);

            }

        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            { return; }

            if (string.IsNullOrEmpty(this.id))
            {
                MessageBox.Show("Please Select am item from the list.", "Please Update Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrEmpty(idbarang.Text.Trim()) || string.IsNullOrEmpty(namabarang.Text.Trim()))
            {
                MessageBox.Show("Please Input Id Barang and Name .", "Please Input Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            KoneksiCRUD.sql = "UPDATE public.warung SET namabarang = @namabarang, harga = @harga, stock = @stock, satuanbarang = @satuanbarang ,idbarang = @idbarang ::character varying";

            execute(KoneksiCRUD.sql, "UPDATE");
            MessageBox.Show("The Record has been updated.", "Update Data : ",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            loadData("");

            resetMe();
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            { return; }

            if (string.IsNullOrEmpty(this.id))
            {
                MessageBox.Show("Please Select am item from the list.", "Please Delete Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("Do you want delete data permanently?", "Delete Data : ",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)

            {
                KoneksiCRUD.sql = "DELETE FROM public.warung WHERE idbarang = @id :: character varying";

                execute(KoneksiCRUD.sql, "Update");

                MessageBox.Show("The record has been deleted.", "Delete Data : ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                loadData("");

                resetMe();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(keyword.Text.Trim())) 
            {
                loadData("");

            }

            else
            {
                loadData(keyword.Text.Trim());
                resetMe();
            }
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
} 
