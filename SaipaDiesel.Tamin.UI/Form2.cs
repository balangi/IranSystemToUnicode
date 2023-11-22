using SaipaDiesel.Tamin.Framework.Enums;

namespace SaipaDiesel.Tamin.UI;

public partial class Form2 : Form
{
    public TaminType TaminType { get; set; }

    public Form2()
    {
        InitializeComponent();
    }

    private void Form2_Load(object sender, EventArgs e)
    {
        comboBox1.SelectedIndex = 0;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        TaminType = (TaminType)comboBox1.SelectedIndex;
        DialogResult = DialogResult.OK;
        Close();
    }
}
