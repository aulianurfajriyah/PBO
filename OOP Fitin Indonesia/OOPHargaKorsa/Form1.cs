using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOPHargaKorsa.myclass;
using MySql.Data.MySqlClient;

namespace OOPHargaKorsa
{
    public partial class Form1 : Form
    {
        Production production = new Production();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {      
           KorsaLibrary.Korsa OrderKorsa = new KorsaLibrary.Korsa();
           double harga = OrderKorsa.EstimatePrice(Convert.ToInt32(txtJumlahItem.Text),Convert.ToInt32(cmbTitikBordir.Text),cmbBahan.Text);
           lblHarga.Text = harga.ToString();           
        }

        
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Create
            CREATE();
            READ();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Update
            UPDATE();
            READ();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Delete
            DELETE();
            READ();
        }

        //Read
        public void READ()
        {
            dataGridView1.DataSource = null;
            production.Read_data();
            dataGridView1.DataSource = production.dt;
        }
        //Create
        public void CREATE()
        {
            production.Name = txtName.Text;
            production.Company = txtCompany.Text;
            production.Contact = txtContact.Text;
            production.Create_data();
        }
        //Update 
        public void UPDATE()
        {
            production.Name = e_txtName.Text;
            production.Company = e_txtCompany.Text;
            production.Contact = e_txtContact.Text;
            production.ID = txtID.Text;
            production.Update_data();
        }
        //Delete
        public void DELETE()
        {
            production.ID = txtID.Text;
            production.Delete_data();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Get Data
            DataGridView senderGrid = (DataGridView)sender;
            try
            {
                if(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    txtID.Text = (dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    e_txtName.Text = (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                    e_txtCompany.Text = (dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    e_txtContact.Text = (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                }
            }
            catch
            {
                MessageBox.Show("You just click the header. Don't Do That!");
            }
        }

        private void btnGenerateQR_Click(object sender, EventArgs e)
        {
            QRCoder.QRCodeGenerator QG = new QRCoder.QRCodeGenerator();
            var Data = QG.CreateQrCode(e_txtName.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(Data);
            picQR.Image = code.GetGraphic(50);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument pDoc = new PrintDocument();
            pDoc.PrintPage += PrintPicture;
            pd.Document = pDoc;
            if (pd.ShowDialog() == DialogResult.OK)
            {
                pDoc.Print();
            }
        }

        private void PrintPicture(object sender, PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(picQR.Width, picQR.Height);
            picQR.DrawToBitmap(bmp, new Rectangle(0, 0, picQR.Width, picQR.Height));
            e.Graphics.DrawImage(bmp, 0, 0);
            bmp.Dispose();
        }
    }
}
