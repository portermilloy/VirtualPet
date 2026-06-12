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
            txtRoomCode = new TextBox();
            btnCreateRoom = new Button();
            btnJoinRoom = new Button();
            lblVisitor = new Label();
            picVisitor = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picPet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picVisitor).BeginInit();
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
            picPet.Size = new Size(333, 338);
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
            // txtRoomCode
            // 
            txtRoomCode.Location = new Point(477, 49);
            txtRoomCode.Name = "txtRoomCode";
            txtRoomCode.PlaceholderText = "Enter room code";
            txtRoomCode.Size = new Size(150, 31);
            txtRoomCode.TabIndex = 8;
            // 
            // btnCreateRoom
            // 
            btnCreateRoom.Location = new Point(477, 9);
            btnCreateRoom.Name = "btnCreateRoom";
            btnCreateRoom.Size = new Size(150, 34);
            btnCreateRoom.TabIndex = 9;
            btnCreateRoom.Text = "Send Pet to Visit";
            btnCreateRoom.UseVisualStyleBackColor = true;
            btnCreateRoom.Click += btnCreateRoom_Click;
            // 
            // btnJoinRoom
            // 
            btnJoinRoom.Location = new Point(359, 9);
            btnJoinRoom.Name = "btnJoinRoom";
            btnJoinRoom.Size = new Size(112, 34);
            btnJoinRoom.TabIndex = 10;
            btnJoinRoom.Text = "Accept Pet";
            btnJoinRoom.UseVisualStyleBackColor = true;
            btnJoinRoom.Click += btnJoinRoom_Click;
            // 
            // lblVisitor
            // 
            lblVisitor.AutoSize = true;
            lblVisitor.Location = new Point(633, 9);
            lblVisitor.Name = "lblVisitor";
            lblVisitor.Size = new Size(59, 25);
            lblVisitor.TabIndex = 11;
            lblVisitor.Text = "label1";
            // 
            // picVisitor
            // 
            picVisitor.Location = new Point(601, 91);
            picVisitor.Name = "picVisitor";
            picVisitor.Size = new Size(344, 338);
            picVisitor.TabIndex = 12;
            picVisitor.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 550);
            Controls.Add(picVisitor);
            Controls.Add(lblVisitor);
            Controls.Add(btnJoinRoom);
            Controls.Add(btnCreateRoom);
            Controls.Add(txtRoomCode);
            Controls.Add(btnSetName);
            Controls.Add(txtName);
            Controls.Add(picPet);
            Controls.Add(btnTick);
            Controls.Add(btnPet);
            Controls.Add(btnFeed);
            Controls.Add(lblStatus);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picPet).EndInit();
            ((System.ComponentModel.ISupportInitialize)picVisitor).EndInit();
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
        private TextBox txtRoomCode;
        private Button btnCreateRoom;
        private Button btnJoinRoom;
        private Label lblVisitor;
        private PictureBox picVisitor;
    }
}
