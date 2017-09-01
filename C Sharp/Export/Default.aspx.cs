using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.IO;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        XmlDocument XmlIn = new XmlDocument();
        XmlDocument fmt_formatDocument = new XmlDocument();

        XmlIn.Load(@"C:\Users\Lenovo\Desktop\data.xml");
        fmt_formatDocument.Load(@"C:\Users\Lenovo\Desktop\report_generic_data_equipment_regis_fmt.xml");

        Export Document = new Export(XmlIn.SelectSingleNode("document/context/export_inputparam"), fmt_formatDocument.SelectSingleNode("export_format"), @"C:\Users\Lenovo\Desktop");
    }
}

public class Export
{
    public Export(XmlNode requestXmlDocument, XmlNode fmtXmlDocument, string directory_path)
    {
        XmlNodeList request_source_list = requestXmlDocument.SelectNodes("source");

        for (int request_source_count = 0; request_source_count < request_source_list.Count; request_source_count++)
        {
            XmlNodeList fmt_type_list = fmtXmlDocument.SelectNodes("type");
            for (int fmt_type_list_count = 0; fmt_type_list_count < fmt_type_list.Count; fmt_type_list_count++)
            {
                if (request_source_list[request_source_count].Attributes["type"].Value == fmt_type_list[fmt_type_list_count].Attributes["name"].Value)
                {
                    XmlNodeList fmt_source_list = fmt_type_list[fmt_type_list_count].SelectNodes("source");
                    for (int fmt_source_list_count = 0; fmt_source_list_count < fmt_source_list.Count; fmt_source_list_count++)
                    {
                        if (request_source_list[request_source_count].Attributes["name"].Value == fmt_source_list[fmt_source_list_count].SelectSingleNode("source_name").InnerText)
                        {
                            switch (request_source_list[request_source_count].Attributes["type"].Value)
                            {
                                case "grid":
                                    ConversionFromGridToExcel(request_source_list[request_source_count].SelectNodes("grid_record"), fmt_source_list[fmt_source_list_count].SelectNodes("fields/field"), directory_path, fmt_source_list[fmt_source_list_count].SelectSingleNode("export_file_name").InnerText);
                                    break;
                                case "html":
                                    ConversionFromHtmlToExcel(request_source_list[request_source_count].SelectNodes("html_record"), directory_path, fmt_source_list[fmt_source_list_count].SelectSingleNode("export_file_name").InnerText);
                                    break;
                                case "chart":
                                    ConversionFromChartToImage(request_source_list[request_source_count].SelectNodes("chart_record"), directory_path, fmt_source_list[fmt_source_list_count].SelectSingleNode("export_file_name").InnerText);
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                }
            }
        }
    }
    public void ConversionFromGridToExcel(XmlNodeList request_fields, XmlNodeList fmt_fields, string directory_path, string file_name)
    {
        string table = "<table border='1'>";
        table += "<tr>";
        List<string> table_header_array_list = new List<string>();
        for (int fmt_fields_count = 0; fmt_fields_count < fmt_fields.Count; fmt_fields_count++)
        {
            if (fmt_fields[fmt_fields_count].SelectSingleNode("field_ignore_flag").InnerText.ToUpper() == "N")
            {
                table_header_array_list.Add(fmt_fields[fmt_fields_count].SelectSingleNode("field_name").InnerText);
                table += "<th>" + fmt_fields[fmt_fields_count].SelectSingleNode("header_text").InnerText + "</th>";
            }
        }
        table += "</tr>";
        for (int request_fields_count = 0; request_fields_count < request_fields.Count; request_fields_count++)
        {
            table += "<tr>";
            for (int table_header_array_list_count = 0; table_header_array_list_count < table_header_array_list.Count; table_header_array_list_count++)
            {
                table += "<td>" + request_fields[request_fields_count].SelectSingleNode(table_header_array_list[table_header_array_list_count]).InnerText + "</td>";
            }
            table += "</tr>";
        }
        table += "</table>";

        if (!Directory.Exists(directory_path))
        {
            DirectoryInfo di = Directory.CreateDirectory(directory_path);
        }

        File.WriteAllText(directory_path + "//" + file_name, table);

    }
    public void ConversionFromHtmlToExcel(XmlNodeList request_fields, string directory_path, string file_name)
    {
        string html_record = request_fields[0].InnerText;
        if (!Directory.Exists(directory_path))
        {
            DirectoryInfo di = Directory.CreateDirectory(directory_path);
        }

        File.WriteAllText(directory_path + "//" + file_name, html_record);
    }
    public void ConversionFromChartToImage(XmlNodeList request_fields, string directory_path, string file_name)
    {
        using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(request_fields[0].InnerText)))
        {
            using (System.Drawing.Bitmap bm2 = new System.Drawing.Bitmap(ms))
            {
                string html_record = request_fields[0].InnerText;
                if (!Directory.Exists(directory_path))
                {
                    DirectoryInfo di = Directory.CreateDirectory(directory_path);
                }
                bm2.Save(directory_path + "//" + file_name);
            }
        }
    }
}
