using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using acadApplication = Autodesk.AutoCAD.ApplicationServices.Application;

namespace WoodyCad.form
{
    public partial class DrawingCheckInForm : MaterialForm
    {
        public DrawingCheckInForm()
        {
            InitializeComponent();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Continue?", "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DrawingUploadDto drawing = new DrawingUploadDto(txtDrawingNo.Text, txtDrawingName.Text, txtDrafter.Text, txtComment.Text, Path.GetFileName(acadApplication.DocumentManager.CurrentDocument.Name));

                VaultService.GetInstance().CheckIn(acadApplication.DocumentManager.CurrentDocument.Name, drawing);
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }

            LoggerUtils.Alert("CHECK IN COMPLETED");

            this.Close();
        }
    }
}
