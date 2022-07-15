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
            MessageBox.Show(name);

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
                    XFont lala = new XFont("Verdana", 18, XFontStyle.Regular);
                    
                    //PDF Contents
                    graph.DrawString(name, lala, XBrushes.Black, new XRect(0, 0, page.Width.Point, page.Height.Point), XStringFormats.BaseLineLeft);
                    graph.DrawString(birthday, lala, XBrushes.Black, new XRect(0, 0, page.Width.Point, page.Height.Point), XStringFormats.BaseLineLeft);
                    graph.DrawString(contact_num, lala, XBrushes.Black, new XRect(0, 0, page.Width.Point, page.Height.Point), XStringFormats.BaseLineLeft);
                    graph.DrawString(email, lala, XBrushes.Black, new XRect(0, 0, page.Width.Point, page.Height.Point), XStringFormats.BaseLineLeft);
                    graph.DrawString(address, lala, XBrushes.Black, new XRect(0, 0, page.Width.Point, page.Height.Point), XStringFormats.BaseLineLeft);

                    graph.DrawString(" ", lala, XBrushes.Black, new XRect(0, 0, page.Width.Point, page.Height.Point), XStringFormats.BaseLineLeft);

                    graph.DrawString("Education:", lala, XBrushes.Black, new XRect(0, 0, page.Width.Point, page.Height.Point), XStringFormats.BaseLineLeft);
                    graph.DrawString(college, lala, XBrushes.Black, new XRect(0, 0, page.Width.Point, page.Height.Point), XStringFormats.BaseLineLeft);
                    graph.DrawString(c_attainment, lala, XBrushes.Black, new XRect(0, 0, page.Width.Point, page.Height.Point), XStringFormats.BaseLineLeft);
                    graph.DrawString(shs, lala, XBrushes.Black, new XRect(0, 0, page.Width.Point, page.Height.Point), XStringFormats.BaseLineLeft);
                    graph.DrawString(shs_attainment, lala, XBrushes.Black, new XRect(0, 0, page.Width.Point, page.Height.Point), XStringFormats.BaseLineLeft);
                    graph.DrawString(jhs, lala, XBrushes.Black, new XRect(0, 0, page.Width.Point, page.Height.Point), XStringFormats.BaseLineLeft);
                    graph.DrawString(jhs_attainment, lala, XBrushes.Black, new XRect(0, 0, page.Width.Point, page.Height.Point), XStringFormats.BaseLineLeft);

                    graph.DrawString(" ", lala, XBrushes.Black, new XRect(0, 0, page.Width.Point, page.Height.Point), XStringFormats.BaseLineLeft);

                    graph.DrawString("Awards and Certificates:", lala, XBrushes.Black, new XRect(0, 0, page.Width.Point, page.Height.Point), XStringFormats.BaseLineLeft);
                    graph.DrawString(award1, lala, XBrushes.Black, new XRect(0, 0, page.Width.Point, page.Height.Point), XStringFormats.BaseLineLeft);
                    graph.DrawString(award2, lala, XBrushes.Black, new XRect(0, 0, page.Width.Point, page.Height.Point), XStringFormats.BaseLineLeft);
                    graph.DrawString(cert1, lala, XBrushes.Black, new XRect(0, 0, page.Width.Point, page.Height.Point), XStringFormats.BaseLineLeft);
                    graph.DrawString(cert2, lala, XBrushes.Black, new XRect(0, 0, page.Width.Point, page.Height.Point), XStringFormats.BaseLineLeft);

                    graph.DrawString(" ", lala, XBrushes.Black, new XRect(0, 0, page.Width.Point, page.Height.Point), XStringFormats.BaseLineLeft);

                    graph.DrawString("Skills:", lala, XBrushes.Black, new XRect(0, 0, page.Width.Point, page.Height.Point), XStringFormats.BaseLineLeft);
                    graph.DrawString(sk1, lala, XBrushes.Black, new XRect(0, 0, page.Width.Point, page.Height.Point), XStringFormats.BaseLineLeft);
                    graph.DrawString(sk2, lala, XBrushes.Black, new XRect(0, 0, page.Width.Point, page.Height.Point), XStringFormats.BaseLineLeft);
                    graph.DrawString(sk3, lala, XBrushes.Black, new XRect(0, 0, page.Width.Point, page.Height.Point), XStringFormats.BaseLineLeft);
                    graph.DrawString(sk4, lala, XBrushes.Black, new XRect(0, 0, page.Width.Point, page.Height.Point), XStringFormats.BaseLineLeft);
                    graph.DrawString(sk5, lala, XBrushes.Black, new XRect(0, 0, page.Width.Point, page.Height.Point), XStringFormats.BaseLineLeft);

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