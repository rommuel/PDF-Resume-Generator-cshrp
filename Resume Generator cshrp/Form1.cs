using PdfSharp;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
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
            string filename = "ResumeData.json";
            string jsonstring = File.ReadAllText(filename);
            ResumeInfo resumeinfo = JsonSerializer.Deserialize<ResumeInfo>(jsonstring)!;
            string name = resumeinfo.Name;
            MessageBox.Show(name);


        }

        private void Generatebtn_Click(object sender, EventArgs e)
        {
            //Defining Resume Information
            
            //using (SaveFileDialog sfd = new SaveFileDialog())
            {
                //sfd.Filter = "PDF|*.pdf";
                //if (sfd.ShowDialog() == DialogResult.OK)
                {
                    //PdfDocument pdf = new PdfDocument();
                    //sfd.FileName = "RIVERA_ROMMUEL";
                    //pdf.Info.Title = "Resume";
                   // PdfPage page = pdf.AddPage();

                    //XGraphics graph = XGraphics.FromPdfPage(page);
                    //XFont font = new XFont("Verdana", 18, XFontStyle.Regular);

                    

                   // pdf.Save(sfd.FileName);

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