namespace DinerMenu
{
    partial class DinerMenu
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
            ExitButton = new Button();
            SoupButton = new Button();
            ChefSpecialButton = new Button();
            FishButton = new Button();
            DinerNameLabel = new Label();
            toolTip1 = new ToolTip(components);
            DisplayItemLabel = new Label();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Font = new Font("Times New Roman", 10F);
            ExitButton.Location = new Point(764, 393);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(155, 68);
            ExitButton.TabIndex = 0;
            ExitButton.Text = "E&xit";
            toolTip1.SetToolTip(ExitButton, "Closes The Program");
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // SoupButton
            // 
            SoupButton.Font = new Font("Times New Roman", 10F);
            SoupButton.Location = new Point(12, 393);
            SoupButton.Name = "SoupButton";
            SoupButton.Size = new Size(155, 68);
            SoupButton.TabIndex = 0;
            SoupButton.Text = "&Soup";
            toolTip1.SetToolTip(SoupButton, "Displays The Soup Of The Day");
            SoupButton.UseVisualStyleBackColor = true;
            SoupButton.Click += SoupButton_Click;
            // 
            // ChefSpecialButton
            // 
            ChefSpecialButton.Font = new Font("Times New Roman", 10F);
            ChefSpecialButton.Location = new Point(173, 393);
            ChefSpecialButton.Name = "ChefSpecialButton";
            ChefSpecialButton.Size = new Size(155, 68);
            ChefSpecialButton.TabIndex = 0;
            ChefSpecialButton.Text = "&Chef's Special";
            toolTip1.SetToolTip(ChefSpecialButton, "Displays The Chef's Special");
            ChefSpecialButton.UseVisualStyleBackColor = true;
            ChefSpecialButton.Click += ChefSpecialButton_Click;
            // 
            // FishButton
            // 
            FishButton.Font = new Font("Times New Roman", 10F);
            FishButton.Location = new Point(334, 393);
            FishButton.Name = "FishButton";
            FishButton.Size = new Size(155, 68);
            FishButton.TabIndex = 0;
            FishButton.Text = "&Fish";
            toolTip1.SetToolTip(FishButton, "Displays The Fish Special");
            FishButton.UseVisualStyleBackColor = true;
            FishButton.Click += FishButton_Click;
            // 
            // DinerNameLabel
            // 
            DinerNameLabel.AutoSize = true;
            DinerNameLabel.Font = new Font("Times New Roman", 20F);
            DinerNameLabel.Location = new Point(379, 9);
            DinerNameLabel.Name = "DinerNameLabel";
            DinerNameLabel.Size = new Size(126, 39);
            DinerNameLabel.TabIndex = 1;
            DinerNameLabel.Text = "X Diner";
            // 
            // DisplayItemLabel
            // 
            DisplayItemLabel.Font = new Font("Times New Roman", 15F);
            DisplayItemLabel.Location = new Point(12, 48);
            DisplayItemLabel.Name = "DisplayItemLabel";
            DisplayItemLabel.Size = new Size(907, 342);
            DisplayItemLabel.TabIndex = 2;
            DisplayItemLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DinerMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 482);
            Controls.Add(DisplayItemLabel);
            Controls.Add(DinerNameLabel);
            Controls.Add(FishButton);
            Controls.Add(ChefSpecialButton);
            Controls.Add(SoupButton);
            Controls.Add(ExitButton);
            Name = "DinerMenu";
            Text = "DinerMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ExitButton;
        private Button SoupButton;
        private Button ChefSpecialButton;
        private Button FishButton;
        private Label DinerNameLabel;
        private ToolTip toolTip1;
        private Label DisplayItemLabel;
    }
}
