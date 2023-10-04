using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TechTestQ1
{
    public partial class GetBanana : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void displayBtn_Click(object sender, EventArgs e)
        {
            // Get the uploaded file.
            HttpPostedFile postedFile = bananatxt.PostedFile;

            // Save the uploaded file to the server.
            string filePath = Server.MapPath("~/Fruits and Veggies.txt");
            postedFile.SaveAs(filePath);

            // Read the text file.
            string[] lines = File.ReadAllLines(filePath);

            // Create a table to store the text file contents.
            Table table = new Table();
            table.BorderStyle = BorderStyle.Solid;
            table.BorderColor = Color.Black;
            table.BorderWidth = 1;

            // Add a header row to the table.
            TableRow headerRow = new TableRow();
            headerRow.Cells.Add(new TableCell() { Text = "No", BorderStyle = BorderStyle.Solid, BorderColor = Color.Black, BorderWidth = 1 });
            headerRow.Cells.Add(new TableCell() { Text = "Name", BorderStyle = BorderStyle.Solid, BorderColor = Color.Black, BorderWidth = 1 });
            headerRow.Cells.Add(new TableCell() { Text = "Type", BorderStyle = BorderStyle.Solid, BorderColor = Color.Black, BorderWidth = 1 });
            table.Rows.Add(headerRow);

            // Add the text file contents to the table.
            foreach (string line in lines)
            {
                // Split the text file line into different columns.
                string[] columns = line.Split(',');

                // Create a new table row.
                TableRow row = new TableRow();

                // Add the columns to the table row.
                foreach (string column in columns)
                {
                    TableCell cell = new TableCell() { Text = column };

                    // Add a border to the bottom of the table cell.
                    cell.BorderStyle = BorderStyle.Solid;
                    cell.BorderColor = Color.Black;
                    cell.BorderWidth = 1;

                    row.Cells.Add(cell);


                }
              

                // Add the table row to the table.
                table.Rows.Add(row);

            }

            // Add the table to the page.
            PlaceHolder1.Controls.Add(table);
        }
        
    }
}