using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using QuanLyBanHang.models;
using QuanLyBanHang.database;
namespace QuanLyBanHang
{
    public partial class frmProduct : Form
    {
        public frmProduct(string text)
        {
            InitializeComponent();
        }
        private List<UserData> account = new List<UserData>();
        public frmProduct(List<UserData> listUser)
        {
            InitializeComponent();
             this.account= listUser; 
        }
        public frmProduct() { }
        readonly fileFactory<CProduct> fPro = new fileFactory<CProduct>();
        readonly productImp pip = new productImp();
        CProduct currentProduct = new CProduct();
        private List<CProduct> dshh = new List<CProduct>();
        private List<CProduct> ds_search = new List<CProduct>();

        private void hienthi()
        {
            //BindingSource bs = new BindingSource();
            //bs.DataSource = dshh;
            //dgvDshh.DataSource = bs;
            //dgvDshh.AutoGenerateColumns = true;
            dgvDshh.DataSource = dshh.ToList();

        }

        private void show_dsseach()
        {
            BindingSource bs_search = new BindingSource();
            bs_search.DataSource = ds_search;
            dgvDshh.DataSource = bs_search;
            dgvDshh.AutoGenerateColumns = true;
        }

        private bool click_save = false;

        private void lbAnh_Click(object sender, EventArgs e)
        {

        }

        private void Nhap_DL()
        {
            string ma = txtMa.Text;
            string ten = txtTen.Text;
            string loai = cmbLoai.Text;
            string soluongnhap = txtSLnhap.Text;
            string soluongxuat = txtSLxuat.Text;
            string gianhap = txtGianhap.Text;
            string giaxuat = txtGiaxuat.Text;
            string ghichu = txtGhichu.Text;

            if (ma == "" || ten == "" || soluongnhap == "" || soluongxuat == "" || loai == "" || gianhap == "" || giaxuat == "")
            {
                MessageBox.Show("Khong hop le", "Thong bao loi!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMa.Text = "";
                txtTen.Text = "";
                cmbLoai.Text = null;
                txtSLnhap.Text = "";
                txtSLxuat.Text = "";
                txtGianhap.Text = "";
                txtGiaxuat.Text = "";
                txtGhichu.Text = "";
                return;
            }

            int GiaNhap = int.Parse(giaxuat);
            int GiaXuat = int.Parse(giaxuat);
            if (GiaNhap < GiaXuat)
            {
                MessageBox.Show("Gia Xuat Khong Hop Le", "Thong bao loi!!", MessageBoxButtons.OK);
                return;
            }
            int Soluongnhap = int.Parse(soluongnhap);
            int Soluongxuat = int.Parse(soluongxuat);
            if(Soluongnhap<Soluongxuat)
            {
                MessageBox.Show("So luong xuat khong hop le ", @"Notice", MessageBoxButtons.OK);
                return;
            }

        }

        private bool Kiem_tra_DL_Nhap()
        {
            string kt_ma = "";


            for (int i = 0; i < dshh.Count; i++)
            {
                if (kt_ma == dshh[i].Ma)
                {
                    MessageBox.Show("Da Co Du Lieu", "Thong bao", MessageBoxButtons.OK);
                    return false;
                }
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            //Nhap_DL();

            //if (!Kiem_tra_DL_Nhap())
            //    return;


            //CProduct bs = new CProduct(txtMa.Text, txtTen.Text, cmbLoai.Text, txtSLnhap.Text, txtSLxuat.Text, txtGianhap.Text, txtGiaxuat.Text, txtGhichu.Text);

            //dshh.Add(bs);
            //hienthi();


            //txtMa.Text = "";
            //txtTen.Text = "";
            //cmbLoai.SelectedIndex = -1;
            //txtSLnhap.Text = "";
            //txtSLxuat.Text = "";
            //txtGianhap.Text = "";
            //txtGiaxuat.Text = "";
            //txtGhichu.Text = "";
            if (!Kiem_tra_DL_Nhap()) return;
            Nhap_DL();
            CProduct cPro = new CProduct();
            cPro.Ma = txtMa.Text;
            cPro.Ten = txtTen.Text;
            cPro.Loai = cmbLoai.Text;
            cPro.Soluongnhap = txtSLnhap.Text;
            cPro.Soluongxuat = txtSLxuat.Text;
            cPro.Gianhap = txtGianhap.Text;
            cPro.Giaxuat = txtGiaxuat.Text;
            cPro.Ghichu = txtGhichu.Text;
            
            pip.btnThem(cPro);
            dgvDshh.DataSource = pip.getALL().ToList();
            clearInput();
            dgvDshh.ClearSelection();
          


        }
        void clearInput()
        {
            txtMa.Clear();
            txtTen.Clear();
            cmbLoai.Text = null;
            txtSLnhap.Clear();
            txtSLxuat.Clear();
            txtGianhap.Clear();
            txtSLxuat.Clear();
            txtGianhap.Clear();
            txtGiaxuat.Clear();
            txtGhichu.Clear();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //if (dgvDshh.SelectedRows.Count > 0)
            //{
            //    DataGridViewRow selectedRow = dgvDshh.SelectedRows[0];

            //    // Lấy đối tượng CProduct từ hàng được chọn
            //    CProduct productToDelete = selectedRow.DataBoundItem as CProduct;

            //    if (productToDelete != null)
            //    {
            //        // Xóa đối tượng CProduct khỏi danh sách dshh
            //        dshh.Remove(productToDelete);

            //        // Cập nhật DataGridView để hiển thị thay đổi
            //        dgvDshh.DataSource = null;
            //        dgvDshh.DataSource = dshh;  
            //    }
            //}
            //else
            //{
            //    MessageBox.Show(@"Choose a product", @"Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            if (dgvDshh.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvDshh.SelectedRows[0];

                // Lấy chỉ số của hàng được chọn
                int rowIndex = selectedRow.Index;

                // Xóa đối tượng CProduct khỏi danh sách dshh dựa trên chỉ số hàng
                dshh.RemoveAt(rowIndex);

                // Cập nhật DataGridView để hiển thị thay đổi
                dgvDshh.DataSource = null;
                dgvDshh.DataSource = dshh;
            }
            else
            {
                MessageBox.Show(@"Choose a product", @"Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

       

        private void btnSua_Click(object sender, EventArgs e)
        {
            
            foreach(DataGridViewCell cell in dgvDshh.SelectedCells)
            {
                int rowIndex = cell.RowIndex;
                int colIndex = cell.ColumnIndex;
           
                string oldValue = dgvDshh.Rows[rowIndex].Cells[colIndex].Value.ToString();
                dgvDshh.Rows[rowIndex].Cells[0].Value = txtMa.Text;
                dgvDshh.Rows[rowIndex].Cells[1].Value = txtTen.Text ;
                dgvDshh.Rows[rowIndex].Cells[2].Value = cmbLoai.Text;
                dgvDshh.Rows[rowIndex].Cells[3].Value = txtSLnhap.Text ;
                dgvDshh.Rows[rowIndex].Cells[4].Value = txtSLxuat.Text;
                dgvDshh.Rows[rowIndex].Cells[5].Value = txtGianhap.Text;
                dgvDshh.Rows[rowIndex].Cells[6].Value = txtGiaxuat.Text ;
                dgvDshh.Rows[rowIndex].Cells[7].Value = txtGhichu.Text;
            }
          
        }
        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            //// Kiểm tra xem ký tự đã nhập có phải là số hoặc phím điều hướng (arrow keys, backspace, delete, etc.)
            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = true; // Không cho phép ký tự này được nhập vào TextBox.
            //}
            keyPressEvent(sender, e);
        }


        void keyPressEvent(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Không cho phép ký tự này được nhập vào TextBox.
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sr_ma = txtSearch.Text;
            string sr_ten = "";
            string sr_loai = "";
            string sr_Soluongnhap = "";
            string sr_Soluongxuat = "";
            string sr_giaNhap = "";
            string sr_giaXuat = "";
            string sr_ghiChu = "";

            ds_search.Clear();

            int dem = 0;
            for (int i = 0; i < dshh.Count; i++)
            {
                if (sr_ma == dshh[i].Ma)
                {
                    sr_ten = dshh[i].Ten;
                    sr_loai = dshh[i].Loai;
                    sr_Soluongnhap = dshh[i].Soluongnhap;
                    sr_Soluongxuat = dshh[i].Soluongxuat;
                    sr_giaNhap = dshh[i].Gianhap;
                    sr_giaXuat = dshh[i].Giaxuat;
                    sr_ghiChu = dshh[i].Ghichu;

                    CProduct bs_search = new CProduct(sr_ma, sr_ten, sr_loai, sr_Soluongnhap, sr_Soluongxuat, sr_giaNhap, sr_giaXuat, sr_ghiChu);
                    ds_search.Add(bs_search);
                }
                else
                {
                    dem++;
                }
            }

            if (dem == dshh.Count)
            {
                MessageBox.Show("Khong co du lieu", "Thong bao", MessageBoxButtons.OK);
                return;
            }

            dgvDshh.AutoGenerateColumns = false;
            show_dsseach();
        }

        private void btnHienthi_Click(object sender, EventArgs e)
        {
            dgvDshh.AutoGenerateColumns = false;
            ds_search.Clear();
            hienthi();
        }

        private void bntSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dgl = new SaveFileDialog();
            dgl.Filter = "Text file (*.txt)|*.txt";
            if (dgl.ShowDialog() == DialogResult.OK)
            {
                string filename = dgl.FileName;
                saveFile(filename);
                MessageBox.Show("Data is Saved");
            }
            //string path = Application.StartupPath + "\\product.txt";
            //bool result = fPro.Save(pip.getALL(), path);
            //if(result)
            //{
            //    MessageBox.Show("Save succuess!");
            //}

        }
        private void saveFile(string filename)
        {
            try
            {
                StringBuilder sp = new StringBuilder();
                foreach(DataGridViewRow row in dgvDshh.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        sp.Append(cell.Value?.ToString() ?? "");
                        sp.Append("\t");
                            
                    }
                    sp.AppendLine();
                }
                StreamWriter writer = new StreamWriter(filename, true);
                writer.WriteLine(sp.ToString());
                writer.Close();
                
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void dgvDshh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            CProduct row = (CProduct)dgvDshh.Rows[e.RowIndex].DataBoundItem;
            txtMa.Text = row.Ma.ToString();
            txtTen.Text = row.Ten.ToString();
            cmbLoai.Text = row.Loai.ToString();
            txtSLnhap.Text = row.Soluongnhap.ToString();
            txtSLxuat.Text = row.Soluongxuat.ToString();
            txtGianhap.Text = row.Gianhap.ToString();
            txtGiaxuat.Text = row.Giaxuat.ToString();
            txtGhichu.Text = row.Ghichu.ToString();
        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi ứng dụng?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                //Application.Exit();
                frmLogin lg = new frmLogin(account);
                lg.Show();
                this.Close();
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Title = "Chon tep tin";
                open.Filter = "Tệp tin văn bản |*.txt|Tất cả các tệp tín|*.*";
                open.Multiselect = false;
                if (open.ShowDialog() == DialogResult.OK) ;
                {
                    string filename = open.FileName;
                    StreamReader reader = new StreamReader(filename);
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] value = line.Split('\t');
                        if (value.Length == 9)
                        {
                            CProduct data = new CProduct(value[0], value[1], value[2], value[3], value[4], value[5], value[6], value[7]);
                            dshh.Add(data);
                        }
                    }
                    reader.Close();
                }
                hienthi();

            }
            catch (Exception ex)
            {
                throw ex; 

            }
            
        }

        private void picbClosePro_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi ứng dụng?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\product.txt";
            if(System.IO.File.Exists(path))
            {
                pip.setAll(fPro.Load(path));
                dgvDshh.DataSource = pip.getALL().ToList();
            }
        }
    }
}
