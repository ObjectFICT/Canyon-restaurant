namespace Project_restaurant
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.orderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.orderoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderoneBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.orderoneBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.orderoneBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.orderoneBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.orderoneBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet2 = new Project_restaurant.Database1DataSet2();
            this.orderoneBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.order_oneTableAdapter = new Project_restaurant.Database1DataSet2TableAdapters.Order_oneTableAdapter();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderoneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderoneBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderoneBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderoneBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderoneBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderoneBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderoneBindingSource6)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.button1.Font = new System.Drawing.Font("Mistral", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Aqua;
            this.button1.Location = new System.Drawing.Point(268, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 61);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cook dish";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // database1DataSet2
            // 
            this.database1DataSet2.DataSetName = "Database1DataSet2";
            this.database1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderoneBindingSource6
            // 
            this.orderoneBindingSource6.DataMember = "Order_one";
            this.orderoneBindingSource6.DataSource = this.database1DataSet2;
            // 
            // order_oneTableAdapter
            // 
            this.order_oneTableAdapter.ClearBeforeFill = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(268, 89);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(242, 264);
            this.listBox1.TabIndex = 9;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form4";
            this.Text = "Кухня";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderoneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderoneBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderoneBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderoneBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderoneBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderoneBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderoneBindingSource6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource orderBindingSource1;
        private System.Windows.Forms.BindingSource orderoneBindingSource;
        private System.Windows.Forms.BindingSource orderoneBindingSource1;
        private System.Windows.Forms.BindingSource orderoneBindingSource2;
        private System.Windows.Forms.BindingSource orderoneBindingSource3;
        private System.Windows.Forms.BindingSource orderoneBindingSource4;
        private System.Windows.Forms.BindingSource orderoneBindingSource5;
        private Database1DataSet2 database1DataSet2;
        private System.Windows.Forms.BindingSource orderoneBindingSource6;
        private Database1DataSet2TableAdapters.Order_oneTableAdapter order_oneTableAdapter;
        private System.Windows.Forms.ListBox listBox1;
    }
}