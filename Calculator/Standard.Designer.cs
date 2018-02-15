namespace Calculator
{
    partial class Standard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Standard));
            this.num7_button = new System.Windows.Forms.Button();
            this.num8_button = new System.Windows.Forms.Button();
            this.num9_button = new System.Windows.Forms.Button();
            this.divide_button = new System.Windows.Forms.Button();
            this.clearEntry_button = new System.Windows.Forms.Button();
            this.clearAll_button = new System.Windows.Forms.Button();
            this.multiply_button = new System.Windows.Forms.Button();
            this.num6_button = new System.Windows.Forms.Button();
            this.num5_button = new System.Windows.Forms.Button();
            this.num4_button = new System.Windows.Forms.Button();
            this.subtract_button = new System.Windows.Forms.Button();
            this.num3_button = new System.Windows.Forms.Button();
            this.num2_button = new System.Windows.Forms.Button();
            this.num1_button = new System.Windows.Forms.Button();
            this.equals_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.decimal_button = new System.Windows.Forms.Button();
            this.num0_button = new System.Windows.Forms.Button();
            this.plusMinus_button = new System.Windows.Forms.Button();
            this.history_label = new System.Windows.Forms.Label();
            this.display_textBox = new System.Windows.Forms.TextBox();
            this.return_button = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.options_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.mode_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.standard_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.scientific_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // num7_button
            // 
            this.num7_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num7_button.Location = new System.Drawing.Point(34, 172);
            this.num7_button.Name = "num7_button";
            this.num7_button.Size = new System.Drawing.Size(60, 60);
            this.num7_button.TabIndex = 0;
            this.num7_button.Text = "7";
            this.num7_button.UseVisualStyleBackColor = true;
            this.num7_button.Click += new System.EventHandler(this.click_number);
            // 
            // num8_button
            // 
            this.num8_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num8_button.Location = new System.Drawing.Point(100, 172);
            this.num8_button.Name = "num8_button";
            this.num8_button.Size = new System.Drawing.Size(60, 60);
            this.num8_button.TabIndex = 1;
            this.num8_button.Text = "8";
            this.num8_button.UseVisualStyleBackColor = true;
            this.num8_button.Click += new System.EventHandler(this.click_number);
            // 
            // num9_button
            // 
            this.num9_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num9_button.Location = new System.Drawing.Point(166, 172);
            this.num9_button.Name = "num9_button";
            this.num9_button.Size = new System.Drawing.Size(60, 60);
            this.num9_button.TabIndex = 2;
            this.num9_button.Text = "9";
            this.num9_button.UseVisualStyleBackColor = true;
            this.num9_button.Click += new System.EventHandler(this.click_number);
            // 
            // divide_button
            // 
            this.divide_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide_button.Location = new System.Drawing.Point(232, 106);
            this.divide_button.Name = "divide_button";
            this.divide_button.Size = new System.Drawing.Size(60, 60);
            this.divide_button.TabIndex = 3;
            this.divide_button.Text = "/";
            this.divide_button.UseVisualStyleBackColor = true;
            this.divide_button.Click += new System.EventHandler(this.click_operation);
            // 
            // clearEntry_button
            // 
            this.clearEntry_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearEntry_button.Location = new System.Drawing.Point(34, 106);
            this.clearEntry_button.Name = "clearEntry_button";
            this.clearEntry_button.Size = new System.Drawing.Size(60, 60);
            this.clearEntry_button.TabIndex = 4;
            this.clearEntry_button.Text = " CE";
            this.clearEntry_button.UseVisualStyleBackColor = true;
            this.clearEntry_button.Click += new System.EventHandler(this.clearEntry);
            // 
            // clearAll_button
            // 
            this.clearAll_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearAll_button.Location = new System.Drawing.Point(100, 106);
            this.clearAll_button.Name = "clearAll_button";
            this.clearAll_button.Size = new System.Drawing.Size(60, 60);
            this.clearAll_button.TabIndex = 9;
            this.clearAll_button.Text = "C";
            this.clearAll_button.UseVisualStyleBackColor = true;
            this.clearAll_button.Click += new System.EventHandler(this.clearAll);
            // 
            // multiply_button
            // 
            this.multiply_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiply_button.Location = new System.Drawing.Point(232, 172);
            this.multiply_button.Name = "multiply_button";
            this.multiply_button.Size = new System.Drawing.Size(60, 60);
            this.multiply_button.TabIndex = 8;
            this.multiply_button.Text = "*";
            this.multiply_button.UseVisualStyleBackColor = true;
            this.multiply_button.Click += new System.EventHandler(this.click_operation);
            // 
            // num6_button
            // 
            this.num6_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num6_button.Location = new System.Drawing.Point(166, 238);
            this.num6_button.Name = "num6_button";
            this.num6_button.Size = new System.Drawing.Size(60, 60);
            this.num6_button.TabIndex = 7;
            this.num6_button.Text = "6";
            this.num6_button.UseVisualStyleBackColor = true;
            this.num6_button.Click += new System.EventHandler(this.click_number);
            // 
            // num5_button
            // 
            this.num5_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num5_button.Location = new System.Drawing.Point(100, 238);
            this.num5_button.Name = "num5_button";
            this.num5_button.Size = new System.Drawing.Size(60, 60);
            this.num5_button.TabIndex = 6;
            this.num5_button.Text = "5";
            this.num5_button.UseVisualStyleBackColor = true;
            this.num5_button.Click += new System.EventHandler(this.click_number);
            // 
            // num4_button
            // 
            this.num4_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num4_button.Location = new System.Drawing.Point(34, 238);
            this.num4_button.Name = "num4_button";
            this.num4_button.Size = new System.Drawing.Size(60, 60);
            this.num4_button.TabIndex = 5;
            this.num4_button.Text = "4";
            this.num4_button.UseVisualStyleBackColor = true;
            this.num4_button.Click += new System.EventHandler(this.click_number);
            // 
            // subtract_button
            // 
            this.subtract_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtract_button.Location = new System.Drawing.Point(232, 238);
            this.subtract_button.Name = "subtract_button";
            this.subtract_button.Size = new System.Drawing.Size(60, 60);
            this.subtract_button.TabIndex = 13;
            this.subtract_button.Text = "-";
            this.subtract_button.UseVisualStyleBackColor = true;
            this.subtract_button.Click += new System.EventHandler(this.click_operation);
            // 
            // num3_button
            // 
            this.num3_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3_button.Location = new System.Drawing.Point(166, 304);
            this.num3_button.Name = "num3_button";
            this.num3_button.Size = new System.Drawing.Size(60, 60);
            this.num3_button.TabIndex = 12;
            this.num3_button.Text = "3";
            this.num3_button.UseVisualStyleBackColor = true;
            this.num3_button.Click += new System.EventHandler(this.click_number);
            // 
            // num2_button
            // 
            this.num2_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2_button.Location = new System.Drawing.Point(100, 304);
            this.num2_button.Name = "num2_button";
            this.num2_button.Size = new System.Drawing.Size(60, 60);
            this.num2_button.TabIndex = 11;
            this.num2_button.Text = "2";
            this.num2_button.UseVisualStyleBackColor = true;
            this.num2_button.Click += new System.EventHandler(this.click_number);
            // 
            // num1_button
            // 
            this.num1_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1_button.Location = new System.Drawing.Point(34, 304);
            this.num1_button.Name = "num1_button";
            this.num1_button.Size = new System.Drawing.Size(60, 60);
            this.num1_button.TabIndex = 10;
            this.num1_button.Text = "1";
            this.num1_button.UseVisualStyleBackColor = true;
            this.num1_button.Click += new System.EventHandler(this.click_number);
            // 
            // equals_button
            // 
            this.equals_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equals_button.Location = new System.Drawing.Point(232, 370);
            this.equals_button.Name = "equals_button";
            this.equals_button.Size = new System.Drawing.Size(60, 60);
            this.equals_button.TabIndex = 19;
            this.equals_button.Text = "=";
            this.equals_button.UseVisualStyleBackColor = true;
            this.equals_button.Click += new System.EventHandler(this.calculate);
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.Location = new System.Drawing.Point(232, 304);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(60, 60);
            this.add_button.TabIndex = 18;
            this.add_button.Text = "+";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.click_operation);
            // 
            // decimal_button
            // 
            this.decimal_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimal_button.Location = new System.Drawing.Point(166, 370);
            this.decimal_button.Name = "decimal_button";
            this.decimal_button.Size = new System.Drawing.Size(60, 60);
            this.decimal_button.TabIndex = 17;
            this.decimal_button.Text = ".";
            this.decimal_button.UseVisualStyleBackColor = true;
            this.decimal_button.Click += new System.EventHandler(this.click_number);
            // 
            // num0_button
            // 
            this.num0_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num0_button.Location = new System.Drawing.Point(100, 370);
            this.num0_button.Name = "num0_button";
            this.num0_button.Size = new System.Drawing.Size(60, 60);
            this.num0_button.TabIndex = 15;
            this.num0_button.Text = "0";
            this.num0_button.UseVisualStyleBackColor = true;
            this.num0_button.Click += new System.EventHandler(this.click_number);
            // 
            // plusMinus_button
            // 
            this.plusMinus_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusMinus_button.Location = new System.Drawing.Point(34, 370);
            this.plusMinus_button.Name = "plusMinus_button";
            this.plusMinus_button.Size = new System.Drawing.Size(60, 60);
            this.plusMinus_button.TabIndex = 20;
            this.plusMinus_button.Text = "±";
            this.plusMinus_button.UseVisualStyleBackColor = true;
            this.plusMinus_button.Click += new System.EventHandler(this.changeSign);
            // 
            // history_label
            // 
            this.history_label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.history_label.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.history_label.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.history_label.Location = new System.Drawing.Point(36, 24);
            this.history_label.Name = "history_label";
            this.history_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.history_label.Size = new System.Drawing.Size(258, 24);
            this.history_label.TabIndex = 21;
            this.history_label.Text = "             ";
            this.history_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // display_textBox
            // 
            this.display_textBox.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_textBox.Location = new System.Drawing.Point(34, 63);
            this.display_textBox.Name = "display_textBox";
            this.display_textBox.ReadOnly = true;
            this.display_textBox.Size = new System.Drawing.Size(258, 32);
            this.display_textBox.TabIndex = 22;
            this.display_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // return_button
            // 
            this.return_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_button.Location = new System.Drawing.Point(166, 106);
            this.return_button.Name = "return_button";
            this.return_button.Size = new System.Drawing.Size(60, 60);
            this.return_button.TabIndex = 23;
            this.return_button.Text = "←";
            this.return_button.UseVisualStyleBackColor = true;
            this.return_button.Click += new System.EventHandler(this.deleteText);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.options_menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(324, 24);
            this.menuStrip1.TabIndex = 45;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // options_menu
            // 
            this.options_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mode_menu});
            this.options_menu.Name = "options_menu";
            this.options_menu.Size = new System.Drawing.Size(61, 20);
            this.options_menu.Text = "Options";
            // 
            // mode_menu
            // 
            this.mode_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standard_menu,
            this.scientific_menu});
            this.mode_menu.Name = "mode_menu";
            this.mode_menu.Size = new System.Drawing.Size(152, 22);
            this.mode_menu.Text = "Mode";
            // 
            // standard_menu
            // 
            this.standard_menu.Name = "standard_menu";
            this.standard_menu.Size = new System.Drawing.Size(152, 22);
            this.standard_menu.Text = "Standard";
            // 
            // scientific_menu
            // 
            this.scientific_menu.Name = "scientific_menu";
            this.scientific_menu.Size = new System.Drawing.Size(152, 22);
            this.scientific_menu.Text = "Scientific";
            this.scientific_menu.Click += new System.EventHandler(this.changeMode);
            // 
            // Standard
            // 
            this.ClientSize = new System.Drawing.Size(324, 451);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.history_label);
            this.Controls.Add(this.return_button);
            this.Controls.Add(this.display_textBox);
            this.Controls.Add(this.plusMinus_button);
            this.Controls.Add(this.equals_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.decimal_button);
            this.Controls.Add(this.num0_button);
            this.Controls.Add(this.subtract_button);
            this.Controls.Add(this.num3_button);
            this.Controls.Add(this.num2_button);
            this.Controls.Add(this.num1_button);
            this.Controls.Add(this.clearAll_button);
            this.Controls.Add(this.multiply_button);
            this.Controls.Add(this.num6_button);
            this.Controls.Add(this.num5_button);
            this.Controls.Add(this.num4_button);
            this.Controls.Add(this.clearEntry_button);
            this.Controls.Add(this.divide_button);
            this.Controls.Add(this.num9_button);
            this.Controls.Add(this.num8_button);
            this.Controls.Add(this.num7_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Standard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator (Standard)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button num0_button;
        private System.Windows.Forms.Button num1_button;
        private System.Windows.Forms.Button num2_button;
        private System.Windows.Forms.Button num3_button;
        private System.Windows.Forms.Button num4_button;
        private System.Windows.Forms.Button num5_button;
        private System.Windows.Forms.Button num6_button;
        private System.Windows.Forms.Button num7_button;
        private System.Windows.Forms.Button num8_button;
        private System.Windows.Forms.Button num9_button;
        private System.Windows.Forms.Button decimal_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button subtract_button;
        private System.Windows.Forms.Button multiply_button;
        private System.Windows.Forms.Button divide_button;
        private System.Windows.Forms.Button equals_button;
        private System.Windows.Forms.Button clearEntry_button;
        private System.Windows.Forms.Button clearAll_button;
        private System.Windows.Forms.Button plusMinus_button;
        private System.Windows.Forms.Label history_label;
        private System.Windows.Forms.TextBox display_textBox;
        private System.Windows.Forms.Button return_button;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem options_menu;
        private System.Windows.Forms.ToolStripMenuItem mode_menu;
        private System.Windows.Forms.ToolStripMenuItem standard_menu;
        private System.Windows.Forms.ToolStripMenuItem scientific_menu;
    }
}

