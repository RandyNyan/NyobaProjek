namespace PBO_Gymly
{
    partial class AddFasilitasGym
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFasilitasGym));
            ButtonCancel = new Button();
            ButtonAdd = new Button();
            SuspendLayout();
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
            ButtonCancel.TabIndex = 0;
            ButtonCancel.Text = "Cancel";
            ButtonCancel.UseVisualStyleBackColor = true;
            ButtonCancel.Click += ButtonCancel_Click_1;
            // 
            // ButtonAdd
            // 
            ButtonAdd.BackColor = Color.FromArgb(127, 200, 248);
            ButtonAdd.FlatAppearance.BorderSize = 0;
            ButtonAdd.FlatStyle = FlatStyle.Flat;
            ButtonAdd.Font = new Font("Anton", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonAdd.ForeColor = Color.FromArgb(249, 249, 249);
            ButtonAdd.Location = new Point(325, 402);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new Size(63, 36);
            ButtonAdd.TabIndex = 1;
            ButtonAdd.Text = "Add";
            ButtonAdd.UseVisualStyleBackColor = true;
            ButtonAdd.Click += ButtonAdd_Click;
            // 
            // AddFasilitasGym
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(400, 450);
            Controls.Add(ButtonAdd);
            Controls.Add(ButtonCancel);
            Name = "AddFasilitasGym";
            Text = "AddFasilitasGym";
            ResumeLayout(false);
        }

        #endregion

        private Button ButtonCancel;
        private Button ButtonAdd;
    }
}