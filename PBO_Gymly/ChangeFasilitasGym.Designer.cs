namespace PBO_Gymly
{
    partial class ChangeFasilitasGym
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeFasilitasGym));
            ButtonChange = new Button();
            ButtonCancel = new Button();
            SuspendLayout();
            // 
            // ButtonChange
            // 
            ButtonChange.BackColor = Color.FromArgb(127, 200, 248);
            ButtonChange.FlatAppearance.BorderSize = 0;
            ButtonChange.FlatStyle = FlatStyle.Flat;
            ButtonChange.Font = new Font("Anton", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonChange.ForeColor = Color.FromArgb(249, 249, 249);
            ButtonChange.Location = new Point(325, 402);
            ButtonChange.Name = "ButtonChange";
            ButtonChange.Size = new Size(63, 36);
            ButtonChange.TabIndex = 3;
            ButtonChange.Text = "Change";
            ButtonChange.UseVisualStyleBackColor = true;
            ButtonChange.Click += ButtonChange_Click;
            // 
            // ButtonCancel
            // 
            ButtonCancel.BackColor = Color.FromArgb(127, 200, 248);
            ButtonCancel.FlatAppearance.BorderSize = 0;
            ButtonCancel.FlatStyle = FlatStyle.Flat;
            ButtonCancel.Font = new Font("Anton", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonCancel.ForeColor = Color.FromArgb(249, 249, 249);
            ButtonCancel.Location = new Point(256, 402);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(63, 36);
            ButtonCancel.TabIndex = 2;
            ButtonCancel.Text = "Cancel";
            ButtonCancel.UseVisualStyleBackColor = true;
            ButtonCancel.Click += ButtonCancel_Click;
            // 
            // ChangeFasilitasGym
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(400, 450);
            Controls.Add(ButtonChange);
            Controls.Add(ButtonCancel);
            Name = "ChangeFasilitasGym";
            Text = "ChangeFasilitasGym";
            ResumeLayout(false);
        }

        #endregion

        private Button ButtonChange;
        private Button ButtonCancel;
    }
}