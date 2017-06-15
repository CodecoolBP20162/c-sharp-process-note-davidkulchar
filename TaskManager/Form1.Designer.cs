namespace TaskManager
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRunNewTask = new System.Windows.Forms.Button();
            this.lbCpu = new System.Windows.Forms.Label();
            this.lbRunTime = new System.Windows.Forms.Label();
            this.lbMem = new System.Windows.Forms.Label();
            this.lbStartTime = new System.Windows.Forms.Label();
            this.btnProps = new System.Windows.Forms.Button();
            this.lbThreads = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(340, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "EndTask";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Pr,
            this.Comment});
            this.dataGridView1.GridColor = System.Drawing.Color.Maroon;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 10;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.Size = new System.Drawing.Size(322, 237);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 30;
            // 
            // Pr
            // 
            this.Pr.HeaderText = "Pr";
            this.Pr.Name = "Pr";
            this.Pr.ReadOnly = true;
            // 
            // Comment
            // 
            this.Comment.HeaderText = "Comment";
            this.Comment.Name = "Comment";
            this.Comment.Width = 250;
            // 
            // btnRunNewTask
            // 
            this.btnRunNewTask.Location = new System.Drawing.Point(340, 168);
            this.btnRunNewTask.Name = "btnRunNewTask";
            this.btnRunNewTask.Size = new System.Drawing.Size(164, 23);
            this.btnRunNewTask.TabIndex = 6;
            this.btnRunNewTask.Text = "Start New Task";
            this.btnRunNewTask.UseVisualStyleBackColor = true;
            this.btnRunNewTask.Click += new System.EventHandler(this.btnRunNewTask_Click);
            // 
            // lbCpu
            // 
            this.lbCpu.AutoSize = true;
            this.lbCpu.Location = new System.Drawing.Point(340, 12);
            this.lbCpu.Name = "lbCpu";
            this.lbCpu.Size = new System.Drawing.Size(25, 13);
            this.lbCpu.TabIndex = 7;
            this.lbCpu.Text = "      ";
            // 
            // lbRunTime
            // 
            this.lbRunTime.AutoSize = true;
            this.lbRunTime.Location = new System.Drawing.Point(340, 82);
            this.lbRunTime.Name = "lbRunTime";
            this.lbRunTime.Size = new System.Drawing.Size(34, 13);
            this.lbRunTime.TabIndex = 8;
            this.lbRunTime.Text = "         ";
            // 
            // lbMem
            // 
            this.lbMem.AutoSize = true;
            this.lbMem.Location = new System.Drawing.Point(340, 35);
            this.lbMem.Name = "lbMem";
            this.lbMem.Size = new System.Drawing.Size(34, 13);
            this.lbMem.TabIndex = 9;
            this.lbMem.Text = "         ";
            // 
            // lbStartTime
            // 
            this.lbStartTime.AutoSize = true;
            this.lbStartTime.Location = new System.Drawing.Point(340, 127);
            this.lbStartTime.Name = "lbStartTime";
            this.lbStartTime.Size = new System.Drawing.Size(34, 13);
            this.lbStartTime.TabIndex = 10;
            this.lbStartTime.Text = "         ";
            this.lbStartTime.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnProps
            // 
            this.btnProps.Location = new System.Drawing.Point(340, 197);
            this.btnProps.Name = "btnProps";
            this.btnProps.Size = new System.Drawing.Size(164, 23);
            this.btnProps.TabIndex = 5;
            this.btnProps.Text = "Threads";
            this.btnProps.UseVisualStyleBackColor = true;
            this.btnProps.Click += new System.EventHandler(this.btnProps_Click);
            // 
            // lbThreads
            // 
            this.lbThreads.AutoSize = true;
            this.lbThreads.Location = new System.Drawing.Point(340, 60);
            this.lbThreads.Name = "lbThreads";
            this.lbThreads.Size = new System.Drawing.Size(34, 13);
            this.lbThreads.TabIndex = 12;
            this.lbThreads.Text = "         ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 258);
            this.Controls.Add(this.lbThreads);
            this.Controls.Add(this.lbStartTime);
            this.Controls.Add(this.lbMem);
            this.Controls.Add(this.lbRunTime);
            this.Controls.Add(this.lbCpu);
            this.Controls.Add(this.btnRunNewTask);
            this.Controls.Add(this.btnProps);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "TheTaskManager";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.Leave += new System.EventHandler(this.Form1_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRunNewTask;
        private System.Windows.Forms.Label lbCpu;
        private System.Windows.Forms.Label lbRunTime;
        private System.Windows.Forms.Label lbMem;
        private System.Windows.Forms.Label lbStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
        private System.Windows.Forms.Button btnProps;
        private System.Windows.Forms.Label lbThreads;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

