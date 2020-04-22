using PokemonSearch;
using submit;
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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        
        //private void anyTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        //{

        //}
        public class PokemonInfo
        {
            public int id;
            public Calu CALU = null;
            public TextBox Item = new TextBox(), Nature = new TextBox(), Ability = new TextBox();
            public TextBox[] Move = new TextBox[4];
            public ComboBox Name = new ComboBox();
            public Label ItemL = new Label(), AbilityL = new Label(), NatureL = new Label(), MoveL = new Label();
            public Label pokemonhead = new Label();
            public PokemonSearch.PokemonInfo poke = Pokemondata.GetpPokemonUSE("风妖精");
            public Button tran = new Button();

            public PokemonInfo(PokemonSearch.PokemonInfo poke, int id)
            {
                this.id = id;
                load_data.AutoTexin(Ability);
                ItemL.Text = "道具";
                AbilityL.Text = "特性";
                NatureL.Text = "性格";
                MoveL.Text = "招式";
                tran.Text = "detail";
                for (int i = 0; i < 4; ++i)
                {
                    Move[i] = new TextBox();
                    load_data.AutoZS(Move[i]);
                    //Move[i].BorderStyle = BorderStyle.FixedSingle;
                    // move[i].LostFocus += PokemonInfo_LostFocus;
                }
                PokemonBase[] temp = Pokemondata.Getpokemon();
                foreach (PokemonBase a in temp) {
                    Name.Items.Add((String)a.name);
                }

                
                
                Name.SelectedIndexChanged += Name_SelectedIndexChanged;
                Name.TextChanged += Name_TextChanged;
                Name.SelectedItem = "烈咬陆鲨";
                tran.Click += Tran_Click;
                
            }

            private void CALU_FormClosing(object sender, FormClosedEventArgs e)
            {
                for (int i = 0; i < 6; ++i)
                {
                    CALU.poke.RacialValue.Value[i] = int.Parse(CALU.pokevalue[i,0].Text);
                    CALU.poke.IVS.Value[i] = int.Parse(CALU.pokevalue[i,1].Text);
                    CALU.poke.EVS.Value[i] = int.Parse(CALU.pokevalue[i,2].Text);
                    CALU.poke.Nature = Pokemondata.getNatureClass(CALU.nature.SelectedIndex);
                }
                qq[CALU.id / 2, CALU.id % 2].poke = CALU.poke;
            }

            private void Tran_Click(object sender, EventArgs e)
            {
                if (CALU == null || CALU.Visible == false)
                {
                    CALU = new Calu();
                    CALU.FormClosed += CALU_FormClosing;
                    CALU.show(poke, id);
                }
                else
                {
                    CALU.Activate();
                }
            }

            private void Name_TextChanged(object sender, EventArgs e)
            {
                //if (this.poke.name == "冰伊布")
                //{
                //    if (((ComboBox)sender).Text == "Icefairy")
                //    {
                //        pokemonhead.Image = (Image)pokeimg.ResourceManager.GetObject("Icefairy");
                //    }
                //    else if (((ComboBox)sender).Text == "艾斯菲力")
                //    {
                //        pokemonhead.Image = (Image)pokeimg.ResourceManager.GetObject("Icefairy");
                //    }
                //}

                //else 
                if (Name.Items.Contains(((ComboBox)sender).Text))
                {
                    Name.SelectedItem = ((ComboBox)sender).Text;
                }
            }

            private void Name_SelectedIndexChanged(object sender, EventArgs e)
            {
                //throw new NotImplementedException();
                if (((ComboBox)sender).SelectedItem.ToString() != poke.name)
                {
                    SetPokemon(((ComboBox)sender).SelectedItem.ToString());
                    pokemonhead.Image = (Image)pokeimg.ResourceManager.GetObject(((ComboBox)sender).SelectedItem.ToString().Replace("-", "T").Replace("（", "T").Replace("）", "").Replace("：", "T").Replace("・", "T").Replace("%", ""));
                }
                
            }

            public void SetPokemon(string poname)
            {
                if (poname == null)
                {
                    this.poke = Pokemondata.GetpPokemonUSE("烈咬陆鲨");
                }
                else if (poname != this.poke.name)
                {
                    this.poke = Pokemondata.GetpPokemonUSE(poname);
                }
            }

            public void show(Main main, int x, int y)
            {
                this.pokemonhead.SetBounds(x - 1, y + 5, 41, 41);
                this.Name.SetBounds(x + 50, y + 15, 100, 21);

                // this.Name.Location = new System.Drawing.Point(x + 50, y + 15);
                for (int i = 0; i < 4; ++i)
                {
                    Move[i].SetBounds(x + 50, y + 50 + 20 * i, 100, 20);
                    // move[i].Location = new System.Drawing.Point();
                    main.Controls.Add(Move[i]);
                    // Pokemondata.AutoMove(move[i]);
                }
                AbilityL.SetBounds(x, y + 110 + 34, 50, 20);
                Ability.SetBounds(x + 50, y + 110 + 30, 100, 20);
                MoveL.SetBounds(x, y + 54, 50, 20);
                ItemL.SetBounds(x, y + 145 + 25, 50, 20);
                Item.SetBounds(x + 50, y + 140 + 25, 100, 20);
                tran.SetBounds(x + 170, y + 15, 80, 170);
                main.Controls.Add(pokemonhead);
                main.Controls.Add(Name);
                main.Controls.Add(AbilityL);
                main.Controls.Add(Ability);
                main.Controls.Add(tran);
                main.Controls.Add(MoveL);
                main.Controls.Add(ItemL);
                main.Controls.Add(Item);
            }
        }

        static PokemonInfo[,] qq = new PokemonInfo[3, 2];


        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < 2; ++j)
                {
                    qq[i,j] = new PokemonInfo(null, i * 2 + j);
                    qq[i,j].show(this, 400 + 300 * j, 50 + 250 * i);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PokemonSearch.PokemonInfo[] asfl = Pokemonshowdown.PStoPokemon(PS.Text.Trim());

            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < 2; ++j)
                {
                    if (i * 2 + j > asfl.Length - 1)
                    {
                        update(i, j, null);
                        continue;
                    }
                    update(i, j, asfl[i * 2 + j]);
                    // if (temp[i * 2 + j] == null) continue;
                    // qq[i,j] = new PokemonInfo(temp[i * 2 + j]);
                    // qq[i,j].show(this, 500 + 300 * j, 50 + 250 * i);
                }
            }
        }

        private void update(int i, int j, PokemonSearch.PokemonInfo poke)
        {
            if (poke == null)
            {
                qq[i,j].Name.SelectedItem = "烈咬陆鲨";
                qq[i,j].poke = Pokemondata.GetpPokemonUSE("烈咬陆鲨");
                for (int index1 = 0; index1 < 4; ++index1)
                {
                    qq[i,j].Move[index1++].Text = "";
                }
                qq[i,j].Item.Text = "";
                qq[i,j].Nature.Text = "";
                qq[i,j].Ability.Text = "";
            }
            else
            {
                qq[i,j].Name.SelectedItem = poke.name;

                qq[i,j].poke = poke;
                int index1 = 0;
                foreach (String item in poke.move)
                {
                    qq[i,j].Move[index1++].Text = item;
                }
                while (index1 < 4)
                {
                    qq[i,j].Move[index1++].Text = "";
                }
                qq[i,j].Item.Text = poke.Item;
                qq[i,j].Nature.Text = poke.Nature.name;
                qq[i,j].Ability.Text = poke.Ability;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PokemonSearch.PokemonInfo[] asfl = new PokemonSearch.PokemonInfo[6];
            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < 2; ++j)
                {
                    qq[i,j].poke.Item = qq[i,j].Item.Text;
                    qq[i,j].poke.Ability = qq[i,j].Ability.Text;
                    qq[i,j].poke.name = (String)qq[i,j].Name.SelectedItem;
                    for (int q = 0; q < qq[i, j].poke.move.Length; ++q)
                    {
                        qq[i,j].poke.move[q] = qq[i,j].Move[q].Text;
                    }
                    asfl[i * 2 + j] = qq[i,j].poke;

                    // if (temp[i * 2 + j] == null) continue;
                    // qq[i,j] = new PokemonInfo(temp[i * 2 + j]);
                    // qq[i,j].show(this, 500 + 300 * j, 50 + 250 * i);
                }
            }
            PS.Text = (Pokemonshowdown.PokemontoPS(asfl));
        }

        private void button21_Click(object sender, EventArgs e)
        {
            PokemonSearch.PokemonInfo[] asfl = new PokemonSearch.PokemonInfo[6];
            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < 2; ++j)
                {
                    qq[i, j].poke.Item = qq[i, j].Item.Text;
                    qq[i, j].poke.Ability = qq[i, j].Ability.Text;
                    qq[i, j].poke.name = (String)qq[i, j].Name.SelectedItem;
                    for (int q = 0; q < qq[i, j].poke.move.Length; ++q)
                    {
                        qq[i, j].poke.move[q] = qq[i, j].Move[q].Text;
                    }
                    asfl[i * 2 + j] = qq[i, j].poke;

                    // if (temp[i * 2 + j] == null) continue;
                    // qq[i,j] = new PokemonInfo(temp[i * 2 + j]);
                    // qq[i,j].show(this, 500 + 300 * j, 50 + 250 * i);
                }
            }
            PS.Text = (Pokemonshowdown.PokemontoPS(asfl, true));
        }

        private void PS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\x1')
            {
                ((TextBox)sender).SelectAll();
                e.Handled = true;
            }
        }

        userQQ cof = null;

        private void button22_Click(object sender, EventArgs e)
        {
            if (cof == null || cof.IsDisposed)
            {
                cof = new userQQ(qq);
                cof.Show();
            }
            else
            {
                cof.Activate();
            }
        }
    }
    
}
