namespace Gestion
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
            listClients = new ListBox();
            textName = new TextBox();
            button1 = new Button();
            button2 = new Button();
            textLastName = new TextBox();
            textEmail = new TextBox();
            textPhone = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            editBtn = new Button();
            label5 = new Label();
            labelId = new Label();
            SuspendLayout();
            // 
            // listClients
            // 
            listClients.FormattingEnabled = true;
            listClients.ItemHeight = 15;
            listClients.Location = new Point(12, 31);
            listClients.Name = "listClients";
            listClients.Size = new Size(293, 364);
            listClients.TabIndex = 0;
            // 
            // textName
            // 
            textName.Location = new Point(488, 109);
            textName.Name = "textName";
            textName.Size = new Size(229, 23);
            textName.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(642, 236);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(318, 369);
            button2.Name = "button2";
            button2.Size = new Size(81, 26);
            button2.TabIndex = 3;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textLastName
            // 
            textLastName.Location = new Point(489, 156);
            textLastName.Name = "textLastName";
            textLastName.Size = new Size(228, 23);
            textLastName.TabIndex = 4;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(488, 196);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(229, 23);
            textEmail.TabIndex = 5;
            // 
            // textPhone
            // 
            textPhone.Location = new Point(489, 236);
            textPhone.Name = "textPhone";
            textPhone.Size = new Size(147, 23);
            textPhone.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(408, 106);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 7;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(408, 156);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 8;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(408, 196);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 9;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(408, 236);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 10;
            label4.Text = "Phone";
            // 
            // editBtn
            // 
            editBtn.Location = new Point(318, 324);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(75, 23);
            editBtn.TabIndex = 11;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(410, 57);
            label5.Name = "label5";
            label5.Size = new Size(26, 15);
            label5.TabIndex = 12;
            label5.Text = "Id : ";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(493, 58);
            labelId.Name = "labelId";
            labelId.Size = new Size(0, 15);
            labelId.TabIndex = 13;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelId);
            Controls.Add(label5);
            Controls.Add(editBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textPhone);
            Controls.Add(textEmail);
            Controls.Add(textLastName);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textName);
            Controls.Add(listClients);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listClients;
        private TextBox textName;
        private Button button1;
        private Button button2;
        private TextBox textLastName;
        private TextBox textEmail;
        private TextBox textPhone;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button editBtn;
        private Label label5;
        private Label labelId;
    }
}