using PokemonSearch;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Core;

namespace PglLinkPs
{
    public partial class userQQ : Form
    {
        private PglLinkPs.Main.PokemonInfo[,] qq;

        public userQQ(PglLinkPs.Main.PokemonInfo[,] qq)
        {
            this.qq = qq;
            
            InitializeComponent();
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToUpper() == "ICEFAIRY" || textBox2.Text == "2057695956")
            {
                label3.Location = new System.Drawing.Point(label3.Location.X - 60, label3.Location.Y);
                label3.Text = "moobot全力为冰仙聚聚生成中...稍等0.0";
            }
            else
            {
                label3.Text = "生成中...";
            }
            
            Excel.Application excel = new Excel.Application();

            Excel.Workbook wb = null;
            //excel.Visible = false;//设置调用引用的 Excel文件是否可见
            excel.DisplayAlerts = false;

            wb = excel.Workbooks.Open(System.Windows.Forms.Application.StartupPath + "\\报名表模板.xlsx");
            Excel.Worksheet ws = (Excel.Worksheet)wb.Worksheets[1];
            ws.Name = textBox1.Text + "报名表";
            ws.Cells[3, 4].Value2 = matchtitle;
            ws.Cells[29, 4].Value2 = tag;
            ws.Cells[4, 5].Value2 = textBox1.Text;
            ws.Cells[4, 7].Value2 = textBox2.Text;
            //ws.Cells[5, 5].Value2 = "点333";
            //string content = "\r\n\r\n\r\n";
            //content += string.Format(",,,{0},{1},{2},{3}\r\n", "ID", textBox1.Text, "QQ", textBox2.Text);
            for (int i = 0; i < 6; i += 2)
            {

                ws.Cells[5 + (i / 2) * 8, 5].Value2 = qq[i / 2, i % 2].poke.name;
                ws.Cells[5 + (i / 2) * 8, 7].Value2 = qq[i / 2, i % 2 + 1].poke.name;
                ws.Cells[6 + (i / 2) * 8, 5].Value2 = qq[i / 2, i % 2].poke.Item;
                ws.Cells[6 + (i / 2) * 8, 7].Value2 = qq[i / 2, i % 2 + 1].poke.Item;
                ws.Cells[7 + (i / 2) * 8, 5].Value2 = qq[i / 2, i % 2].poke.Ability;
                ws.Cells[7 + (i / 2) * 8, 7].Value2 = qq[i / 2, i % 2 + 1].poke.Ability;
                ws.Cells[8 + (i / 2) * 8, 5].Value2 = qq[i / 2, i % 2].poke.Nature.name;
                ws.Cells[8 + (i / 2) * 8, 7].Value2 = qq[i / 2, i % 2 + 1].poke.Nature.name;
                //content += string.Format(",,,{0},{1},{0},{2}\r\n", "宝可梦", qq[i / 2, i % 2].poke.name, qq[i / 2, i % 2 + 1].poke.name);
                //content += string.Format(",,,{0},{1},{0},{2}\r\n", "道具", qq[i / 2, i % 2].poke.Item, qq[i / 2, i % 2 + 1].poke.Item);
                //content += string.Format(",,,{0},{1},{0},{2}\r\n", "特性", qq[i / 2, i % 2].poke.Ability, qq[i / 2, i % 2 + 1].poke.Ability);
                //content += string.Format(",,,{0},{1},{0},{2}\r\n", "性格", qq[i / 2, i % 2].poke.Nature.name, qq[i / 2, i % 2 + 1].poke.Nature.name);

                for (int j = 0; j < 4; ++j)
                {
                    ws.Cells[9 + j + (i / 2) * 8, 5].Value2 = qq[i / 2, i % 2].poke.move[j];
                    ws.Cells[9 + j + (i / 2) * 8, 7].Value2 = qq[i / 2, i % 2 + 1].poke.move[j];
                }

                //FileStream fs = new FileStream(string.Format("{0} 报名表.csv", textBox1.Text), FileMode.OpenOrCreate);
                //StreamWriter sw = new StreamWriter(fs, Encoding.GetEncoding("gb2312"));



                //sw.Write(content);
                //sw.Close();
                //fs.Close();
                //fs.Dispose();
            }
            wb.SaveAs(System.Windows.Forms.Application.StartupPath + string.Format("\\{0} 报名表.xlsx", textBox1.Text));
            wb.Close();
            this.Close();
            excel.Quit();
        }
        public static string readToString(string fileName)
        {
            FileStream fs = new FileStream(System.Windows.Forms.Application.StartupPath + "\\" + fileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);

            string re = sr.ReadToEnd();
            sr.Close();
            fs.Close();
            fs.Dispose();
            return re;
        }

        string matchtitle = "";
        string tag = "";

        private void userQQ_Load(object sender, EventArgs e)
        {
            //string[] qq = readToString("load.txt").Split('\n');
            //matchtitle = qq[0].Trim();
            //tag = qq[1].Trim();
        }
    }
}
