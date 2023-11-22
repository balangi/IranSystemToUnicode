using SaipaDiesel.Tamin.Core.Comain;
using SaipaDiesel.Tamin.Framework.Converters;
using SaipaDiesel.Tamin.Framework.DataHelpers;
using System.Data;
using System.Data.Odbc;


namespace SaipaDiesel.Tamin.UI;

public partial class Form3 : Form
{
    public static string SelectedTable = string.Empty;

    public Form3()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
    }

    private void btnDiskKar_Click(object sender, EventArgs e)
    {
        var fdlg = new OpenFileDialog();
        fdlg.Title = "Select file";
        fdlg.InitialDirectory = @"c:\Users\balangi_ar\Desktop\fox\";
        fdlg.FileName = txtDiskKar.Text;
        fdlg.Filter = "DBF Files(*.dbf)|*.dbf|All Files(*.*)|*.*";
        fdlg.FilterIndex = 1;
        fdlg.RestoreDirectory = true;
        if (fdlg.ShowDialog() == DialogResult.OK)
        {
            txtDiskKar.Text = fdlg.FileName;
            if (txtDiskKar.Text.Trim() != string.Empty)
            {
                Form2 frm = new Form2();
                frm.ShowDialog();

                ReadDbfFile<WorkshopInfoDto>(txtDiskKar.Text);
                Application.DoEvents();
            }
            else
            {
                MessageBox.Show("Empty");
            }
        }
    }

    private void ReadDbfFile<T>(string text)
    {
        try
        {
            var dt = GetDataTableFromDbf(text);

            //var text = dr["dsk_name"].ToString();
            //var text = "¥‏¢ ‘•‏‘¨ –î¤ھ";
            //text = text.IranSystemToUnicode();
            //var text1 = text.UnicodeToIranSystem();
            //var text2 = text1.IranSystemToUnicode();

            dataGridView1.DataSource = dt.DefaultView;

            List<string> columns = new List<string>();
            foreach (DataColumn dr in dt.Columns)
            {
                columns.Add(dr.ColumnName);
            }

            var str = string.Join(",", columns.ToArray());

            var list2 = dt.DataTableToList<T>();

            foreach (T item in list2)
            {
                var properties = typeof(T).GetProperties();
                foreach (var property in properties)
                {
                    var propertyValue = property.GetValue(item);
                    var propertyInfo = item.GetType().GetProperty(property.Name);

                    if (propertyInfo != null)
                    {
                        propertyValue = propertyValue != null ? propertyValue.ToString().IranSystemToUnicode() : propertyValue;

                        Type t = Nullable.GetUnderlyingType(propertyInfo.PropertyType) ?? propertyInfo.PropertyType;
                        if (t.Name.ToLower() == "string")
                        {
                            propertyInfo.SetValue(item, propertyValue, null);
                        }
                    }
                }
            }

            dataGridView2.DataSource = list2.ListToDataTable("DiskDT").DefaultView;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message.ToString());
        }
    }

    public static DataTable GetDataTableFromDbf(string strFileName)
    {
        OdbcConnection conn = new OdbcConnection($"Provider=vfpoledb;DSN=VFPDB;Data Source={strFileName};Collating Sequence=machine;");
        conn.Open();

        OdbcDataAdapter adapter = new OdbcDataAdapter($"SELECT * FROM [{strFileName}]", conn);
        DataSet ds = new DataSet();
        adapter.Fill(ds);
        return ds.Tables[0];
    }
}