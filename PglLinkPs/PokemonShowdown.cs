using System.Text.RegularExpressions;
using PokemonSearch;
using PglLinkPs;

namespace submit
{
    public class Pokemonshowdown
    {
        public static PokemonInfo PStoPokemon_once(string PStext)
        {
            string[] data = Regex.Split(PStext.Trim(), "\r*\n");
            string[] NameandItem = Regex.Split(data[0].Trim(), @"\s+@\s+"); // 昵称
            string Item = null;
            string Name = NameandItem[0];
            string move = "";
            string Ability = null;
            Racial EVSfin = new Racial();
            EVSfin.clear();
            Racial IVsfin = new Racial();
            IVsfin.fill();
            int Level = 50;
            
            if (NameandItem.Length > 1)
            {
                Item = Pokemondata.GetItemName(Pokemondata.EnglishNametoItemID(NameandItem[1]));
            }
            string[] ntemp = Regex.Split(Name ,@"\s+\(");
            string nickname = null;
            string Nature = "Serious";
            bool SHINY = false;
            if (ntemp.Length == 3)
            {
                nickname = ntemp[0];
                Name = ntemp[1].Substring(0, ntemp[1].Length - 1);
            }
            else if (ntemp.Length == 2)
            {
                if (ntemp[1].Length <= 4)
                {
                    Name = ntemp[0];
                }
                else
                {
                    Name = ntemp[1].Substring(0, ntemp[1].Length - 1);
                }
            }
            int qq = 9;
            PokemonInfo PB = new PokemonInfo(Pokemondata.GetPokemonBase(Pokemondata.EnglishNametopokeID(Name)));

            for (int i = 1; i < data.Length; ++i)
            {
                string[] temp = Regex.Split(data[i].Trim(), @"\s*:\s*");
                switch (temp[0])
                {
                    case "Ability":
                        Ability = Pokemondata.GetAbilityName(Pokemondata.EnglishNametoAbilityID(temp[1]));
                        break;
                    case "EVs":
                        string[] EVs = Regex.Split(temp[1], @"\s*/\s*");

                        foreach (string item in EVs)
                        {
                            string[] orz = Regex.Split(item, @"\s+");
                            if (title(orz[1]) >= 0)
                            {
                                EVSfin.FromnumToSet(title(orz[1]), int.Parse(orz[0]));
                            }
                        }
                        break;
                    case "IVs":
                        string[] IVs = Regex.Split(temp[1], @"\s*/\s*");

                        foreach (string item in IVs)
                        {
                            string[] orz = Regex.Split(item, @"\s+");
                            if (title(orz[1]) >= 0)
                            {
                                IVsfin.FromnumToSet(title(orz[1]), int.Parse(orz[0]));
                            }
                        }
                        break;
                    case "Level":
                        Level = int.Parse(temp[1]);
                        break;
                    case "Shiny":
                        if (temp[1] == "Yes")
                        {
                            SHINY = true;
                        }

                        break;
                    default:
                        string[] gg = data[i].Split(' ');
                        if (gg[1] == "Nature")
                        {
                            Nature = gg[0];
                        }
                        else
                        {
                            string move1 = Regex.Replace(data[i].Trim(), @"\s*-\s+", "");
                            if (move1.Contains("Hidden Power"))
                            {
                                if (move1.Contains("["))
                                {
                                    string wqeeq = move1.Substring(move1.IndexOf("[")
                                        + 1, move1.Length - move1.IndexOf("[") - 2);
                                    move1 = "觉醒力量-" + Pokemondata.GetTypeName
                                        (Pokemondata.GetEngTypeId(move1.Substring(move1.IndexOf("[") 
                                        + 1, move1.Length - move1.IndexOf("[") - 2)));
                                }
                                else
                                {
                                    move1 = "觉醒力量-" + Pokemondata.GetTypeName(Pokemondata.GetEngTypeId(IVsfin.getHiddenPowerType()));
                                }
                                if (move == "") move = move1;
                                else move += "," + (move1);
                            }
                            else
                            {
                                if (move == "") move = Pokemondata.GetMoveName(Pokemondata.EnglishNametoMoveID(move1));
                                else move += "," + Pokemondata.GetMoveName(Pokemondata.EnglishNametoMoveID(move1));
                            }
                            //move1 = Regex.Replace(move1, "\\[.+?\\]", "").Trim();
                            
                        }
                        break;

                }
            }
            string[] movelist = move.Split(',');
            PB.Pokemonextend(movelist, Item, Ability, SHINY, EVSfin, IVsfin, Level, Pokemondata.getNatureClass(Nature));
            return PB;
        }

        private static int title(string a)
        {
            switch (a)
            {
                case "HP":
                    return 0;
                case "Atk":
                    return 1;
                case "Def":
                    return 2;
                case "SpA":
                    return 3;
                case "SpD":
                    return 4;
                case "Spe":
                    return 5;
                default:
                    return -1;
            }

        }
        public static PokemonInfo[] PStoPokemon(string PStext) {
            string[] team = Regex.Split(PStext.Trim(), "(?:\r\n){2,}", RegexOptions.IgnoreCase);
            PokemonInfo[] TeamList = new PokemonInfo[team.Length];

            int index = 0; 
            foreach (var item in team)
            {
                if (item != "")
                    try
                    {
                        TeamList[index++] = PStoPokemon_once(item);
                    }
                    catch { }
            }
            return TeamList;
        }
        public static string PokemontoPS(PokemonInfo[] poke, bool chiflag = false)
        {
            string team = "";
            int index = 0;
            foreach (PokemonInfo item in poke)
            {
                if (item != null)
                    try
                    {
                        if (chiflag)
                        {
                            team += PokemontochiPS_once(item) + "\r\n\r\n";
                        }
                        else
                        {
                            team += PokemontoPS_once(item) + "\r\n\r\n";

                        }
                    }
                    catch 
                    {

                    }
            }
            return team;
        }

        public static string PokemontoPS_once(PokemonInfo poke)
        {
            string team = Pokemondata.EnglishName[(int)(Pokemondata.PokemonnameID[poke.name])];
            if (poke.Item != "")
            {
                team += " @ " + Pokemondata.ItemEngName[Pokemondata.GetItemId(poke.Item)];
            }
            team += "\r\n";
            if (poke.Ability != "")
            {
                team += "Ability: " + Pokemondata.AbilityEngName[Pokemondata.GetAbilityId(poke.Ability)] + "\r\n";
            }
            team += "Level: 50\r\n";
            string aa = "";
            string[] orz = { "HP", "Atk", "Def", "SpA", "SpD", "Spe" };
            for (int i = 0; i < 6; ++i)
            {
                if (poke.EVS.Value[i] != 0)
                {
                    aa += " " + (poke.EVS.Value[i]).ToString() + " " + orz[i] + " /";
                }
            }
            if (aa != "")
            {
                team += "EVs:" + aa.Substring(0, aa.Length - 1) + "\r\n";
            }
            if (poke.Nature != null)
            {
                team += Pokemondata.Engnature[poke.Nature.id];
            }
            else
            {
                team += Pokemondata.Engnature[0];
            }
            team += " Nature\r\n";
            aa = "";
            for (int i = 0; i < 6; ++i)
            {
                if (poke.IVS.Value[i] != 31)
                {
                    aa += " " + (poke.IVS.Value[i]).ToString() + " " + orz[i] + " /";
                }
            }
            if (aa != "")
            {
                team += "IVs:" + aa.Substring(0, aa.Length - 1) + "\r\n";
            }

            foreach (string i in poke.move)
            {
                if (i != "")
                {
                    if (i.Contains("觉醒力量"))
                    {
                        if (i.Contains("-"))
                        {
                            team += string.Format("Hidden Power [{0}]\r\n", Pokemondata.GetEngTypeName(Pokemondata.GetTypeId(i.Substring(i.IndexOf("-") + 1))));
                        }
                        else
                        {
                            team += string.Format("Hidden Power [{0}]\r\n", poke.getHiddenPowerType());
                        }
                    }
                    else
                        team += "- " + Pokemondata.MoveEngName[Pokemondata.GetMoveId(i)] + "\r\n";
                }
                    
            }
            return team;
        }

        public static string PokemontochiPS_once(PokemonInfo poke)
        {
            string team = poke.name;
            if (poke.Item != "")
            {
                team += " @ " + poke.Item;
            }
            team += "\r\n";
            if (poke.Ability != "")
            {
                team += "特性: " + poke.Ability + "\r\n";
            }
            team += "等级: 50\r\n";
            string aa = "";
            string[] orz = { "HP", "物攻", "物防", "特攻", "特防", "速度" };
            for (int i = 0; i < 6; ++i)
            {
                if (poke.EVS.Value[i] != 0)
                {
                    aa += " " + (poke.EVS.Value[i]).ToString() + " " + orz[i] + " /";
                }
            }
            if (aa != "")
            {
                team += "努力值:" + aa.Substring(0, aa.Length - 1) + "\r\n";
            }
            if (poke.Nature != null)
            {
                team += poke.Nature.name;
            }
            else
            {
                team += Pokemondata.getNatureClass(0);
            }
            team += " 性格\r\n";
            aa = "";
            for (int i = 0; i < 6; ++i)
            {
                if (poke.IVS.Value[i] != 31)
                {
                    aa += " " + (poke.IVS.Value[i]).ToString() + " " + orz[i] + " /";
                }
            }
            if (aa != "")
            {
                team += "个体值:" + aa.Substring(0, aa.Length - 1) + "\r\n";
            }

            foreach (string i in poke.move)
            {
                if (i != "")

                    team += "- " + i + "\r\n";
            }
            return team;
        }
    }
}
