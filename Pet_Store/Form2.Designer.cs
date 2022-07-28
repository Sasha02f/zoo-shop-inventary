
namespace Pet_Store
{
    partial class Form2
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
            this.number = new System.Windows.Forms.NumericUpDown();
            this.category = new System.Windows.Forms.NumericUpDown();
            this.price = new System.Windows.Forms.NumericUpDown();
            this.producer = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.price)).BeginInit();
            this.SuspendLayout();
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(102, 73);
            this.number.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(117, 27);
            this.number.TabIndex = 0;
            // 
            // category
            // 
            this.category.Location = new System.Drawing.Point(102, 7);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(117, 27);
            this.category.TabIndex = 1;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(102, 106);
            this.price.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(117, 27);
            this.price.TabIndex = 2;
            // 
            // producer
            // 
            this.producer.Location = new System.Drawing.Point(102, 138);
            this.producer.Name = "producer";
            this.producer.Size = new System.Drawing.Size(117, 27);
            this.producer.TabIndex = 3;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(102, 39);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(117, 27);
            this.name.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Producer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "CategoryID";
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(53, 218);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(140, 35);
            this.edit.TabIndex = 25;
            this.edit.Text = "Змінити";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 281);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.producer);
            this.Controls.Add(this.price);
            this.Controls.Add(this.category);
            this.Controls.Add(this.number);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.category)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown number;
        private System.Windows.Forms.NumericUpDown category;
        private System.Windows.Forms.NumericUpDown price;
        private System.Windows.Forms.TextBox producer;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button edit;
    }
}