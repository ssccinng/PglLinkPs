using PokemonSearch;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace PglLinkPs
{

    public class Pokemondata
    {
        static int a = 1;

        private static string[] Type = { null, "火", "水", "草", "电", "一般", "格斗", "飞行", "虫", "毒", "岩石", "地面", "钢", "冰", "超能力", "恶", "幽灵", "龙", "妖精" };
        private static string[] EngType = { null, "Fire", "Water", "Grass", "Electric", "Normal", "Fighting", "Flying", "Bug", "Poison", "Rock", "Ground", "Steel", "Ice", "Psychic", "Dark", "Ghost", "Dragon", "Fairy" };
        public static string[] Ability = database.Ability.Split(',');
        public static string[] EnglishName = database.EnglishName.Split(',');

        public static string[] AbilityEngName = database.AbilityEngName.Split(',');

        public static string[] MoveName = database.MoveName.Split(',');
        public static string[] MoveEngName = database.MoveEngName.Split(',');
        public static string[] ItemName = database.ItemName.Split(',');
        public static string[] ItemEngName = database.ItemEngName.Split(',');
        private static Hashtable TypeId = DeHashtable(Type);
        private static Hashtable EngTypeId = DeHashtable(EngType);
        public static Hashtable EngAbilityID = DeHashtable(AbilityEngName);
        private static Hashtable EngMoveID = DeHashtable(MoveEngName);
        private static Hashtable EngItemID = DeHashtable(ItemEngName);
        private static Hashtable ItemID = DeHashtable(ItemName);
        private static Hashtable MoveID = DeHashtable(MoveName);
        private static string Pokedatasour = database.Pokedata;
        private static string[,] Pokedata = Pokedatainit();
        public static Hashtable PokemonID = PokemonIDinit();
        public static Hashtable PokemonnameID = PokemonnameIDinit();
        private static Hashtable EngPokemonID = DeHashtable(EnglishName);
        private static string[] PokeNamelist = PokeNamelistinit();
        private static Hashtable AbilityId = DeHashtable(Ability);
        private static PokemonBase[] POKEMON = Pokemoninit();
        private static NatureClass[] naturedata = NatureClassinit();
        public static string[] Engnature = { "Hardy", "Lonely", "Brave", "Adamant", "Naughty", "Bold", "Docile", "Relaxed",
            "Impish", "Lax", "Timid", "Hasty", "Serious", "Jolly", "Naive", "Modest", "Mild", "Quiet", "Bashful",
            "Rash", "Calm", "Gentle", "Sassy", "Careful", "Quirky" };
        private static Hashtable EngnatureId = DeHashtable(Engnature);

        private static Hashtable pokemonListId = PokemonListIDinit();

        private static Hashtable DeHashtable(string[] a)
        {
            Hashtable temp = new Hashtable();
            int index = 0;
            foreach (string item in a)
            {
                if (item != null)
                    temp[item] = index;
                index++;
            }
            return temp;
        }

        private static string[,] Pokedatainit()
        {
            string[] data = Regex.Split(Pokedatasour, "\r*\n");
            string[,] Pokedata = new string[data.Length, 13];
            int index = 0;
            foreach (string item in data)
            {
                string[] poke = item.Split(',');
                for (int i = 0; i < 13; ++i)
                {
                    Pokedata[index,i] = poke[i];
                }
                index++;
            }
            return Pokedata;
        }

        private static Hashtable PokemonIDinit()
        {
            Hashtable PokemonID = new Hashtable();
            for (int i = 0; i < Pokedata.GetLength(0); ++i)
            {
                PokemonID[Pokedata[i,0]] =  int.Parse(Pokedata[i,12]);
            }
            return PokemonID;
        }

        private static Hashtable PokemonnameIDinit()
        {
            Hashtable PokemonID = new Hashtable();

            for (int i = 0; i < Pokedata.GetLength(0); ++i)
            {
                PokemonID[Pokedata[i, 0]] = i;
            }
            return PokemonID;
        }

        private static Hashtable EngPokemonIDinit()
        {
            Hashtable PokemonID = new Hashtable();
            for (int i = 0; i < EnglishName.Length; ++i)
            {
                PokemonID[EnglishName[i]] = i;
            }
            return PokemonID;
        }

        private static string[] PokeNamelistinit()
        {
            int max = 0;
            foreach (Object item in PokemonID.Values)
            {
                max = Max(max, (int)item);
            }
            string[] PokeNamelist = new string[max + 1];
            for (int i = 0; i < Pokedata.GetLength(0); ++i)
            {
                if (PokeNamelist[int.Parse(Pokedata[i,12])] == null)
                {
                    PokeNamelist[int.Parse(Pokedata[i,12])] = Pokedata[i,0];
                }
                else
                {
                    PokeNamelist[int.Parse(Pokedata[i,12])] += "," + Pokedata[i,0];
                }
            }
            return PokeNamelist;
        }

        private static int Max(int max, int item)
        {
            return max > item ? max : item;
        }

        private static PokemonBase[] Pokemoninit()
        {
            PokemonBase[] POKEMON = new PokemonBase[Pokedata.GetLength(0)];
            int[] index = new int[PokeNamelist.Length];
            for (int i = 0; i < index.Length; ++i)
            {
                index[i] = 0;
            }
            for (int i = 0; i < Pokedata.GetLength(0); ++i)
            {
                Racial temp = new Racial(Pokedata[i,3], Pokedata[i,4], Pokedata[i,5], Pokedata[i,6], Pokedata[i,7],
                        Pokedata[i,8]);
                int[] TypeList = { int.Parse(Pokedata[i,1]), int.Parse(Pokedata[i,2]) };
                int[] AbilityList = { int.Parse(Pokedata[i,9]), int.Parse(Pokedata[i,10]),
                    int.Parse(Pokedata[i,11]) };
                POKEMON[i] = new PokemonBase(Pokedata[i,0], int.Parse(Pokedata[i,12]),
                        PokeNamelist[int.Parse(Pokedata[i,12])].Split(','), TypeList, AbilityList,
                        index[int.Parse(Pokedata[i,12])], temp);
                index[int.Parse(Pokedata[i,12])]++;
            }
            return POKEMON;
        }

        private static Hashtable PokemonListIDinit()
        {
            Hashtable pokemonlistId = new Hashtable();
            for (int i = 0; i < Pokedata.GetLength(0); ++i)
            {
                pokemonlistId[Pokedata[i,0]] = i;
            }
            return pokemonlistId;
        }

        private static NatureClass[] NatureClassinit()
        {
            NatureClass[] Naturelist = new NatureClass[26];
            int i = 0;
            foreach (string s in database.Naturedata)
            {
                string[] ss = s.Split(',');
                Naturelist[i++] = new NatureClass(ss[0], int.Parse(ss[1]), int.Parse(ss[2]),
                        int.Parse(ss[3]), i - 1);
            }
            return Naturelist;
        }

        public static int GetPokemonID(string Name)
        {
            return (int)PokemonID[Name];
        }

        public static string[] GetPokemonFrom(int PkId)
        {
            return PokeNamelist[PkId].Split(',');
        }

        public static int GetPokemonListID(string Name)
        {
            return (int)pokemonListId[Name];
        }

        public static int[] GetPokemonType(string name)
        {
            return GetPokemonType(GetPokemonID(name));
        }

        public static int[] GetPokemonType(int PkId)
        {
            return POKEMON[PkId].TypeId;
        }

        public static string[] GetPokemonFrom(string name)
        {
            return GetPokemonFrom(GetPokemonID(name));
        }

        public static string GetTypeName(int TypeId)
        {
            return Type[TypeId];
        }

        public static string[] GetTypeName(int[] TypeId)
        {
            string[] Typename = new string[TypeId.Length];
            for (int i = 0; i < TypeId.Length; ++i)
            {
                Typename[i] = GetTypeName(TypeId[i]);
            }
            return Typename;
        }

        public static int GetTypeId(string Typename)
        {
            return (int)TypeId[Typename];
        }

        public static int[] GetTypeId(string[] Typename)
        {
            int[] TypeId = new int[Typename.Length];
            for (int i = 0; i < Typename.Length; ++i)
            {
                TypeId[i] = GetTypeId(Typename[i]);
            }
            return TypeId;
        }

        public static string GetEngTypeName(int TypeId)
        {
            return EngType[TypeId];
        }

        public static string[] GetEngTypeName(int[] TypeId)
        {
            string[] EngTypename = new string[TypeId.Length];
            for (int i = 0; i < TypeId.Length; ++i)
            {
                EngTypename[i] = GetEngTypeName(TypeId[i]);
            }
            return EngTypename;
        }

        public static int GetEngTypeId(string Typename)
        {
            return (int)EngTypeId[Typename];
        }

        public static int[] GetEngTypeId(string[] Typename)
        {
            int[] EngTypeId = new int[Typename.Length];
            for (int i = 0; i < Typename.Length; ++i)
            {
                EngTypeId[i] = GetEngTypeId(Typename[i]);
            }
            return EngTypeId;
        }

        public static int GetAbilityId(string name)
        {
            if (AbilityId.Contains(name))
                return (int)AbilityId[name];
            return 0;
        }

        public static string GetAbilityName(int Id)
        {
            return Ability[Id];
        }

        public static int GetItemId(string name)
        {
            if (ItemID.Contains(name))
                return (int)ItemID[name];
            return 0;
        }

        public static int GetMoveId(string name)
        {
            if (MoveID.Contains(name))
                return (int)MoveID[name];
            return 0;
        }

        public static string GetMoveName(int Id)
        {
            return MoveName[Id];
        }

        public static string GetItemName(int Id)
        {
            return ItemName[Id];
        }

        public static PokemonBase GetPokemonBase(int Id)
        {
            if (Id < POKEMON.Length)
                return POKEMON[Id];
            else
                return null;
        }

        public static PokemonBase GetPokemonBase(string name)
        {
            if (pokemonListId.Contains(name))
                return GetPokemonBase(GetPokemonListID(name));
            return null;
        }

        public static NatureClass getNatureClass(int id)
        {
            return naturedata[id];
        }

        public static NatureClass getNatureClass(string name)
        {
            return getNatureClass(GetEngnatureId(name));
        }

        public static int GetEngnatureId(string name)
        {
            if (EngnatureId.Contains(name))
                return (int)EngnatureId[name];
            return 0;
        }

        public static PokemonInfo GetpPokemonUSE(string name)
        {
            if (pokemonListId.Contains(name))
            {
                PokemonInfo b = new PokemonInfo(GetPokemonBase(name));
                b.Pokemonextend();
                return b;
            }
            return null;
        }

        public static int EnglishNametopokeID(string name)
        {
            return (int)EngPokemonID[name];
        }

        public static int EnglishNametoAbilityID(string name)
        {
            return (int)EngAbilityID[name];
        }

        public static int EnglishNametoMoveID(string name)
        {
            return (int)EngMoveID[name];
        }

        public static int EnglishNametoItemID(string name)
        {
            return (int)EngItemID[name];
        }

        public static PokemonBase[] Getpokemon()
        {
            return POKEMON;
        }
    }
}
