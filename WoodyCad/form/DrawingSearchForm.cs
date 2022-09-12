using Autodesk.AutoCAD.ApplicationServices;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using acadApplication = Autodesk.AutoCAD.ApplicationServices.Application;

namespace WoodyCad.form
{
    public partial class DrawingSearchForm : MaterialForm
    {
        ValutService ValutService;

        Document Doc;

        public DrawingSearchForm()
        {
            ValutService = new ValutService();

            Doc = Autodesk.AutoCAD.ApplicationServices.Core.Application.DocumentManager.MdiActiveDocument;

            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SidePanel.Visible = false;

            var query = new DrawingSearchDto();

            if (!String.IsNullOrEmpty(txtDrawingNo.Text))
                query.DrawingNo = txtDrawingNo.Text;

            if (!String.IsNullOrEmpty(txtDrawingName.Text))
                query.DrawingName = txtDrawingName.Text;

            if (!String.IsNullOrEmpty(txtDrafter.Text))
                query.Drafter = txtDrafter.Text;

            if (!String.IsNullOrEmpty(dateStart.Text))
                query.StartDate = dateStart.Text;

            if (!String.IsNullOrEmpty(dateEnd.Text))
                query.EndDate = dateEnd.Value.AddDays(1).Date.ToShortDateString();


            List<Drawing> drawings = ValutService.FindDrawing(query);

            searchView.BeginUpdate();

            searchView.Clear();

            searchView.View = View.Details;

            searchView.HeaderStyle = ColumnHeaderStyle.Clickable;




            searchView.Columns.Add("No", 100, HorizontalAlignment.Left);
            searchView.Columns.Add("Id", 50, HorizontalAlignment.Left);
            searchView.Columns.Add("Name", 150, HorizontalAlignment.Left);
            searchView.Columns.Add("Rev", 50, HorizontalAlignment.Left);
            searchView.Columns.Add("Drafter", 100, HorizontalAlignment.Left);
            searchView.Columns.Add("Created", 150, HorizontalAlignment.Left);


            if (drawings != null)
            {
                 foreach(var row in drawings)
                 {
                     ListViewItem item = new ListViewItem(row.DrawingNo);
                     item.SubItems.Add(row.DrawingId);
                     item.SubItems.Add(row.DrawingName);
                     item.SubItems.Add(row.Revision);
                     item.SubItems.Add(row.Drafter);
                     item.SubItems.Add(row.CreatedDate);
                     searchView.Items.Add(item);
                 }
            }





            searchView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            //searchView.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
            searchView.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent);


            searchView.Columns[1].Width = 0;


            searchView.EndUpdate();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {

            Drawing drawing = new Drawing();
            drawing.DrawingNo = searchView.SelectedItems[0].SubItems[0].Text;
            drawing.DrawingId = searchView.SelectedItems[0].SubItems[1].Text;
            drawing.DrawingName = searchView.SelectedItems[0].SubItems[2].Text;

            ValutService.CheckOut(drawing);
        }

        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btnSearch_Click(sender, e);
            }
        }

        private void searchView_ItemActive(object sender, EventArgs e)
        {
            if (this.Width < 1500)
            {
                this.Width = 1500;
            }
            SidePanel.Visible = true;
        }
    }
}
