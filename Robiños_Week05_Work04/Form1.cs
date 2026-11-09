using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robiños_Week05_Work04
{
    public partial class Form1 : Form
    {
        private readonly List<Product> savedProducts = new List<Product>();
        private readonly ErrorProvider errorProvider = new ErrorProvider();
        private bool isCalculating;

        public Form1()
        {
            InitializeComponent();
            errorProvider.ContainerControl = this;
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new object[]
            {
                "Food",
                "Beverage",
                "Electronics",
                "Clothing",
                "Household",
                "Personal Care",
                "Office Supplies",
                "Other"
            });

            barcodebox.MaxLength = 13;
            AcceptButton = savebutton;
            CancelButton = cancelbutton;
            SetBarcodeStatus("Barcode is available.", SystemColors.ActiveBorder);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (isCalculating)
            {
                return;
            }

            ShowMarkupFromCostAndPrice();
        }

        private void costbox_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(costbox, string.Empty);
            if (isCalculating)
            {
                return;
            }

            decimal markup;
            if (pricebox.Text.Trim().Length == 0 && TryReadDecimal(markupbox, out markup))
            {
                ShowPriceFromCostAndMarkup();
                return;
            }

            ShowMarkupFromCostAndPrice();
        }

        private void markupbox_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(markupbox, string.Empty);
            if (isCalculating || !markupbox.Focused)
            {
                return;
            }

            ShowPriceFromCostAndMarkup();
        }

        private void label11_Click(object sender, EventArgs e)
        {
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                MessageBox.Show(
                    "Some fields still need attention. Fix the items marked with an error icon, then save again.",
                    "Cannot save",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            decimal cost = ReadDecimal(costbox);
            decimal price = ReadDecimal(pricebox);
            decimal markup = CalculateMarkup(cost, price);

            isCalculating = true;
            costbox.Text = FormatMoney(cost);
            pricebox.Text = FormatMoney(price);
            markupbox.Text = FormatMoney(markup);
            isCalculating = false;

            Product product = new Product();
            product.Barcode = barcodebox.Text.Trim();
            product.Name = namebox.Text.Trim();
            product.Description = descriptionbox.Text.Trim();
            product.Category = comboBox1.Text.Trim();
            product.Origin = radioButton1.Checked ? "Local" : "Abroad";
            product.IsActive = checkBox1.Checked;
            product.Cost = cost;
            product.Price = price;
            product.MarkupPercent = markup;
            savedProducts.Add(product);

            string description = product.Description.Length == 0 ? "(none)" : product.Description;
            string status = product.IsActive ? "Active" : "Inactive";
            string message =
                "Product saved." + Environment.NewLine + Environment.NewLine +
                "Barcode: " + product.Barcode + Environment.NewLine +
                "Name: " + product.Name + Environment.NewLine +
                "Description: " + description + Environment.NewLine +
                "Category: " + product.Category + Environment.NewLine +
                "Origin: " + product.Origin + Environment.NewLine +
                "Status: " + status + Environment.NewLine +
                "Cost: " + FormatMoney(product.Cost) + Environment.NewLine +
                "Price: " + FormatMoney(product.Price) + Environment.NewLine +
                "Markup: " + FormatMoney(product.MarkupPercent) + "%" + Environment.NewLine + Environment.NewLine +
                "Markup (%) = ((Price - Cost) / Cost) x 100" + Environment.NewLine +
                "Products saved this session: " + savedProducts.Count.ToString();

            MessageBox.Show(message, "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearForm();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            if (HasUnsavedInput())
            {
                DialogResult answer = MessageBox.Show(
                    "Clear every field on the form?",
                    "Clear",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                if (answer != DialogResult.Yes)
                {
                    return;
                }
            }

            ClearForm();
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!HasUnsavedInput())
            {
                return;
            }

            DialogResult answer = MessageBox.Show(
                "Discard this entry and close the form?",
                "Cancel",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (answer != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void barcodebox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void barcodebox_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(barcodebox, string.Empty);

            string barcode = barcodebox.Text.Trim();
            if (barcode.Length == 0)
            {
                SetBarcodeStatus("Barcode is available.", SystemColors.ActiveBorder);
                return;
            }

            if (!IsAllDigits(barcode))
            {
                SetBarcodeStatus("Digits only.", Color.Firebrick);
                return;
            }

            if (barcode.Length < 4)
            {
                SetBarcodeStatus("Enter at least 4 digits.", SystemColors.ActiveBorder);
                return;
            }

            if (IsBarcodeTaken(barcode))
            {
                SetBarcodeStatus("Barcode is already used.", Color.Firebrick);
                return;
            }

            SetBarcodeStatus("Barcode is available.", SystemColors.ActiveBorder);
        }

        private void Money_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
            {
                e.KeyChar = '.';
            }

            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            TextBox box = (TextBox)sender;
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }

            if (e.KeyChar == '.' && box.Text.IndexOf('.') < 0)
            {
                return;
            }

            if (box == markupbox && e.KeyChar == '-' && box.SelectionStart == 0 && box.Text.IndexOf('-') < 0)
            {
                return;
            }

            e.Handled = true;
        }

        // Markup (%) = ((Price - Cost) / Cost) * 100
        private static decimal CalculateMarkup(decimal cost, decimal price)
        {
            return ((price - cost) / cost) * 100m;
        }

        // Price = Cost * (1 + Markup / 100)
        private static decimal CalculatePrice(decimal cost, decimal markupPercent)
        {
            return cost * (1m + (markupPercent / 100m));
        }

        private void ShowMarkupFromCostAndPrice()
        {
            decimal cost;
            decimal price;
            if (!TryReadDecimal(costbox, out cost) || !TryReadDecimal(pricebox, out price) || cost <= 0m)
            {
                if (costbox.Text.Trim().Length == 0 && pricebox.Text.Trim().Length == 0)
                {
                    isCalculating = true;
                    markupbox.Clear();
                    isCalculating = false;
                }

                return;
            }

            isCalculating = true;
            markupbox.Text = FormatMoney(CalculateMarkup(cost, price));
            isCalculating = false;
        }

        private void ShowPriceFromCostAndMarkup()
        {
            decimal cost;
            decimal markup;
            if (!TryReadDecimal(costbox, out cost) || !TryReadDecimal(markupbox, out markup) || cost < 0m)
            {
                return;
            }

            isCalculating = true;
            pricebox.Text = FormatMoney(CalculatePrice(cost, markup));
            isCalculating = false;
        }

        private bool ValidateForm()
        {
            errorProvider.Clear();
            bool isValid = true;
            Control firstInvalid = null;

            string barcode = barcodebox.Text.Trim();
            if (barcode.Length == 0)
            {
                MarkInvalid(barcodebox, "Barcode is required.", ref isValid, ref firstInvalid);
            }
            else if (!IsAllDigits(barcode) || barcode.Length < 4 || barcode.Length > 13)
            {
                MarkInvalid(barcodebox, "Barcode must be 4 to 13 digits.", ref isValid, ref firstInvalid);
            }
            else if (IsBarcodeTaken(barcode))
            {
                MarkInvalid(barcodebox, "Barcode is already used.", ref isValid, ref firstInvalid);
            }

            if (namebox.Text.Trim().Length == 0)
            {
                MarkInvalid(namebox, "Name is required.", ref isValid, ref firstInvalid);
            }

            if (comboBox1.Text.Trim().Length == 0)
            {
                MarkInvalid(comboBox1, "Select a category.", ref isValid, ref firstInvalid);
            }

            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MarkInvalid(groupBox1, "Select Local or Abroad.", ref isValid, ref firstInvalid);
            }

            decimal cost;
            if (!TryReadDecimal(costbox, out cost))
            {
                MarkInvalid(costbox, "Enter a valid cost.", ref isValid, ref firstInvalid);
            }
            else if (cost <= 0m)
            {
                MarkInvalid(costbox, "Cost must be greater than zero.", ref isValid, ref firstInvalid);
            }

            decimal price;
            if (!TryReadDecimal(pricebox, out price))
            {
                MarkInvalid(pricebox, "Enter a valid price.", ref isValid, ref firstInvalid);
            }
            else if (price < 0m)
            {
                MarkInvalid(pricebox, "Price cannot be negative.", ref isValid, ref firstInvalid);
            }

            if (!isValid)
            {
                if (firstInvalid == groupBox1)
                {
                    radioButton1.Focus();
                }
                else if (firstInvalid != null)
                {
                    firstInvalid.Focus();
                }
            }

            return isValid;
        }

        private void MarkInvalid(Control control, string message, ref bool isValid, ref Control firstInvalid)
        {
            errorProvider.SetError(control, message);
            if (firstInvalid == null)
            {
                firstInvalid = control;
            }

            isValid = false;
        }

        private void ClearForm()
        {
            isCalculating = true;
            barcodebox.Clear();
            namebox.Clear();
            descriptionbox.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox1.Text = string.Empty;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            checkBox1.Checked = false;
            costbox.Clear();
            pricebox.Clear();
            markupbox.Clear();
            isCalculating = false;

            errorProvider.Clear();
            SetBarcodeStatus("Barcode is available.", SystemColors.ActiveBorder);
            barcodebox.Focus();
        }

        private bool HasUnsavedInput()
        {
            if (barcodebox.Text.Length > 0 || namebox.Text.Length > 0 || descriptionbox.Text.Length > 0)
            {
                return true;
            }

            if (comboBox1.Text.Trim().Length > 0 || radioButton1.Checked || radioButton2.Checked || checkBox1.Checked)
            {
                return true;
            }

            return costbox.Text.Length > 0 || pricebox.Text.Length > 0 || markupbox.Text.Length > 0;
        }

        private bool IsBarcodeTaken(string barcode)
        {
            for (int i = 0; i < savedProducts.Count; i++)
            {
                if (savedProducts[i].Barcode == barcode)
                {
                    return true;
                }
            }

            return false;
        }

        private static bool IsAllDigits(string value)
        {
            if (value.Length == 0)
            {
                return false;
            }

            for (int i = 0; i < value.Length; i++)
            {
                if (!char.IsDigit(value[i]))
                {
                    return false;
                }
            }

            return true;
        }

        private void SetBarcodeStatus(string message, Color color)
        {
            label11.Text = message;
            label11.ForeColor = color;
        }

        private static bool TryReadDecimal(TextBox box, out decimal value)
        {
            return decimal.TryParse(
                box.Text.Trim(),
                NumberStyles.Number,
                CultureInfo.InvariantCulture,
                out value);
        }

        private static decimal ReadDecimal(TextBox box)
        {
            return decimal.Parse(box.Text.Trim(), NumberStyles.Number, CultureInfo.InvariantCulture);
        }

        private static string FormatMoney(decimal value)
        {
            return value.ToString("0.00", CultureInfo.InvariantCulture);
        }

        private sealed class Product
        {
            public string Barcode { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string Category { get; set; }
            public string Origin { get; set; }
            public bool IsActive { get; set; }
            public decimal Cost { get; set; }
            public decimal Price { get; set; }
            public decimal MarkupPercent { get; set; }
        }
    }
}
