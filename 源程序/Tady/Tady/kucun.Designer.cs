namespace Tady
{
    partial class kucun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kucun));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.factoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tadyDataSet21 = new Tady.TadyDataSet21();
            this.tadyDataSet = new Tady.TadyDataSet();
            this.tadyDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.factoryTableAdapter = new Tady.TadyDataSet21TableAdapters.FactoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.factoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tadyDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tadyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tadyDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(30, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "产品编号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(30, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "产品名称";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(30, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 14);
            this.label5.TabIndex = 6;
            this.label5.Text = "产品单价";
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(110, 71);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(127, 21);
            this.tb1.TabIndex = 9;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(110, 111);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(127, 21);
            this.tb2.TabIndex = 10;
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(110, 159);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(127, 21);
            this.tb3.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(30, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 14);
            this.label1.TabIndex = 15;
            this.label1.Text = "企业编码";
            // 
            // cb1
            // 
            this.cb1.DataSource = this.factoryBindingSource;
            this.cb1.DisplayMember = "Factory_ID";
            this.cb1.FormattingEnabled = true;
            this.cb1.Location = new System.Drawing.Point(110, 29);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(127, 20);
            this.cb1.TabIndex = 16;
            this.cb1.ValueMember = "Factory_ID";
            // 
            // factoryBindingSource
            // 
            this.factoryBindingSource.DataMember = "Factory";
            this.factoryBindingSource.DataSource = this.tadyDataSet21;
            // 
            // tadyDataSet21
            // 
            this.tadyDataSet21.DataSetName = "TadyDataSet21";
            this.tadyDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tadyDataSet
            // 
            this.tadyDataSet.DataSetName = "TadyDataSet";
            this.tadyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tadyDataSetBindingSource
            // 
            this.tadyDataSetBindingSource.DataSource = this.tadyDataSet;
            this.tadyDataSetBindingSource.Position = 0;
            // 
            // factoryTableAdapter
            // 
            this.factoryTableAdapter.ClearBeforeFill = true;
            // 
            // kucun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(299, 268);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "kucun";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加";
            this.Load += new System.EventHandler(this.kucun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.factoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tadyDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tadyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tadyDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.BindingSource tadyDataSetBindingSource;
        private TadyDataSet tadyDataSet;
        private TadyDataSet21 tadyDataSet21;
        private System.Windows.Forms.BindingSource factoryBindingSource;
        private TadyDataSet21TableAdapters.FactoryTableAdapter factoryTableAdapter;
    }
}