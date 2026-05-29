namespace PetApp
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
            components = new System.ComponentModel.Container();
            gameTimer = new System.Windows.Forms.Timer(components);
            lblStatus = new Label();
            btnFeed = new Button();
            btnPet = new Button();
            btnTick = new Button();
            picPet = new PictureBox();
            txtName = new TextBox();
            btnSetName = new Button();
            ((System.ComponentModel.ISupportInitialize)picPet).BeginInit();
            SuspendLayout();
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 7000;
            gameTimer.Tick += gameTimer_Tick;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(12, 63);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(60, 25);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Status";
            // 
            // btnFeed
            // 
            btnFeed.Location = new Point(12, 91);
            btnFeed.Name = "btnFeed";
            btnFeed.Size = new Size(197, 110);
            btnFeed.TabIndex = 2;
            btnFeed.Text = "Feed";
            btnFeed.UseVisualStyleBackColor = true;
            btnFeed.Click += btnFeed_Click;
            // 
            // btnPet
            // 
            btnPet.Location = new Point(12, 208);
            btnPet.Name = "btnPet";
            btnPet.Size = new Size(197, 108);
            btnPet.TabIndex = 3;
            btnPet.Text = "Pet";
            btnPet.UseVisualStyleBackColor = true;
            btnPet.Click += btnPet_Click;
            // 
            // btnTick
            // 
            btnTick.Location = new Point(12, 328);
            btnTick.Name = "btnTick";
            btnTick.Size = new Size(197, 110);
            btnTick.TabIndex = 4;
            btnTick.Text = "Tick";
            btnTick.UseVisualStyleBackColor = true;
            btnTick.Click += btnTick_Click;
            // 
            // picPet
            // 
            picPet.Location = new Point(227, 91);
            picPet.Name = "picPet";
            picPet.Size = new Size(538, 347);
            picPet.SizeMode = PictureBoxSizeMode.Zoom;
            picPet.TabIndex = 5;
            picPet.TabStop = false;
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 12);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 31);
            txtName.TabIndex = 6;
            // 
            // btnSetName
            // 
            btnSetName.Location = new Point(168, 9);
            btnSetName.Name = "btnSetName";
            btnSetName.Size = new Size(112, 34);
            btnSetName.TabIndex = 7;
            btnSetName.Text = "Set Name";
            btnSetName.UseVisualStyleBackColor = true;
            btnSetName.Click += btnSetName_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSetName);
            Controls.Add(txtName);
            Controls.Add(picPet);
            Controls.Add(btnTick);
            Controls.Add(btnPet);
            Controls.Add(btnFeed);
            Controls.Add(lblStatus);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picPet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private Label lblStatus;
        private Button btnFeed;
        private Button btnPet;
        private Button btnTick;
        private PictureBox picPet;
        private TextBox txtName;
        private Button btnSetName;
    }
}
