using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            try
            {
                this.productsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.northwindDataSet);
            }
            // If two users try to do the similar task at the same time, this catch will give the concurrency error.
            catch (DBConcurrencyException)
            {
                MessageBox.Show("Two users are trying to attempt the similar task.", "Concurrency Error");
                // refresh dataset to save the change and then try to make the change again
                this.productsTableAdapter.Fill(this.northwindDataSet.Products);
                Form1_Load(sender, e); // redirects the form back to main form
            }
            // Any sql exception such as trying to delete the 
            catch (SqlException ex) // any exception from the provider
            {
                MessageBox.Show("Database error while saving: " + ex.Message, ex.GetType().ToString());
                Form1_Load(sender, e);
            }
            // Avoid any exceptions while loading the data
            catch (Exception ex)
            {
                MessageBox.Show("Unanticipated error while loading data: " + ex.Message, ex.GetType().ToString());
                Form1_Load(sender, e);
            }
            // Turn the add button back to enable
            finally
            {
                bindingNavigatorAddNewItem.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.northwindDataSet.Categories);
            // TODO: This line of code loads data into the 'northwindDataSet.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.northwindDataSet.Suppliers);
            // TODO: This line of code loads data into the 'northwindDataSet.Order_Details' table. You can move, or remove it, as needed.
            this.order_DetailsTableAdapter.Fill(this.northwindDataSet.Order_Details);
            // TODO: This line of code loads data into the 'northwindDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.northwindDataSet.Products);

        }

        // When add button clicked, disable it until save button is clicked.
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem.Enabled = false;
        }
    }
}
