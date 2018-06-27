namespace FileCorruptor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_save_project = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_load_project = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_import_file = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_export_file = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cb_protectFromOverwrite = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_file_bytes = new System.Windows.Forms.Label();
            this.ImportFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.hex_source_file = new Be.Windows.Forms.HexBox();
            this.lbl_source_hexbox = new System.Windows.Forms.Label();
            this.lbl_target_hexbox = new System.Windows.Forms.Label();
            this.hex_target_file = new Be.Windows.Forms.HexBox();
            this.tb_goto = new System.Windows.Forms.TextBox();
            this.lb_targetFiles = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_file_identifier = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_selected_file_path = new System.Windows.Forms.Label();
            this.btn_file_create_copy = new System.Windows.Forms.Button();
            this.btn_set_source_file = new System.Windows.Forms.Button();
            this.btn_set_target_file = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_save_file = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_hash = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save_changes = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identifier";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1281, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_save_project,
            this.menu_load_project,
            this.toolStripSeparator1,
            this.menu_import_file,
            this.menu_export_file,
            this.toolStripSeparator2,
            this.menu_exit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menu_save_project
            // 
            this.menu_save_project.Name = "menu_save_project";
            this.menu_save_project.Size = new System.Drawing.Size(152, 22);
            this.menu_save_project.Text = "Save Project";
            // 
            // menu_load_project
            // 
            this.menu_load_project.Name = "menu_load_project";
            this.menu_load_project.Size = new System.Drawing.Size(152, 22);
            this.menu_load_project.Text = "Load Project";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // menu_import_file
            // 
            this.menu_import_file.Name = "menu_import_file";
            this.menu_import_file.Size = new System.Drawing.Size(152, 22);
            this.menu_import_file.Text = "Import File";
            this.menu_import_file.Click += new System.EventHandler(this.menu_import_file_Click);
            // 
            // menu_export_file
            // 
            this.menu_export_file.Name = "menu_export_file";
            this.menu_export_file.Size = new System.Drawing.Size(152, 22);
            this.menu_export_file.Text = "Export File";
            // 
            // menu_exit
            // 
            this.menu_exit.Name = "menu_exit";
            this.menu_exit.Size = new System.Drawing.Size(152, 22);
            this.menu_exit.Text = "Exit";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // cb_protectFromOverwrite
            // 
            this.cb_protectFromOverwrite.AutoSize = true;
            this.cb_protectFromOverwrite.Location = new System.Drawing.Point(161, 14);
            this.cb_protectFromOverwrite.Name = "cb_protectFromOverwrite";
            this.cb_protectFromOverwrite.Size = new System.Drawing.Size(73, 17);
            this.cb_protectFromOverwrite.TabIndex = 2;
            this.cb_protectFromOverwrite.Text = "ReadOnly";
            this.cb_protectFromOverwrite.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bytes:";
            // 
            // lbl_file_bytes
            // 
            this.lbl_file_bytes.AutoSize = true;
            this.lbl_file_bytes.Location = new System.Drawing.Point(39, 52);
            this.lbl_file_bytes.Name = "lbl_file_bytes";
            this.lbl_file_bytes.Size = new System.Drawing.Size(0, 13);
            this.lbl_file_bytes.TabIndex = 5;
            // 
            // ImportFileDialog
            // 
            this.ImportFileDialog.FileName = "openFileDialog1";
            // 
            // hex_source_file
            // 
            this.hex_source_file.ColumnInfoVisible = true;
            this.hex_source_file.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hex_source_file.LineInfoVisible = true;
            this.hex_source_file.Location = new System.Drawing.Point(4, 201);
            this.hex_source_file.Name = "hex_source_file";
            this.hex_source_file.ReadOnly = true;
            this.hex_source_file.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.hex_source_file.Size = new System.Drawing.Size(637, 593);
            this.hex_source_file.StringViewVisible = true;
            this.hex_source_file.TabIndex = 6;
            this.hex_source_file.UseFixedBytesPerLine = true;
            this.hex_source_file.VScrollBarVisible = true;
            // 
            // lbl_source_hexbox
            // 
            this.lbl_source_hexbox.AutoSize = true;
            this.lbl_source_hexbox.Location = new System.Drawing.Point(2, 185);
            this.lbl_source_hexbox.Name = "lbl_source_hexbox";
            this.lbl_source_hexbox.Size = new System.Drawing.Size(60, 13);
            this.lbl_source_hexbox.TabIndex = 7;
            this.lbl_source_hexbox.Text = "Source File";
            // 
            // lbl_target_hexbox
            // 
            this.lbl_target_hexbox.AutoSize = true;
            this.lbl_target_hexbox.Location = new System.Drawing.Point(639, 185);
            this.lbl_target_hexbox.Name = "lbl_target_hexbox";
            this.lbl_target_hexbox.Size = new System.Drawing.Size(57, 13);
            this.lbl_target_hexbox.TabIndex = 9;
            this.lbl_target_hexbox.Text = "Target File";
            // 
            // hex_target_file
            // 
            this.hex_target_file.ColumnInfoVisible = true;
            this.hex_target_file.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hex_target_file.LineInfoVisible = true;
            this.hex_target_file.Location = new System.Drawing.Point(642, 201);
            this.hex_target_file.Name = "hex_target_file";
            this.hex_target_file.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.hex_target_file.Size = new System.Drawing.Size(637, 593);
            this.hex_target_file.StringViewVisible = true;
            this.hex_target_file.TabIndex = 8;
            this.hex_target_file.UseFixedBytesPerLine = true;
            this.hex_target_file.VScrollBarVisible = true;
            // 
            // tb_goto
            // 
            this.tb_goto.Location = new System.Drawing.Point(1169, 119);
            this.tb_goto.Name = "tb_goto";
            this.tb_goto.Size = new System.Drawing.Size(100, 20);
            this.tb_goto.TabIndex = 10;
            // 
            // lb_targetFiles
            // 
            this.lb_targetFiles.FormattingEnabled = true;
            this.lb_targetFiles.Location = new System.Drawing.Point(5, 48);
            this.lb_targetFiles.Name = "lb_targetFiles";
            this.lb_targetFiles.Size = new System.Drawing.Size(136, 134);
            this.lb_targetFiles.TabIndex = 11;
            this.lb_targetFiles.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lb_targetFiles_DrawItem);
            this.lb_targetFiles.SelectedIndexChanged += new System.EventHandler(this.lb_targetFiles_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.lbl_hash);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btn_save_file);
            this.groupBox1.Controls.Add(this.btn_set_target_file);
            this.groupBox1.Controls.Add(this.btn_set_source_file);
            this.groupBox1.Controls.Add(this.btn_file_create_copy);
            this.groupBox1.Controls.Add(this.lbl_selected_file_path);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_file_identifier);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cb_protectFromOverwrite);
            this.groupBox1.Controls.Add(this.lbl_file_bytes);
            this.groupBox1.Location = new System.Drawing.Point(147, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 158);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File";
            // 
            // tb_file_identifier
            // 
            this.tb_file_identifier.Location = new System.Drawing.Point(55, 12);
            this.tb_file_identifier.Name = "tb_file_identifier";
            this.tb_file_identifier.Size = new System.Drawing.Size(100, 20);
            this.tb_file_identifier.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Path:";
            // 
            // lbl_selected_file_path
            // 
            this.lbl_selected_file_path.AutoSize = true;
            this.lbl_selected_file_path.Location = new System.Drawing.Point(33, 35);
            this.lbl_selected_file_path.Name = "lbl_selected_file_path";
            this.lbl_selected_file_path.Size = new System.Drawing.Size(0, 13);
            this.lbl_selected_file_path.TabIndex = 15;
            // 
            // btn_file_create_copy
            // 
            this.btn_file_create_copy.Location = new System.Drawing.Point(229, 42);
            this.btn_file_create_copy.Name = "btn_file_create_copy";
            this.btn_file_create_copy.Size = new System.Drawing.Size(78, 23);
            this.btn_file_create_copy.TabIndex = 13;
            this.btn_file_create_copy.Text = "Create Copy";
            this.btn_file_create_copy.UseVisualStyleBackColor = true;
            this.btn_file_create_copy.Click += new System.EventHandler(this.btn_file_create_copy_Click);
            // 
            // btn_set_source_file
            // 
            this.btn_set_source_file.Location = new System.Drawing.Point(202, 111);
            this.btn_set_source_file.Name = "btn_set_source_file";
            this.btn_set_source_file.Size = new System.Drawing.Size(105, 23);
            this.btn_set_source_file.TabIndex = 16;
            this.btn_set_source_file.Text = "Set As Source File";
            this.btn_set_source_file.UseVisualStyleBackColor = true;
            this.btn_set_source_file.Click += new System.EventHandler(this.btn_set_source_file_Click);
            // 
            // btn_set_target_file
            // 
            this.btn_set_target_file.Location = new System.Drawing.Point(202, 133);
            this.btn_set_target_file.Name = "btn_set_target_file";
            this.btn_set_target_file.Size = new System.Drawing.Size(105, 23);
            this.btn_set_target_file.TabIndex = 17;
            this.btn_set_target_file.Text = "Set As Target File";
            this.btn_set_target_file.UseVisualStyleBackColor = true;
            this.btn_set_target_file.Click += new System.EventHandler(this.btn_set_target_file_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(115, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 110);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pass";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(342, 32);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Randomize";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(342, 10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(105, 23);
            this.button5.TabIndex = 13;
            this.button5.Text = "Create New";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(250, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 20);
            this.textBox1.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(181, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Start Address";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(250, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(68, 20);
            this.textBox2.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(181, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "End Address";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(61, 81);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(68, 20);
            this.textBox3.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Chunk Size";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(61, 60);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(68, 20);
            this.textBox4.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Interval";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(103, 121);
            this.listBox1.TabIndex = 19;
            // 
            // btn_save_file
            // 
            this.btn_save_file.Location = new System.Drawing.Point(229, 64);
            this.btn_save_file.Name = "btn_save_file";
            this.btn_save_file.Size = new System.Drawing.Size(78, 23);
            this.btn_save_file.TabIndex = 18;
            this.btn_save_file.Text = "Save As";
            this.btn_save_file.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Hash:";
            // 
            // lbl_hash
            // 
            this.lbl_hash.AutoSize = true;
            this.lbl_hash.Location = new System.Drawing.Point(33, 82);
            this.lbl_hash.Name = "lbl_hash";
            this.lbl_hash.Size = new System.Drawing.Size(0, 13);
            this.lbl_hash.TabIndex = 20;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(229, 86);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(78, 23);
            this.btn_delete.TabIndex = 21;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_save_changes
            // 
            this.btn_save_changes.Location = new System.Drawing.Point(1189, 180);
            this.btn_save_changes.Name = "btn_save_changes";
            this.btn_save_changes.Size = new System.Drawing.Size(90, 23);
            this.btn_save_changes.TabIndex = 22;
            this.btn_save_changes.Text = "Save Changes";
            this.btn_save_changes.UseVisualStyleBackColor = true;
            this.btn_save_changes.Click += new System.EventHandler(this.btn_save_changes_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Location = new System.Drawing.Point(459, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(576, 158);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Corrupt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Files";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Passes";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(453, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 34);
            this.button1.TabIndex = 24;
            this.button1.Text = "Write to File";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(61, 23);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Identifier";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(250, 78);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(26, 20);
            this.textBox6.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(169, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "WriteValue Max";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(250, 57);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(26, 20);
            this.textBox7.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(169, 60);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "WriteValue Min";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 487);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_save_changes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_targetFiles);
            this.Controls.Add(this.tb_goto);
            this.Controls.Add(this.lbl_target_hexbox);
            this.Controls.Add(this.hex_target_file);
            this.Controls.Add(this.lbl_source_hexbox);
            this.Controls.Add(this.hex_source_file);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "File Corruptor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_save_project;
        private System.Windows.Forms.ToolStripMenuItem menu_load_project;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menu_import_file;
        private System.Windows.Forms.ToolStripMenuItem menu_export_file;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menu_exit;
        private System.Windows.Forms.CheckBox cb_protectFromOverwrite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_file_bytes;
        private System.Windows.Forms.OpenFileDialog ImportFileDialog;
        private Be.Windows.Forms.HexBox hex_source_file;
        private System.Windows.Forms.Label lbl_source_hexbox;
        private System.Windows.Forms.Label lbl_target_hexbox;
        private Be.Windows.Forms.HexBox hex_target_file;
        private System.Windows.Forms.TextBox tb_goto;
        private System.Windows.Forms.ListBox lb_targetFiles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_file_identifier;
        private System.Windows.Forms.Button btn_file_create_copy;
        private System.Windows.Forms.Label lbl_selected_file_path;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_set_target_file;
        private System.Windows.Forms.Button btn_set_source_file;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lbl_hash;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_save_file;
        private System.Windows.Forms.Button btn_save_changes;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
    }
}

