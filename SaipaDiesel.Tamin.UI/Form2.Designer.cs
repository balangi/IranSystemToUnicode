namespace SaipaDiesel.Tamin.UI;

partial class Form2
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
        authorGroup = new GroupBox();
        label1 = new Label();
        comboBox1 = new ComboBox();
        button1 = new Button();
        authorGroup.SuspendLayout();
        SuspendLayout();
        // 
        // authorGroup
        // 
        authorGroup.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        authorGroup.Controls.Add(label1);
        authorGroup.Controls.Add(comboBox1);
        authorGroup.Location = new Point(12, 12);
        authorGroup.Name = "authorGroup";
        authorGroup.Size = new Size(544, 82);
        authorGroup.TabIndex = 0;
        authorGroup.TabStop = false;
        authorGroup.Text = " انتخاب نوع اطلاعات ";
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        label1.AutoSize = true;
        label1.Location = new Point(454, 39);
        label1.Name = "label1";
        label1.Size = new Size(68, 15);
        label1.TabIndex = 1;
        label1.Text = "نوع اطلاعات :";
        // 
        // comboBox1
        // 
        comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBox1.FormattingEnabled = true;
        comboBox1.Items.AddRange(new object[] { "اطلاعات کارگاه", "اطلاعات پرسنل" });
        comboBox1.Location = new Point(25, 36);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new Size(412, 23);
        comboBox1.TabIndex = 0;
        // 
        // button1
        // 
        button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        button1.Location = new Point(12, 112);
        button1.Name = "button1";
        button1.Size = new Size(544, 33);
        button1.TabIndex = 1;
        button1.Text = "انتخاب";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // Form2
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(568, 157);
        Controls.Add(button1);
        Controls.Add(authorGroup);
        Name = "Form2";
        RightToLeft = RightToLeft.Yes;
        RightToLeftLayout = true;
        StartPosition = FormStartPosition.CenterParent;
        Text = "Form1";
        Load += Form2_Load;
        authorGroup.ResumeLayout(false);
        authorGroup.PerformLayout();
        ResumeLayout(false);
    }

    private GroupBox authorGroup;
    #endregion

    private Label label1;
    private ComboBox comboBox1;
    private Button button1;
}
