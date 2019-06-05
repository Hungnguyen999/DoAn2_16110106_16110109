using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectQuanlyNhahang
{
	public partial class FrmCRUDLuong : Form
	{
		public FrmCRUDLuong()
		{
			InitializeComponent();
		}
		void LoadDaTa()
		{
			pnql.Enabled = false;
			cbbMa.Enabled = true;
			txttong.Enabled = true;
			RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();

			var kq1 = from k in dbs.NHANVIENs
					  select k;
			TenNV.DataSource = kq1;
			TenNV.DisplayMember = "HoTenNV";
			TenNV.ValueMember = "ID";

			var kq = from p in dbs.LUONGs
					 where p.Status == true
					 select new
					 {
						 p.ID_NV,
						 p.TenNV,
						 p.LuongCB,
						 p.Thuong,
						 p.TongLuong
					 };
			btnSua.Enabled = true;
			btnLuu.Enabled = false;
			btnXoa.Enabled = true;
			btnSave.Enabled = false;
			dgvLuong.DataSource = kq;
			dgvLuong_CellClick(null, null);

		}
		bool them = false;
		private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			pnql.Enabled = true;
			them = true;
			cbbMa.ResetText();
			cbbMa.Enabled = false;
			txttong.Enabled = false;
			txtLuong.ResetText();
			txtThuong.ResetText();
			txttong.ResetText();
			cbxMANV.ResetText();
			btnSave.Enabled = true;
		}

		private void dgvLuong_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
			var kq1 = from nv in dbs.NHANVIENs
					  select nv;
			cbxMANV.DataSource = kq1.ToList();
			cbxMANV.DisplayMember = "HoTenNV";
			cbxMANV.ValueMember = "ID";

			//var kq3 = from nv in dbs.NHANVIENs
			//		  select nv;
			//cbbMa.DataSource = kq3.ToList();
			//cbbMa.DisplayMember = "ID";
			//cbbMa.ValueMember = "ID";

			int r = dgvLuong.CurrentCell.RowIndex;
			cbbMa.Text = dgvLuong.Rows[r].Cells[0].Value.ToString();
			cbxMANV.SelectedValue = dgvLuong.Rows[r].Cells[1].Value;
			txtLuong.Text = dgvLuong.Rows[r].Cells[2].Value.ToString();
			txtThuong.Text = dgvLuong.Rows[r].Cells[3].Value.ToString();
			txttong.Text = dgvLuong.Rows[r].Cells[4].Value.ToString();
		}
		public void Them(string Hoten, string LuongCB,string Thuong, string TongLuong)
		{
			
			RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
			LUONG L = new LUONG();
			L.TenNV = Convert.ToInt32(cbxMANV.SelectedValue.ToString());
			if (!dbs.LUONGs.Where(cls => cls.TenNV == Convert.ToInt32(cbxMANV.SelectedValue.ToString())).Any())
			{
				
				L.TenNV = Convert.ToInt32(cbxMANV.SelectedValue.ToString());
				L.LuongCB = Convert.ToInt32(txtLuong.Text);
				L.Thuong = Convert.ToInt32(txtThuong.Text);
				L.TongLuong = Convert.ToInt32(txtLuong.Text) + Convert.ToInt32(txtThuong.Text);
				L.TrangThai = true;
				dbs.LUONGs.InsertOnSubmit(L);
				dbs.SubmitChanges();
				MessageBox.Show("Đã Thêm !", "Thông báo!",
					   MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadDaTa();
			}
			else
			{
				MessageBox.Show("Nhân viên này đã có bảng lương !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		public void sua(string ma)
		{
			
			btnThem.Enabled = true;
			btnSave.Enabled = true;
			txttong.Enabled = false;
			RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
			LUONG L = dbs.LUONGs.Single(p => p.ID_NV.ToString() == ma);
			L.TenNV = Convert.ToInt32(cbxMANV.SelectedValue.ToString());
			L.LuongCB = Convert.ToInt32(txtLuong.Text);
			L.Thuong = Convert.ToInt32(txtThuong.Text);
			L.TongLuong = Convert.ToInt32(txtLuong.Text) + Convert.ToInt32(txtThuong.Text);
			L.TrangThai = true;
			dbs.SubmitChanges();
		}

		private void FrmCRUDLuong_Load(object sender, EventArgs e)
		{
			LoadDaTa();
		}

		private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (them)
			{
				Them(cbxMANV.Text, txtLuong.Text, txtThuong.Text, txttong.Text);
				
				LoadDaTa();
			}
			else
			{
				int r = dgvLuong.CurrentCell.RowIndex;
				string a = dgvLuong.Rows[r].Cells[0].Value.ToString();
				sua(a);
				LoadDaTa();
				MessageBox.Show("Đã sửa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void dgvLuong_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			cbbMa.Enabled = false;
			txttong.Enabled = false;
			pnql.Enabled = true;
			btnSave.Enabled = true;
		}
		public void xoa(string a)
		{
			RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
			LUONG dc = dbs.LUONGs.Single(p => p.ID_NV.ToString() == a);
			dc.Status = false;
			dbs.SubmitChanges();
		}

		private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			int r = dgvLuong.CurrentCell.RowIndex;
			string a = dgvLuong.Rows[r].Cells[0].Value.ToString();
			xoa(a);
			MessageBox.Show("Đã xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			LoadDaTa();
		}

		private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			LoadDaTa();
		}
	}
}
