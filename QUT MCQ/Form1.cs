using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.xml;
using System.IO;

namespace QUT_MCQ
{
    public partial class Form1 : Form
    {
        private string filePath = "";
        private AcroFields fields;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            log.Text = "Please browse for a text file to begin..." + Environment.NewLine;
        }

        private void FillForm()
        {
            int totalMarks = 0;
            int accumulatedMarks = 0;
            string pdfTemplate = "C:\\Users\\Zhi On\\Desktop\\WTW\\701\\QUT_MCQ_A4.pdf";
            string newFile = "C:\\Users\\Zhi On\\Desktop\\WTW\\701\\QUT_MCQ_A4_NEW.pdf";
            PdfReader pdfReader = new PdfReader(pdfTemplate);
            PdfStamper pdfStamper = new PdfStamper(pdfReader, new FileStream(newFile, FileMode.Create));
            fields = pdfStamper.AcroFields;

            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] splittedline = line.Split(' ');

                    switch (splittedline[0])
                    {
                        case "Surname":
                            fillSurname(splittedline[1]);
                            break;
                        case "Initials":
                            fillInitials(splittedline[1]);
                            break;
                        case "SubjectCode":
                            fillSubjectCode(splittedline[1]);
                            break;
                        case "StudentNumber":
                            fillStudentNumber(splittedline[1]);
                            break;
                        case "Codes":
                            fillCodes(splittedline[1]);
                            break;
                        case "TotalMarks":
                            totalMarks = Int32.Parse(splittedline[1]);
                            break;
                        default:
                            if (Int32.TryParse(splittedline[0], out int number))
                            {
                                fillQuestionAnswer(splittedline);
                                accumulatedMarks += Int32.Parse(splittedline[2]);
                            } else
                            {
                                log.Text = log.Text + DateTime.Now + " -- INVALID INPUT -- " + line + Environment.NewLine;
                            }
                            break;
                    }
                }
                sr.Close();
            }

            pdfStamper.FormFlattening = true;
            pdfStamper.Close();

            log.Text = log.Text + DateTime.Now + " -- Generating Completed for " + fields.GetField("SubjectCode") + Environment.NewLine;

            if(totalMarks != accumulatedMarks)
            {
                log.Text = log.Text + DateTime.Now + "WARNING -- ACCUMULATED MARKS DOES NOT EQUAL TO THE TOTAL MARKS SET! PLEASE CHECK AGAIN!";
            } else
            {
                log.Text = log.Text + DateTime.Now + " -- ACCUMULATED MARKS MATCHED THE TOTAL MARKS SET";
            }
        }

        private void fillSurname(string value)
        {
            char[] surname = value.ToCharArray();

            log.Text = log.Text + DateTime.Now + " -- Generating Surname" + Environment.NewLine;

            fields.SetField("Surname", value);
            for (int i = 0; i < surname.Length; i++)
            {
                fields.SetField("Surname" + (i + 1), surname[i].ToString());
            }
            log.Text = log.Text + DateTime.Now + " -- Generating Surname Completed" + Environment.NewLine;
        }

        private void fillInitials(string value)
        {
            char[] initials = value.ToCharArray();

            log.Text = log.Text + DateTime.Now + " -- Generating Initials" + Environment.NewLine;
            fields.SetField("Initials", value);
            for (int i = 0; i < initials.Length; i++)
            {
                fields.SetField("Initials" + (i + 1), initials[i].ToString());
            }
            log.Text = log.Text + DateTime.Now + " -- Generating Initials Completed" + Environment.NewLine;
        }

        private void fillSubjectCode(string value)
        {
            char[] subjectCode = value.ToCharArray();

            log.Text = log.Text + DateTime.Now + " -- Generating Subject Code" + Environment.NewLine;
            fields.SetField("SubjectCode", value);
            for (int i = 0; i < subjectCode.Length; i++)
            {
                fields.SetField("SubjectCode" + (i + 1), subjectCode[i].ToString());
            }
            log.Text = log.Text + DateTime.Now + " -- Generating Subject Code Completed" + Environment.NewLine;
        }

        private void fillStudentNumber(string value)
        {
            char[] studentNumber = value.ToCharArray();

            log.Text = log.Text + DateTime.Now + " -- Generating Student Number" + Environment.NewLine;
            fields.SetField("StudentNumber", value);
            for (int i = 0; i < studentNumber.Length; i++)
            {
                fields.SetField("StudentNumber" + (i + 1), studentNumber[i].ToString());
            }
            log.Text = log.Text + DateTime.Now + " -- Generating Student Number Completed" + Environment.NewLine;
        }

        private void fillCodes(string value)
        {
            char[] codes = value.ToCharArray();

            log.Text = log.Text + DateTime.Now + " -- Generating Codes" + Environment.NewLine;
            fields.SetField("Codes", value);
            for (int i = 0; i < codes.Length; i++)
            {
                fields.SetField("Codes" + (i + 1), codes[i].ToString());
            }
            log.Text = log.Text + DateTime.Now + " -- Generating Codes Completed";
        }

        private void fillQuestionAnswer(string[] value)
        {
            log.Text = log.Text + DateTime.Now + " -- Generating Question Answer for Q" + value[0] + Environment.NewLine;
            //fields.SetField("Q" + value[0], value[1].ToUpper());
            fields.SetField("Q" + value[0] + value[1].ToUpper(), "Yes", true);
            log.Text = log.Text + DateTime.Now + " -- Generating Question Answer Completed for Q" + value[0] + Environment.NewLine;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            log.Text = log.Text + DateTime.Now + "-- Start Generating" + Environment.NewLine;
            FillForm();
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            log.Text = log.Text + DateTime.Now + " -- Browsing File" + Environment.NewLine;

            DialogResult dialogResult = this.openFileDialog1.ShowDialog();
            
            if(dialogResult == DialogResult.OK)
            {
                log.Text = log.Text + DateTime.Now + " -- " + this.openFileDialog1.FileName + " has been selected" + Environment.NewLine;
                this.selectedFile.Text = this.openFileDialog1.FileName;
                filePath = this.openFileDialog1.FileName;
                this.startBtn.Enabled = true;
            } else if(dialogResult == DialogResult.Cancel)
            {
                log.Text = log.Text + DateTime.Now + " -- Browsing File Operation has been cancelled" + Environment.NewLine;
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
