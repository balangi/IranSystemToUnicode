namespace SaipaDiesel.Tamin.UI;

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
        btnDiskKar = new Button();
        dataGridView1 = new DataGridView();
        txtDiskKar = new TextBox();
        lblDiskKar = new Label();
        dataGridView2 = new DataGridView();
        txtDiskWork = new TextBox();
        lblDiskWork = new Label();
        btnDiskWork = new Button();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
        SuspendLayout();
        // 
        // btnDiskKar
        // 
        btnDiskKar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnDiskKar.Location = new Point(1013, 21);
        btnDiskKar.Margin = new Padding(4, 3, 4, 3);
        btnDiskKar.Name = "btnDiskKar";
        btnDiskKar.Size = new Size(37, 27);
        btnDiskKar.TabIndex = 1;
        btnDiskKar.Text = "...";
        btnDiskKar.UseVisualStyleBackColor = true;
        btnDiskKar.Click += btnDiskKar_Click;
        // 
        // dataGridView1
        // 
        dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(13, 122);
        dataGridView1.Margin = new Padding(4, 3, 4, 3);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.Size = new Size(1037, 215);
        dataGridView1.TabIndex = 2;
        // 
        // txtDiskKar
        // 
        txtDiskKar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtDiskKar.Location = new Point(111, 24);
        txtDiskKar.Margin = new Padding(4, 3, 4, 3);
        txtDiskKar.Name = "txtDiskKar";
        txtDiskKar.Size = new Size(895, 23);
        txtDiskKar.TabIndex = 28;
        // 
        // lblDiskKar
        // 
        lblDiskKar.AutoSize = true;
        lblDiskKar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
        lblDiskKar.Location = new Point(21, 28);
        lblDiskKar.Margin = new Padding(4, 0, 4, 0);
        lblDiskKar.Name = "lblDiskKar";
        lblDiskKar.Size = new Size(84, 13);
        lblDiskKar.TabIndex = 27;
        lblDiskKar.Text = "Disk Kargah :";
        // 
        // dataGridView2
        // 
        dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView2.Location = new Point(13, 354);
        dataGridView2.Margin = new Padding(4, 3, 4, 3);
        dataGridView2.Name = "dataGridView2";
        dataGridView2.Size = new Size(1037, 197);
        dataGridView2.TabIndex = 29;
        // 
        // txtDiskWork
        // 
        txtDiskWork.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtDiskWork.Location = new Point(111, 65);
        txtDiskWork.Margin = new Padding(4, 3, 4, 3);
        txtDiskWork.Name = "txtDiskWork";
        txtDiskWork.Size = new Size(895, 23);
        txtDiskWork.TabIndex = 32;
        // 
        // lblDiskWork
        // 
        lblDiskWork.AutoSize = true;
        lblDiskWork.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
        lblDiskWork.Location = new Point(21, 69);
        lblDiskWork.Margin = new Padding(4, 0, 4, 0);
        lblDiskWork.Name = "lblDiskWork";
        lblDiskWork.Size = new Size(74, 13);
        lblDiskWork.TabIndex = 31;
        lblDiskWork.Text = "Disk Work :";
        // 
        // btnDiskWork
        // 
        btnDiskWork.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnDiskWork.Location = new Point(1013, 62);
        btnDiskWork.Margin = new Padding(4, 3, 4, 3);
        btnDiskWork.Name = "btnDiskWork";
        btnDiskWork.Size = new Size(37, 27);
        btnDiskWork.TabIndex = 30;
        btnDiskWork.Text = "...";
        btnDiskWork.UseVisualStyleBackColor = true;
        btnDiskWork.Click += btnDiskWork_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1065, 621);
        Controls.Add(txtDiskWork);
        Controls.Add(lblDiskWork);
        Controls.Add(btnDiskWork);
        Controls.Add(dataGridView2);
        Controls.Add(txtDiskKar);
        Controls.Add(lblDiskKar);
        Controls.Add(dataGridView1);
        Controls.Add(btnDiskKar);
        Margin = new Padding(4, 3, 4, 3);
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnDiskKar;
    private DataGridView dataGridView1;
    private TextBox txtDiskKar;
    private Label lblDiskKar;
    private DataGridView dataGridView2;
    private TextBox txtDiskWork;
    private Label lblDiskWork;
    private Button btnDiskWork;
}

