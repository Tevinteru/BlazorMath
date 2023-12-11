using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
namespace BlazorMath.Models
{
    public class Test
    {

        public string Text { get; set; }
        public int RightAnswer { get; set; }
       
    }
    public class Methods
    {
        public static int Size { get; set; }
        public Test[] Questions;
        public void Add()
        {

        }
        public void Init()
        {
            FileStream fileStreamPath = new FileStream("Номер вопроса.docx", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            WordDocument document = new WordDocument(fileStreamPath, FormatType.Docx);
            WTable table = document.Sections[0].Tables[0] as WTable;
            Size = Convert.ToInt32(table.Rows.Count);
            Questions =new Test[Size-1];
            for(int i = 1;i < Size;i++)
            {
                Questions[i-1] = new Test { Text = Convert.ToString(table[i, 1].LastParagraph.Text), RightAnswer = Convert.ToInt32(table[i,2].LastParagraph.Text) };
            }
            document.Close();
        }
    }
}
