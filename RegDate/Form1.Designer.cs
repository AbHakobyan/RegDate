
namespace RegDate
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPaymentDay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btMutq = new System.Windows.Forms.Button();
            this.btXmbagrel = new System.Windows.Forms.Button();
            this.btJnjel = new System.Windows.Forms.Button();
            this.btToxerJnjel = new System.Windows.Forms.Button();
            this.txtFnameFiltr = new System.Windows.Forms.TextBox();
            this.btFiltr = new System.Windows.Forms.Button();
            this.btSearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Անուն";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(195, 39);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(229, 28);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ազգանուն";
            // 
            // txtSname
            // 
            this.txtSname.Location = new System.Drawing.Point(195, 80);
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(229, 28);
            this.txtSname.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 35);
            this.label3.TabIndex = 0;
            this.label3.Text = "Էլ․Հասցե";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(195, 118);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(229, 28);
            this.txtEmail.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 35);
            this.label4.TabIndex = 0;
            this.label4.Text = "Վճարման օրը";
            // 
            // txtPaymentDay
            // 
            this.txtPaymentDay.Location = new System.Drawing.Point(195, 164);
            this.txtPaymentDay.Name = "txtPaymentDay";
            this.txtPaymentDay.Size = new System.Drawing.Size(229, 28);
            this.txtPaymentDay.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(435, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 35);
            this.label5.TabIndex = 0;
            this.label5.Text = "Տարիք";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(537, 46);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(222, 28);
            this.txtAge.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(782, 231);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btMutq
            // 
            this.btMutq.Location = new System.Drawing.Point(435, 80);
            this.btMutq.Name = "btMutq";
            this.btMutq.Size = new System.Drawing.Size(110, 47);
            this.btMutq.TabIndex = 3;
            this.btMutq.Text = "Մուտք";
            this.btMutq.UseVisualStyleBackColor = true;
            this.btMutq.Click += new System.EventHandler(this.button1_Click);
            // 
            // btXmbagrel
            // 
            this.btXmbagrel.Location = new System.Drawing.Point(435, 133);
            this.btXmbagrel.Name = "btXmbagrel";
            this.btXmbagrel.Size = new System.Drawing.Size(110, 47);
            this.btXmbagrel.TabIndex = 3;
            this.btXmbagrel.Text = "Խմբագրել";
            this.btXmbagrel.UseVisualStyleBackColor = true;
            this.btXmbagrel.Click += new System.EventHandler(this.btXmbagrel_Click);
            // 
            // btJnjel
            // 
            this.btJnjel.Location = new System.Drawing.Point(551, 80);
            this.btJnjel.Name = "btJnjel";
            this.btJnjel.Size = new System.Drawing.Size(110, 47);
            this.btJnjel.TabIndex = 3;
            this.btJnjel.Text = "Ջնջել";
            this.btJnjel.UseVisualStyleBackColor = true;
            this.btJnjel.Click += new System.EventHandler(this.btJnjel_Click);
            // 
            // btToxerJnjel
            // 
            this.btToxerJnjel.Location = new System.Drawing.Point(551, 133);
            this.btToxerJnjel.Name = "btToxerJnjel";
            this.btToxerJnjel.Size = new System.Drawing.Size(110, 47);
            this.btToxerJnjel.TabIndex = 3;
            this.btToxerJnjel.Text = "Տողերը ջնջել";
            this.btToxerJnjel.UseVisualStyleBackColor = true;
            this.btToxerJnjel.Click += new System.EventHandler(this.btToxerJnjel_Click);
            // 
            // txtFnameFiltr
            // 
            this.txtFnameFiltr.Location = new System.Drawing.Point(963, 46);
            this.txtFnameFiltr.Name = "txtFnameFiltr";
            this.txtFnameFiltr.Size = new System.Drawing.Size(222, 28);
            this.txtFnameFiltr.TabIndex = 1;
            // 
            // btFiltr
            // 
            this.btFiltr.BackColor = System.Drawing.Color.Lime;
            this.btFiltr.Image = ((System.Drawing.Image)(resources.GetObject("btFiltr.Image")));
            this.btFiltr.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btFiltr.Location = new System.Drawing.Point(1008, 118);
            this.btFiltr.Name = "btFiltr";
            this.btFiltr.Size = new System.Drawing.Size(131, 47);
            this.btFiltr.TabIndex = 3;
            this.btFiltr.Text = "Որոնել";
            this.btFiltr.UseVisualStyleBackColor = false;
            this.btFiltr.Click += new System.EventHandler(this.btFiltr_Click);
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(667, 108);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(121, 47);
            this.btSearch.TabIndex = 3;
            this.btSearch.Text = "Բացել Ֆիլտրը";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(869, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 35);
            this.label6.TabIndex = 0;
            this.label6.Text = " Անուն ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.btXmbagrel);
            this.Controls.Add(this.btFiltr);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.btToxerJnjel);
            this.Controls.Add(this.btJnjel);
            this.Controls.Add(this.btMutq);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtPaymentDay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFnameFiltr);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPaymentDay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btMutq;
        private System.Windows.Forms.Button btXmbagrel;
        private System.Windows.Forms.Button btJnjel;
        private System.Windows.Forms.Button btToxerJnjel;
        private System.Windows.Forms.TextBox txtFnameFiltr;
        private System.Windows.Forms.Button btFiltr;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Label label6;
    }
}

