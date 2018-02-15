namespace Calculator
{
    partial class Scientific
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scientific));
            this.display_textBox = new System.Windows.Forms.TextBox();
            this.return_button = new System.Windows.Forms.Button();
            this.plusMinus_button = new System.Windows.Forms.Button();
            this.equals_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.decimal_button = new System.Windows.Forms.Button();
            this.num0_button = new System.Windows.Forms.Button();
            this.subtract_button = new System.Windows.Forms.Button();
            this.num3_button = new System.Windows.Forms.Button();
            this.num2_button = new System.Windows.Forms.Button();
            this.num1_button = new System.Windows.Forms.Button();
            this.clearAll_button = new System.Windows.Forms.Button();
            this.multiply_button = new System.Windows.Forms.Button();
            this.num6_button = new System.Windows.Forms.Button();
            this.num5_button = new System.Windows.Forms.Button();
            this.num4_button = new System.Windows.Forms.Button();
            this.clearEntry_button = new System.Windows.Forms.Button();
            this.divide_button = new System.Windows.Forms.Button();
            this.num9_button = new System.Windows.Forms.Button();
            this.num8_button = new System.Windows.Forms.Button();
            this.num7_button = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.options_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.mode_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.standard_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.scientific_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.memoryClear_button = new System.Windows.Forms.Button();
            this.memoryRecall_button = new System.Windows.Forms.Button();
            this.memoryAdd_button = new System.Windows.Forms.Button();
            this.inverse_button = new System.Windows.Forms.Button();
            this.squareRoot_button = new System.Windows.Forms.Button();
            this.power_button = new System.Windows.Forms.Button();
            this.random_button = new System.Windows.Forms.Button();
            this.log_button = new System.Windows.Forms.Button();
            this.tangent_button = new System.Windows.Forms.Button();
            this.cosine_button = new System.Windows.Forms.Button();
            this.sine_button = new System.Windows.Forms.Button();
            this.factorial_button = new System.Windows.Forms.Button();
            this.euler_button = new System.Windows.Forms.Button();
            this.pi_button = new System.Windows.Forms.Button();
            this.naturalLog_button = new System.Windows.Forms.Button();
            this.history_label = new System.Windows.Forms.Label();
            this.memory_label = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // display_textBox
            // 
            this.display_textBox.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_textBox.Location = new System.Drawing.Point(34, 63);
            this.display_textBox.Name = "display_textBox";
            this.display_textBox.ReadOnly = true;
            this.display_textBox.Size = new System.Drawing.Size(477, 32);
            this.display_textBox.TabIndex = 23;
            this.display_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // return_button
            // 
            this.return_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_button.Location = new System.Drawing.Point(166, 111);
            this.return_button.Name = "return_button";
            this.return_button.Size = new System.Drawing.Size(60, 45);
            this.return_button.TabIndex = 43;
            this.return_button.Text = "←";
            this.return_button.UseVisualStyleBackColor = true;
            this.return_button.Click += new System.EventHandler(this.deleteText);
            // 
            // plusMinus_button
            // 
            this.plusMinus_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusMinus_button.Location = new System.Drawing.Point(34, 315);
            this.plusMinus_button.Name = "plusMinus_button";
            this.plusMinus_button.Size = new System.Drawing.Size(60, 45);
            this.plusMinus_button.TabIndex = 42;
            this.plusMinus_button.Text = "±";
            this.plusMinus_button.UseVisualStyleBackColor = true;
            this.plusMinus_button.Click += new System.EventHandler(this.changeSign);
            // 
            // equals_button
            // 
            this.equals_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equals_button.Location = new System.Drawing.Point(232, 315);
            this.equals_button.Name = "equals_button";
            this.equals_button.Size = new System.Drawing.Size(60, 45);
            this.equals_button.TabIndex = 41;
            this.equals_button.Text = "=";
            this.equals_button.UseVisualStyleBackColor = true;
            this.equals_button.Click += new System.EventHandler(this.calculate);
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.Location = new System.Drawing.Point(232, 264);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(60, 45);
            this.add_button.TabIndex = 40;
            this.add_button.Text = "+";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.click_operation);
            // 
            // decimal_button
            // 
            this.decimal_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimal_button.Location = new System.Drawing.Point(166, 315);
            this.decimal_button.Name = "decimal_button";
            this.decimal_button.Size = new System.Drawing.Size(60, 45);
            this.decimal_button.TabIndex = 39;
            this.decimal_button.Text = ".";
            this.decimal_button.UseVisualStyleBackColor = true;
            this.decimal_button.Click += new System.EventHandler(this.click_number);
            // 
            // num0_button
            // 
            this.num0_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num0_button.Location = new System.Drawing.Point(100, 315);
            this.num0_button.Name = "num0_button";
            this.num0_button.Size = new System.Drawing.Size(60, 45);
            this.num0_button.TabIndex = 38;
            this.num0_button.Text = "0";
            this.num0_button.UseVisualStyleBackColor = true;
            this.num0_button.Click += new System.EventHandler(this.click_number);
            // 
            // subtract_button
            // 
            this.subtract_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtract_button.Location = new System.Drawing.Point(232, 213);
            this.subtract_button.Name = "subtract_button";
            this.subtract_button.Size = new System.Drawing.Size(60, 45);
            this.subtract_button.TabIndex = 37;
            this.subtract_button.Text = "-";
            this.subtract_button.UseVisualStyleBackColor = true;
            this.subtract_button.Click += new System.EventHandler(this.click_operation);
            // 
            // num3_button
            // 
            this.num3_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3_button.Location = new System.Drawing.Point(166, 264);
            this.num3_button.Name = "num3_button";
            this.num3_button.Size = new System.Drawing.Size(60, 45);
            this.num3_button.TabIndex = 36;
            this.num3_button.Text = "3";
            this.num3_button.UseVisualStyleBackColor = true;
            this.num3_button.Click += new System.EventHandler(this.click_number);
            // 
            // num2_button
            // 
            this.num2_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2_button.Location = new System.Drawing.Point(100, 264);
            this.num2_button.Name = "num2_button";
            this.num2_button.Size = new System.Drawing.Size(60, 45);
            this.num2_button.TabIndex = 35;
            this.num2_button.Text = "2";
            this.num2_button.UseVisualStyleBackColor = true;
            this.num2_button.Click += new System.EventHandler(this.click_number);
            // 
            // num1_button
            // 
            this.num1_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1_button.Location = new System.Drawing.Point(34, 264);
            this.num1_button.Name = "num1_button";
            this.num1_button.Size = new System.Drawing.Size(60, 45);
            this.num1_button.TabIndex = 34;
            this.num1_button.Text = "1";
            this.num1_button.UseVisualStyleBackColor = true;
            this.num1_button.Click += new System.EventHandler(this.click_number);
            // 
            // clearAll_button
            // 
            this.clearAll_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearAll_button.Location = new System.Drawing.Point(100, 111);
            this.clearAll_button.Name = "clearAll_button";
            this.clearAll_button.Size = new System.Drawing.Size(60, 45);
            this.clearAll_button.TabIndex = 33;
            this.clearAll_button.Text = "C";
            this.clearAll_button.UseVisualStyleBackColor = true;
            this.clearAll_button.Click += new System.EventHandler(this.clearAll);
            // 
            // multiply_button
            // 
            this.multiply_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiply_button.Location = new System.Drawing.Point(232, 162);
            this.multiply_button.Name = "multiply_button";
            this.multiply_button.Size = new System.Drawing.Size(60, 45);
            this.multiply_button.TabIndex = 32;
            this.multiply_button.Text = "*";
            this.multiply_button.UseVisualStyleBackColor = true;
            this.multiply_button.Click += new System.EventHandler(this.click_operation);
            // 
            // num6_button
            // 
            this.num6_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num6_button.Location = new System.Drawing.Point(166, 213);
            this.num6_button.Name = "num6_button";
            this.num6_button.Size = new System.Drawing.Size(60, 45);
            this.num6_button.TabIndex = 31;
            this.num6_button.Text = "6";
            this.num6_button.UseVisualStyleBackColor = true;
            this.num6_button.Click += new System.EventHandler(this.click_number);
            // 
            // num5_button
            // 
            this.num5_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num5_button.Location = new System.Drawing.Point(100, 213);
            this.num5_button.Name = "num5_button";
            this.num5_button.Size = new System.Drawing.Size(60, 45);
            this.num5_button.TabIndex = 30;
            this.num5_button.Text = "5";
            this.num5_button.UseVisualStyleBackColor = true;
            this.num5_button.Click += new System.EventHandler(this.click_number);
            // 
            // num4_button
            // 
            this.num4_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num4_button.Location = new System.Drawing.Point(34, 213);
            this.num4_button.Name = "num4_button";
            this.num4_button.Size = new System.Drawing.Size(60, 45);
            this.num4_button.TabIndex = 29;
            this.num4_button.Text = "4";
            this.num4_button.UseVisualStyleBackColor = true;
            this.num4_button.Click += new System.EventHandler(this.click_number);
            // 
            // clearEntry_button
            // 
            this.clearEntry_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearEntry_button.Location = new System.Drawing.Point(34, 111);
            this.clearEntry_button.Name = "clearEntry_button";
            this.clearEntry_button.Size = new System.Drawing.Size(60, 45);
            this.clearEntry_button.TabIndex = 28;
            this.clearEntry_button.Text = " CE";
            this.clearEntry_button.UseVisualStyleBackColor = true;
            this.clearEntry_button.Click += new System.EventHandler(this.clearEntry);
            // 
            // divide_button
            // 
            this.divide_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide_button.Location = new System.Drawing.Point(232, 111);
            this.divide_button.Name = "divide_button";
            this.divide_button.Size = new System.Drawing.Size(60, 45);
            this.divide_button.TabIndex = 27;
            this.divide_button.Text = "/";
            this.divide_button.UseVisualStyleBackColor = true;
            this.divide_button.Click += new System.EventHandler(this.click_operation);
            // 
            // num9_button
            // 
            this.num9_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num9_button.Location = new System.Drawing.Point(166, 162);
            this.num9_button.Name = "num9_button";
            this.num9_button.Size = new System.Drawing.Size(60, 45);
            this.num9_button.TabIndex = 26;
            this.num9_button.Text = "9";
            this.num9_button.UseVisualStyleBackColor = true;
            this.num9_button.Click += new System.EventHandler(this.click_number);
            // 
            // num8_button
            // 
            this.num8_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num8_button.Location = new System.Drawing.Point(100, 162);
            this.num8_button.Name = "num8_button";
            this.num8_button.Size = new System.Drawing.Size(60, 45);
            this.num8_button.TabIndex = 25;
            this.num8_button.Text = "8";
            this.num8_button.UseVisualStyleBackColor = true;
            this.num8_button.Click += new System.EventHandler(this.click_number);
            // 
            // num7_button
            // 
            this.num7_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num7_button.Location = new System.Drawing.Point(34, 162);
            this.num7_button.Name = "num7_button";
            this.num7_button.Size = new System.Drawing.Size(60, 45);
            this.num7_button.TabIndex = 24;
            this.num7_button.Text = "7";
            this.num7_button.UseVisualStyleBackColor = true;
            this.num7_button.Click += new System.EventHandler(this.click_number);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.options_menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(537, 24);
            this.menuStrip1.TabIndex = 44;
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
            this.standard_menu.Click += new System.EventHandler(this.changeMode);
            // 
            // scientific_menu
            // 
            this.scientific_menu.Name = "scientific_menu";
            this.scientific_menu.Size = new System.Drawing.Size(152, 22);
            this.scientific_menu.Text = "Scientific";
            // 
            // memoryClear_button
            // 
            this.memoryClear_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoryClear_button.Location = new System.Drawing.Point(451, 264);
            this.memoryClear_button.Name = "memoryClear_button";
            this.memoryClear_button.Size = new System.Drawing.Size(60, 45);
            this.memoryClear_button.TabIndex = 107;
            this.memoryClear_button.Text = "MC";
            this.memoryClear_button.UseVisualStyleBackColor = true;
            this.memoryClear_button.Click += new System.EventHandler(this.memory_clear);
            // 
            // memoryRecall_button
            // 
            this.memoryRecall_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoryRecall_button.Location = new System.Drawing.Point(451, 215);
            this.memoryRecall_button.Name = "memoryRecall_button";
            this.memoryRecall_button.Size = new System.Drawing.Size(60, 45);
            this.memoryRecall_button.TabIndex = 106;
            this.memoryRecall_button.Text = "MRC";
            this.memoryRecall_button.UseVisualStyleBackColor = true;
            this.memoryRecall_button.Click += new System.EventHandler(this.memory_recall);
            // 
            // memoryAdd_button
            // 
            this.memoryAdd_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoryAdd_button.Location = new System.Drawing.Point(451, 164);
            this.memoryAdd_button.Name = "memoryAdd_button";
            this.memoryAdd_button.Size = new System.Drawing.Size(60, 45);
            this.memoryAdd_button.TabIndex = 105;
            this.memoryAdd_button.Text = "M+";
            this.memoryAdd_button.UseVisualStyleBackColor = true;
            this.memoryAdd_button.Click += new System.EventHandler(this.memory_add);
            // 
            // inverse_button
            // 
            this.inverse_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inverse_button.Location = new System.Drawing.Point(451, 113);
            this.inverse_button.Name = "inverse_button";
            this.inverse_button.Size = new System.Drawing.Size(60, 45);
            this.inverse_button.TabIndex = 104;
            this.inverse_button.Text = "A";
            this.inverse_button.UseVisualStyleBackColor = true;
            this.inverse_button.Click += new System.EventHandler(this.toggle_operation);
            // 
            // squareRoot_button
            // 
            this.squareRoot_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.squareRoot_button.Location = new System.Drawing.Point(318, 113);
            this.squareRoot_button.Name = "squareRoot_button";
            this.squareRoot_button.Size = new System.Drawing.Size(60, 45);
            this.squareRoot_button.TabIndex = 103;
            this.squareRoot_button.Text = "√";
            this.squareRoot_button.UseVisualStyleBackColor = true;
            this.squareRoot_button.Click += new System.EventHandler(this.click_scientific);
            // 
            // power_button
            // 
            this.power_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.power_button.Location = new System.Drawing.Point(318, 164);
            this.power_button.Name = "power_button";
            this.power_button.Size = new System.Drawing.Size(60, 45);
            this.power_button.TabIndex = 102;
            this.power_button.Text = "^";
            this.power_button.UseVisualStyleBackColor = true;
            this.power_button.Click += new System.EventHandler(this.click_operation);
            // 
            // random_button
            // 
            this.random_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.random_button.Location = new System.Drawing.Point(319, 317);
            this.random_button.Name = "random_button";
            this.random_button.Size = new System.Drawing.Size(60, 45);
            this.random_button.TabIndex = 101;
            this.random_button.Text = "Rnd";
            this.random_button.UseVisualStyleBackColor = true;
            this.random_button.Click += new System.EventHandler(this.click_constant);
            // 
            // log_button
            // 
            this.log_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_button.Location = new System.Drawing.Point(385, 266);
            this.log_button.Name = "log_button";
            this.log_button.Size = new System.Drawing.Size(60, 45);
            this.log_button.TabIndex = 100;
            this.log_button.Text = "log";
            this.log_button.UseVisualStyleBackColor = true;
            this.log_button.Click += new System.EventHandler(this.click_scientific);
            // 
            // tangent_button
            // 
            this.tangent_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tangent_button.Location = new System.Drawing.Point(384, 215);
            this.tangent_button.Name = "tangent_button";
            this.tangent_button.Size = new System.Drawing.Size(60, 45);
            this.tangent_button.TabIndex = 99;
            this.tangent_button.Text = "tan";
            this.tangent_button.UseVisualStyleBackColor = true;
            this.tangent_button.Click += new System.EventHandler(this.click_scientific);
            // 
            // cosine_button
            // 
            this.cosine_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cosine_button.Location = new System.Drawing.Point(384, 164);
            this.cosine_button.Name = "cosine_button";
            this.cosine_button.Size = new System.Drawing.Size(60, 45);
            this.cosine_button.TabIndex = 98;
            this.cosine_button.Text = "cos";
            this.cosine_button.UseVisualStyleBackColor = true;
            this.cosine_button.Click += new System.EventHandler(this.click_scientific);
            // 
            // sine_button
            // 
            this.sine_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sine_button.Location = new System.Drawing.Point(384, 113);
            this.sine_button.Name = "sine_button";
            this.sine_button.Size = new System.Drawing.Size(60, 45);
            this.sine_button.TabIndex = 97;
            this.sine_button.Text = "sin";
            this.sine_button.UseVisualStyleBackColor = true;
            this.sine_button.Click += new System.EventHandler(this.click_scientific);
            // 
            // factorial_button
            // 
            this.factorial_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factorial_button.Location = new System.Drawing.Point(451, 317);
            this.factorial_button.Name = "factorial_button";
            this.factorial_button.Size = new System.Drawing.Size(60, 45);
            this.factorial_button.TabIndex = 96;
            this.factorial_button.Text = "n!";
            this.factorial_button.UseVisualStyleBackColor = true;
            this.factorial_button.Click += new System.EventHandler(this.click_scientific);
            // 
            // euler_button
            // 
            this.euler_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.euler_button.Location = new System.Drawing.Point(318, 266);
            this.euler_button.Name = "euler_button";
            this.euler_button.Size = new System.Drawing.Size(60, 45);
            this.euler_button.TabIndex = 95;
            this.euler_button.Text = "e";
            this.euler_button.UseVisualStyleBackColor = true;
            this.euler_button.Click += new System.EventHandler(this.click_constant);
            // 
            // pi_button
            // 
            this.pi_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pi_button.Location = new System.Drawing.Point(318, 215);
            this.pi_button.Name = "pi_button";
            this.pi_button.Size = new System.Drawing.Size(60, 45);
            this.pi_button.TabIndex = 94;
            this.pi_button.Text = "π";
            this.pi_button.UseVisualStyleBackColor = true;
            this.pi_button.Click += new System.EventHandler(this.click_constant);
            // 
            // naturalLog_button
            // 
            this.naturalLog_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naturalLog_button.Location = new System.Drawing.Point(385, 317);
            this.naturalLog_button.Name = "naturalLog_button";
            this.naturalLog_button.Size = new System.Drawing.Size(60, 45);
            this.naturalLog_button.TabIndex = 93;
            this.naturalLog_button.Text = "ln";
            this.naturalLog_button.UseVisualStyleBackColor = true;
            this.naturalLog_button.Click += new System.EventHandler(this.click_scientific);
            // 
            // history_label
            // 
            this.history_label.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.history_label.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.history_label.Location = new System.Drawing.Point(290, 36);
            this.history_label.Name = "history_label";
            this.history_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.history_label.Size = new System.Drawing.Size(221, 24);
            this.history_label.TabIndex = 108;
            this.history_label.Text = "             ";
            this.history_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // memory_label
            // 
            this.memory_label.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memory_label.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.memory_label.Location = new System.Drawing.Point(31, 36);
            this.memory_label.Name = "memory_label";
            this.memory_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.memory_label.Size = new System.Drawing.Size(221, 24);
            this.memory_label.TabIndex = 109;
            this.memory_label.Text = "             ";
            this.memory_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Scientific
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 387);
            this.Controls.Add(this.memory_label);
            this.Controls.Add(this.history_label);
            this.Controls.Add(this.memoryClear_button);
            this.Controls.Add(this.memoryRecall_button);
            this.Controls.Add(this.memoryAdd_button);
            this.Controls.Add(this.inverse_button);
            this.Controls.Add(this.squareRoot_button);
            this.Controls.Add(this.power_button);
            this.Controls.Add(this.random_button);
            this.Controls.Add(this.log_button);
            this.Controls.Add(this.tangent_button);
            this.Controls.Add(this.cosine_button);
            this.Controls.Add(this.sine_button);
            this.Controls.Add(this.factorial_button);
            this.Controls.Add(this.euler_button);
            this.Controls.Add(this.pi_button);
            this.Controls.Add(this.naturalLog_button);
            this.Controls.Add(this.return_button);
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
            this.Controls.Add(this.display_textBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Scientific";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator (Scientific)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox display_textBox;
        private System.Windows.Forms.Button return_button;
        private System.Windows.Forms.Button plusMinus_button;
        private System.Windows.Forms.Button equals_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button decimal_button;
        private System.Windows.Forms.Button num0_button;
        private System.Windows.Forms.Button subtract_button;
        private System.Windows.Forms.Button num3_button;
        private System.Windows.Forms.Button num2_button;
        private System.Windows.Forms.Button num1_button;
        private System.Windows.Forms.Button clearAll_button;
        private System.Windows.Forms.Button multiply_button;
        private System.Windows.Forms.Button num6_button;
        private System.Windows.Forms.Button num5_button;
        private System.Windows.Forms.Button num4_button;
        private System.Windows.Forms.Button clearEntry_button;
        private System.Windows.Forms.Button divide_button;
        private System.Windows.Forms.Button num9_button;
        private System.Windows.Forms.Button num8_button;
        private System.Windows.Forms.Button num7_button;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem options_menu;
        private System.Windows.Forms.ToolStripMenuItem mode_menu;
        private System.Windows.Forms.ToolStripMenuItem standard_menu;
        private System.Windows.Forms.ToolStripMenuItem scientific_menu;
        private System.Windows.Forms.Button memoryClear_button;
        private System.Windows.Forms.Button memoryRecall_button;
        private System.Windows.Forms.Button memoryAdd_button;
        private System.Windows.Forms.Button inverse_button;
        private System.Windows.Forms.Button squareRoot_button;
        private System.Windows.Forms.Button power_button;
        private System.Windows.Forms.Button random_button;
        private System.Windows.Forms.Button log_button;
        private System.Windows.Forms.Button tangent_button;
        private System.Windows.Forms.Button cosine_button;
        private System.Windows.Forms.Button sine_button;
        private System.Windows.Forms.Button factorial_button;
        private System.Windows.Forms.Button euler_button;
        private System.Windows.Forms.Button pi_button;
        private System.Windows.Forms.Button naturalLog_button;
        private System.Windows.Forms.Label history_label;
        private System.Windows.Forms.Label memory_label;
    }
}