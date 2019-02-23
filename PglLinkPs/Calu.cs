using PokemonSearch;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PglLinkPs
{
    public partial class Calu : Form
    {
        private void Calu_Load(object sender, EventArgs e)
        {

        }
        public Calu()
        {
            pokevalue = new TextBox[6, 3];
            init();
            InitializeComponent();
        }
        public PokemonInfo poke;
        public int id;
        public TextBox[,] pokevalue;
        Label rac = new Label();//"种族值")
        Label IVs = new Label();//"个体值"
        Label EVs = new Label();//
        Label sum = new Label();//"总和"
        Label sumrac = new Label();//"0"
        Button sumIVs = new Button();//"6V"
        Label sumEVs = new Label();//"0"
        Label stats = new Label();//"能力值"
        public Label natures = new Label();//"性格"
        Label[] stat = new Label[6];
        Label pokemonhead = new Label();
        public ComboBox nature = new ComboBox();


        Label[] title = new Label[6];

        public void show(PokemonInfo poke, int id)
        {
            this.poke = poke;
            sumrac.Text = ((poke.RacialValue.GetSumRacial()).ToString());
            nature.SelectedIndex = (poke.Nature.id);
            this.id = id;
            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < 6; ++j)
                {
                    if (i == 0)
                    {
                        pokevalue[j, i].Text = ((poke.RacialValue.Value[j]).ToString());
                    }
                    if (i == 1)
                    {
                        pokevalue[j, i].Text = ((poke.IVS.Value[j]).ToString());
                    }
                    if (i == 2)
                    {
                        pokevalue[j, i].Text = ((poke.EVS.Value[j]).ToString());
                    }

                }
            }

            this.Visible = (true);
            pokemonhead.Image = (Image)pokeimg.ResourceManager.GetObject(poke.name.Replace("-", "T"));
            update();

        }

        private void update()
        {
            int temp = 0;
            for (int i = 0; i < 6; ++i)
            {
                temp += int.Parse(pokevalue[i, 2].Text);
            }
            sumEVs.Text = ((temp.ToString()));
            if (temp > 510)
            {
                sumEVs.ForeColor = (Color.Red);
            }
            else
            {
                sumEVs.ForeColor = (Color.Black);
            }
            for (int i = 0; i < 6; ++i)
            {
                if (i == 0)
                {
                    if (poke.RacialValue.Value[0] == 1)
                        stat[i].Text = ("1");
                    else
                        stat[0].Text = ((((int)((int.Parse(pokevalue[0, 0].Text) * 2 + int.Parse(pokevalue[0, 1].Text) + (int.Parse(pokevalue[0, 2].Text) / 4)) * poke.Level / 100 + 10 + poke.Level)))).ToString();
                }
                else
                {
                    stat[i].Text = ((((int)((int.Parse(pokevalue[i, 0].Text) * 2 + int.Parse(pokevalue[i, 1].Text) + (int.Parse(pokevalue[i, 2].Text) / 4)) * poke.Level / 100 + 5)))).ToString();
                }
            }
            if (Pokemondata.getNatureClass(nature.SelectedIndex).up != 0)
            {
                stat[Pokemondata.getNatureClass(nature.SelectedIndex).up].Text = (((int)(int.Parse(stat[Pokemondata.getNatureClass(nature.SelectedIndex).up].Text) * 1.1))).ToString();
                stat[Pokemondata.getNatureClass(nature.SelectedIndex).down].Text = (((int)(int.Parse(stat[Pokemondata.getNatureClass(nature.SelectedIndex).down].Text) * 0.9))).ToString();
            }
        }

        //private static final long serialVersionUID = 1L;

        private int confirmEVs(String gg)
        {
            if (gg == "")
            {
                return 0;
            }
            int aa = int.Parse(gg);
            if (aa > 252)
            {
                return 252;
            }
            if (aa < 0)
            {
                return 0;
            }
            return int.Parse(gg);
        }

        private int confirmIVs(String gg)
        {
            if (gg == "")
            {
                return 0;
            }
            int aa = int.Parse(gg);
            if (aa > 31)
            {
                return 31;
            }
            if (aa < 0)
            {
                return 0;
            }
            return int.Parse(gg);
        }

        private void init()
        {

            //this.setLayout(null);
            this.Text = "内部数值查看";
            // this.setIconImage(image);
            nature.DropDownStyle = ComboBoxStyle.DropDownList;
            Rectangle scr = System.Windows.Forms.Screen.GetWorkingArea(this);

            this.SetBounds(scr.Width / 2 - 160, scr.Height / 2 - 160, 320, 320);
            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < 6; ++j)
                {
                    pokevalue[j, i] = new TextBox();
                    pokevalue[j, i].Text = "0";
                    pokevalue[j, i].SetBounds(100 + i * 45, 50 + j * 25, 40, 20);
                    this.Controls.Add(pokevalue[j, i]);
                    if (i == 0)
                    {
                        pokevalue[j, i].Enabled = (false);

                    }
                    if (i == 1)
                    {
                        pokevalue[j, i].TextChanged += Calu_TextChanged;
                    }
                    if (i == 2)
                    {
                        pokevalue[j, i].TextChanged += Calu_TextChanged1;
                    }
                    Controls.Add(pokevalue[j, i]);
                }
            }

            for (int i = 0; i < database.Naturedata.Length; ++i)
            {
                nature.Items.Add(Pokemondata.getNatureClass(i).name);
            }
            for (int i = 0; i < 6; ++i)
            {
                title[i] = new Label();
                stat[i] = new Label();
                stat[i].Text = ("0");

                title[i].SetBounds(50, 50 + i * 25, 30, 20);
                stat[i].SetBounds(250 - 8, 50 + i * 25 + 5, 30, 20);
                // stat[i].setFont();
                this.Controls.Add(title[i]);
                this.Controls.Add(stat[i]);
            }
            nature.SelectedIndexChanged += Nature_SelectedIndexChanged;
            rac.Text = "种族值";
            IVs.Text = "个体值";
            EVs.Text = "努力值";
            sum.Text = "总和";
            sumrac.Text = "0";
            sumIVs.Text = "6V";
            sumEVs.Text = "0";
            stats.Text = "能力值";
            natures.Text = "性格";
            title[0].Text = ("HP");
            title[1].Text = ("物攻");
            title[2].Text = ("物防");
            title[3].Text = ("特攻");
            title[4].Text = ("特防");
            title[5].Text = ("速度");
            natures.SetBounds(50, 235, 30, 20);
            rac.SetBounds(100, 20, 40, 20);
            IVs.SetBounds(145, 20, 40, 20);
            EVs.SetBounds(190, 20, 40, 20);
            sumrac.SetBounds(100, 205, 40, 20);
            sumIVs.SetBounds(140, 200, 45, 20);
            sumIVs.Click += SumIVs_Click;
            sumEVs.SetBounds(190, 205, 40, 20);
            sum.SetBounds(50, 205, 40, 20);
            stats.SetBounds(240, 20, 40, 20);
            pokemonhead.SetBounds(50 - 10, 10, 40, 41);

            nature.SetBounds(100, 230, 130, 20);

            this.Controls.Add(rac);
            this.Controls.Add(IVs);
            this.Controls.Add(EVs);
            this.Controls.Add(sumrac);
            this.Controls.Add(sumIVs);
            this.Controls.Add(sumEVs);
            this.Controls.Add(stats);
            this.Controls.Add(pokemonhead);
            this.Controls.Add(nature);
            this.Controls.Add(natures);
            this.Controls.Add(sum);
        }

        private void SumIVs_Click(object sender, EventArgs e)
        {
            poke.IVS.fill(31);
            for(int i = 0; i < 6; ++i) {
                pokevalue[i,1].Text = ("31");
            }
            update();
        }

        private void Nature_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; ++i) title[i].ForeColor = (Color.Black);
            if (Pokemondata.getNatureClass(((ComboBox)sender).SelectedIndex).up == 0)
            {
                // rss.Text = "��ֻ����������ϲ�������е�rss��! ����";
                // System.out.println(1);
                return;
            }

            title[Pokemondata.getNatureClass(((ComboBox)sender).SelectedIndex).up].ForeColor = (Color.Red);
            title[Pokemondata.getNatureClass(((ComboBox)sender).SelectedIndex).down]
                    .ForeColor = (Color.Blue);
            update();
            // power[xingge[(int)sexgenum[Sex.Text]].up].Text = ((int)(int.Parse(power[xingge[(int)sexgenum[Sex.Text]].up].Text) * 1.1)).ToString();
            // power[xingge[(int)sexgenum[Sex.Text]].down].Text = ((int)(int.Parse(power[xingge[(int)sexgenum[Sex.Text]].down].Text) * 0.9)).ToString();
        }
    

        private void Calu_TextChanged1(object sender, EventArgs e)
        {
            int temp = confirmEVs(((TextBox)sender).Text);
            TextBox t = ((TextBox)sender);
            if (temp >= 0)
            {
                t.Text = temp.ToString();
                if (t.Text != temp.ToString())
                {
                    t.Text = temp.ToString();
                    t.SelectionStart = t.Text.Length;
                }
                update();

            }
        }

        private void Calu_TextChanged(object sender, EventArgs e)
        {
            int temp = confirmIVs(((TextBox)sender).Text);
            TextBox t = ((TextBox)sender);
            if (temp >= 0)
            {
                t.Text = temp.ToString();
                if (t.Text != temp.ToString())
                {
                    t.Text = temp.ToString();
                    t.SelectionStart = t.Text.Length;
                }
                update();

            }
        }

    }
}
