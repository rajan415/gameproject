namespace gameproject
{
    partial class game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(game));
            this.btn_spin = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_playagain = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_shoot = new System.Windows.Forms.Button();
            this.btn_shootaway = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_spin
            // 
            this.btn_spin.Location = new System.Drawing.Point(39, 103);
            this.btn_spin.Name = "btn_spin";
            this.btn_spin.Size = new System.Drawing.Size(89, 29);
            this.btn_spin.TabIndex = 0;
            this.btn_spin.Text = "spin";
            this.btn_spin.UseVisualStyleBackColor = true;
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(39, 38);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(89, 27);
            this.btn_load.TabIndex = 1;
            this.btn_load.Text = "load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_playagain
            // 
            this.btn_playagain.ForeColor = System.Drawing.Color.Black;
            this.btn_playagain.Location = new System.Drawing.Point(564, 390);
            this.btn_playagain.Name = "btn_playagain";
            this.btn_playagain.Size = new System.Drawing.Size(75, 28);
            this.btn_playagain.TabIndex = 2;
            this.btn_playagain.Text = "play again";
            this.btn_playagain.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(658, 390);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 28);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // btn_shoot
            // 
            this.btn_shoot.Location = new System.Drawing.Point(39, 181);
            this.btn_shoot.Name = "btn_shoot";
            this.btn_shoot.Size = new System.Drawing.Size(89, 30);
            this.btn_shoot.TabIndex = 4;
            this.btn_shoot.Text = "shoot";
            this.btn_shoot.UseVisualStyleBackColor = true;
            // 
            // btn_shootaway
            // 
            this.btn_shootaway.Location = new System.Drawing.Point(39, 251);
            this.btn_shootaway.Name = "btn_shootaway";
            this.btn_shootaway.Size = new System.Drawing.Size(89, 28);
            this.btn_shootaway.TabIndex = 5;
            this.btn_shootaway.Text = "shoot away";
            this.btn_shootaway.UseVisualStyleBackColor = true;
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.btn_shootaway);
            this.Controls.Add(this.btn_shoot);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_playagain);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_spin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "game";
            this.Text = " ";
            this.Load += new System.EventHandler(this.game_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_spin;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_playagain;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_shoot;
        private System.Windows.Forms.Button btn_shootaway;
    }
}

