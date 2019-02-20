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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        class PokemonInfo
        {
            public int id;

            public TextBox Item = new TextBox(), Nature = new TextBox(), Ability = new TextBox();
            public TextBox[,] pokevalue = new TextBox[6, 3];
            public TextBox[] Move = new TextBox[4];
            public ComboBox Name = new ComboBox();
            public Label ItemL = new Label(), AbilityL = new Label(), NatureL = new Label(), MoveL = new Label();
            public Label pokemonhead = new Label();
            public Pokemon poke;
            public Button tran = new Button();

            public PokemonInfo(Pokemon poke, int id)
            {
                this.id = id;
                ItemL.Text = "道具";
                AbilityL.Text = "特性";
                NatureL.Text = "性格";
                MoveL.Text = "招式";
                tran.Text = "detail";
                for (int i = 0; i < 4; ++i)
                {
                    Move[i] = new TextBox();
                    // move[i].LostFocus += PokemonInfo_LostFocus;
                }
                PokemonBase[] temp = Pokemondata.Getpokemon();
                foreach (PokemonBase a in temp) {
                    Name.Items.Add((String)a.name);
                }
                Name.SelectedItem = "冰伊布";
                Name.SelectedIndexChanged += Name_SelectedIndexChanged;
            }

            private void Name_SelectedIndexChanged(object sender, EventArgs e)
            {
                //throw new NotImplementedException();
            }


            public void show(Main main, int x, int y)
            {
                this.pokemonhead.SetBounds(x, y + 5, 41, 41);
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

        PokemonInfo[,] qq = new PokemonInfo[3, 2];


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
    }
}
