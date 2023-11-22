using System.Data;
using System.Data.Odbc;
using System.Reflection;
using SaipaDiesel.Tamin.Core.Comain;
using SaipaDiesel.Tamin.Framework.DataHelpers;
using SaipaDiesel.Tamin.Framework.Converters;
using System.Text;
using static System.Windows.Forms.LinkLabel;

namespace SaipaDiesel.Tamin.UI;

public partial class Form1 : Form
{
    public static string SelectedTable = string.Empty;

    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
    }

    private void btnDiskKar_Click(object sender, EventArgs e)
    {
        var fdlg = new OpenFileDialog();
        fdlg.Title = "انتخاب فایل";
        fdlg.InitialDirectory = @"c:\Users\balangi_ar\Desktop\fox\";
        fdlg.FileName = txtDiskKar.Text;
        fdlg.Filter = "TXT Files(*.txt)|*.txt|All Files(*.*)|*.*";
        fdlg.FilterIndex = 1;
        fdlg.RestoreDirectory = true;
        if (fdlg.ShowDialog() == DialogResult.OK)
        {
            txtDiskKar.Text = fdlg.FileName;
            if (txtDiskKar.Text.Trim() != string.Empty)
            {
                Form2 frm = new Form2();
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    FillGridView<WorkshopInfoDto>(txtDiskKar.Text);
                    Application.DoEvents();
                }
            }
            else
            {
                MessageBox.Show("Empty");
            }
        }
    }


    private void FillGridView<T>(string text)
    {
        var listT = new List<T>
        {
            (T)Activator.CreateInstance(typeof(T), new object[] { })
        };

        DataTable dt = new DataTable("table");
        foreach (T item in listT)
        {
            var properties = typeof(T).GetProperties();
            foreach (var property in properties)
            {
                dt.Columns.Add(property.Name, property.PropertyType);
            }
        }

        dataGridView1.DataSource = dt.DefaultView;

        var lineList = ReadTextFile(text);
        listT = new List<T>();

        for (int i = 0; i < lineList.Count; i++)
        {
            var line1 = lineList[i].ToString().TrimEnd().Split('\t').ToList<string>();

            listT.Add((T)Activator.CreateInstance(typeof(T), new object[] { }));

            var j = 0;
            var properties = typeof(T).GetProperties();
            foreach (var property in properties)
            {
                var propertyValue = property.GetValue(listT[i]);
                var propertyInfo = listT[i].GetType().GetProperty(property.Name);

                if (propertyInfo != null)
                {
                    Type t = Nullable.GetUnderlyingType(propertyInfo.PropertyType) ?? propertyInfo.PropertyType;
                    if (t.Name.ToLower() == "string")
                    {
                        propertyInfo.SetValue(listT[i], line1[j], null);
                    }
                    else if (t.Name.ToLower() == "decimal")
                    {
                        propertyInfo.SetValue(listT[i], Convert.ToDecimal( line1[j]), null);
                    }
                }
                j++;
            }
        }

        dataGridView1.DataSource = listT.ListToDataTable("DiskDT").DefaultView;
    }

    private List<string> ReadTextFile(string text)
    {
        var line1 = new List<string>();

        try
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var reader = new StreamReader(text, Encoding.GetEncoding(1256));
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                line1.Add(line.Trim());
            }
            reader.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }

        return line1;
    }

    //private void ReadDiskFile<T>(string text)
    //{
    //    try
    //    {
    //        var dt = GetDataTableDBF(text);

    //        //var text = dr["dsk_name"].ToString();
    //        //var text = "¥‏¢ ‘•‏‘¨ –î¤ھ";
    //        //text = text.IranSystemToUnicode();
    //        //var text1 = text.UnicodeToIranSystem();
    //        //var text2 = text1.IranSystemToUnicode();

    //        dataGridView1.DataSource = dt.DefaultView;

    //        List<string> columns = new List<string>();
    //        foreach (DataColumn dr in dt.Columns)
    //        {
    //            columns.Add(dr.ColumnName);
    //        }

    //        var str = string.Join(",", columns.ToArray());

    //        var list2 = dt.DataTableToList<T>();

    //        foreach (T item in list2)
    //        {
    //            var properties = typeof(T).GetProperties();
    //            foreach (var property in properties)
    //            {
    //                var propertyValue = property.GetValue(item);
    //                var propertyInfo = item.GetType().GetProperty(property.Name);

    //                if (propertyInfo != null)
    //                {
    //                    propertyValue = propertyValue != null ? propertyValue.ToString().IranSystemToUnicode() : propertyValue;

    //                    Type t = Nullable.GetUnderlyingType(propertyInfo.PropertyType) ?? propertyInfo.PropertyType;
    //                    if (t.Name.ToLower() == "string")
    //                    {
    //                        propertyInfo.SetValue(item, propertyValue, null);
    //                    }
    //                }
    //            }
    //        }

    //        dataGridView2.DataSource = list2.ListToDataTable("DiskDT").DefaultView;
    //    }
    //    catch (Exception ex)
    //    {
    //        MessageBox.Show(ex.Message.ToString());
    //    }
    //}

    //public static DataTable GetDataTableDBF(string strFileName)
    //{
    //    OdbcConnection conn = new OdbcConnection($"Provider=vfpoledb;DSN=VFPDB;Data Source={strFileName};Collating Sequence=machine;");
    //    conn.Open();

    //    OdbcDataAdapter adapter = new OdbcDataAdapter($"SELECT * FROM [{strFileName}]", conn);
    //    DataSet ds = new DataSet();
    //    adapter.Fill(ds);
    //    return ds.Tables[0];
    //}
}