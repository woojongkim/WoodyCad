using Autodesk.Windows;
using System;
using Autodesk.AutoCAD.ApplicationServices;
using MaterialSkin;
using Autodesk.AutoCAD.DatabaseServices;

namespace WoodyCad
{
    public class EKIWindowService : WindowService
    {
        private string TabName { get; set; }
        private string TabId { get; set; }

        public override void Init()
        {
            TabName = "EKI";
            //TabId = Guid.NewGuid().ToString();
            TabId = "EKI_TABID";

            MakeRibbonMenu();
        }

        private void MakeRibbonMenu()
        {
            RibbonControl ribbon = ComponentManager.Ribbon;
            if (ribbon != null)
            {
                RibbonTab rtab = ribbon.FindTab(TabId);
                if (rtab != null)
                {
                    ribbon.Tabs.Remove(rtab);
                }

                rtab = new RibbonTab();
                rtab.Title = TabName;
                rtab.Id = TabId;
                //Add the Tab
                ribbon.Tabs.Add(rtab);
                // AddContent(rtab);

                // create Ribbon panels
                {
                    // login/logout
                    {
                        RibbonPanelSource panelSource = new RibbonPanelSource();
                        panelSource.Title = "User";
                        RibbonPanel panel = new RibbonPanel();
                        panel.Source = panelSource;
                        rtab.Panels.Add(panel);

                        // button
                        {
                            RibbonButton button = new RibbonButton();
                            button.Id = "ID_LOG_IN";
                            button.Text = "로그인";
                            button.ShowText = true;
                            button.ShowImage = true;
                            button.Image = ImageUtils.GetBitmap(Properties.Resources.login_16);
                            button.LargeImage = ImageUtils.GetBitmap(Properties.Resources.login_32);
                            button.Orientation = System.Windows.Controls.Orientation.Vertical;
                            button.Size = RibbonItemSize.Large;
                            button.CommandHandler = new RibbonCommandHandler();
                            panelSource.Items.Add(button);
                        }

                        panelSource.Items.Add(new RibbonSeparator());

                        // button
                        {
                            RibbonButton button = new RibbonButton();
                            button.Id = "ID_LOG_OUT";
                            button.Text = "로그아웃";
                            button.ShowText = true;
                            button.ShowImage = true;
                            button.Image = ImageUtils.GetBitmap(Properties.Resources.search_16);
                            button.LargeImage = ImageUtils.GetBitmap(Properties.Resources.login_32_2);
                            button.Orientation = System.Windows.Controls.Orientation.Vertical;
                            button.Size = RibbonItemSize.Large;
                            button.CommandHandler = new RibbonCommandHandler();
                            panelSource.Items.Add(button);
                        }
                    }

                    // drawing
                    {
                        RibbonPanelSource panelSource = new RibbonPanelSource();
                        panelSource.Title = "Drawing";
                        RibbonPanel panel = new RibbonPanel();
                        panel.Source = panelSource;
                        rtab.Panels.Add(panel);

                        // button
                        {
                            RibbonButton button = new RibbonButton();
                            button.Id = "ID_DRAWING_SEARCH";
                            button.Text = "도면 검색";
                            button.ShowText = true;
                            button.ShowImage = true;
                            button.Image = ImageUtils.GetBitmap(Properties.Resources.search_16);
                            button.LargeImage = ImageUtils.GetBitmap(Properties.Resources.login_32_3);
                            button.Orientation = System.Windows.Controls.Orientation.Vertical;
                            button.Size = RibbonItemSize.Standard;
                            button.CommandHandler = new RibbonCommandHandler();
                            panelSource.Items.Add(button);
                        }

                        panelSource.Items.Add(new RibbonSeparator());

                        // button
                        {
                            RibbonButton button = new RibbonButton();
                            button.Id = "ID_CHECK_IN";
                            button.Text = "체크인";
                            button.ShowText = true;
                            button.ShowImage = true;
                            button.Image = ImageUtils.GetBitmap(Properties.Resources.Small);
                            button.LargeImage = ImageUtils.GetBitmap(Properties.Resources.large);
                            button.Orientation = System.Windows.Controls.Orientation.Vertical;
                            button.Size = RibbonItemSize.Large;
                            button.CommandHandler = new RibbonCommandHandler();
                            panelSource.Items.Add(button);
                        }

                        panelSource.Items.Add(new RibbonSeparator());

                        // button
                        {
                            RibbonButton button = new RibbonButton();
                            button.Id = "ID_CHECK_OUT";
                            button.Text = "체크아웃";
                            button.ShowText = true;
                            button.ShowImage = true;
                            button.Image = ImageUtils.GetBitmap(Properties.Resources.large);
                            button.LargeImage = ImageUtils.GetBitmap(Properties.Resources.Small);
                            button.Orientation = System.Windows.Controls.Orientation.Vertical;
                            button.Size = RibbonItemSize.Large;
                            button.CommandHandler = new RibbonCommandHandler();
                            panelSource.Items.Add(button);
                        }
                    }
                }

                rtab.IsActive = true;
            }
        }
    }

    public class RibbonCommandHandler : System.Windows.Input.ICommand
    {
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            Document doc = Autodesk.AutoCAD.ApplicationServices.Core.Application.DocumentManager.MdiActiveDocument;

            if (parameter is RibbonButton)
            {
                RibbonButton button = parameter as RibbonButton;
                doc.Editor.WriteMessage("\nRibbonButton Executed: " + button.Id + " : " + button.Text + "\n");

                switch (button.Id)
                {
                    case "ID_DRAWING_SEARCH":
                        form.DrawingSearchForm drawingSearchForm = new form.DrawingSearchForm();
                        
                        var skinManager = MaterialSkinManager.Instance;
                        skinManager.AddFormToManage(drawingSearchForm);
                        skinManager.Theme = MaterialSkinManager.Themes.DARK;
                        skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue700, TextShade.WHITE);

                        drawingSearchForm.Show();
                        break;
                }
            }
        }
    }
}