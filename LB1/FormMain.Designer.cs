namespace LB1
{
    partial class FormMain
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
            panelTop = new Panel();
            labelUsers = new Label();
            panel1 = new Panel();
            labelInfAboutUsers = new Label();
            panelTop.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(labelUsers);
            panelTop.Dock = DockStyle.Top;
            panelTop.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(10);
            panelTop.Size = new Size(684, 80);
            panelTop.TabIndex = 0;
            // 
            // labelUsers
            // 
            labelUsers.Dock = DockStyle.Fill;
            labelUsers.ImageAlign = ContentAlignment.TopRight;
            labelUsers.Location = new Point(10, 10);
            labelUsers.Name = "labelUsers";
            labelUsers.Size = new Size(664, 60);
            labelUsers.TabIndex = 0;
            labelUsers.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelInfAboutUsers);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 80);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(684, 481);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // labelInfAboutUsers
            // 
            labelInfAboutUsers.Dock = DockStyle.Fill;
            labelInfAboutUsers.Font = new Font("Segoe UI", 14F);
            labelInfAboutUsers.Location = new Point(10, 10);
            labelInfAboutUsers.Name = "labelInfAboutUsers";
            labelInfAboutUsers.Size = new Size(664, 461);
            labelInfAboutUsers.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(684, 561);
            Controls.Add(panel1);
            Controls.Add(panelTop);
            Name = "FormMain";
            Text = "Пользователи";
            Load += Form1_Load;
            panelTop.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Label labelUsers;
        private Panel panel1;
        private Label labelInfAboutUsers;
    }
}
