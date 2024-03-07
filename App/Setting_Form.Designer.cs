namespace App
{
    partial class Setting_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting_Form));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Top = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.Panel();
            this.Choose = new System.Windows.Forms.Panel();
            this.Exam = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Gender = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Exam_ = new System.Windows.Forms.Panel();
            this.ChooseQ = new System.Windows.Forms.Panel();
            this.b0708 = new System.Windows.Forms.Button();
            this.b0411 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.b3436 = new System.Windows.Forms.Button();
            this.b3335 = new System.Windows.Forms.Button();
            this.b2830 = new System.Windows.Forms.Button();
            this.b2632 = new System.Windows.Forms.Button();
            this.b2224 = new System.Windows.Forms.Button();
            this.b1721 = new System.Windows.Forms.Button();
            this.b1620 = new System.Windows.Forms.Button();
            this.b1519 = new System.Windows.Forms.Button();
            this.b0818 = new System.Windows.Forms.Button();
            this.Random = new System.Windows.Forms.Button();
            this.Sequence = new System.Windows.Forms.Button();
            this.Gender_ = new System.Windows.Forms.Panel();
            this.GirlSound_ = new System.Windows.Forms.Label();
            this.BoySound_ = new System.Windows.Forms.Label();
            this.GirlSound = new System.Windows.Forms.PictureBox();
            this.BoySound = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Top.SuspendLayout();
            this.Menu.SuspendLayout();
            this.Exam_.SuspendLayout();
            this.Gender_.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GirlSound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoySound)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Top
            // 
            this.Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(138)))), ((int)(((byte)(102)))));
            this.Top.Controls.Add(this.Exit);
            this.Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top.Location = new System.Drawing.Point(0, 0);
            this.Top.Name = "Top";
            this.Top.Size = new System.Drawing.Size(504, 30);
            this.Top.TabIndex = 1;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(138)))), ((int)(((byte)(102)))));
            this.Exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(138)))), ((int)(((byte)(102)))));
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(472, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(32, 32);
            this.Exit.TabIndex = 5;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(166)))), ((int)(((byte)(123)))));
            this.Menu.Controls.Add(this.Choose);
            this.Menu.Controls.Add(this.Exam);
            this.Menu.Controls.Add(this.Gender);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.Menu.Location = new System.Drawing.Point(0, 30);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(504, 105);
            this.Menu.TabIndex = 2;
            // 
            // Choose
            // 
            this.Choose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(107)))), ((int)(((byte)(90)))));
            this.Choose.Location = new System.Drawing.Point(72, 97);
            this.Choose.Name = "Choose";
            this.Choose.Size = new System.Drawing.Size(134, 8);
            this.Choose.TabIndex = 3;
            // 
            // Exam
            // 
            this.Exam.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(166)))), ((int)(((byte)(123)))));
            this.Exam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(166)))), ((int)(((byte)(123)))));
            this.Exam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exam.BorderRadius = 0;
            this.Exam.ButtonText = "題庫";
            this.Exam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exam.DisabledColor = System.Drawing.Color.Gray;
            this.Exam.Iconcolor = System.Drawing.Color.Transparent;
            this.Exam.Iconimage = null;
            this.Exam.Iconimage_right = null;
            this.Exam.Iconimage_right_Selected = null;
            this.Exam.Iconimage_Selected = null;
            this.Exam.IconMarginLeft = 0;
            this.Exam.IconMarginRight = 0;
            this.Exam.IconRightVisible = true;
            this.Exam.IconRightZoom = 0D;
            this.Exam.IconVisible = true;
            this.Exam.IconZoom = 90D;
            this.Exam.IsTab = false;
            this.Exam.Location = new System.Drawing.Point(310, 0);
            this.Exam.Name = "Exam";
            this.Exam.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(166)))), ((int)(((byte)(123)))));
            this.Exam.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(136)))), ((int)(((byte)(101)))));
            this.Exam.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(50)))), ((int)(((byte)(36)))));
            this.Exam.selected = false;
            this.Exam.Size = new System.Drawing.Size(134, 105);
            this.Exam.TabIndex = 1;
            this.Exam.Text = "題庫";
            this.Exam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Exam.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(50)))), ((int)(((byte)(36)))));
            this.Exam.TextFont = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Exam.Click += new System.EventHandler(this.Exam_Click);
            // 
            // Gender
            // 
            this.Gender.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(166)))), ((int)(((byte)(123)))));
            this.Gender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(166)))), ((int)(((byte)(123)))));
            this.Gender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Gender.BorderRadius = 0;
            this.Gender.ButtonText = "音源";
            this.Gender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gender.DisabledColor = System.Drawing.Color.Gray;
            this.Gender.Iconcolor = System.Drawing.Color.Transparent;
            this.Gender.Iconimage = null;
            this.Gender.Iconimage_right = null;
            this.Gender.Iconimage_right_Selected = null;
            this.Gender.Iconimage_Selected = null;
            this.Gender.IconMarginLeft = 0;
            this.Gender.IconMarginRight = 0;
            this.Gender.IconRightVisible = true;
            this.Gender.IconRightZoom = 0D;
            this.Gender.IconVisible = true;
            this.Gender.IconZoom = 90D;
            this.Gender.IsTab = false;
            this.Gender.Location = new System.Drawing.Point(72, 0);
            this.Gender.Name = "Gender";
            this.Gender.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(166)))), ((int)(((byte)(123)))));
            this.Gender.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(136)))), ((int)(((byte)(101)))));
            this.Gender.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(50)))), ((int)(((byte)(36)))));
            this.Gender.selected = false;
            this.Gender.Size = new System.Drawing.Size(134, 105);
            this.Gender.TabIndex = 0;
            this.Gender.Text = "音源";
            this.Gender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Gender.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(50)))), ((int)(((byte)(36)))));
            this.Gender.TextFont = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Gender.Click += new System.EventHandler(this.Gender_Click);
            // 
            // Exam_
            // 
            this.Exam_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(129)))), ((int)(((byte)(122)))));
            this.Exam_.Controls.Add(this.ChooseQ);
            this.Exam_.Controls.Add(this.b0708);
            this.Exam_.Controls.Add(this.b0411);
            this.Exam_.Controls.Add(this.button10);
            this.Exam_.Controls.Add(this.b3436);
            this.Exam_.Controls.Add(this.b3335);
            this.Exam_.Controls.Add(this.b2830);
            this.Exam_.Controls.Add(this.b2632);
            this.Exam_.Controls.Add(this.b2224);
            this.Exam_.Controls.Add(this.b1721);
            this.Exam_.Controls.Add(this.b1620);
            this.Exam_.Controls.Add(this.b1519);
            this.Exam_.Controls.Add(this.b0818);
            this.Exam_.Controls.Add(this.Random);
            this.Exam_.Controls.Add(this.Sequence);
            this.Exam_.Location = new System.Drawing.Point(0, 135);
            this.Exam_.Name = "Exam_";
            this.Exam_.Size = new System.Drawing.Size(504, 507);
            this.Exam_.TabIndex = 3;
            // 
            // ChooseQ
            // 
            this.ChooseQ.BackColor = System.Drawing.Color.Transparent;
            this.ChooseQ.Location = new System.Drawing.Point(0, 356);
            this.ChooseQ.Name = "ChooseQ";
            this.ChooseQ.Size = new System.Drawing.Size(10, 55);
            this.ChooseQ.TabIndex = 2;
            // 
            // b0708
            // 
            this.b0708.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(151)))), ((int)(((byte)(112)))));
            this.b0708.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.b0708.FlatAppearance.BorderSize = 0;
            this.b0708.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b0708.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.b0708.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(80)))), ((int)(((byte)(72)))));
            this.b0708.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.b0708.Location = new System.Drawing.Point(72, 67);
            this.b0708.Name = "b0708";
            this.b0708.Size = new System.Drawing.Size(134, 55);
            this.b0708.TabIndex = 15;
            this.b0708.Text = "ㄋ、ㄌ";
            this.b0708.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b0708.UseVisualStyleBackColor = false;
            this.b0708.Click += new System.EventHandler(this.b0708_Click);
            // 
            // b0411
            // 
            this.b0411.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(151)))), ((int)(((byte)(112)))));
            this.b0411.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.b0411.FlatAppearance.BorderSize = 0;
            this.b0411.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b0411.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.b0411.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(80)))), ((int)(((byte)(72)))));
            this.b0411.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.b0411.Location = new System.Drawing.Point(72, 12);
            this.b0411.Name = "b0411";
            this.b0411.Size = new System.Drawing.Size(134, 55);
            this.b0411.TabIndex = 14;
            this.b0411.Text = "ㄈ、ㄏ";
            this.b0411.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b0411.UseVisualStyleBackColor = false;
            this.b0411.Click += new System.EventHandler(this.b0411_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(151)))), ((int)(((byte)(112)))));
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(80)))), ((int)(((byte)(72)))));
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button10.Location = new System.Drawing.Point(296, 341);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(134, 55);
            this.button10.TabIndex = 13;
            this.button10.Text = "展示題組";
            this.button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // b3436
            // 
            this.b3436.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(151)))), ((int)(((byte)(112)))));
            this.b3436.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.b3436.FlatAppearance.BorderSize = 0;
            this.b3436.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b3436.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.b3436.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(80)))), ((int)(((byte)(72)))));
            this.b3436.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.b3436.Location = new System.Drawing.Point(296, 177);
            this.b3436.Name = "b3436";
            this.b3436.Size = new System.Drawing.Size(134, 55);
            this.b3436.TabIndex = 12;
            this.b3436.Text = "ㄣ、ㄥ";
            this.b3436.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b3436.UseVisualStyleBackColor = false;
            this.b3436.Click += new System.EventHandler(this.b3436_Click);
            // 
            // b3335
            // 
            this.b3335.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(151)))), ((int)(((byte)(112)))));
            this.b3335.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.b3335.FlatAppearance.BorderSize = 0;
            this.b3335.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b3335.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.b3335.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(80)))), ((int)(((byte)(72)))));
            this.b3335.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.b3335.Location = new System.Drawing.Point(296, 122);
            this.b3335.Name = "b3335";
            this.b3335.Size = new System.Drawing.Size(134, 55);
            this.b3335.TabIndex = 11;
            this.b3335.Text = "ㄢ、ㄤ";
            this.b3335.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b3335.UseVisualStyleBackColor = false;
            this.b3335.Click += new System.EventHandler(this.b3335_Click);
            // 
            // b2830
            // 
            this.b2830.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(151)))), ((int)(((byte)(112)))));
            this.b2830.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.b2830.FlatAppearance.BorderSize = 0;
            this.b2830.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b2830.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.b2830.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(80)))), ((int)(((byte)(72)))));
            this.b2830.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.b2830.Location = new System.Drawing.Point(296, 67);
            this.b2830.Name = "b2830";
            this.b2830.Size = new System.Drawing.Size(134, 55);
            this.b2830.TabIndex = 10;
            this.b2830.Text = "ㄝ、ㄟ";
            this.b2830.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b2830.UseVisualStyleBackColor = false;
            this.b2830.Click += new System.EventHandler(this.b2830_Click);
            // 
            // b2632
            // 
            this.b2632.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(151)))), ((int)(((byte)(112)))));
            this.b2632.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.b2632.FlatAppearance.BorderSize = 0;
            this.b2632.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b2632.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.b2632.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(80)))), ((int)(((byte)(72)))));
            this.b2632.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.b2632.Location = new System.Drawing.Point(296, 12);
            this.b2632.Name = "b2632";
            this.b2632.Size = new System.Drawing.Size(134, 55);
            this.b2632.TabIndex = 9;
            this.b2632.Text = "ㄛ、ㄡ";
            this.b2632.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b2632.UseVisualStyleBackColor = false;
            this.b2632.Click += new System.EventHandler(this.b2632_Click);
            // 
            // b2224
            // 
            this.b2224.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(151)))), ((int)(((byte)(112)))));
            this.b2224.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.b2224.FlatAppearance.BorderSize = 0;
            this.b2224.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b2224.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.b2224.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(80)))), ((int)(((byte)(72)))));
            this.b2224.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.b2224.Location = new System.Drawing.Point(72, 341);
            this.b2224.Name = "b2224";
            this.b2224.Size = new System.Drawing.Size(134, 55);
            this.b2224.TabIndex = 8;
            this.b2224.Text = "ㄧ、ㄩ";
            this.b2224.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b2224.UseVisualStyleBackColor = false;
            this.b2224.Click += new System.EventHandler(this.b2224_Click);
            // 
            // b1721
            // 
            this.b1721.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(151)))), ((int)(((byte)(112)))));
            this.b1721.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.b1721.FlatAppearance.BorderSize = 0;
            this.b1721.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b1721.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.b1721.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(80)))), ((int)(((byte)(72)))));
            this.b1721.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.b1721.Location = new System.Drawing.Point(72, 287);
            this.b1721.Name = "b1721";
            this.b1721.Size = new System.Drawing.Size(134, 55);
            this.b1721.TabIndex = 7;
            this.b1721.Text = "ㄕ、ㄙ";
            this.b1721.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b1721.UseVisualStyleBackColor = false;
            this.b1721.Click += new System.EventHandler(this.b1721_Click);
            // 
            // b1620
            // 
            this.b1620.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(151)))), ((int)(((byte)(112)))));
            this.b1620.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.b1620.FlatAppearance.BorderSize = 0;
            this.b1620.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b1620.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.b1620.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(80)))), ((int)(((byte)(72)))));
            this.b1620.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.b1620.Location = new System.Drawing.Point(72, 232);
            this.b1620.Name = "b1620";
            this.b1620.Size = new System.Drawing.Size(134, 55);
            this.b1620.TabIndex = 6;
            this.b1620.Text = "ㄔ、ㄘ";
            this.b1620.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b1620.UseVisualStyleBackColor = false;
            this.b1620.Click += new System.EventHandler(this.b1620_Click);
            // 
            // b1519
            // 
            this.b1519.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(151)))), ((int)(((byte)(112)))));
            this.b1519.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.b1519.FlatAppearance.BorderSize = 0;
            this.b1519.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b1519.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.b1519.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(80)))), ((int)(((byte)(72)))));
            this.b1519.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.b1519.Location = new System.Drawing.Point(72, 177);
            this.b1519.Name = "b1519";
            this.b1519.Size = new System.Drawing.Size(134, 55);
            this.b1519.TabIndex = 5;
            this.b1519.Text = "ㄓ、ㄗ";
            this.b1519.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b1519.UseVisualStyleBackColor = false;
            this.b1519.Click += new System.EventHandler(this.b1519_Click);
            // 
            // b0818
            // 
            this.b0818.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(151)))), ((int)(((byte)(112)))));
            this.b0818.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.b0818.FlatAppearance.BorderSize = 0;
            this.b0818.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b0818.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.b0818.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(80)))), ((int)(((byte)(72)))));
            this.b0818.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.b0818.Location = new System.Drawing.Point(72, 122);
            this.b0818.Name = "b0818";
            this.b0818.Size = new System.Drawing.Size(134, 55);
            this.b0818.TabIndex = 4;
            this.b0818.Text = "ㄌ、ㄖ";
            this.b0818.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b0818.UseVisualStyleBackColor = false;
            this.b0818.Click += new System.EventHandler(this.b0818_Click);
            // 
            // Random
            // 
            this.Random.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(151)))), ((int)(((byte)(112)))));
            this.Random.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.Random.FlatAppearance.BorderSize = 0;
            this.Random.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Random.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Random.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(80)))), ((int)(((byte)(72)))));
            this.Random.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Random.Location = new System.Drawing.Point(296, 287);
            this.Random.Name = "Random";
            this.Random.Size = new System.Drawing.Size(134, 55);
            this.Random.TabIndex = 3;
            this.Random.Text = "題庫測試2";
            this.Random.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Random.UseVisualStyleBackColor = false;
            this.Random.Click += new System.EventHandler(this.Random_Click);
            // 
            // Sequence
            // 
            this.Sequence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(151)))), ((int)(((byte)(112)))));
            this.Sequence.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.Sequence.FlatAppearance.BorderSize = 0;
            this.Sequence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sequence.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Sequence.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(80)))), ((int)(((byte)(72)))));
            this.Sequence.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Sequence.Location = new System.Drawing.Point(296, 232);
            this.Sequence.Name = "Sequence";
            this.Sequence.Size = new System.Drawing.Size(134, 55);
            this.Sequence.TabIndex = 1;
            this.Sequence.Text = "題庫測試1";
            this.Sequence.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Sequence.UseVisualStyleBackColor = false;
            this.Sequence.Click += new System.EventHandler(this.SequenceSet_Click);
            // 
            // Gender_
            // 
            this.Gender_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(129)))), ((int)(((byte)(122)))));
            this.Gender_.Controls.Add(this.GirlSound_);
            this.Gender_.Controls.Add(this.BoySound_);
            this.Gender_.Controls.Add(this.GirlSound);
            this.Gender_.Controls.Add(this.BoySound);
            this.Gender_.Controls.Add(this.label1);
            this.Gender_.Dock = System.Windows.Forms.DockStyle.Top;
            this.Gender_.Location = new System.Drawing.Point(0, 135);
            this.Gender_.Name = "Gender_";
            this.Gender_.Size = new System.Drawing.Size(504, 433);
            this.Gender_.TabIndex = 4;
            // 
            // GirlSound_
            // 
            this.GirlSound_.AutoSize = true;
            this.GirlSound_.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold);
            this.GirlSound_.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(194)))), ((int)(((byte)(113)))));
            this.GirlSound_.Location = new System.Drawing.Point(346, 295);
            this.GirlSound_.Name = "GirlSound_";
            this.GirlSound_.Size = new System.Drawing.Size(48, 24);
            this.GirlSound_.TabIndex = 4;
            this.GirlSound_.Text = "女聲";
            // 
            // BoySound_
            // 
            this.BoySound_.AutoSize = true;
            this.BoySound_.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold);
            this.BoySound_.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(194)))), ((int)(((byte)(113)))));
            this.BoySound_.Location = new System.Drawing.Point(119, 295);
            this.BoySound_.Name = "BoySound_";
            this.BoySound_.Size = new System.Drawing.Size(48, 24);
            this.BoySound_.TabIndex = 3;
            this.BoySound_.Text = "男聲";
            // 
            // GirlSound
            // 
            this.GirlSound.Image = ((System.Drawing.Image)(resources.GetObject("GirlSound.Image")));
            this.GirlSound.InitialImage = null;
            this.GirlSound.Location = new System.Drawing.Point(310, 120);
            this.GirlSound.Name = "GirlSound";
            this.GirlSound.Size = new System.Drawing.Size(120, 164);
            this.GirlSound.TabIndex = 2;
            this.GirlSound.TabStop = false;
            this.GirlSound.Click += new System.EventHandler(this.GirlSound_Click);
            this.GirlSound.Paint += new System.Windows.Forms.PaintEventHandler(this.GirlSound_Paint);
            // 
            // BoySound
            // 
            this.BoySound.Image = ((System.Drawing.Image)(resources.GetObject("BoySound.Image")));
            this.BoySound.Location = new System.Drawing.Point(86, 120);
            this.BoySound.Name = "BoySound";
            this.BoySound.Size = new System.Drawing.Size(120, 164);
            this.BoySound.TabIndex = 1;
            this.BoySound.TabStop = false;
            this.BoySound.Click += new System.EventHandler(this.BoySound_Click);
            this.BoySound.Paint += new System.Windows.Forms.PaintEventHandler(this.BoySound_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(217)))));
            this.label1.Location = new System.Drawing.Point(145, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "--選擇語音類型--";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.Top;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Setting_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(117)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(504, 547);
            this.Controls.Add(this.Gender_);
            this.Controls.Add(this.Exam_);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Setting_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting_Form";
            this.Load += new System.EventHandler(this.Setting_Form_Load);
            this.Top.ResumeLayout(false);
            this.Menu.ResumeLayout(false);
            this.Exam_.ResumeLayout(false);
            this.Gender_.ResumeLayout(false);
            this.Gender_.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GirlSound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoySound)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel Top;
        private System.Windows.Forms.Panel Menu;
        private Bunifu.Framework.UI.BunifuFlatButton Gender;
        private Bunifu.Framework.UI.BunifuFlatButton Exam;
        private System.Windows.Forms.Panel Choose;
        private System.Windows.Forms.Panel Exam_;
        private System.Windows.Forms.Panel Gender_;
        private System.Windows.Forms.PictureBox GirlSound;
        private System.Windows.Forms.PictureBox BoySound;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label GirlSound_;
        private System.Windows.Forms.Label BoySound_;
        private System.Windows.Forms.Button Sequence;
        private System.Windows.Forms.Panel ChooseQ;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Random;
        private System.Windows.Forms.Button b0708;
        private System.Windows.Forms.Button b0411;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button b3436;
        private System.Windows.Forms.Button b3335;
        private System.Windows.Forms.Button b2830;
        private System.Windows.Forms.Button b2632;
        private System.Windows.Forms.Button b2224;
        private System.Windows.Forms.Button b1721;
        private System.Windows.Forms.Button b1620;
        private System.Windows.Forms.Button b1519;
        private System.Windows.Forms.Button b0818;
    }
}