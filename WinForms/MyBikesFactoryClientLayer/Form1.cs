using MyBikesFactoryBusinessLayer;
using MyBikesFactoryBusinessLayer.Enums;
using MyBikesFactoryDataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBikesFactoryClientLayer
{
    public partial class Form1 : Form
    {

        private Bike currentBike = null;

        private List<Bike> listOfBikes = new List<Bike>();
        private List<Bike> currentListOfBikes = null;

        public Form1()
        {
            InitializeComponent();

            webView1.ScriptNotify += WebView1_ScriptNotify;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            configureComboEnum<BikeType>(cbType, "(Choose a Bike Type)");
            configureComboEnum<SuspensionType>(cbSuspension, "");

            //rightMenu.Height = listBox1.Top - 50;
        }

        private void WebView1_ScriptNotify(object sender, Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlScriptNotifyEventArgs e)
        {
            MessageBox.Show(e.Value);

        }

        private void configureComboEnum<T>(ComboBox cb, string initialValue)
        {
            if (!string.IsNullOrEmpty(initialValue))
            {
                cb.Items.Add(initialValue);
            }
            var values = Enum.GetValues(typeof(T));
            foreach (var value in values)
            {
                cb.Items.Add(value);
            }
            cb.SelectedIndex = 0;
        }

       
        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cbType.Enabled)
                return;

            listView1.Enabled = false;
            ////////
            listView1.SelectedItems.Clear();

            listView1.Enabled = true;

            if (cbType.SelectedIndex == 0)
            {
                currentBike = null;
                rightMenu.Visible = false;
                return;
            }

            rightMenu.Visible = true;
            gbCommon.Visible = true;
            btnAdd.Visible = true;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;

            string currentType = cbType.Text;
            ShowGroupBoxBasedOnType(currentType);

            Reset();

            if (currentType == BikeType.MountainBike.ToString())
            {
                currentBike = new MountainBike();
                webView1.InvokeScriptAsync("eval", new[] { $"gameInstance.SendMessage('_SCENE_MANAGER', 'SelectBike', 'mountain_bike');" });
                trackHeightFromGround_Scroll(sender, e);
                cbSuspension_SelectedIndexChanged(sender, e);
            }
                
            else if (currentType == BikeType.RoadBike.ToString())
            {
                currentBike = new RoadBike();
                webView1.InvokeScriptAsync("eval", new[] { $"gameInstance.SendMessage('_SCENE_MANAGER', 'SelectBike', 'road_bike');" });
                trackSeatHeight_Scroll(sender, e);
            }

            UpdateBike3DColor(btnColor.BackColor);
        }

        private void ShowGroupBoxBasedOnType(string type)
        {
            var shapeTypeControls = new List<Control> { gbMountain, gbRoad };
            foreach (var c in shapeTypeControls)
            {
                c.Visible = (c.Tag.ToString() == type);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void SelectComboItemBasedOnValue(ComboBox comboBox, string value)
        {

            for (int i = 0; i < comboBox.Items.Count; i++)
            {
                if (comboBox.Items[i].ToString() == value)
                {
                    comboBox.SelectedIndex = i;
                    break;
                }
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                btnColor.BackColor = colorDialog.Color;

                UpdateBike3DColor(colorDialog.Color);

            }
        }

        private void UpdateBike3DColor(Color color)
        {
            float r = color.R;
            float g = color.G;
            float b = color.B;

            webView1.InvokeScriptAsync("eval", new[] { $"gameInstance.SendMessage('_SCENE_MANAGER', 'ChangeBikeColor', '{r},{g},{b}');" });
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            BikeType type;
            Enum.TryParse<BikeType>(cbType.Text, out type);

            Bike bike = null;

            switch (type)
            {
                case BikeType.MountainBike:
                    SuspensionType suspension;
                    Enum.TryParse<SuspensionType>(cbSuspension.Text, out suspension);
                    bike = new MountainBike(suspension, trackHeightFromGround.Value);
                    break;
                case BikeType.RoadBike:
                    bike = new RoadBike((float)trackSeatHeight.Value);
                    break;
            }

            bike.SerialNumber = txtSerialNumber.Text;
            bike.Made = txtMade.Text;
            bike.Model = txtModel.Text;
            bike.BikeColor = btnColor.BackColor;
            bike.MadeDate = monthCalendar1.SelectionRange.Start;

            listOfBikes.Add(bike);

            if (MessageBox.Show($"The {type.ToString()} was successfully added.\n\nDo you want to update the list?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                btnDisplayAll_Click(this, e);
                listView1.Items[listView1.Items.Count-1].Selected = true;
            }
        }

        private bool ValidateInput()
        {
            if (cbType.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select a Bike Type", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (string.IsNullOrEmpty(txtSerialNumber.Text))
            {
                MessageBox.Show("Please Inform a Serial Number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (string.IsNullOrEmpty(txtMade.Text))
            {
                MessageBox.Show("Please Inform the made field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (string.IsNullOrEmpty(txtModel.Text))
            {
                MessageBox.Show("Please Inform a Model", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            
            return true;
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            DisplayList(listOfBikes);
        }

        private void DisplayList(List<Bike> list, BikeType? type = null)
        {
            if (list.Count == 0)
                return;

            currentListOfBikes = list;

            listView1.Items.Clear();

            List<Bike> queryList = null;

            if (type != null)
            {
                queryList = (from bike in list
                             where bike.Type == type
                             select bike).ToList<Bike>();
            }
            else
                queryList = list;

            foreach (var bike in queryList)
            {

                listView1.Items.Add(bike.ToListViewItem());
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();

            UpdateBike3DColor(btnColor.BackColor);
        }

        private void Reset()
        {
            txtSerialNumber.Text = "";
            txtMade.Text = "";
            txtModel.Text = "";
            btnColor.BackColor = System.Drawing.Color.Blue;
            monthCalendar1.SetDate(System.DateTime.Now);
            cbSuspension.SelectedIndex = 0;
            trackHeightFromGround.Value = 100;
            trackSeatHeight.Value = 8;
        }

        private void btnDisplayMountainBikes_Click(object sender, EventArgs e)
        {
            DisplayList(listOfBikes, BikeType.MountainBike);
        }

        private void btnDisplayRoadBikes_Click(object sender, EventArgs e)
        {
            DisplayList(listOfBikes, BikeType.RoadBike);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (var fileHandler = new XmlFileHandler())
                {
                    fileHandler.WriteToFile("bikes", listOfBikes.Cast<SerializableItem>().ToList());
                    MessageBox.Show("File successfully saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            try
            {
                using (var fileHandler = new XmlFileHandler())
                {
                    listOfBikes = fileHandler.ReadFromFile<SerializableItem>("bikes").Cast<Bike>().ToList();

                    if (MessageBox.Show("File successfully loaded\n\nDo you want to refresh the list?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        btnDisplayAll_Click(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var frmSearch = new Search();
            if (frmSearch.ShowDialog() == DialogResult.OK)
            {
                var result = from bike in listOfBikes
                             where
                                  bike.SerialNumber == frmSearch.Criteria
                             select bike;
                if (result.Count() == 0)
                    MessageBox.Show("Bike not found!");
                else
                {
                    DisplayList(result.ToList());
                    if (listView1.Items.Count>0)
                        listView1.Items[0].Selected = true;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            switch (currentBike.Type)
            {
                case BikeType.MountainBike:
                    SuspensionType suspension;
                    Enum.TryParse<SuspensionType>(cbSuspension.Text, out suspension);
                    //bike = new MountainBike(suspension, (float)ndHeightFromGround.Value);
                    (currentBike as MountainBike).Suspension = suspension;
                    (currentBike as MountainBike).HeightFromGround = trackHeightFromGround.Value;
                    break;
                case BikeType.RoadBike:
                    (currentBike as RoadBike).SeatHeight = (float)trackSeatHeight.Value;
                    break;
            }

            currentBike.SerialNumber = txtSerialNumber.Text;
            currentBike.Made = txtMade.Text;
            currentBike.Model = txtModel.Text;
            currentBike.BikeColor = btnColor.BackColor;
            currentBike.MadeDate = monthCalendar1.SelectionRange.Start;

            listView1.Items[listView1.SelectedIndices[0]] = currentBike.ToListViewItem();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Proceed with exclusion?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //listOfBikes.RemoveAt(listBox1.SelectedIndex);
                listOfBikes.Remove(currentBike);
                Reset();
                btnDisplayAll_Click(sender, e);
            }
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void trackHeightFromGround_Scroll(object sender, EventArgs e)
        {
            lblHeightFromGround.Text = $"Height from Ground ({trackHeightFromGround.Value}cm):";

            float heightFromGround = (float)trackHeightFromGround.Value / 100;
            webView1.InvokeScriptAsync("eval", new[] { $"gameInstance.SendMessage('_SCENE_MANAGER', 'AdjustHeightFromGround', '{heightFromGround}');" });
        }

        private void cbSuspension_SelectedIndexChanged(object sender, EventArgs e)
        {
            SuspensionType suspension;
            Enum.TryParse<SuspensionType>(cbSuspension.Text, out suspension);
            if (suspension == SuspensionType.Front)
            {
                webView1.InvokeScriptAsync("eval", new[] { $"gameInstance.SendMessage('_SCENE_MANAGER', 'SelectFrontSuspension', 'true');" });
                webView1.InvokeScriptAsync("eval", new[] { $"gameInstance.SendMessage('_SCENE_MANAGER', 'SelectRearSuspension', 'false');" });
            }
            else if (suspension == SuspensionType.FrontAndRear)
            {
                webView1.InvokeScriptAsync("eval", new[] { $"gameInstance.SendMessage('_SCENE_MANAGER', 'SelectFrontSuspension', 'true');" });
                webView1.InvokeScriptAsync("eval", new[] { $"gameInstance.SendMessage('_SCENE_MANAGER', 'SelectRearSuspension', 'true');" });
            }
            else if (suspension == SuspensionType.Rear)
            {
                webView1.InvokeScriptAsync("eval", new[] { $"gameInstance.SendMessage('_SCENE_MANAGER', 'SelectFrontSuspension', 'false');" });
                webView1.InvokeScriptAsync("eval", new[] { $"gameInstance.SendMessage('_SCENE_MANAGER', 'SelectRearSuspension', 'true');" });
            }
        }

        private void trackSpeed_Scroll(object sender, EventArgs e)
        {
            if (currentBike == null)
                return;

            double speedOffset = 0;
            if (trackSpeed.Value > currentBike?.Speed)
            {
                speedOffset = trackSpeed.Value - currentBike.Speed;
                currentBike.Accelerate(speedOffset);
            }
                
            else
            {
                speedOffset = currentBike.Speed - trackSpeed.Value;
                currentBike.Decelerate(speedOffset);
            }

            lblBikeState.Text = $"Bike state: {currentBike.State}";

            lblSpeed.Text = $"Accelerate / Decelerate Speed ({currentBike.Speed}km/h):";
            webView1.InvokeScriptAsync("eval", new[] { $"gameInstance.SendMessage('_SCENE_MANAGER', 'DefineSpeed', '{trackSpeed.Value}');" });
        }

        private void trackRotation_Scroll(object sender, EventArgs e)
        {
            webView1.InvokeScriptAsync("eval", new[] { $"gameInstance.SendMessage('_SCENE_MANAGER', 'DefineRotation', '{trackRotation.Value}');" });
        }

        private void trackSeatHeight_Scroll(object sender, EventArgs e)
        {
            //trackSeatHeight

            lblSeatHeight.Text = $"Seat Height ({trackSeatHeight.Value}cm):";

            float seatHeight = (float)trackSeatHeight.Value / 15;
            webView1.InvokeScriptAsync("eval", new[] { $"gameInstance.SendMessage('_SCENE_MANAGER', 'AdjustSeatHeight', '{seatHeight}');" });
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!listView1.Enabled)
                return;

            cbType.Enabled = false;
            cbType.SelectedIndex = 0;
            cbType.Enabled = true;

            if (listView1.SelectedItems.Count >= 1)
            {

                rightMenu.Visible = true;


                var index = listView1.SelectedItems[0].Index;
                currentBike = currentListOfBikes[index];

                btnColor.BackColor = currentBike.BikeColor;

                //show updating options:
                btnAdd.Visible = false;
                btnUpdate.Visible = true;
                btnDelete.Visible = true;

                //Common data regarding Bike class:
                txtSerialNumber.Text = currentBike.SerialNumber;
                txtMade.Text = currentBike.Made;
                txtModel.Text = currentBike.Model;

                monthCalendar1.SetDate(currentBike.MadeDate);

                gbCommon.Visible = true;
                gbMountain.Visible = false;
                gbRoad.Visible = false;

                switch (currentBike.Type)
                {
                    case BikeType.MountainBike:
                        webView1.InvokeScriptAsync("eval", new[] { $"gameInstance.SendMessage('_SCENE_MANAGER', 'SelectBike', 'mountain_bike');" });
                        gbMountain.Visible = true;
                        SelectComboItemBasedOnValue(cbSuspension, (currentBike as MountainBike).Suspension.ToString());
                        trackHeightFromGround.Value = (int)(currentBike as MountainBike).HeightFromGround;
                        trackHeightFromGround_Scroll(sender, e);
                        break;
                    case BikeType.RoadBike:
                        webView1.InvokeScriptAsync("eval", new[] { $"gameInstance.SendMessage('_SCENE_MANAGER', 'SelectBike', 'road_bike');" });
                        gbRoad.Visible = true;
                        trackSeatHeight.Value = (int)(currentBike as RoadBike).SeatHeight;
                        trackSeatHeight_Scroll(sender, e);
                        break;
                }

                UpdateBike3DColor(currentBike.BikeColor);
            }
            else
            {
                currentBike = null;
            }
        }
    }
}
