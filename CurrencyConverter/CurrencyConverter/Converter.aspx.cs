using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CurrencyConverter
{
    public partial class Converter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Please enter value greater than 0!')", true);
            }
            else
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(TextBox1.Text,
                                                  "^[0-9]+\\.?[0-9]*$"))
                {
                    if (DropDownList1.Text == "0")
                    {
                        if (DropDownList2.Text == "1")
                        {
                            TextBox2.Text = (0.96 * Convert.ToDouble(TextBox1.Text)).ToString();
                        }
                        if (DropDownList2.Text == "2")
                        {
                            TextBox2.Text = (117.92 * Convert.ToDouble(TextBox1.Text)).ToString();
                        }
                        if (DropDownList2.Text == "3")
                        {
                            TextBox2.Text = (1.876 * Convert.ToDouble(TextBox1.Text)).ToString();
                        }
                    }

                    if (DropDownList1.Text == "1")
                    {
                        if (DropDownList2.Text == "0")
                        {
                            TextBox2.Text = (Convert.ToDouble(TextBox1.Text) / 0.96).ToString();
                        }
                        if (DropDownList2.Text == "2")
                        {
                            TextBox2.Text = (122.83 * Convert.ToDouble(TextBox1.Text)).ToString();
                        }
                        if (DropDownList2.Text == "3")
                        {
                            TextBox2.Text = (1.954 * Convert.ToDouble(TextBox1.Text)).ToString();
                        }
                    }

                    if (DropDownList1.Text == "2")
                    {
                        if (DropDownList2.Text == "0")
                        {
                            TextBox2.Text = (Convert.ToDouble(TextBox1.Text) / 117.92).ToString();
                        }
                        if (DropDownList2.Text == "3")
                        {
                            TextBox2.Text = (117.92 * (Convert.ToDouble(TextBox1.Text) / 1.876)).ToString();
                        }
                        if (DropDownList2.Text == "1")
                        {
                            TextBox2.Text = (0.96 * (Convert.ToDouble(TextBox1.Text) / 122.83)).ToString();
                        }
                    }

                    if (DropDownList1.Text == "3")
                    {
                        if (DropDownList2.Text == "0")
                        {
                            TextBox2.Text = (Convert.ToDouble(TextBox1.Text) / 1.876).ToString();
                        }
                        if (DropDownList2.Text == "2")
                        {
                            TextBox2.Text = (122.83 * Convert.ToDouble(TextBox1.Text) / 1.954).ToString();
                        }
                        if (DropDownList2.Text == "1")
                        {
                            TextBox2.Text = (Convert.ToDouble(TextBox1.Text) / 1.954).ToString();
                        }
                    }
                }
                else
                    Response.Write("Enter only numbers");
            }
            if (DropDownList1.Text == DropDownList2.Text)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Input & Output Currency should not be same!')", true);
            }
        }
    }
}