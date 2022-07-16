using PdfSharp;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using PdfSharp.Pdf.IO;
using System.Diagnostics;
using System.Text;
using System.Text.Json;
using System.IO;


namespace Resume_Generator_cshrp
{
    //This is the new one
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            
        }

        private void Generatebtn_Click(object sender, EventArgs e)
        {

            string filename = "ResumeData.json";
            string jsonstring = File.ReadAllText(filename);
            ResumeInfo resumeinfo = JsonSerializer.Deserialize<ResumeInfo>(jsonstring)!;

            //Defining Resume Information
            string name = resumeinfo.Name;
            string birthday = resumeinfo.Birthday;
            string contact_num = resumeinfo.Contact_Number;
            string email = resumeinfo.Email_Address;
            string address = resumeinfo.Address;
            string college = resumeinfo.College;
            string c_attainment = resumeinfo.Collegestat;
            string shs = resumeinfo.SeniorHighSchool;
            string shs_attainment = resumeinfo.SHSstat;
            string jhs = resumeinfo.JuniorHighSchool;
            string jhs_attainment = resumeinfo.JHSstat;
            string award1 = resumeinfo.Award1;
            string award2 = resumeinfo.Award2;
            string cert1 = resumeinfo.Certificate1;
            string cert2 = resumeinfo.Certificate2;
            string sk1 = resumeinfo.Skill1;
            string sk2 = resumeinfo.Skill2;
            string sk3 = resumeinfo.Skill3;
            string sk4 = resumeinfo.Skill4;
            string sk5 = resumeinfo.Skill5;
            MessageBox.Show("Resume for: " + name);

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF|*.pdf";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    PdfDocument pdf = new PdfDocument();
                    sfd.FileName = "RIVERA_ROMMUEL";
                    pdf.Info.Title = "RIVERA_ROMMUEL";
                    PdfPage page = pdf.AddPage();

                    XGraphics graph = XGraphics.FromPdfPage(page);
                    XFont basic = new XFont("Verdana", 11, XFontStyle.Regular);
                    XFont boldf = new XFont("Verdana", 15, XFontStyle.Bold);
                    XFont smallbold = new XFont("Verdana", 13, XFontStyle.Bold);
                    //PDF Contents
                    graph.DrawString(name, boldf, XBrushes.Black, new XRect(10, 0, page.Width, page.Height), XStringFormats.TopLeft);
                    graph.DrawString(birthday, basic, XBrushes.Black, new XRect(10, 15, page.Width, page.Height), XStringFormats.TopLeft);
                    graph.DrawString(contact_num, basic, XBrushes.Black, new XRect(10, 30, page.Width, page.Height), XStringFormats.TopLeft);
                    graph.DrawString(email, basic, XBrushes.Black, new XRect(10, 45, page.Width, page.Height), XStringFormats.TopLeft);
                    graph.DrawString(address, basic, XBrushes.Black, new XRect(10, 60, page.Width, page.Height), XStringFormats.TopLeft);

                    graph.DrawString(" ", basic, XBrushes.Black, new XRect(0, 70, page.Width, page.Height), XStringFormats.TopLeft);

                    graph.DrawString("Education:", boldf, XBrushes.Black, new XRect(10, 80, page.Width, page.Height), XStringFormats.TopLeft);
                    graph.DrawString(college, smallbold, XBrushes.Black, new XRect(10, 95, page.Width, page.Height), XStringFormats.TopLeft);
                    graph.DrawString(c_attainment, basic, XBrushes.Black, new XRect(10, 110, page.Width, page.Height), XStringFormats.TopLeft);
                    graph.DrawString(shs, smallbold, XBrushes.Black, new XRect(10, 125, page.Width, page.Height), XStringFormats.TopLeft);
                    graph.DrawString(shs_attainment, basic, XBrushes.Black, new XRect(10, 140, page.Width, page.Height), XStringFormats.TopLeft);
                    graph.DrawString(jhs, smallbold, XBrushes.Black, new XRect(10, 155, page.Width, page.Height), XStringFormats.TopLeft);
                    graph.DrawString(jhs_attainment, basic, XBrushes.Black, new XRect(10, 170, page.Width, page.Height), XStringFormats.TopLeft);

                    graph.DrawString(" ", basic, XBrushes.Black, new XRect(0, 195, page.Width, page.Height), XStringFormats.TopLeft);

                    graph.DrawString("Awards and Certificates:", boldf, XBrushes.Black, new XRect(10, 205, page.Width, page.Height), XStringFormats.TopLeft);
                    graph.DrawString(award1, basic, XBrushes.Black, new XRect(10, 220, page.Width, page.Height), XStringFormats.TopLeft);
                    graph.DrawString(award2, basic, XBrushes.Black, new XRect(10, 235, page.Width, page.Height), XStringFormats.TopLeft);
                    graph.DrawString(cert1, basic, XBrushes.Black, new XRect(10, 250, page.Width, page.Height), XStringFormats.TopLeft);
                    graph.DrawString(cert2, basic, XBrushes.Black, new XRect(10, 265, page.Width, page.Height), XStringFormats.TopLeft);

                    graph.DrawString(" ", basic, XBrushes.Black, new XRect(0, 275, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString("Skills:", boldf, XBrushes.Black, new XRect(10, 285, page.Width, page.Height), XStringFormats.TopLeft);
                    graph.DrawString(sk1, basic, XBrushes.Black, new XRect(10, 300, page.Width, page.Height), XStringFormats.TopLeft);
                    graph.DrawString(sk2, basic, XBrushes.Black, new XRect(10, 315, page.Width, page.Height), XStringFormats.TopLeft);
                    graph.DrawString(sk3, basic, XBrushes.Black, new XRect(10, 330, page.Width, page.Height), XStringFormats.TopLeft);
                    graph.DrawString(sk4, basic, XBrushes.Black, new XRect(10, 345, page.Width, page.Height), XStringFormats.TopLeft);
                    graph.DrawString(sk5, basic, XBrushes.Black, new XRect(10, 360, page.Width, page.Height), XStringFormats.TopLeft);

                    pdf.Save(sfd.FileName);

                }
            }
        }
    }
    public class ResumeInfo
    {
        //Basic Information
        public string Name { get; set; }
        public string Birthday { get; set; }
        public string Contact_Number { get; set; }
        public string Email_Address { get; set; }
        public string Address { get; set; }

        //Educational Background
        public string College { get; set; }
        public string SeniorHighSchool { get; set; }
        public string JuniorHighSchool { get; set; }

        public string Collegestat { get; set; }
        public string SHSstat { get; set; }
        public string JHSstat { get; set; }


        //Awards and Certificates
        public string Award1 { get; set; }
        public string Award2 { get; set; }
        public string Certificate1 { get; set; }
        public string Certificate2 { get; set; }

        //Skills
        public string Skill1 { get; set; }
        public string Skill2 { get; set; }
        public string Skill3 { get; set; }
        public string Skill4 { get; set; }
        public string Skill5 { get; set; }

    }
}