using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project2
{
    public partial class MainPage : Form
    {
        private ArrayList Households = new ArrayList();
        private ArrayList Carrier = new ArrayList();
        private DateTime starDate;
        private DateTime suspendDate;
        private DateTime endDate;
        private int HouseHoldIndex = 0;
        private int CarrierIndex = 0;

        public MainPage()
        {
            InitializeComponent();
            gbxSummary.Visible = false;
        }

        private void tbxFistName_TextChanged(object sender, EventArgs e)
        {
            lblFirstName.Text = " ";

        }

        private void tbxLastName_TextChanged(object sender, EventArgs e)
        {
            lblLastName.Text = " ";
        }

        private void tbxAddress_TextChanged(object sender, EventArgs e)
        {
            lblAddress.Text = " ";
        }

        private void tbxPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            lblPhoneNumber.Text = " ";
        }

        private void lblFirstName_Click(object sender, EventArgs e)
        {

        }

        private void lblLastName_Click(object sender, EventArgs e)
        {

        }

        private void lblAddress_Click(object sender, EventArgs e)
        {

        }

        private void lblPaper_Click(object sender, EventArgs e)
        {

        }

        private void lblPhoneNumber_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            HouseHold aHousehold = new HouseHold();

            starDate = new DateTime(dateTimePickerStartDate.Value.Year, dateTimePickerStartDate.Value.Month, dateTimePickerStartDate.Value.Day);
            endDate = new DateTime(dateTimePickerEndDate.Value.Year, dateTimePickerEndDate.Value.Month, dateTimePickerEndDate.Value.Day);

            switch (cbxPaperType.SelectedIndex)
            {
                case 0:
                    aHousehold.PaperType = "NewYorkTime";
                    aHousehold.BillAmount = 40 * (12 * (endDate.Year - starDate.Year) + (endDate.Month - starDate.Month));
                    if (aHousehold.BillAmount - aHousehold.AmountPaid - aHousehold.AmountRemain > 0)
                        aHousehold.AmountRemain = aHousehold.BillAmount - aHousehold.AmountPaid - aHousehold.AmountRemain;
                    break;

                case 1:
                    aHousehold.PaperType = "Time Magazine";
                    aHousehold.BillAmount = 50 * (12 * (endDate.Year - starDate.Year) + (endDate.Month - starDate.Month));
                    if (aHousehold.BillAmount - aHousehold.AmountPaid - aHousehold.AmountRemain > 0)
                        aHousehold.AmountRemain = aHousehold.BillAmount - aHousehold.AmountPaid - aHousehold.AmountRemain;
                    break;

                case 2:
                    aHousehold.PaperType = "StatenIsland Advance";
                    aHousehold.BillAmount = 30 * (12 * (endDate.Year - starDate.Year) + (endDate.Month - starDate.Month));
                    if (aHousehold.BillAmount - aHousehold.AmountPaid - aHousehold.AmountRemain > 0)
                        aHousehold.AmountRemain = aHousehold.BillAmount - aHousehold.AmountPaid - aHousehold.AmountRemain;
                    break;
            }



            aHousehold.FirstName = tbxFistName.Text;
            aHousehold.LastName = tbxLastName.Text;
            aHousehold.Address = tbxAddress.Text;
            aHousehold.PhoneNumber = tbxPhoneNumber.Text;
            try
            {
                aHousehold.AmountPaid = Int32.Parse(tbxPaidAmount.Text);
            }
            catch
            {
                aHousehold.AmountRemain = 0;
            }

            lblFirstName.Text = Convert.ToString(aHousehold.FirstName);
            lblLastName.Text = Convert.ToString(aHousehold.LastName);
            lblAddress.Text = Convert.ToString(aHousehold.Address);
            lblPhoneNumber.Text = Convert.ToString(aHousehold.PhoneNumber);
            lblPaper.Text = Convert.ToString(aHousehold.PaperType);
            lblBillAmount.Text = Convert.ToString(aHousehold.BillAmount);
            lblPaidAmount.Text = Convert.ToString(aHousehold.AmountPaid);
            lblRemainingAmount.Text = Convert.ToString(aHousehold.AmountRemain);

            Households.Add(aHousehold);
            HouseHoldIndex = Households.Count - 1;

        }


        private void btnNextHouse_Click_1(object sender, EventArgs e)
        {

            if (HouseHoldIndex < Households.Count - 1)
            {
                HouseHoldIndex++;
                HouseHold aHouseHold = (HouseHold)Households[HouseHoldIndex];
                lblFirstName.Text = Convert.ToString(aHouseHold.FirstName);
                lblLastName.Text = Convert.ToString(aHouseHold.LastName);
                lblAddress.Text = Convert.ToString(aHouseHold.Address);
                lblPhoneNumber.Text = Convert.ToString(aHouseHold.PhoneNumber);
                lblBillAmount.Text = Convert.ToString(aHouseHold.BillAmount);
                lblPaidAmount.Text = Convert.ToString(aHouseHold.AmountPaid);
                lblRemainingAmount.Text = Convert.ToString(aHouseHold.AmountRemain);
            }
            else
            {
                MessageBox.Show("No more HouseHold are available", "Error in Performance",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPreviousHouse_Click(object sender, EventArgs e)
        {

            if (HouseHoldIndex > 1)
            {
                HouseHoldIndex--;
                HouseHold aHouseHold = (HouseHold)Households[HouseHoldIndex];
                lblFirstName.Text = Convert.ToString(aHouseHold.FirstName);
                lblLastName.Text = Convert.ToString(aHouseHold.LastName);
                lblAddress.Text = Convert.ToString(aHouseHold.Address);
                lblPhoneNumber.Text = Convert.ToString(aHouseHold.PhoneNumber);
                lblBillAmount.Text = Convert.ToString(aHouseHold.BillAmount);
                lblPaidAmount.Text = Convert.ToString(aHouseHold.AmountPaid);
                lblRemainingAmount.Text = Convert.ToString(aHouseHold.AmountRemain);
            }
            else
            {
                MessageBox.Show("No more HouseHold is available", "Error in Performance",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Households.RemoveAt(HouseHoldIndex);
            if (HouseHoldIndex > 1)
                HouseHoldIndex--;
            lblFirstName.Text = " ";
            lblLastName.Text = " ";
            lblAddress.Text = " ";
            lblPhoneNumber.Text = " ";
            lblPaper.Text = " ";
            lblBillAmount.Text = " ";
            lblPaidAmount.Text = " ";
            lblRemainingAmount.Text = " ";
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                HouseHold theHouseHold = (HouseHold)Households[HouseHoldIndex];
                HouseHold aHousehold = new HouseHold();

                aHousehold.FirstName = tbxFistName.Text;
                aHousehold.LastName = tbxLastName.Text;
                aHousehold.Address = tbxAddress.Text;
                aHousehold.PhoneNumber = tbxPhoneNumber.Text;
                aHousehold.BillAmount = theHouseHold.BillAmount;
                aHousehold.AmountPaid = Int32.Parse(tbxPaidAmount.Text);
                if (aHousehold.BillAmount - aHousehold.AmountPaid - aHousehold.AmountRemain > 0)
                    aHousehold.AmountRemain = aHousehold.BillAmount - aHousehold.AmountPaid - aHousehold.AmountRemain;

                lblFirstName.Text = Convert.ToString(aHousehold.FirstName);
                lblLastName.Text = Convert.ToString(aHousehold.LastName);
                lblAddress.Text = Convert.ToString(aHousehold.Address);
                lblPhoneNumber.Text = Convert.ToString(aHousehold.PhoneNumber);
                lblBillAmount.Text = Convert.ToString(aHousehold.BillAmount);
                lblPaidAmount.Text = Convert.ToString(aHousehold.AmountPaid);
                lblRemainingAmount.Text = Convert.ToString(aHousehold.AmountRemain);

                Households.RemoveAt(HouseHoldIndex);
                Households.Insert(HouseHoldIndex, aHousehold);
            }
            catch
            {
                MessageBox.Show("HouseHold do not exist", "Error in Performance",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        // Carrie's Operations

        private void lblCarriersFirstName_Click(object sender, EventArgs e)
        {

        }

        private void lblCarriersLastName_Click(object sender, EventArgs e)
        {

        }

        private void lblCarriersAddress_Click(object sender, EventArgs e)
        {

        }

        private void lblCarriersPhoneNumber_Click(object sender, EventArgs e)
        {

        }

        private void tbxCarrierFirstName_TextChanged(object sender, EventArgs e)
        {
            lblCarriersFirstName.Text = " ";
        }

        private void tbxCarrierLastName_TextChanged(object sender, EventArgs e)
        {
            lblCarriersLastName.Text = " ";
        }

        private void tbxCarrierAddress_TextChanged(object sender, EventArgs e)
        {
            lblCarriersAddress.Text = " ";
        }

        private void tbxCarrierPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            lblCarriersPhoneNumber.Text = " ";
        }

        private void btnAddCarriersInfo_Click(object sender, EventArgs e)
        {
            Carrier aCarrier = new Carrier();

            aCarrier.CarrierFirstName = tbxCarrierFirstName.Text;
            aCarrier.CarrierLastName = tbxCarrierLastName.Text;
            aCarrier.CarrierAddress = tbxCarrierAddress.Text;
            aCarrier.CarrierPhoneNumber = tbxCarrierPhoneNumber.Text;

            lblCarriersFirstName.Text = Convert.ToString(aCarrier.CarrierFirstName);
            lblCarriersLastName.Text = Convert.ToString(aCarrier.CarrierLastName);
            lblCarriersAddress.Text = Convert.ToString(aCarrier.CarrierAddress);
            lblCarriersPhoneNumber.Text = Convert.ToString(aCarrier.CarrierPhoneNumber);

            if (CarrierIndex != Carrier.Count - 1 && CarrierIndex != 0)
            {
                Carrier.RemoveAt(CarrierIndex);
                Carrier.Insert(CarrierIndex, aCarrier);
            }
            else
            {
                Carrier.Add(aCarrier);
                CarrierIndex = Carrier.Count - 1;
            }
        }

        private void btnModifyCarrier_Click(object sender, EventArgs e)
        {
            Carrier aCarrier = new Carrier();

            aCarrier.CarrierFirstName = tbxCarrierFirstName.Text;
            aCarrier.CarrierLastName = tbxCarrierLastName.Text;
            aCarrier.CarrierAddress = tbxCarrierAddress.Text;
            aCarrier.CarrierPhoneNumber = tbxCarrierPhoneNumber.Text;

            Carrier.RemoveAt(CarrierIndex);
            Carrier.Insert(CarrierIndex, aCarrier);

        }

        private void btnDeleteCarriere_Click(object sender, EventArgs e)
        {
            Carrier.RemoveAt(CarrierIndex);
            if (CarrierIndex > 0)
                CarrierIndex--;

            lblCarriersFirstName.Text = " ";
            lblCarriersLastName.Text = " ";
            lblCarriersAddress.Text = " ";
            lblCarriersPhoneNumber.Text = " ";
        }

        private void cbxPaperType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerStartDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerSuspendDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerEndDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblNewYorkTime_Click(object sender, EventArgs e)
        {

        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            gbxHouseHoldInfo.Visible = false;
            gbxBillingInfo.Visible = false;
            gbxSummary.Visible = true;

            int NewYorkTimeCount = 0, TimeMagazineCount = 0, StatenIslandAdvanceCount = 0;
            for (int index = 0; index < Households.Count - 1; index++)
            {
                HouseHold household = (HouseHold)Households[index];
                if (household.PaperType == "NewYorkTime")
                    NewYorkTimeCount++;
                if (household.PaperType == "StatenIsland Advance")
                    StatenIslandAdvanceCount++;
                if (household.PaperType == "Time Magazine")
                    TimeMagazineCount++;
            }

            lblNewYorkTime.Text = Convert.ToString(NewYorkTimeCount);
            lblTimeMagazine.Text = Convert.ToString(TimeMagazineCount);
            lblStatenIslandAdvance.Text = Convert.ToString(StatenIslandAdvanceCount);
        }

        private void btnSuspend_Click(object sender, EventArgs e)
        {
            HouseHold household = (HouseHold)Households[HouseHoldIndex];
            suspendDate = new DateTime(dateTimePickerSuspendDate.Value.Year, dateTimePickerSuspendDate.Value.Month, dateTimePickerSuspendDate.Value.Day);
            endDate = new DateTime(dateTimePickerEndDate.Value.Year, dateTimePickerEndDate.Value.Month, dateTimePickerEndDate.Value.Day);

            if (household.PaperType == "NewYorkTime")
            {
                household.BillAmount -= 40 * (12 * (endDate.Year - suspendDate.Year) + (endDate.Month - suspendDate.Month));
                if (household.BillAmount - household.AmountPaid - household.AmountRemain > 0)
                    household.AmountRemain = household.BillAmount - household.AmountPaid - household.AmountRemain;
            }
            if (household.PaperType == "StatenIsland Advance")
            {
                household.BillAmount -= 30 * (12 * (endDate.Year - suspendDate.Year) + (endDate.Month - suspendDate.Month));
                if (household.BillAmount - household.AmountPaid - household.AmountRemain > 0)
                    household.AmountRemain = household.BillAmount - household.AmountPaid - household.AmountRemain;
            }
            if (household.PaperType == "Time Magazine")
            {
                household.BillAmount -= 50 * (12 * (endDate.Year - suspendDate.Year) + (endDate.Month - suspendDate.Month));
                if (household.BillAmount - household.AmountPaid - household.AmountRemain > 0)
                    household.AmountRemain = household.BillAmount - household.AmountPaid - household.AmountRemain;
            }

            lblFirstName.Text = Convert.ToString(household.FirstName);
            lblLastName.Text = Convert.ToString(household.LastName);
            lblAddress.Text = Convert.ToString(household.Address);
            lblPhoneNumber.Text = Convert.ToString(household.PhoneNumber);
            lblBillAmount.Text = Convert.ToString(household.BillAmount);
            lblPaidAmount.Text = Convert.ToString(household.AmountPaid);
            lblRemainingAmount.Text = Convert.ToString(household.AmountRemain);
        }

    }
}
