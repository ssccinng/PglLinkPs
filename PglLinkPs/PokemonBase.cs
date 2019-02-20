using PokemonSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PglLinkPs
{
    public class PokemonBase
    {

        public string name;
        public int PokemonID;
        public string[] NameList;
        public int[] TypeId;
        public int[] AbilityList;
        public string[] movelist; // 未完�?
        public int FormId;
        public Racial RacialValue;

        public PokemonBase(string name, int PokemonID, string[] NameList, int[] TypeId, int[] AbilityList, int FormId,
                Racial racial)
        {
            this.name = name;
            this.PokemonID = PokemonID;
            this.NameList = NameList;
            this.TypeId = TypeId;
            this.AbilityList = AbilityList;
            this.FormId = FormId;
            this.RacialValue = racial;
        }

        public PokemonBase()
        {

        }
    }

}
