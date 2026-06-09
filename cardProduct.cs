using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Project1
{
    public partial class cardProduct : UserControl
    {
        public cardProduct()
        {
            InitializeComponent();
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int id { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string productId { get; set; }

        [Category("Product")]
        [Description("The display name of the product.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string productName
        {
            get
            {
                return productname != null ? productname.Text : string.Empty;
            }
            set
            {
                if (productname != null) productname.Text = value;
            }
        }

        [Category("Product")]
        [Description("Available stock for the product.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string productStock
        {
            get
            {
                return stock != null ? stock.Text : "0";
            }
            set
            {
                if (stock != null) stock.Text = value;
            }
        }

        [Category("Product")]
        [Description("Formatted price text for the product.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string productPrice
        {
            get
            {
                return price != null ? price.Text : "0.00";
            }
            set
            {
                if (price != null) price.Text = value;
            }
        }

        [Category("Product")]
        [Description("Image shown for the product.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Image productImage
        {
            get
            {
                return pictureBox1 != null ? pictureBox1.Image : null;
            }
            set
            {
                if (pictureBox1 != null) pictureBox1.Image = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Category { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string productQuantity
        {
            get
            {
                return quantity != null ? quantity.Text : "0";
            }

            set
            {
                if (quantity != null) quantity.Text = value;
            }
        }

        public event EventHandler selectedCard = null;
        private void add_btn_Click(object sender, EventArgs e)
        {
            selectedCard?.Invoke(this, EventArgs.Empty);
        }
    }
}
