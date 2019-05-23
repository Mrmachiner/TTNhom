using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNV.Model;

namespace QLNV.View
{
   
    public partial class FormChonCa : Form
    {
        YeuCau yeuCauEdit;
        public FormChonCa()
        {
           
            InitializeComponent();
           
        }
        QLPCNhanVienEntities1 db = new QLPCNhanVienEntities1();
        private void FormChonCa_Load(object sender, EventArgs e)
        {
            //chỉnh view Người được chọn
            //Chỉnh view Người được chọn vào ca
            dtGribPhai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGribPhai.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            // Chỉnh view danh sách dữ liệu
            dtGridTrai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGridTrai.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dtBatDau.Format = DateTimePickerFormat.Custom;
            dtBatDau.CustomFormat = "HH:mm"; // Only use hours and minutes
            dtBatDau.ShowUpDown = true;
            dtKetThuc.Format = DateTimePickerFormat.Custom;
            dtKetThuc.CustomFormat = "HH:mm"; // Only use hours and minutes
            dtKetThuc.ShowUpDown = true;
           

        }
        List<CanBo> lstCBPhanCong;
        List<CanBo> lstCBBoPhanCong;
        List<CanBo> lstCBDuocChon;
        List<CanBo> lstCBTrungGian;
        CaTruc caTrucEdit;
        int? SoViec;
        private void btnPhai_Click(object sender, EventArgs e)
        {
            if (caTrucEdit == null)
            {
                MessageBox.Show("Ấn Nút 'Xem' Ca Chực Để Chọn Ca");
                return;
            }
            for (int i = dtGridTrai.RowCount - 1; i >= 0; i--)
            {
                DataGridViewRow row = dtGridTrai.Rows[i];
                if (Convert.ToBoolean(row.Cells["Chon"].Value))
                {
                    CanBo canBoRow = (CanBo)row.DataBoundItem;
                    CanBo canBo = db.CanBo.SingleOrDefault(x => x.CanBoID == canBoRow.CanBoID);
                    PhanCong phanCong1 = canBo.PhanCong.Where(x => x.CaTruc.YeuCau.NgayTruc == yeuCauEdit.NgayTruc).FirstOrDefault();
                    if(phanCong1 != null)
                    {
                        MessageBox.Show("Da truc");
                        return;
                    }
                    if (lstCBPhanCong.Count < caTrucEdit.NguoiCan)
                    {
                        List<PhanCong> lstPhancong = new List<PhanCong>();
                        if (canBo.PhanCong.Count != 0)
                        {
                                List<PhanCong> listPhanCong = canBo.PhanCong.ToList();
                                foreach (PhanCong phanCong in listPhanCong)
                                {
                                    if (phanCong.YeuCau != null)
                                    {
                                        if (phanCong.YeuCau.NgayTruc == yeuCauEdit.NgayTruc)
                                        {
                                            lstPhancong.Add(phanCong);
                                        }
                                    }
                                }
                            }
                            if (lstPhancong.Count > 0)
                            {
                                foreach (PhanCong phanCong in lstPhancong)
                                {
                                   
                                    if (DateTime.Compare((DateTime)phanCong.CaTruc.BatDau, (DateTime)caTrucEdit.BatDau) == 0 && DateTime.Compare((DateTime)caTrucEdit.BatDau, (DateTime)phanCong.CaTruc.KetThuc) == -1)
                                    {
                                        MessageBox.Show("Cán bộ " + canBo.HoTen + "trùng ca trực");
                                        break;
                                    }
                                    else
                                    {
                                        canBoBindingSource2.Add(canBo);
                                        if (lstCBDuocChon.FindIndex(x => x.CanBoID == canBo.CanBoID) < 0)
                                        {
                                            lstCBDuocChon.Add(canBo);
                                        }
                                        SoViec++;
                                        lstCBPhanCong.Add(canBo);
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                canBoBindingSource2.Add(canBo);
                                if (lstCBDuocChon.FindIndex(x => x.CanBoID == canBo.CanBoID) < 0)
                                {
                                    lstCBDuocChon.Add(canBo);
                                }
                                SoViec++;
                                lstCBPhanCong.Add(canBo);
                            }

                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm người mới vào");
                        break;
                    }
                }
            }
            foreach (CanBo canBoDel in lstCBPhanCong)
            {
                canBoBindingSource.Remove(canBoDel);
            }
            dtGribPhai.DataSource = null;
            dtGribPhai.DataSource = canBoBindingSource2;
        }

        private void btnTrai_Click(object sender, EventArgs e)
        {
            if (caTrucEdit == null)
            {
                MessageBox.Show("Ấn Nút 'Xem' Ca Chực Để Chọn Ca");
                return;
            }
            for (int i=dtGribPhai.RowCount - 1; i >= 0; i--)
            {

                DataGridViewRow row = dtGribPhai.Rows[i];
                if (Convert.ToBoolean(row.Cells["Chon1"].Value)==true)
                {
                    CanBo canBo = (CanBo)row.DataBoundItem;
                    canBoBindingSource.Add((CanBo)row.DataBoundItem);
                    lstCBBoPhanCong.Add(canBo);
                    lstCBPhanCong.Remove(canBo);
                }
            }
            foreach(CanBo canbo in lstCBBoPhanCong)
            {
                canBoBindingSource2.Remove(canbo);
            }
            dtGribPhai.DataSource = null;
            dtGribPhai.DataSource = lstCBPhanCong;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            List<PhanCong> lstPhancong = new List<PhanCong>();
            db.PhanCong.RemoveRange(caTrucEdit.PhanCong);
            foreach(CanBo canBo in lstCBPhanCong)
            {
                lstPhancong.Add(new PhanCong()
                {
                    YeuCauID=yeuCauEdit.YeuCauID,
                    CanBoID = canBo.CanBoID,
                    CaTrucID = caTrucEdit.CaTrucID
                });
            }
            db.PhanCong.AddRange(lstPhancong);
            try
            {
                db.SaveChanges();
                MessageBox.Show("Lưu Thành Công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu Thất Bại");
            }
        }
        void GetTTCaTruc()
        {
            SoViec = yeuCauEdit.PhanCong.Count;
            int id = int.Parse(cbxChonCa.SelectedValue.ToString());
            caTrucEdit = db.CaTruc.SingleOrDefault(x => x.CaTrucID == id);
            dtBatDau.Value = caTrucEdit.BatDau.Value;
            dtKetThuc.Value = caTrucEdit.KetThuc.Value;
            txtNgCan.Text = caTrucEdit.NguoiCan.ToString();
        }
        void GetDataCatruc(int isle)
        {
            List<CanBo> dataCanBo = db.CanBo.ToList();
            CanBo.FindCV(dataCanBo, (DateTime)yeuCauEdit.DotCongViec.NgayBatDau, (DateTime)yeuCauEdit.DotCongViec.NgayKetThuc);
            List<CanBo> ChonCanBo = new List<CanBo>();
            foreach (var item in dataCanBo)
            {
                if(GioiHan + isle > item.CountCv)
                {
                    ChonCanBo.Add(item);
                }
            }
            canBoBindingSource.DataSource = ChonCanBo;
            lstCBPhanCong = new List<CanBo>();
            lstCBBoPhanCong = new List<CanBo>();
            foreach (PhanCong phanCong in caTrucEdit.PhanCong)
            {
                lstCBPhanCong.Add(phanCong.CanBo);
            }
            dtGribPhai.DataSource = lstCBPhanCong;
            lstCBTrungGian = new List<CanBo>();
            canBoBindingSource2.List.Clear();
            foreach (CanBo canbo in lstCBPhanCong)
            {
                canBoBindingSource2.Add(canbo);
                canBoBindingSource.Remove(canbo);
            }
        }
        int CountCongViec()
        {
            int count = 0;
            DotCongViec dotCongViec = db.DotCongViec.SingleOrDefault(x => x.DotCongViecID == caTrucEdit.YeuCau.DotCongViecID);
            foreach (var item in dotCongViec.YeuCau)
            {
                count = count+ item.PhanCong.Count;
            }
            return count;
        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            
            if(cbxChonCa.SelectedValue == null)
            {
                MessageBox.Show("Không tìm thấy ca. Vui lòng chọn lại ngày!");
                return;
            }
            caTrucEdit = new CaTruc();
            GetTTCaTruc();
            int SoCongViec = CountCongViec();
            if(SoCongViec < MucGioiHan)
            {
                GetDataCatruc(0);
            }
            if(SoCongViec>= MucGioiHan && SoCongViec <= caTrucEdit.YeuCau.DotCongViec.LuongNguoiCan)
            {
                GetDataCatruc(1);
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtGridTrai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtGribPhai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRandom_Click(object sender, EventArgs e)
        {

        }
        void LoadingCaTruc()
        {
            List<CaTruc> lstCaTruc = yeuCauEdit.CaTruc.ToList();
            cbxChonCa.DataSource = null;
            if (lstCaTruc.Count != 0)
            {
               
                cbxChonCa.DataSource = lstCaTruc;
                cbxChonCa.DisplayMember = "TenCa";
                cbxChonCa.ValueMember = "CaTrucID";
            }
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("vi-VN");
        }
        void GetDataCaTruc()
        {
            lstCBDuocChon = new List<CanBo>();
            foreach (PhanCong phanCong in yeuCauEdit.PhanCong)
            {
                if (lstCBDuocChon.FindIndex(x => x.CanBoID == phanCong.CanBoID) < 0)
                {
                    lstCBDuocChon.Add(phanCong.CanBo);
                }

            }
        }
        int GioiHan = 0;
        int MucGioiHan = 0;
        //Tạo Đợt???/?
        private void button1_Click(object sender, EventArgs e)
        {
            
            CaTruc caTruc = db.CaTruc.SingleOrDefault(x => x.BatDau.Value == dtNgayTruc.Value.Date);

                yeuCauEdit = db.YeuCau.SingleOrDefault(x => x.NgayTruc.Value == dtNgayTruc.Value.Date);
                GioiHan = (int)yeuCauEdit.DotCongViec.LuongNguoiCan / db.CanBo.ToList().Count;

                MucGioiHan = GioiHan * db.CanBo.ToList().Count;
                if (yeuCauEdit == null)
                {
                    txtDot.Text = "";
                    txtDenNgay.Text = "";
                    txtTuNgay.Text = "";
                }
                else
                {
                    txtDot.Text = "Đợt" + yeuCauEdit.DotCongViec.DotCongViecID;
                    txtDenNgay.Text = yeuCauEdit.DotCongViec.NgayKetThuc.Value.Date.ToShortDateString();
                    txtTuNgay.Text = yeuCauEdit.DotCongViec.NgayBatDau.Value.Date.ToShortDateString();
                }

                if (yeuCauEdit != null)
                {
                    caTrucEdit = null;
                    LoadingCaTruc();
                    GetDataCaTruc();
                    if (canBoBindingSource2.Count != 0)
                    {
                        dtGribPhai.DataSource = null;
                    }
                }
                else
                {
                    if (MessageBox.Show("Yêu Cầu chưa được tạo. Bạn muốn tạo yêu cầu?", "Mesage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FormSuaYeuCau formSuaYeuCau = new FormSuaYeuCau(null);
                        formSuaYeuCau.ShowDialog();
                    }
                }
            
        }

        private void txtNhanVien_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDot_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
