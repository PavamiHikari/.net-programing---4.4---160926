namespace _4._4
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
            groupBox1 = new GroupBox();
            btnAdd = new Button();
            lstMenu = new ListBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            lblTotal = new Label();
            btnRemove = new Button();
            lstSelected = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(lstMenu);
            groupBox1.Location = new Point(0, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(408, 408);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Menu";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(312, 152);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = ">>>";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lstMenu
            // 
            lstMenu.BackColor = Color.FromArgb(255, 224, 192);
            lstMenu.FormattingEnabled = true;
            lstMenu.Location = new Point(0, 24);
            lstMenu.Name = "lstMenu";
            lstMenu.Size = new Size(304, 344);
            lstMenu.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(800, 46);
            label1.TabIndex = 1;
            label1.Text = "ĐẶT HÀNG";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblTotal);
            groupBox2.Controls.Add(btnRemove);
            groupBox2.Controls.Add(lstSelected);
            groupBox2.Location = new Point(408, 48);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(392, 400);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Đang chọn";
            // 
            // lblTotal
            // 
            lblTotal.BackColor = Color.FromArgb(192, 255, 255);
            lblTotal.Dock = DockStyle.Bottom;
            lblTotal.Font = new Font("Segoe UI", 13F);
            lblTotal.Location = new Point(3, 372);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(386, 25);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "0";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(0, 184);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 2;
            btnRemove.Text = "<<<";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // lstSelected
            // 
            lstSelected.BackColor = Color.FromArgb(255, 255, 192);
            lstSelected.FormattingEnabled = true;
            lstSelected.Location = new Point(104, 24);
            lstSelected.Name = "lstSelected";
            lstSelected.Size = new Size(288, 344);
            lstSelected.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Đặt hàng";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnAdd;
        private ListBox lstMenu;
        private ListBox lstSelected;
        private Label lblTotal;
        private Button btnRemove;
    }
}
