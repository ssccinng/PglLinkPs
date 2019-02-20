
using PglLinkPs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonSearch
{
    // mega对mega 形态归形态
    public class Pokemon : PokemonBase
    {

        // private String name;
        public string Name;

        public string getname()
        {
            return NameList[FormId];
        }
        // private String[] NameList;

        public string Item;
        public string Ability;

        public string[] move = new string[4];
        public int Level;
        public bool Shiny;
        public Racial EVS;
        public Racial IVS;
        public NatureClass Nature;
        public Pokemon(PokemonBase f) : base(f.name, f.PokemonID, f.NameList, f.TypeId, f.AbilityList, f.FormId, f.RacialValue)
        {
        }

        public void Pokemonextend()
        {
            Setmove(move);
            this.Item = null;
            this.Ability = Pokemondata.GetAbilityName(AbilityList[0]);
            this.Shiny = false;
            this.EVS = new Racial();
            this.IVS = new Racial(31);
            this.Nature = Pokemondata.getNatureClass(0);
            this.Level = 50;
        }

        // public Pokemon(Pokemon f) {
        //     super(f.name, f.PokemonID, f.NameList, f.TypeId, f.AbilityList, f.FormId, f.RacialValue);
        //     Pokemonextend(f.movelist, f.Item, f.Ability, f.Shiny, f.EVS, f.IVS, f.Level, f.Nature);
        // }
        public void Pokemonextend(string[] move, string Item, string Ability, bool Shiny, Racial EVS, Racial IVS,
                int Level, NatureClass Nature)
        {
            Setmove(move);
            this.Item = Item;
            this.Ability = Ability;
            this.Shiny = Shiny;

            // this.EVS = new Racial(EVS) ;
            // this.IVS = new Racial(IVS);
            this.EVS = (EVS);
            this.IVS = (IVS);
            this.Level = Level;
            this.Nature = (Nature);
            // this.Nature = new NatureClass(Nature);
        }
        // public Pokemon(/*String Name, String Item, String Ability,
        // String Nature, String[] move, int FormId = 0*/): base()
        // {
        // // this.name = Name;
        // // this.PokemonID = Pokemondata.GetPokemonID(Name);
        // // this.NameList = Pokemondata.GetPokemonFrom(Name);
        // // this.TypeId = Pokemondata.GetPokemonType(this.PokemonID);

        // // // this.Limit = GetLimit(Pokemondata.GetPokeLimit(this.PokemonID));
        // // this.Item = Item;
        // // this.Ability = Ability;
        // // this.Nature = Nature;
        // // this.FormId = FormId;
        // // this.move = new String[move.length];
        // // for (int i = 0; i < move.length; ++i)
        // // {
        // // this.move[i] = move[i];
        // // }
        // }

        public bool Setmove(string[] move)
        {
            if (move == null)
                return true;
            if (move.Length > 4)
                return false;
            else
            {
                this.move = new string[move.Length];
                for (int i = 0; i < move.Length; ++i)
                {
                    this.move[i] = move[i];
                }
                return true;
            }
        }
        // private PokeLimit GetLimit(int LimitId)
        // {
        // switch (LimitId)
        // {
        // case 0: return PokeLimit.NORMAL;
        // case 1: return PokeLimit.LEGEND;
        // case 2: return PokeLimit.MYSTERY;
        // default:
        // return PokeLimit.NORMAL;
        // }
        // }

        // public void print() {
        // Console.WriteLine("����: " + Name);
        // Console.WriteLine("����: " + Ability);
        // Console.WriteLine("����: " + Item);
        // Console.WriteLine("��ʽ: ");
        // foreach (String item in move)
        // {
        // Console.WriteLine(item);
        // }
        // Console.WriteLine("Ŭ��ֵ: ");
        // EVS.print();
        // Console.WriteLine("����ֵ: ");
        // IVS.print();

        //

    }
}
