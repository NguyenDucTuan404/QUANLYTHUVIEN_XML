using DevExpress.LookAndFeel;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraEditors.ColorWheel;
using QUANLYTHUVIEN.BLL;
using QUANLYTHUVIEN.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYTHUVIEN
{
    public partial class DOCGIA : Form
    {
        public DOCGIA()
        {
            InitializeComponent();
        }
        private DOCGIABLL docgiaBLL = new DOCGIABLL();
        private DOCGIADTO docgiaDTO = new DOCGIADTO();
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMDG.SelectedText != "")
       
                txtMDG.Cut();
            if (txtMTTV.SelectedText != "")
     
                txtMTTV.Cut();
            if (txtTDG.SelectedText != "")
          
                txtTDG.Cut();
            if (txtSDTDG.SelectedText != "")
            
                txtSDTDG.Cut();
            if (txtGTDG.SelectedText != "")
              
                txtGTDG.Cut();
            if (txtNSDG.SelectedText != "")
             
                txtNSDG.Cut();
            if (txtNCTTV.SelectedText != "")
       
                txtNCTTV.Cut();
            if (txtNHHTTV.SelectedText != "")
       
                txtNHHTTV.Cut();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMDG.SelectionLength > 0)
                
                txtMDG.Copy();
            if (txtMTTV.SelectionLength > 0)
           
                txtMTTV.Copy();
            if (txtTDG.SelectionLength > 0)
              
                txtTDG.Copy();
            if (txtSDTDG.SelectionLength > 0)
             
                txtSDTDG.Copy();
            if (txtGTDG.SelectionLength > 0)
              
                txtGTDG.Copy();
            if (txtNSDG.SelectionLength > 0)
                
                txtNSDG.Copy();
            if (txtNCTTV.SelectionLength > 0)
               
                txtNCTTV.Copy();
            if (txtNHHTTV.SelectionLength > 0)
               
                txtNHHTTV.Copy();
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
             
                if (txtMDG.SelectionLength > 0)
                {
             
                    if (MessageBox.Show("Do you want to paste over current selection?", "Cut Example", MessageBoxButtons.YesNo) == DialogResult.No)
                   
                        txtMDG.SelectionStart = txtMDG.SelectionStart + txtMDG.SelectionLength;
                }
              
                txtMDG.Paste();
            }
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
               
                if (txtTDG.SelectionLength > 0)
                {
                    
                    if (MessageBox.Show("Do you want to paste over current selection?", "Cut Example", MessageBoxButtons.YesNo) == DialogResult.No)
                  
                        txtTDG.SelectionStart = txtTDG.SelectionStart + txtTDG.SelectionLength;
                }
          
                txtTDG.Paste();
            }
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                
                if (txtSDTDG.SelectionLength > 0)
                {
                   
                    if (MessageBox.Show("Do you want to paste over current selection?", "Cut Example", MessageBoxButtons.YesNo) == DialogResult.No)
                       
                        txtSDTDG.SelectionStart = txtSDTDG.SelectionStart + txtSDTDG.SelectionLength;
                }
                
                txtSDTDG.Paste();
            }
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
              
                if (txtGTDG.SelectionLength > 0)
                {
                    
                    if (MessageBox.Show("Do you want to paste over current selection?", "Cut Example", MessageBoxButtons.YesNo) == DialogResult.No)
                      
                        txtGTDG.SelectionStart = txtGTDG.SelectionStart + txtGTDG.SelectionLength;
                }
                
                txtGTDG.Paste();
            }
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                
                if (txtNSDG.SelectionLength > 0)
                {
                   
                    if (MessageBox.Show("Do you want to paste over current selection?", "Cut Example", MessageBoxButtons.YesNo) == DialogResult.No)
                      
                        txtNSDG.SelectionStart = txtNSDG.SelectionStart + txtNSDG.SelectionLength;
                }
              
                txtNSDG.Paste();
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                txtMDG.Font = fd.Font;
                txtMTTV.Font = fd.Font;
                txtTDG.Font = fd.Font;
                txtSDTDG.Font = fd.Font;
                txtGTDG.Font = fd.Font;
                txtNSDG.Font = fd.Font;
                txtNCTTV.Font = fd.Font;
                txtNHHTTV.Font = fd.Font;
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ColorDialog fd = new ColorDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                txtMDG.BackColor = fd.Color;
                txtMTTV.BackColor = fd.Color;
                txtTDG.BackColor = fd.Color;
                txtSDTDG.BackColor = fd.Color;
                txtGTDG.BackColor = fd.Color;
                txtNSDG.BackColor = fd.Color;
                txtNCTTV.BackColor = fd.Color;
                txtNHHTTV.BackColor = fd.Color;
            }
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtMDG.Undo();
            txtMTTV.Undo();
            txtTDG.Undo();
            txtSDTDG.Undo();
            txtGTDG.Undo();
            txtNSDG.Undo();
            txtNCTTV.Undo();
            txtNHHTTV.Undo();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMDG == null) return;
            txtMDG.SelectAll();
            if (txtMTTV == null) return;
            txtMTTV.SelectAll();
            if (txtTDG == null) return;
            txtTDG.SelectAll();
            if (txtSDTDG == null) return;
            txtSDTDG.SelectAll();
            if (txtGTDG == null) return;
            txtGTDG.SelectAll();
            if (txtNSDG == null) return;
            txtNSDG.SelectAll();
            if (txtNCTTV == null) return;
            txtNCTTV.SelectAll();
            if (txtNHHTTV == null) return;
            txtNHHTTV.SelectAll();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            docgiaBLL.HienThi(dgv);
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMDG.Text.Trim() != "")
            {
                //gán dữ liệu vào DTO
                docgiaDTO.MaDG = txtMDG.Text.ToLower();
                docgiaDTO.MaTTV = txtMTTV.Text.ToLower();
                docgiaDTO.TenDG = txtTDG.Text;
                docgiaDTO.SDTDG = txtSDTDG.Text;
                docgiaDTO.GTDG = txtGTDG.Text;
                docgiaDTO.NgaySinhDG = txtNSDG.Text;
                docgiaDTO.NgayCapTTV = txtNCTTV.Text;
                docgiaDTO.NgayHetHanTTV = txtNHHTTV.Text;

                docgiaBLL.Them(docgiaDTO);
                //hiện lên dgv
                docgiaBLL.HienThi(dgv);
            }
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMDG.Text.Trim() != "")
            {
                //gán dữ liệu vào DTO
                docgiaDTO.MaDG = txtMDG.Text.ToLower();
                docgiaDTO.MaTTV = txtMTTV.Text.ToLower();
                docgiaDTO.TenDG = txtTDG.Text;
                docgiaDTO.SDTDG = txtSDTDG.Text;
                docgiaDTO.GTDG = txtGTDG.Text;
                docgiaDTO.NgaySinhDG = txtNSDG.Text;
                docgiaDTO.NgayCapTTV = txtNCTTV.Text;
                docgiaDTO.NgayHetHanTTV = txtNHHTTV.Text;
                //gọi BLL thực hiện
                docgiaBLL.Sua(docgiaDTO);
                //hiện lên dgv
                docgiaBLL.HienThi(dgv);
            }
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMDG.Text.Trim() != "")
            {
                //gán dữ liệu vào DTO
                docgiaDTO.MaDG = txtMDG.Text.ToLower();

                //gọi BLL thực hiện
                docgiaBLL.Xoa(docgiaDTO);
                //hiện lên dgv
                docgiaBLL.HienThi(dgv);
            }
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMDG.Text.Trim() != "")
            {
                //gán dữ liệu vào DTO
                docgiaDTO.MaDG = txtMDG.Text.ToLower();
                //gọi BLL thực hiện
                var sachTim = docgiaBLL.TimKiem2(docgiaDTO, dgv);
                //khác null là tìm thấy, thực hiện bind lên ui
                if (sachTim != null)
                {
                    txtMDG.Text = sachTim.MaDG;
                    txtMTTV.Text = sachTim.MaTTV;
                    txtTDG.Text = sachTim.TenDG;
                    txtSDTDG.Text = sachTim.SDTDG;
                    txtGTDG.Text = sachTim.GTDG;
                    txtNSDG.Text = sachTim.NgaySinhDG;
                    txtNCTTV.Text = sachTim.NgayCapTTV;
                    txtNHHTTV.Text = sachTim.NgayHetHanTTV;
                }
                else
                {
                    //không thấy thì xóa trăng
                    txtMDG.Text = txtMTTV.Text = txtTDG.Text = txtSDTDG.Text = txtGTDG.Text = txtNSDG.Text = txtNCTTV.Text = txtNHHTTV.Text = string.Empty;
                }
            }
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ColorWheelForm form = new ColorWheelForm();
            form.StartPosition = FormStartPosition.CenterParent;
            form.SkinMaskColor = UserLookAndFeel.Default.SkinMaskColor;
            form.SkinMaskColor2 = UserLookAndFeel.Default.SkinMaskColor2;
            form.ShowDialog(this);
        }

        private void DOCGIA_Load(object sender, EventArgs e)
        {
            SkinHelper.InitSkinPopupMenu(SkinsLink);
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var a1 = new ProcessStartInfo("msedge.exe");
            a1.Arguments = "https://www.facebook.com/tuancutedapxetrenph0";
            Process.Start(a1);

            var a2 = new ProcessStartInfo("msedge.exe");
            a2.Arguments = "https://www.facebook.com/tuancutedapxetrenph0";
            Process.Start(a2);
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ABOUT about = new ABOUT();
            //this.Hide();
            about.Show();
            this.Show();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                // Determine if any text is selected in the text box.
                if (txtMTTV.SelectionLength > 0)
                {
                    // Ask user if they want to paste over currently selected text.
                    if (MessageBox.Show("Do you want to paste over current selection?", "Cut Example", MessageBoxButtons.YesNo) == DialogResult.No)
                        // Move selection to the point after the current selection and paste.
                        txtMTTV.SelectionStart = txtMTTV.SelectionStart + txtMTTV.SelectionLength;
                }
                // Paste current text in Clipboard into text box.
                txtMTTV.Paste();
            }
        }

        private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                // Determine if any text is selected in the text box.
                if (txtNCTTV.SelectionLength > 0)
                {
                    // Ask user if they want to paste over currently selected text.
                    if (MessageBox.Show("Do you want to paste over current selection?", "Cut Example", MessageBoxButtons.YesNo) == DialogResult.No)
                        // Move selection to the point after the current selection and paste.
                        txtNCTTV.SelectionStart = txtNCTTV.SelectionStart + txtNCTTV.SelectionLength;
                }
                // Paste current text in Clipboard into text box.
                txtNCTTV.Paste();
            }
        }

        private void barButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                // Determine if any text is selected in the text box.
                if (txtNHHTTV.SelectionLength > 0)
                {
                    // Ask user if they want to paste over currently selected text.
                    if (MessageBox.Show("Do you want to paste over current selection?", "Cut Example", MessageBoxButtons.YesNo) == DialogResult.No)
                        // Move selection to the point after the current selection and paste.
                        txtNHHTTV.SelectionStart = txtNHHTTV.SelectionStart + txtNHHTTV.SelectionLength;
                }
                // Paste current text in Clipboard into text box.
                txtNHHTTV.Paste();
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
