namespace test_butotn
{
    public partial  class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        public void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkBox2_1 = new System.Windows.Forms.CheckBox();
            this.checkBox1_1 = new System.Windows.Forms.CheckBox();
            this.button2_1 = new System.Windows.Forms.Button();
            this.button1_1 = new System.Windows.Forms.Button();
            this.label2_1 = new System.Windows.Forms.Label();
            this.label1_1 = new System.Windows.Forms.Label();
            this.textBox1_1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3_2 = new System.Windows.Forms.Button();
            this.button4_2 = new System.Windows.Forms.Button();
            this.textBox2_2 = new System.Windows.Forms.TextBox();
            this.comboBox1_2 = new System.Windows.Forms.ComboBox();
            this.radioButton3_2 = new System.Windows.Forms.RadioButton();
            this.radioButton2_2 = new System.Windows.Forms.RadioButton();
            this.radioButton1_2 = new System.Windows.Forms.RadioButton();
            this.label3_2 = new System.Windows.Forms.Label();
            this.checkBox3_2 = new System.Windows.Forms.CheckBox();
            this.checkBox4_2 = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label4_3 = new System.Windows.Forms.Label();
            this.button5_3 = new System.Windows.Forms.Button();
            this.button6_3 = new System.Windows.Forms.Button();
            this.checkBox5_3 = new System.Windows.Forms.CheckBox();
            this.checkBox6_3 = new System.Windows.Forms.CheckBox();
            this.radioButton5_3 = new System.Windows.Forms.RadioButton();
            this.radioButton6_3 = new System.Windows.Forms.RadioButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textBox3_4 = new System.Windows.Forms.TextBox();
            this.radioButton8_4 = new System.Windows.Forms.RadioButton();
            this.radioButton4_4 = new System.Windows.Forms.RadioButton();
            this.radioButton7_4 = new System.Windows.Forms.RadioButton();
            this.checkBox7_4 = new System.Windows.Forms.CheckBox();
            this.checkBox8_4 = new System.Windows.Forms.CheckBox();
            this.button7_4 = new System.Windows.Forms.Button();
            this.button8_4 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(300, 500);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage1.Controls.Add(this.checkBox2_1);
            this.tabPage1.Controls.Add(this.checkBox1_1);
            this.tabPage1.Controls.Add(this.button2_1);
            this.tabPage1.Controls.Add(this.button1_1);
            this.tabPage1.Controls.Add(this.label2_1);
            this.tabPage1.Controls.Add(this.label1_1);
            this.tabPage1.Controls.Add(this.textBox1_1);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage1.Location = new System.Drawing.Point(4, 49);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(292, 447);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "多max文件输出";
            this.tabPage1.ToolTipText = "选择输出按钮  选择max 文件 会按照指定的选择集合输出 ";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // checkBox2_1
            // 
            this.checkBox2_1.AutoSize = true;
            this.checkBox2_1.CheckAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.checkBox2_1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBox2_1.Location = new System.Drawing.Point(26, 183);
            this.checkBox2_1.Name = "checkBox2_1";
            this.checkBox2_1.Size = new System.Drawing.Size(108, 16);
            this.checkBox2_1.TabIndex = 6;
            this.checkBox2_1.Text = "输出位移到原点";
            this.checkBox2_1.UseVisualStyleBackColor = true;
            // 
            // checkBox1_1
            // 
            this.checkBox1_1.AutoSize = true;
            this.checkBox1_1.CheckAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.checkBox1_1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBox1_1.Location = new System.Drawing.Point(26, 151);
            this.checkBox1_1.Name = "checkBox1_1";
            this.checkBox1_1.Size = new System.Drawing.Size(198, 16);
            this.checkBox1_1.TabIndex = 5;
            this.checkBox1_1.Text = "统一物体所有坐标为包围盒z中心";
            this.checkBox1_1.UseVisualStyleBackColor = true;
            // 
            // button2_1
            // 
            this.button2_1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2_1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2_1.Location = new System.Drawing.Point(140, 275);
            this.button2_1.Name = "button2_1";
            this.button2_1.Size = new System.Drawing.Size(108, 41);
            this.button2_1.TabIndex = 4;
            this.button2_1.Text = "tounity 输出";
            this.button2_1.UseVisualStyleBackColor = true;
            // 
            // button1_1
            // 
            this.button1_1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1_1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1_1.Location = new System.Drawing.Point(15, 275);
            this.button1_1.Name = "button1_1";
            this.button1_1.Size = new System.Drawing.Size(108, 41);
            this.button1_1.TabIndex = 3;
            this.button1_1.Tag = "";
            this.button1_1.Text = "Ling 标准输出";
            this.button1_1.UseVisualStyleBackColor = true;
            this.button1_1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2_1
            // 
            this.label2_1.AutoSize = true;
            this.label2_1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2_1.Location = new System.Drawing.Point(13, 336);
            this.label2_1.Name = "label2_1";
            this.label2_1.Size = new System.Drawing.Size(251, 72);
            this.label2_1.TabIndex = 2;
            this.label2_1.Text = "按照max 文件名输出。\r\n\r\n标准输出：直接输出 Z轴朝上 \r\n\r\ntounity输出：y轴朝上 物体选择90度塌陷输出\r\n(该输出是为了在unity 地形笔刷" +
    "绘制 ) ";
            // 
            // label1_1
            // 
            this.label1_1.AutoSize = true;
            this.label1_1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1_1.Location = new System.Drawing.Point(12, 67);
            this.label1_1.Name = "label1_1";
            this.label1_1.Size = new System.Drawing.Size(89, 12);
            this.label1_1.TabIndex = 1;
            this.label1_1.Text = "设置选择集合：";
            this.label1_1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1_1
            // 
            this.textBox1_1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBox1_1.Location = new System.Drawing.Point(107, 64);
            this.textBox1_1.Name = "textBox1_1";
            this.textBox1_1.Size = new System.Drawing.Size(141, 21);
            this.textBox1_1.TabIndex = 0;
            this.textBox1_1.Text = "ling";
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackColor = System.Drawing.Color.Silver;
            this.tabPage2.Controls.Add(this.button3_2);
            this.tabPage2.Controls.Add(this.button4_2);
            this.tabPage2.Controls.Add(this.textBox2_2);
            this.tabPage2.Controls.Add(this.comboBox1_2);
            this.tabPage2.Controls.Add(this.radioButton3_2);
            this.tabPage2.Controls.Add(this.radioButton2_2);
            this.tabPage2.Controls.Add(this.radioButton1_2);
            this.tabPage2.Controls.Add(this.label3_2);
            this.tabPage2.Controls.Add(this.checkBox3_2);
            this.tabPage2.Controls.Add(this.checkBox4_2);
            this.tabPage2.Location = new System.Drawing.Point(4, 49);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(292, 447);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "单文件选择集输出";
            this.tabPage2.ToolTipText = "标准化的单文件ling输出";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // button3_2
            // 
            this.button3_2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3_2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3_2.Location = new System.Drawing.Point(141, 297);
            this.button3_2.Name = "button3_2";
            this.button3_2.Size = new System.Drawing.Size(108, 41);
            this.button3_2.TabIndex = 17;
            this.button3_2.Text = "tounity 输出";
            this.button3_2.UseVisualStyleBackColor = true;
            // 
            // button4_2
            // 
            this.button4_2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4_2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4_2.Location = new System.Drawing.Point(16, 297);
            this.button4_2.Name = "button4_2";
            this.button4_2.Size = new System.Drawing.Size(108, 41);
            this.button4_2.TabIndex = 16;
            this.button4_2.Tag = "";
            this.button4_2.Text = "Ling 标准输出";
            this.button4_2.UseVisualStyleBackColor = true;
            // 
            // textBox2_2
            // 
            this.textBox2_2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBox2_2.Location = new System.Drawing.Point(45, 250);
            this.textBox2_2.Name = "textBox2_2";
            this.textBox2_2.Size = new System.Drawing.Size(141, 21);
            this.textBox2_2.TabIndex = 15;
            this.textBox2_2.Text = "ling";
            // 
            // comboBox1_2
            // 
            this.comboBox1_2.DisplayMember = "0";
            this.comboBox1_2.FormattingEnabled = true;
            this.comboBox1_2.Items.AddRange(new object[] {
            "ling",
            "wall"});
            this.comboBox1_2.Location = new System.Drawing.Point(105, 43);
            this.comboBox1_2.Name = "comboBox1_2";
            this.comboBox1_2.Size = new System.Drawing.Size(121, 20);
            this.comboBox1_2.TabIndex = 14;
            this.comboBox1_2.ValueMember = "0";
            this.comboBox1_2.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            this.comboBox1_2.SelectedIndex = 0;
            // 
            // radioButton3_2
            // 
            this.radioButton3_2.AutoSize = true;
            this.radioButton3_2.Location = new System.Drawing.Point(34, 228);
            this.radioButton3_2.Name = "radioButton3_2";
            this.radioButton3_2.Size = new System.Drawing.Size(83, 16);
            this.radioButton3_2.TabIndex = 13;
            this.radioButton3_2.TabStop = true;
            this.radioButton3_2.Text = "自定义名称";
            this.radioButton3_2.UseVisualStyleBackColor = true;
            // 
            // radioButton2_2
            // 
            this.radioButton2_2.AutoSize = true;
            this.radioButton2_2.Location = new System.Drawing.Point(34, 206);
            this.radioButton2_2.Name = "radioButton2_2";
            this.radioButton2_2.Size = new System.Drawing.Size(119, 16);
            this.radioButton2_2.TabIndex = 12;
            this.radioButton2_2.TabStop = true;
            this.radioButton2_2.Text = "按照选择集合输出";
            this.radioButton2_2.UseVisualStyleBackColor = true;
            // 
            // radioButton1_2
            // 
            this.radioButton1_2.AutoSize = true;
            this.radioButton1_2.Checked = true;
            this.radioButton1_2.Location = new System.Drawing.Point(34, 184);
            this.radioButton1_2.Name = "radioButton1_2";
            this.radioButton1_2.Size = new System.Drawing.Size(137, 16);
            this.radioButton1_2.TabIndex = 11;
            this.radioButton1_2.TabStop = true;
            this.radioButton1_2.Text = "按照max文件命名输出";
            this.radioButton1_2.UseVisualStyleBackColor = true;
            this.radioButton1_2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label3_2
            // 
            this.label3_2.AutoSize = true;
            this.label3_2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3_2.Location = new System.Drawing.Point(22, 46);
            this.label3_2.Name = "label3_2";
            this.label3_2.Size = new System.Drawing.Size(77, 12);
            this.label3_2.TabIndex = 10;
            this.label3_2.Text = "收集选择集：";
            // 
            // checkBox3_2
            // 
            this.checkBox3_2.AutoSize = true;
            this.checkBox3_2.CheckAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.checkBox3_2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBox3_2.Location = new System.Drawing.Point(34, 138);
            this.checkBox3_2.Name = "checkBox3_2";
            this.checkBox3_2.Size = new System.Drawing.Size(108, 16);
            this.checkBox3_2.TabIndex = 8;
            this.checkBox3_2.Text = "输出位移到原点";
            this.checkBox3_2.UseVisualStyleBackColor = true;
            // 
            // checkBox4_2
            // 
            this.checkBox4_2.AutoSize = true;
            this.checkBox4_2.CheckAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.checkBox4_2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBox4_2.Location = new System.Drawing.Point(34, 106);
            this.checkBox4_2.Name = "checkBox4_2";
            this.checkBox4_2.Size = new System.Drawing.Size(198, 16);
            this.checkBox4_2.TabIndex = 7;
            this.checkBox4_2.Text = "统一物体所有坐标为包围盒z中心";
            this.checkBox4_2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage3.Controls.Add(this.label4_3);
            this.tabPage3.Controls.Add(this.button5_3);
            this.tabPage3.Controls.Add(this.button6_3);
            this.tabPage3.Controls.Add(this.checkBox5_3);
            this.tabPage3.Controls.Add(this.checkBox6_3);
            this.tabPage3.Controls.Add(this.radioButton5_3);
            this.tabPage3.Controls.Add(this.radioButton6_3);
            this.tabPage3.Location = new System.Drawing.Point(4, 49);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(292, 447);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "单文件多选择集合输出";
            this.tabPage3.ToolTipText = "单个文件中  选择模型 会查找在那个选择集合中然输出选择集合";
            // 
            // label4_3
            // 
            this.label4_3.AutoSize = true;
            this.label4_3.Location = new System.Drawing.Point(45, 34);
            this.label4_3.Name = "label4_3";
            this.label4_3.Size = new System.Drawing.Size(215, 36);
            this.label4_3.TabIndex = 21;
            this.label4_3.Text = "1.根据选择物体 找到对应的 选择集合 \r\n\r\n2. 按照选择集合输出 \r\n";
            // 
            // button5_3
            // 
            this.button5_3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5_3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5_3.Location = new System.Drawing.Point(153, 307);
            this.button5_3.Name = "button5_3";
            this.button5_3.Size = new System.Drawing.Size(108, 41);
            this.button5_3.TabIndex = 20;
            this.button5_3.Text = "tounity 输出";
            this.button5_3.UseVisualStyleBackColor = true;
            // 
            // button6_3
            // 
            this.button6_3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button6_3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6_3.Location = new System.Drawing.Point(28, 307);
            this.button6_3.Name = "button6_3";
            this.button6_3.Size = new System.Drawing.Size(108, 41);
            this.button6_3.TabIndex = 19;
            this.button6_3.Tag = "";
            this.button6_3.Text = "Ling 标准输出";
            this.button6_3.UseVisualStyleBackColor = true;
            // 
            // checkBox5_3
            // 
            this.checkBox5_3.AutoSize = true;
            this.checkBox5_3.CheckAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.checkBox5_3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBox5_3.Location = new System.Drawing.Point(47, 114);
            this.checkBox5_3.Name = "checkBox5_3";
            this.checkBox5_3.Size = new System.Drawing.Size(108, 16);
            this.checkBox5_3.TabIndex = 18;
            this.checkBox5_3.Text = "输出位移到原点";
            this.checkBox5_3.UseVisualStyleBackColor = true;
            // 
            // checkBox6_3
            // 
            this.checkBox6_3.AutoSize = true;
            this.checkBox6_3.CheckAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.checkBox6_3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBox6_3.Location = new System.Drawing.Point(47, 136);
            this.checkBox6_3.Name = "checkBox6_3";
            this.checkBox6_3.Size = new System.Drawing.Size(198, 16);
            this.checkBox6_3.TabIndex = 17;
            this.checkBox6_3.Text = "统一物体所有坐标为包围盒z中心";
            this.checkBox6_3.UseVisualStyleBackColor = true;
            // 
            // radioButton5_3
            // 
            this.radioButton5_3.AutoSize = true;
            this.radioButton5_3.Location = new System.Drawing.Point(47, 226);
            this.radioButton5_3.Name = "radioButton5_3";
            this.radioButton5_3.Size = new System.Drawing.Size(119, 16);
            this.radioButton5_3.TabIndex = 15;
            this.radioButton5_3.TabStop = true;
            this.radioButton5_3.Text = "按照选择集合输出";
            this.radioButton5_3.UseVisualStyleBackColor = true;
            // 
            // radioButton6_3
            // 
            this.radioButton6_3.AutoSize = true;
            this.radioButton6_3.Checked = true;
            this.radioButton6_3.Location = new System.Drawing.Point(47, 192);
            this.radioButton6_3.Name = "radioButton6_3";
            this.radioButton6_3.Size = new System.Drawing.Size(167, 16);
            this.radioButton6_3.TabIndex = 14;
            this.radioButton6_3.TabStop = true;
            this.radioButton6_3.Text = "按照选择集第一个节点命名";
            this.radioButton6_3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.AutoScroll = true;
            this.tabPage4.BackColor = System.Drawing.Color.Silver;
            this.tabPage4.Controls.Add(this.textBox3_4);
            this.tabPage4.Controls.Add(this.radioButton8_4);
            this.tabPage4.Controls.Add(this.radioButton4_4);
            this.tabPage4.Controls.Add(this.radioButton7_4);
            this.tabPage4.Controls.Add(this.checkBox7_4);
            this.tabPage4.Controls.Add(this.checkBox8_4);
            this.tabPage4.Controls.Add(this.button7_4);
            this.tabPage4.Controls.Add(this.button8_4);
            this.tabPage4.Location = new System.Drawing.Point(4, 49);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(292, 447);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "单文件多节点输出";
            this.tabPage4.ToolTipText = "单文件中输出选择节点 或输出每个选择节点";
            // 
            // textBox3_4
            // 
            this.textBox3_4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBox3_4.Location = new System.Drawing.Point(80, 244);
            this.textBox3_4.Name = "textBox3_4";
            this.textBox3_4.Size = new System.Drawing.Size(141, 21);
            this.textBox3_4.TabIndex = 28;
            this.textBox3_4.Text = "ling";
            // 
            // radioButton8_4
            // 
            this.radioButton8_4.AutoSize = true;
            this.radioButton8_4.Location = new System.Drawing.Point(42, 222);
            this.radioButton8_4.Name = "radioButton8_4";
            this.radioButton8_4.Size = new System.Drawing.Size(179, 16);
            this.radioButton8_4.TabIndex = 27;
            this.radioButton8_4.TabStop = true;
            this.radioButton8_4.Text = "选择节点一起输出名称自定义";
            this.radioButton8_4.UseVisualStyleBackColor = true;
            // 
            // radioButton4_4
            // 
            this.radioButton4_4.AutoSize = true;
            this.radioButton4_4.Location = new System.Drawing.Point(42, 200);
            this.radioButton4_4.Name = "radioButton4_4";
            this.radioButton4_4.Size = new System.Drawing.Size(155, 16);
            this.radioButton4_4.TabIndex = 26;
            this.radioButton4_4.TabStop = true;
            this.radioButton4_4.Text = "选择的节点分别独立输出";
            this.radioButton4_4.UseVisualStyleBackColor = true;
            // 
            // radioButton7_4
            // 
            this.radioButton7_4.AutoSize = true;
            this.radioButton7_4.Checked = true;
            this.radioButton7_4.Location = new System.Drawing.Point(42, 178);
            this.radioButton7_4.Name = "radioButton7_4";
            this.radioButton7_4.Size = new System.Drawing.Size(203, 16);
            this.radioButton7_4.TabIndex = 25;
            this.radioButton7_4.TabStop = true;
            this.radioButton7_4.Text = "选择节点一起输出名称使用第一个";
            this.radioButton7_4.UseVisualStyleBackColor = true;
            // 
            // checkBox7_4
            // 
            this.checkBox7_4.AutoSize = true;
            this.checkBox7_4.CheckAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.checkBox7_4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBox7_4.Location = new System.Drawing.Point(42, 107);
            this.checkBox7_4.Name = "checkBox7_4";
            this.checkBox7_4.Size = new System.Drawing.Size(108, 16);
            this.checkBox7_4.TabIndex = 24;
            this.checkBox7_4.Text = "输出位移到原点";
            this.checkBox7_4.UseVisualStyleBackColor = true;
            // 
            // checkBox8_4
            // 
            this.checkBox8_4.AutoSize = true;
            this.checkBox8_4.CheckAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.checkBox8_4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBox8_4.Location = new System.Drawing.Point(42, 85);
            this.checkBox8_4.Name = "checkBox8_4";
            this.checkBox8_4.Size = new System.Drawing.Size(198, 16);
            this.checkBox8_4.TabIndex = 23;
            this.checkBox8_4.Text = "统一物体所有坐标为包围盒z中心";
            this.checkBox8_4.UseVisualStyleBackColor = true;
            // 
            // button7_4
            // 
            this.button7_4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button7_4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7_4.Location = new System.Drawing.Point(153, 329);
            this.button7_4.Name = "button7_4";
            this.button7_4.Size = new System.Drawing.Size(108, 41);
            this.button7_4.TabIndex = 22;
            this.button7_4.Text = "tounity 输出";
            this.button7_4.UseVisualStyleBackColor = true;
            // 
            // button8_4
            // 
            this.button8_4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button8_4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button8_4.Location = new System.Drawing.Point(22, 329);
            this.button8_4.Name = "button8_4";
            this.button8_4.Size = new System.Drawing.Size(108, 41);
            this.button8_4.TabIndex = 21;
            this.button8_4.Tag = "";
            this.button8_4.Text = "Ling 标准输出";
            this.button8_4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 577);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.TabPage tabPage3;
        public System.Windows.Forms.TabPage tabPage4;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.Label label1_1;
        public System.Windows.Forms.TextBox textBox1_1;
        public System.Windows.Forms.Label label2_1;
        public System.Windows.Forms.Button button1_1;
        public System.Windows.Forms.Button button2_1;
        public System.Windows.Forms.CheckBox checkBox1_1;
        public System.Windows.Forms.CheckBox checkBox2_1;
        public System.Windows.Forms.Label label3_2;
        public System.Windows.Forms.CheckBox checkBox3_2;
        public System.Windows.Forms.CheckBox checkBox4_2;
        public System.Windows.Forms.RadioButton radioButton3_2;
        public System.Windows.Forms.RadioButton radioButton2_2;
        public System.Windows.Forms.RadioButton radioButton1_2;
        public System.Windows.Forms.ComboBox comboBox1_2;
        public System.Windows.Forms.TextBox textBox2_2;
        public System.Windows.Forms.Button button3_2;
        public System.Windows.Forms.Button button4_2;
        public System.Windows.Forms.CheckBox checkBox5_3;
        public System.Windows.Forms.CheckBox checkBox6_3;
        public System.Windows.Forms.RadioButton radioButton5_3;
        public System.Windows.Forms.RadioButton radioButton6_3;
        public System.Windows.Forms.Label label4_3;
        public System.Windows.Forms.Button button5_3;
        public System.Windows.Forms.Button button6_3;
        public System.Windows.Forms.TextBox textBox3_4;
        public System.Windows.Forms.RadioButton radioButton8_4;
        public System.Windows.Forms.RadioButton radioButton4_4;
        public System.Windows.Forms.RadioButton radioButton7_4;
        public System.Windows.Forms.CheckBox checkBox7_4;
        public System.Windows.Forms.CheckBox checkBox8_4;
        public System.Windows.Forms.Button button7_4;
        public System.Windows.Forms.Button button8_4;
    }
}

