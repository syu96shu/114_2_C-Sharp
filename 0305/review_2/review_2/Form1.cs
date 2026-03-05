using System.Globalization;

namespace review_2
{
    public partial class Form1 : Form
    {
        // Prices
        private const decimal PRICE_CHANGE_OIL = 780m;
        private const decimal PRICE_LUBE = 540m;
        private const decimal PRICE_RADIATOR = 900m;
        private const decimal PRICE_TRANS_FLUSH = 2400m;
        private const decimal PRICE_INSPECTION = 450m;
        private const decimal PRICE_MUFFLER = 3000m;
        private const decimal PRICE_TIRE_ROTATION = 600m;
        private const decimal LABOR_RATE_PER_HOUR = 200m; // example labor rate
        private const decimal PARTS_TAX_RATE = 0.12m; // 12% tax on parts

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal serviceAndLabor = 0m;
            // service items
            if (chkChangeOil.Checked) serviceAndLabor += PRICE_CHANGE_OIL;
            if (chkLubeJob.Checked) serviceAndLabor += PRICE_LUBE;
            if (chkRadiatorFlush.Checked) serviceAndLabor += PRICE_RADIATOR;
            if (chkTransmissionFlush.Checked) serviceAndLabor += PRICE_TRANS_FLUSH;
            if (chkInspection.Checked) serviceAndLabor += PRICE_INSPECTION;
            if (chkReplaceMuffler.Checked) serviceAndLabor += PRICE_MUFFLER;
            if (chkTireRotation.Checked) serviceAndLabor += PRICE_TIRE_ROTATION;

            // labor from hours
            decimal hours = ParseDecimal(txtHours.Text);
            if (hours > 0) serviceAndLabor += hours * LABOR_RATE_PER_HOUR;

            decimal partsCost = ParseDecimal(txtParts.Text);
            decimal partsTax = Math.Round(partsCost * PARTS_TAX_RATE, 2);
            decimal total = serviceAndLabor + partsCost + partsTax;

            txtServiceAndLabor.Text = serviceAndLabor.ToString("C0", CultureInfo.GetCultureInfo("zh-TW"));
            txtPartsCost.Text = partsCost.ToString("C0", CultureInfo.GetCultureInfo("zh-TW"));
            txtPartsTax.Text = partsTax.ToString("C0", CultureInfo.GetCultureInfo("zh-TW"));
            txtTotal.Text = total.ToString("C0", CultureInfo.GetCultureInfo("zh-TW"));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Uncheck all
            chkChangeOil.Checked = false;
            chkLubeJob.Checked = false;
            chkRadiatorFlush.Checked = false;
            chkTransmissionFlush.Checked = false;
            chkInspection.Checked = false;
            chkReplaceMuffler.Checked = false;
            chkTireRotation.Checked = false;

            // Clear inputs
            txtParts.Text = string.Empty;
            txtHours.Text = string.Empty;

            // Clear summary
            txtServiceAndLabor.Text = string.Empty;
            txtPartsCost.Text = string.Empty;
            txtPartsTax.Text = string.Empty;
            txtTotal.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private decimal ParseDecimal(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return 0m;
            s = s.Replace(",", string.Empty);
            if (decimal.TryParse(s, NumberStyles.Number, CultureInfo.InvariantCulture, out var v)) return v;
            if (decimal.TryParse(s, NumberStyles.Number, CultureInfo.CurrentCulture, out v)) return v;
            return 0m;
        }
    }
}
