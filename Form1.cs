using Microsoft.Reporting.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanhSachCuTru_383XVNT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        QuanLyDanhSach quanly;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = modify.Table("Select * from Customer");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi hiển thị: {ex.Message}");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2_IdStatus.SelectedIndex == 0)
            {
                textBox1_TimKiem.Text = "Hong Nhung";
                textBox2_FullName.Text = "Ha Thi Hong Nhung";
                textBox3_IdCard.Text = "06630201495*";
                textBox4_Address.Text = "Thon Hop Hoa,Cumgar,DakLak";
                textBox3_Fee.Text = "1800";
            }
            if (comboBox2_IdStatus.SelectedIndex == 1)
            {
                textBox1_TimKiem.Text = "Ngoc Linh";
                textBox2_FullName.Text = "Tran Thi Ngoc Linh";
                textBox3_IdCard.Text = "08030401427*";
                textBox4_Address.Text = "ap Loc Tien, My Loc, Can Giuoc, Long An";
                textBox3_Fee.Text = "1700";
            }
            if (comboBox2_IdStatus.SelectedIndex == 2)
            {
                textBox1_TimKiem.Text = "Tram Anh";
                textBox2_FullName.Text = "Vo Thi Tram Anh";
                textBox3_IdCard.Text = "05619701982*";
                textBox4_Address.Text = "15 A Mac Dinh Chi, phuong Phuoc Tien, Tp Nha Trang, Khanh Hoa";
                textBox3_Fee.Text = "2000";
            }
            if (comboBox2_IdStatus.SelectedIndex == 3)
            {
                textBox1_TimKiem.Text = "Xuan Nhi";
                textBox2_FullName.Text = "Nguyen Xuan Nhi";
                textBox3_IdCard.Text = "08619900249*";
                textBox4_Address.Text = "297 Phan Van Nam, Cai Von, TX Binh Minh, Vinh Long";
                textBox3_Fee.Text = "2200";
            }
            if (comboBox2_IdStatus.SelectedIndex == 4)
            {
                textBox1_TimKiem.Text = "An An";
                textBox2_FullName.Text = "Dao Phan An An";
                textBox3_IdCard.Text = "04930300214*";
                textBox4_Address.Text = "Khoi pho 7, p An Xuan ,Tp Tam Ky,Quang Nam";
                textBox3_Fee.Text = "1850";
            }
            if (comboBox2_IdStatus.SelectedIndex == 5)
            {
                textBox1_TimKiem.Text = "Nguyễn Trà Giang";
                textBox2_FullName.Text = "Nguyễn Trà Giang";
                textBox3_IdCard.Text = "04230400404*";
                textBox4_Address.Text = "Thôn Đông Nam Lý,Xã Cẩm Bình,HUyện Cẩm Xuyên,Hà Tĩnh";
                textBox3_Fee.Text = "1900";
            }
            if (comboBox2_IdStatus.SelectedIndex == 6)
            {
                textBox1_TimKiem.Text = "My Thuong";
                textBox2_FullName.Text = "Phan Thi My Thuong";
                textBox3_IdCard.Text = "06619801835*";
                textBox4_Address.Text = "TDP 5, Thi Tran Buon Trap, Huyen Krong Ana, Đak Lak";
                textBox3_Fee.Text = "2100";
            }
            if (comboBox2_IdStatus.SelectedIndex == 7)
            {
                textBox1_TimKiem.Text = "Ky Duyen";
                textBox2_FullName.Text = "Nguyen Xuan Ky Duyen";
                textBox3_IdCard.Text = "07530300080*";
                textBox4_Address.Text = "3314C Nguyen Thai Son, 3,Gò vấp,Thành phố hồ chí minh";
                textBox3_Fee.Text = "1750";
            }
            if (comboBox2_IdStatus.SelectedIndex == 8)
            {
                textBox1_TimKiem.Text = "Nguyễn Quỳnh Nhung";
                textBox2_FullName.Text = "Nguyễn Quỳnh Nhung";
                textBox3_IdCard.Text = "02594807*";
                textBox4_Address.Text = "xxxx";
                textBox3_Fee.Text = "1800";
            }
            if (comboBox2_IdStatus.SelectedIndex == 9)
            {
                textBox1_TimKiem.Text = "Cao Nguyễn Hoàng Yến";
                textBox2_FullName.Text = "Cao Nguyễn Hoàng Yến";
                textBox3_IdCard.Text = "08319700395*";
                textBox4_Address.Text = "Ấp Giồng Bông,Thới Lai,Bình Đại,Bến Tre";
                textBox3_Fee.Text = "2250";
            }
            if (comboBox2_IdStatus.SelectedIndex == 10)
            {
                textBox1_TimKiem.Text = "Nguyễn Ngọc Lan";
                textBox2_FullName.Text = "Nguyễn Ngọc Lan";
                textBox3_IdCard.Text = "02630200336*";
                textBox4_Address.Text = "44A, tổ 16, ấp Phước Lý,xã Phước Lý,huyện Cần Giuộc,tỉnh Long An";
                textBox3_Fee.Text = "2200";
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void DeleteTextBoxes()
        {
            comboBox2_IdStatus.SelectedIndex = -1;
            textBox1_TimKiem.Text = "";
            textBox2_FullName.Text = "";
            textBox3_IdCard.Text = "";
            textBox4_Address.Text = "";
            textBox3_Fee.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox2_IdStatus.SelectedItem = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2_FullName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox3_IdCard.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox4_Address.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox3_Fee.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            textBox5_Phone.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private bool CheckTextBoxes()
        {
            if (comboBox2_IdStatus.SelectedIndex == -1) { MessageBox.Show("Mời bạn chọn số thứ tự!!!"); return false; }
            if (textBox5_Phone.Text == "") { MessageBox.Show("Mời bạn nhập số điện thoại của mình!!!"); return false; }
            return true;
        }

        private void GetValueTextBoxes()
        {
            string _idStatus = comboBox2_IdStatus.Text;
            string _idCard = textBox3_IdCard.Text;
            string _fullName = textBox2_FullName.Text;
            string _sex = comboBox1_Sex.Text;
            long _phone = long.Parse(textBox5_Phone.Text);
            string _address = textBox4_Address.Text;
            DateTime _dateofBirth = dateTimePicker1.Value;
            int _fee = int.Parse(textBox3_Fee.Text);
            int _month = int.Parse(textBox2_month.Text);
            quanly = new QuanLyDanhSach(_idStatus, _idCard, _fullName, _sex, _phone, _address, _dateofBirth, _fee, _month);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                GetValueTextBoxes();
                string query = "INSERT INTO Customer VALUES ('" + quanly.IdStatus + "', '" + quanly.IdCard + "', '" + quanly.FullName + "', '" + quanly.Sex + "', '" + quanly.Phone + "', '" + quanly.Address + "', '" + quanly.DateofBirth.ToString("yyyy'/'MM'/'dd") + "' ,'" + quanly.Fee + "', '" + quanly.Month + "' , '" + quanly.Total() + "')";
                try
                {
                    if (MessageBox.Show("Ban co thuc su muon them ?", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        modify.Command(query);
                        MessageBox.Show("Them thanh cong");
                        Form1_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                    throw;
                }
            }
        }

        private void button5_Xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                string choose = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                string query = "DELETE Customer ";
                query += "WHERE IdStatus='" + choose + "'";

                try
                {
                    if (MessageBox.Show("Ban thuc su muon xoa khong?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        modify.Command(query);
                        MessageBox.Show("Xóa dữ liệu thành công");
                        Form1_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Kiểm tra lại dữ liệu: {ex}");
                    throw;
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                GetValueTextBoxes();
                string query = "UPDATE Customer SET IdCard = N'" + quanly.IdCard + "',FullName= N'" + quanly.FullName + "' ,Sex= N'" + quanly.Sex + "',Phone=" + quanly.Phone + ",Address= N'" + quanly.Address + "',DateOfBirth=" + quanly.DateofBirth.ToString("yyyy'/'MM'/'dd") + ",Fee=" + quanly.Fee + ",Month=" + quanly.Month + ",Total=" + quanly.Total() + " ";
                query += " WHERE IdStatus='" + quanly.IdStatus + "'";
                try
                {
                    if (MessageBox.Show("Ban co thuc su muon sua ?", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        modify.Command(query);
                        MessageBox.Show("Sửa thanh cong");
                        Form1_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                    throw;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            if (name == "")
            {
                Form1_Load(sender, e);
            }
            else
            {
                string query = "Select * from Customer Where IdStatus like '%" + name + "%'";
                dataGridView1.DataSource = modify.Table(query);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormReport formReport = new FormReport();
            formReport.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            LocalReport localReport = new LocalReport();
            localReport.ReportPath = Application.StartupPath + "\\Report2.rdlc";
            localReport.PrintToPrinter();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}

