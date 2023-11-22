namespace SaipaDiesel.Tamin.UI;

partial class Form3
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
        dataGridView1.Location = new Point(13, 68);
        dataGridView1.Margin = new Padding(4, 3, 4, 3);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.Size = new Size(1037, 269);
        dataGridView1.TabIndex = 2;
        // 
        // txtDiskKar
        // 
        txtDiskKar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtDiskKar.Location = new Point(138, 24);
        txtDiskKar.Margin = new Padding(4, 3, 4, 3);
        txtDiskKar.Name = "txtDiskKar";
        txtDiskKar.Size = new Size(868, 23);
        txtDiskKar.TabIndex = 28;
        // 
        // lblDiskKar
        // 
        lblDiskKar.AutoSize = true;
        lblDiskKar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
        lblDiskKar.Location = new Point(21, 28);
        lblDiskKar.Margin = new Padding(4, 0, 4, 0);
        lblDiskKar.Name = "lblDiskKar";
        lblDiskKar.Size = new Size(109, 13);
        lblDiskKar.TabIndex = 27;
        lblDiskKar.Text = "بارگذاری از فایل :";
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
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1065, 621);
        Controls.Add(dataGridView2);
        Controls.Add(txtDiskKar);
        Controls.Add(lblDiskKar);
        Controls.Add(dataGridView1);
        Controls.Add(btnDiskKar);
        Margin = new Padding(4, 3, 4, 3);
        Name = "Form3";
        RightToLeft = RightToLeft.Yes;
        RightToLeftLayout = true;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Form3";
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
}

