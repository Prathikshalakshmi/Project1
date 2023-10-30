using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace Project1
{
    public partial class Dashboard : System.Web.UI.Page
    {
        private readonly object lblMessage;
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            // Sign the user out
            System.Web.Security.FormsAuthentication.SignOut();
            // Redirect to the login page or any other desired page
            Response.Redirect("Login.aspx");
        }
        protected void btnRedirect_Click(object sender, EventArgs e)
        {
            // Get the selected option from the dropdown.
            string selectedValue = ddlTemplates.SelectedValue;
            if (!string.IsNullOrEmpty(selectedValue))
            {
                // Redirect to the selected page.
                Response.Redirect(selectedValue);
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // You can perform any initialization here.
            }
        }
        protected void btnUpload_Click(object sender, EventArgs e)
        {
            if (fileUpload.HasFile)
            {
                try
                {
                    // Get the uploaded file's content.
                    Stream stream = fileUpload.PostedFile.InputStream;
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        // Create a DataTable to hold the CSV data.
                        DataTable dt = new DataTable();
                        bool firstRow = true;
                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            string[] values = line.Split(',');
                            if (firstRow)
                            {
                                // Create columns based on the first row of the CSV.
                                foreach (var value in values)
                                {
                                    dt.Columns.Add(value);
                                }
                                firstRow = false;
                            }
                            else
                            {
                                // Add data rows to the DataTable.
                                DataRow row = dt.NewRow();
                                for (int i = 0; i < values.Length; i++)
                                {
                                    row[i] = values[i];
                                }
                                dt.Rows.Add(row);
                            }
                        }
                        // Bind the DataTable to the GridView.
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions (e.g., invalid CSV format).
                    Response.Write("Error: " + ex.Message);
                }
            }
        }
    }
}
