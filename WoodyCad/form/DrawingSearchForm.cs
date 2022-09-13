using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.EditorInput;
using MaterialSkin.Controls;
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
using System.Windows.Media;
using acadApplication = Autodesk.AutoCAD.ApplicationServices.Application;

namespace WoodyCad.form
{
    public partial class DrawingSearchForm : MaterialForm
    {
        VaultService ValutService;

        Document Doc;

        public DrawingSearchForm()
        {
            ValutService = VaultService.GetInstance();

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
            searchView.Columns.Add("Name", 300, HorizontalAlignment.Left);
            searchView.Columns.Add("Rev", 50, HorizontalAlignment.Left);
            searchView.Columns.Add("Drafter", 80, HorizontalAlignment.Left);
            searchView.Columns.Add("Modified", 160, HorizontalAlignment.Left);


            if (drawings != null)
            {
                 foreach(var row in drawings)
                 {
                     ListViewItem item = new ListViewItem(row.DrawingNo);
                     item.SubItems.Add(row.DrawingId);
                     item.SubItems.Add(row.DrawingName);
                     item.SubItems.Add(row.Version);
                     item.SubItems.Add(row.Drafter);
                     item.SubItems.Add(row.ModifiedDate);
                     searchView.Items.Add(item);
                 }
            }




            //{ // fit column
            //    searchView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            //    searchView.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent);

            //    foreach (ColumnHeader col in searchView.Columns)
            //    {
            //        col.Width += 20;
            //    }
            //}
           

            searchView.Columns[1].Width = 0;


            searchView.EndUpdate();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {

            Drawing drawing = new Drawing();
            drawing.DrawingNo = searchView.SelectedItems[0].SubItems[0].Text;
            drawing.DrawingId = searchView.SelectedItems[0].SubItems[1].Text;
            drawing.DrawingName = searchView.SelectedItems[0].SubItems[2].Text;

            ValutService.OpenDrawing(drawing, true);
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
            SidePanel.Width = 500;
            SidePanel.Visible = true;

            lbRevisionDrawing.Text = searchView.SelectedItems[0].SubItems[0].Text;
            string drawingId = searchView.SelectedItems[0].SubItems[1].Text;

            List<Drawing> drawings = ValutService.FindRevisions(drawingId);

            reivisionView.BeginUpdate();
            reivisionView.Clear();
            reivisionView.View = View.Details;
            reivisionView.HeaderStyle = ColumnHeaderStyle.Clickable;


            reivisionView.Columns.Add("Rev", 50, HorizontalAlignment.Left);
            reivisionView.Columns.Add("Id", 0, HorizontalAlignment.Left);
            reivisionView.Columns.Add("Name", 150, HorizontalAlignment.Left);
            reivisionView.Columns.Add("Drafter", 100, HorizontalAlignment.Left);
            reivisionView.Columns.Add("Comment", 150, HorizontalAlignment.Left);
            reivisionView.Columns.Add("Modified", 150, HorizontalAlignment.Left);

            if (drawings != null)
            {
                foreach (var row in drawings)
                {
                    ListViewItem item = new ListViewItem(row.Version);
                    item.SubItems.Add(row.DrawingId);
                    item.SubItems.Add(row.DrawingName);
                    item.SubItems.Add(row.Drafter);
                    item.SubItems.Add(row.Comment);
                    item.SubItems.Add(row.ModifiedDate);
                    reivisionView.Items.Add(item);
                }
            }

            //{ // fit column
            //    reivisionView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            //    reivisionView.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent);

            //    foreach (ColumnHeader col in reivisionView.Columns)
            //    {
            //        col.Width += 20;
            //    }
            //}

            reivisionView.Columns[1].Width = 0;

            reivisionView.EndUpdate();
        }

        private void btnOpenDrawing_Click(object sender, EventArgs e)
        {
            if(reivisionView.SelectedItems.Count > 0)
            {
                Drawing drawing = new Drawing();
                drawing.DrawingNo = lbRevisionDrawing.Text;
                drawing.DrawingId = reivisionView.SelectedItems[0].SubItems[1].Text;
                drawing.DrawingName = reivisionView.SelectedItems[0].SubItems[2].Text;

                ValutService.OpenDrawing(drawing, false);
            }
        }
    }
}
