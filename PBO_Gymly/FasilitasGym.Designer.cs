namespace PBO_Gymly
{
    partial class FasilitasGym
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FasilitasGym));
            ButtonBack = new Button();
            ButtonAddFasilitasGym = new Button();
            SuspendLayout();
            // 
            // ButtonBack
            // 
            ButtonBack.BackColor = Color.FromArgb(127, 200, 248);
            ButtonBack.FlatAppearance.BorderSize = 0;
            ButtonBack.FlatStyle = FlatStyle.Flat;
            ButtonBack.Font = new Font("Anton", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonBack.ForeColor = Color.FromArgb(249, 249, 249);
            ButtonBack.Location = new Point(20, 387);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(60, 30);
            ButtonBack.TabIndex = 0;
            ButtonBack.Text = "Back";
            ButtonBack.UseVisualStyleBackColor = true;
            ButtonBack.Click += ButtonBack_Click;
            // 
            // ButtonAddFasilitasGym
            // 
            ButtonAddFasilitasGym.BackColor = Color.FromArgb(127, 200, 248);
            ButtonAddFasilitasGym.FlatAppearance.BorderSize = 0;
            ButtonAddFasilitasGym.FlatStyle = FlatStyle.Flat;
            ButtonAddFasilitasGym.Font = new Font("Anton", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonAddFasilitasGym.ForeColor = Color.FromArgb(249, 249, 249);
            ButtonAddFasilitasGym.Location = new Point(710, 387);
            ButtonAddFasilitasGym.Name = "ButtonAddFasilitasGym";
            ButtonAddFasilitasGym.Size = new Size(60, 30);
            ButtonAddFasilitasGym.TabIndex = 1;
            ButtonAddFasilitasGym.Text = "Add";
            ButtonAddFasilitasGym.UseVisualStyleBackColor = true;
            ButtonAddFasilitasGym.Click += ButtonAddFasilitasGym_Click;
            // 
            // FasilitasGym
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonAddFasilitasGym);
            Controls.Add(ButtonBack);
            Name = "FasilitasGym";
            Text = "FasilitasGym";
            ResumeLayout(false);
        }

        #endregion

        private Button ButtonBack;
        private Button ButtonAddFasilitasGym;
    }
}