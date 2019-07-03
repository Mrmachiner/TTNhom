using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNV.Model;

namespace QLNV.APIS
{
    public class CanBoAPIS
    {
        QLPCNhanVienEntities1 db = new QLPCNhanVienEntities1();
        public IQueryable<CanBo> GetCanBo()
        {
            return db.CanBo;
        }
        //GetCanBo
        public CanBo GetCanBoID(int Id)
        {
            return db.CanBo.SingleOrDefault(x => x.CanBoID == Id);
        }
        public CanBo GetCanBoHoTen(string hoten)
        {
            return db.CanBo.SingleOrDefault(x => x.HoTen == hoten);
        }
        public CanBo GetCanBoDonVi(int donVi)
        {
            return db.CanBo.SingleOrDefault(x => x.DonViID == donVi);
        }
        public CanBo GetCanBoChucVu(string chucVu)
        {
            return db.CanBo.SingleOrDefault(x => x.ChucVu == chucVu);
        }
        public CanBo GetCanBoNgaySinh(DateTime ngaySinh)
        {
            return db.CanBo.SingleOrDefault(x => x.NgaySinh == ngaySinh);
        }
        
        //PostCanBo
        public void PostCanBo(CanBo canBo)
        {
            if(canBo == null)
            {
                //return92
            }
            else
            {
                db.CanBo.Add(canBo);
                db.SaveChanges();
            }
            //return
        }
        //PostYeuCau
     
        //UpdateCanBo
        public void UpdateCanBo(CanBo canBo)
        {
            CanBo CanBo=db.CanBo.SingleOrDefault(x => x.CanBoID == canBo.CanBoID);
            if (canBo == null)
            {

            }
            else
            {
                CanBo.HoTen = canBo.HoTen;
                CanBo.NgaySinh = canBo.NgaySinh;
                CanBo.DonVi = canBo.DonVi;
                canBo.ChucVu = canBo.ChucVu;
            }
        }
        //UpdateYeuCau
       
        //DeleteCanBo
        public void DeleteCanBo(CanBo canBo)
        {
            CanBo CanBo = db.CanBo.SingleOrDefault(x => x.CanBoID == canBo.CanBoID);
            if (canBo == null)
            {

            }
            else
            {
                db.CanBo.Remove(canBo);
            }
        }
        //DeleteYeuCau
     
    }
}
