﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PglLinkPs
{

    public class database
    {
        public static string readToString(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs, Encoding.GetEncoding("gb2312"));

            string re = sr.ReadToEnd();
            sr.Close();
            fs.Close();
            fs.Dispose();
            return re;
        }

        public static string Ability = ",恶臭,降雨,加速,战斗盔甲,结实,湿气,柔软,沙隐,静电,蓄电,储水,迟钝,无关天气,复眼,不眠,变色,免疫,引火,鳞粉,我行我素,吸盘,威吓,踩影,粗糙皮肤,神奇守护,飘浮,孢子,同步,恒净之躯,自然回复,避雷针,天恩,悠游自如,叶绿素,发光,复制,大力士,毒刺,精神力,熔岩铠甲,水幕,磁力,隔音,雨盘,扬沙,压迫感,厚脂肪,早起,火焰之躯,逃跑,锐利目光,怪力钳,捡拾,懒惰,活力,迷人之躯,正电,负电,阴晴不定,黏着,蜕皮,毅力,神奇鳞片,污泥浆,茂盛,猛火,激流,虫之预感,坚硬脑袋,日照,沙穴,干劲,白色烟雾,瑜伽之力,硬壳盔甲,气闸,蹒跚,电气引擎,斗争心,不屈之心,雪隐,贪吃鬼,愤怒穴位,轻装,耐热,单纯,干燥皮肤,下载,铁拳,毒疗,适应力,连续攻击,湿润之躯,太阳之力,飞毛腿,一般皮肤,狙击手,魔法防守,无防守,慢出,技术高手,叶子防守,笨拙,破格,超幸运,引爆,危险预知,预知梦,纯朴,有色眼镜,过滤,慢启动,胆量,引水,冰冻之躯,坚硬岩石,降雪,采蜜,察觉,舍身,多属性,花之礼,梦魇,顺手牵羊,强行,唱反调,紧张感,不服输,软弱,诅咒之躯,治愈之心,友情防守,碎裂铠甲,重金属,轻金属,多重鳞片,中毒激升,受热激升,收获,心灵感应,心情不定,防尘,毒手,再生力,健壮胸肌,拨沙,奇迹皮肤,分析,幻觉,变身者,穿透,木乃伊,自信过度,正义之心,胆怯,魔法镜,食草,恶作剧之心,沙之力,铁刺,达摩模式,胜利之星,涡轮火焰,兆级电压,芳香幕,花幕,颊囊,变幻自如,毛皮大衣,魔术师,防弹,好胜,强壮之颚,冰冻皮肤,甜幕,战斗切换,疾风之翼,超级发射器,草之毛皮,共生,硬爪,妖精皮肤,黏滑,飞行皮肤,亲子爱,暗黑气场,妖精气场,气场破坏,始源之海,终结之地,德尔塔气流,持久力,跃跃欲逃,危险回避,遇水凝固,不仁不义,界限盾壳,蹲守,水泡,钢能力者,怒火冲天,拨雪,远隔,湿润之声,先行治疗,电气皮肤,冲浪之尾,鱼群,画皮,牵绊变身,群聚变形,腐蚀,绝对睡眠,女王的威严,飞出的内在物,舞者,蓄电池,毛茸茸,鲜艳之躯,魂心,卷发,接球手,化学之力,异兽提升,AR系统,电气制造者,精神制造者,薄雾制造者,青草制造者,金属防护,幻影防守,棱镜装甲,脑核之力";
        public static string AbilityEngName = ",Stench,Drizzle,Speed Boost,Battle Armor,Sturdy,Damp,Limber,Sand Veil,Static,Volt Absorb,Water Absorb,Oblivious,Cloud Nine,Compound Eyes,Insomnia,Color Change,Immunity,Flash Fire,Shield Dust,Own Tempo,Suction Cups,Intimidate,Shadow Tag,Rough Skin,Wonder Guard,Levitate,Effect Spore,Synchronize,Clear Body,Natural Cure,Lightning Rod,Serene Grace,Swift Swim,Chlorophyll,Illuminate,Trace,Huge Power,Poison Point,Inner Focus,Magma Armor,Water Veil,Magnet Pull,Soundproof,Rain Dish,Sand Stream,Pressure,Thick Fat,Early Bird,Flame Body,Run Away,Keen Eye,Hyper Cutter,Pickup,Truant,Hustle,Cute Charm,Plus,Minus,Forecast,Sticky Hold,Shed Skin,Guts,Marvel Scale,Liquid Ooze,Overgrow,Blaze,Torrent,Swarm,Rock Head,Drought,Arena Trap,Vital Spirit,White Smoke,Pure Power,Shell Armor,Air Lock,Tangled Feet,Motor Drive,Rivalry,Steadfast,Snow Cloak,Gluttony,Anger Point,Unburden,Heatproof,Simple,Dry Skin,Download,Iron Fist,Poison Heal,Adaptability,Skill Link,Hydration,Solar Power,Quick Feet,Normalize,Sniper,Magic Guard,No Guard,Stall,Technician,Leaf Guard,Klutz,Mold Breaker,Super Luck,Aftermath,Anticipation,Forewarn,Unaware,Tinted Lens,Filter,Slow Start,Scrappy,Storm Drain,Ice Body,Solid Rock,Snow Warning,Honey Gather,Frisk,Reckless,Multitype,Flower Gift,Bad Dreams,Pickpocket,Sheer Force,Contrary,Unnerve,Defiant,Defeatist,Cursed Body,Healer,Friend Guard,Weak Armor,Heavy Metal,Light Metal,Multiscale,Toxic Boost,Flare Boost,Harvest,Telepathy,Moody,Overcoat,Poison Touch,Regenerator,Big Pecks,Sand Rush,Wonder Skin,Analytic,Illusion,Imposter,Infiltrator,Mummy,Moxie,Justified,Rattled,Magic Bounce,Sap Sipper,Prankster,Sand Force,Iron Barbs,Zen Mode,Victory Star,Turboblaze,Teravolt,Aroma Veil,Flower Veil,Cheek Pouch,Protean,Fur Coat,Magician,Bulletproof,Competitive,Strong Jaw,Refrigerate,Sweet Veil,Stance Change,Gale Wings,Mega Launcher,Grass Pelt,Symbiosis,Tough Claws,Pixilate,Gooey,Aerilate,Parental Bond,Dark Aura,Fairy Aura,Aura Break,Primordial Sea,Desolate Land,Delta Stream,Stamina,Wimp Out,Emergency Exit,Water Compaction,Merciless,Shields Down,Stakeout,Water Bubble,Steelworker,Berserk,Slush Rush,Long Reach,Liquid Voice,Triage,Galvanize,Surge Surfer,Schooling,Disguise,Battle Bond,Power Construct,Corrosion,Comatose,Queenly Majesty,Innards Out,Dancer,Battery,Fluffy,Dazzling,Soul-Heart,Tangling Hair,Receiver,Power of Alchemy,Beast Boost,RKS System,Electric Surge,Psychic Surge,Misty Surge,Grassy Surge,Full Metal Body,Shadow Shield,Prism Armor,Neuroforce";
        public static string EnglishName = "Bulbasaur,Ivysaur,Venusaur,Venusaur-Mega,Charmander,Charmeleon,Charizard,Charizard-Mega-X,Charizard-Mega-Y,Squirtle,Wartortle,Blastoise,Blastoise-Mega,Caterpie,Metapod,Butterfree,Weedle,Kakuna,Beedrill,Beedrill-Mega,Pidgey,Pidgeotto,Pidgeot,Pidgeot-Mega,Rattata,Rattata-Alola,Raticate,Raticate-Alola,Spearow,Fearow,Ekans,Arbok,Pikachu,Pikachu-Original,Pikachu-Hoenn,Pikachu-Sinnoh,Pikachu-Unova,Pikachu-Kalos,Pikachu-Alola,Raichu,Raichu-Alola,Sandshrew,Sandshrew-Alola,Sandslash,Sandslash-Alola,Nidoran-F,Nidorina,Nidoqueen,Nidoran-M,Nidorino,Nidoking,Clefairy,Clefable,Vulpix,Vulpix-Alola,Ninetales,Ninetales-Alola,Jigglypuff,Wigglytuff,Zubat,Golbat,Oddish,Gloom,Vileplume,Paras,Parasect,Venonat,Venomoth,Diglett,Diglett-Alola,Dugtrio,Dugtrio-Alola,Meowth,Meowth-Alola,Persian,Persian-Alola,Psyduck,Golduck,Mankey,Primeape,Growlithe,Arcanine,Poliwag,Poliwhirl,Poliwrath,Abra,Kadabra,Alakazam,Alakazam-Mega,Machop,Machoke,Machamp,Bellsprout,Weepinbell,Victreebel,Tentacool,Tentacruel,Geodude,Geodude-Alola,Graveler,Graveler-Alola,Golem,Golem-Alola,Ponyta,Rapidash,Slowpoke,Slowbro,Slowbro-Mega,Magnemite,Magneton,Farfetch'd,Doduo,Dodrio,Seel,Dewgong,Grimer,Grimer-Alola,Muk,Muk-Alola,Shellder,Cloyster,Gastly,Haunter,Gengar,Gengar-Mega,Onix,Drowzee,Hypno,Krabby,Kingler,Voltorb,Electrode,Exeggcute,Exeggutor,Exeggutor-Alola,Cubone,Marowak,Marowak-Alola,Hitmonlee,Hitmonchan,Lickitung,Koffing,Weezing,Rhyhorn,Rhydon,Chansey,Tangela,Kangaskhan,Kangaskhan-Mega,Horsea,Seadra,Goldeen,Seaking,Staryu,Starmie,Mr. Mime,Scyther,Jynx,Electabuzz,Magmar,Pinsir,Pinsir-Mega,Tauros,Magikarp,Gyarados,Gyarados-Mega,Lapras,Ditto,Eevee,Vaporeon,Jolteon,Flareon,Porygon,Omanyte,Omastar,Kabuto,Kabutops,Aerodactyl,Aerodactyl-Mega,Snorlax,Articuno,Zapdos,Moltres,Dratini,Dragonair,Dragonite,Mewtwo,Mewtwo-Mega-X,Mewtwo-Mega-Y,Mew,Chikorita,Bayleef,Meganium,Cyndaquil,Quilava,Typhlosion,Totodile,Croconaw,Feraligatr,Sentret,Furret,Hoothoot,Noctowl,Ledyba,Ledian,Spinarak,Ariados,Crobat,Chinchou,Lanturn,Pichu,Cleffa,Igglybuff,Togepi,Togetic,Natu,Xatu,Mareep,Flaaffy,Ampharos,Ampharos-Mega,Bellossom,Marill,Azumarill,Sudowoodo,Politoed,Hoppip,Skiploom,Jumpluff,Aipom,Sunkern,Sunflora,Yanma,Wooper,Quagsire,Espeon,Umbreon,Murkrow,Slowking,Misdreavus,Unown,Wobbuffet,Girafarig,Pineco,Forretress,Dunsparce,Gligar,Steelix,Steelix-Mega,Snubbull,Granbull,Qwilfish,Scizor,Scizor-Mega,Shuckle,Heracross,Heracross-Mega,Sneasel,Teddiursa,Ursaring,Slugma,Magcargo,Swinub,Piloswine,Corsola,Remoraid,Octillery,Delibird,Mantine,Skarmory,Houndour,Houndoom,Houndoom-Mega,Kingdra,Phanpy,Donphan,Porygon2,Stantler,Smeargle,Tyrogue,Hitmontop,Smoochum,Elekid,Magby,Miltank,Blissey,Raikou,Entei,Suicune,Larvitar,Pupitar,Tyranitar,Tyranitar-Mega,Lugia,Ho-Oh,Celebi,Treecko,Grovyle,Sceptile,Sceptile-Mega,Torchic,Combusken,Blaziken,Blaziken-Mega,Mudkip,Marshtomp,Swampert,Swampert-Mega,Poochyena,Mightyena,Zigzagoon,Linoone,Wurmple,Silcoon,Beautifly,Cascoon,Dustox,Lotad,Lombre,Ludicolo,Seedot,Nuzleaf,Shiftry,Taillow,Swellow,Wingull,Pelipper,Ralts,Kirlia,Gardevoir,Gardevoir-Mega,Surskit,Masquerain,Shroomish,Breloom,Slakoth,Vigoroth,Slaking,Nincada,Ninjask,Shedinja,Whismur,Loudred,Exploud,Makuhita,Hariyama,Azurill,Nosepass,Skitty,Delcatty,Sableye,Sableye-Mega,Mawile,Mawile-Mega,Aron,Lairon,Aggron,Aggron-Mega,Meditite,Medicham,Medicham-Mega,Electrike,Manectric,Manectric-Mega,Plusle,Minun,Volbeat,Illumise,Roselia,Gulpin,Swalot,Carvanha,Sharpedo,Sharpedo-Mega,Wailmer,Wailord,Numel,Camerupt,Camerupt-Mega,Torkoal,Spoink,Grumpig,Spinda,Trapinch,Vibrava,Flygon,Cacnea,Cacturne,Swablu,Altaria,Altaria-Mega,Zangoose,Seviper,Lunatone,Solrock,Barboach,Whiscash,Corphish,Crawdaunt,Baltoy,Claydol,Lileep,Cradily,Anorith,Armaldo,Feebas,Milotic,Castform,Castform-Sunny,Castform-Rainy,Castform-Snowy,Kecleon,Shuppet,Banette,Banette-Mega,Duskull,Dusclops,Tropius,Chimecho,Absol,Absol-Mega,Wynaut,Snorunt,Glalie,Glalie-Mega,Spheal,Sealeo,Walrein,Clamperl,Huntail,Gorebyss,Relicanth,Luvdisc,Bagon,Shelgon,Salamence,Salamence-Mega,Beldum,Metang,Metagross,Metagross-Mega,Regirock,Regice,Registeel,Latias,Latias-Mega,Latios,Latios-Mega,Kyogre,Kyogre-Primal,Groudon,Groudon-Primal,Rayquaza,Rayquaza-Mega,Jirachi,Deoxys,Deoxys-Attack,Deoxys-Defense,Deoxys-Speed,Turtwig,Grotle,Torterra,Chimchar,Monferno,Infernape,Piplup,Prinplup,Empoleon,Starly,Staravia,Staraptor,Bidoof,Bibarel,Kricketot,Kricketune,Shinx,Luxio,Luxray,Budew,Roserade,Cranidos,Rampardos,Shieldon,Bastiodon,Burmy,Burmy-Sandy,Burmy-Trash,Wormadam,Wormadam-Sandy,Wormadam-Trash,Mothim,Combee,Vespiquen,Pachirisu,Buizel,Floatzel,Cherubi,Cherrim,Cherrim-Sunshine,Shellos,Shellos-East,Gastrodon,Gastrodon-East,Ambipom,Drifloon,Drifblim,Buneary,Lopunny,Lopunny-Mega,Mismagius,Honchkrow,Glameow,Purugly,Chingling,Stunky,Skuntank,Bronzor,Bronzong,Bonsly,Mime Jr.,Happiny,Chatot,Spiritomb,Gible,Gabite,Garchomp,Garchomp-Mega,Munchlax,Riolu,Lucario,Lucario-Mega,Hippopotas,Hippowdon,Skorupi,Drapion,Croagunk,Toxicroak,Carnivine,Finneon,Lumineon,Mantyke,Snover,Abomasnow,Abomasnow-Mega,Weavile,Magnezone,Lickilicky,Rhyperior,Tangrowth,Electivire,Magmortar,Togekiss,Yanmega,Leafeon,Glaceon,Gliscor,Mamoswine,Porygon-Z,Gallade,Gallade-Mega,Probopass,Dusknoir,Froslass,Rotom,Rotom-Heat,Rotom-Wash,Rotom-Frost,Rotom-Fan,Rotom-Mow,Uxie,Mesprit,Azelf,Dialga,Palkia,Heatran,Regigigas,Giratina,Giratina-Origin,Cresselia,Phione,Manaphy,Darkrai,Shaymin,Shaymin-Sky,Arceus,Victini,Snivy,Servine,Serperior,Tepig,Pignite,Emboar,Oshawott,Dewott,Samurott,Patrat,Watchog,Lillipup,Herdier,Stoutland,Purrloin,Liepard,Pansage,Simisage,Pansear,Simisear,Panpour,Simipour,Munna,Musharna,Pidove,Tranquill,Unfezant,Blitzle,Zebstrika,Roggenrola,Boldore,Gigalith,Woobat,Swoobat,Drilbur,Excadrill,Audino,Audino-Mega,Timburr,Gurdurr,Conkeldurr,Tympole,Palpitoad,Seismitoad,Throh,Sawk,Sewaddle,Swadloon,Leavanny,Venipede,Whirlipede,Scolipede,Cottonee,Whimsicott,Petilil,Lilligant,Basculin,Basculin-Blue-Striped,Sandile,Krokorok,Krookodile,Darumaka,Darmanitan,Darmanitan-Zen,Maractus,Dwebble,Crustle,Scraggy,Scrafty,Sigilyph,Yamask,Cofagrigus,Tirtouga,Carracosta,Archen,Archeops,Trubbish,Garbodor,Zorua,Zoroark,Minccino,Cinccino,Gothita,Gothorita,Gothitelle,Solosis,Duosion,Reuniclus,Ducklett,Swanna,Vanillite,Vanillish,Vanilluxe,Deerling,Deerling-Summer,Deerling-Autumn,Deerling-Winter,Sawsbuck,Sawsbuck-Summer,Sawsbuck-Autumn,Sawsbuck-Winter,Emolga,Karrablast,Escavalier,Foongus,Amoonguss,Frillish,Jellicent,Alomomola,Joltik,Galvantula,Ferroseed,Ferrothorn,Klink,Klang,Klinklang,Tynamo,Eelektrik,Eelektross,Elgyem,Beheeyem,Litwick,Lampent,Chandelure,Axew,Fraxure,Haxorus,Cubchoo,Beartic,Cryogonal,Shelmet,Accelgor,Stunfisk,Mienfoo,Mienshao,Druddigon,Golett,Golurk,Pawniard,Bisharp,Bouffalant,Rufflet,Braviary,Vullaby,Mandibuzz,Heatmor,Durant,Deino,Zweilous,Hydreigon,Larvesta,Volcarona,Cobalion,Terrakion,Virizion,Tornadus,Tornadus-Therian,Thundurus,Thundurus-Therian,Reshiram,Zekrom,Landorus,Landorus-Therian,Kyurem,Kyurem-Black,Kyurem-White,Keldeo,Keldeo-Resolute,Meloetta,Meloetta-Pirouette,Genesect,Chespin,Quilladin,Chesnaught,Fennekin,Braixen,Delphox,Froakie,Frogadier,Greninja,Greninja-Ash,Bunnelby,Diggersby,Fletchling,Fletchinder,Talonflame,Scatterbug,Spewpa,Vivillon,Litleo,Pyroar,Flabe�0�7be�0�7,Floette,Florges,Skiddo,Gogoat,Pancham,Pangoro,Furfrou,Furfrou-Dandy,Furfrou-Debutante,Furfrou-Diamond,Furfrou-Heart,Furfrou-Kabuki,Furfrou-Lareine,Furfrou-Matron,Furfrou-Pharaoh,Furfrou-Star,Espurr,Meowstic,Meowstic-F,Honedge,Doublade,Aegislash,Aegislash-Blade,Spritzee,Aromatisse,Swirlix,Slurpuff,Inkay,Malamar,Binacle,Barbaracle,Skrelp,Dragalge,Clauncher,Clawitzer,Helioptile,Heliolisk,Tyrunt,Tyrantrum,Amaura,Aurorus,Sylveon,Hawlucha,Dedenne,Carbink,Goomy,Sliggoo,Goodra,Klefki,Phantump,Trevenant,Pumpkaboo,Pumpkaboo-Small,Pumpkaboo-Large,Pumpkaboo-Super,Gourgeist,Gourgeist-Small,Gourgeist-Large,Gourgeist-Super,Bergmite,Avalugg,Noibat,Noivern,Xerneas,Yveltal,Zygarde,Zygarde-10%,Zygarde-Complete,Diancie,Diancie-Mega,Hoopa,Hoopa-Unbound,Volcanion,Rowlet,Dartrix,Decidueye,Litten,Torracat,Incineroar,Popplio,Brionne,Primarina,Pikipek,Trumbeak,Toucannon,Yungoos,Gumshoos,Grubbin,Charjabug,Vikavolt,Crabrawler,Crabominable,Oricorio,Oricorio-Pom-Pom,Oricorio-Pa'u,Oricorio-Sensu,Cutiefly,Ribombee,Rockruff,Lycanroc,Lycanroc-Midnight,Lycanroc-Dusk,Wishiwashi,Wishiwashi-School,Mareanie,Toxapex,Mudbray,Mudsdale,Dewpider,Araquanid,Fomantis,Lurantis,Morelull,Shiinotic,Salandit,Salazzle,Stufful,Bewear,Bounsweet,Steenee,Tsareena,Comfey,Oranguru,Passimian,Wimpod,Golisopod,Sandygast,Palossand,Pyukumuku,Type: Null,Silvally,Minior-Meteor,Minior,Minior-Orange,Minior-Yellow,Minior-Green,Minior-pblue,Minior-Blue,Minior-Purple,Komala,Turtonator,Togedemaru,Mimikyu,Mimikyu-Busted,Bruxish,Drampa,Dhelmise,Jangmo-o,Hakamo-o,Kommo-o,Tapu Koko,Tapu Lele,Tapu Bulu,Tapu Fini,Cosmog,Cosmoem,Solgaleo,Lunala,Nihilego,Buzzwole,Pheromosa,Xurkitree,Celesteela,Kartana,Guzzlord,Necrozma,Necrozma-Dusk-Mane,Necrozma-Dawn-Wings,Necrozma-Ultra,Magearna,Magearna-Original,Marshadow,Poipole,Naganadel,Stakataka,Blacephalon,Zeraora";
        public static string ItemEngName = ",Ability Capsule,Health Wing,Muscle Wing,Resist Wing,Genius Wing,Clever Wing,Swift Wing,HP Up,Protein,Iron,Carbos,Calcium,Rare Candy,PP Up,Zinc,PP Max,Sacred Ash,Casteliacone,Ether,Elixir,Max Ether,Max Elixir,Sweet Heart,Potion,Berry Juice,Fresh Water,Soda Pop,Energy Powder,Super Potion,Lemonade,Moomoo Milk,Energy Root,Hyper Potion,Max Potion,Antidote,Burn Heal,Ice Heal,Awakening,Paralyze Heal,Full Heal,Heal Powder,Lava Cookie,Old Gateau,Rage Candy Bar,Lumiose Galette,Shalour Sable,Big Malasada,Revive,Max Revive,Revival Herb,Full Restore,Red Orb,Blue Orb,Normalium Z,Firium Z,Waterium Z,Electrium Z,Grassium Z,Icium Z,Fightinium Z,Poisonium Z,Groundium Z,Flyinium Z,Psychium Z,Buginium Z,Rockium Z,Ghostium Z,Dragonium Z,Darkinium Z,Steelium Z,Fairium Z,Pikanium Z,Decidium Z,Incinium Z,Primarium Z,Tapunium Z,Marshadium Z,Aloraichium Z,Snorlium Z,Eevium Z,Mewnium Z,Pikashunium Z,Soothe Bell,Choice Band,Metal Powder,Red Scarf,Blue Scarf,Pink Scarf,Green Scarf,Yellow Scarf,Quick Powder,Lagging Tail,Destiny Knot,Choice Scarf,Shed Shell,Choice Specs,Full Incense,Pure Incense,Reaper Cloth,Ring Target,Cleanse Tag,Soul Dew,Deep Sea Scale,Smoke Ball,Everstone,Lucky Egg,Scope Lens,Light Ball,Up-Grade,Toxic Orb,Flame Orb,Float Stone,Binding Band,Protective Pads,Lucky Punch,Eviolite,Dubious Disc,Fighting Memory,Flying Memory,Poison Memory,Ground Memory,Rock Memory,Bug Memory,Ghost Memory,Steel Memory,Fire Memory,Water Memory,Grass Memory,Electric Memory,Psychic Memory,Ice Memory,Dragon Memory,Dark Memory,Fairy Memory,Macho Brace,Stick,Terrain Extender,Douse Drive,Shock Drive,Burn Drive,Chill Drive,Protector,Electirizer,Magmarizer,Razor Claw,Assault Vest,Whipped Dream,Sachet,Safety Goggles,Gengarite,Gardevoirite,Ampharosite,Venusaurite,Charizardite X,Blastoisinite,Mewtwonite X,Mewtwonite Y,Blazikenite,Medichamite,Houndoominite,Aggronite,Banettite,Tyranitarite,Scizorite,Pinsirite,Aerodactylite,Lucarionite,Abomasite,Kangaskhanite,Gyaradosite,Absolite,Charizardite Y,Alakazite,Heracronite,Mawilite,Manectite,Garchompite,Latiasite,Latiosite,Swampertite,Sceptilite,Sablenite,Altarianite,Galladite,Audinite,Metagrossite,Sharpedonite,Slowbronite,Steelixite,Pidgeotite,Glalitite,Diancite,Cameruptite,Lopunnite,Salamencite,Beedrillite,Deep Sea Tooth,Thick Club,Grip Claw,Iron Ball,Fire Gem,Water Gem,Electric Gem,Grass Gem,Ice Gem,Fighting Gem,Poison Gem,Ground Gem,Flying Gem,Psychic Gem,Bug Gem,Rock Gem,Ghost Gem,Dragon Gem,Dark Gem,Steel Gem,Normal Gem,Fairy Gem,White Herb,Mental Herb,Power Herb,Focus Sash,Air Balloon,Red Card,Electric Seed,Psychic Seed,Misty Seed,Grassy Seed,Absorb Bulb,Cell Battery,Eject Button,Luminous Moss,Snowball,Weakness Policy,Smooth Rock,Light Clay,Icy Rock,Heat Rock,Damp Rock,Rocky Helmet,Shell Bell,Power Bracer,Power Belt,Power Lens,Power Band,Power Anklet,Power Weight,Sticky Barb,Bright Powder,Focus Band,Leftovers,Lax Incense,Wide Lens,Muscle Band,Wise Glasses,Luck Incense,King’s Rock,Amulet Coin,Dragon Scale,Razor Fang,Black Sludge,Silver Powder,Soft Sand,Silk Scarf,Sea Incense,Expert Belt,Zoom Lens,Odd Incense,Rock Incense,Wave Incense,Rose Incense,Metal Coat,Miracle Seed,Black Glasses,Black Belt,Magnet,Mystic Water,Never-Melt Ice,Spell Tag,Twisted Spoon,Charcoal,Metronome,Sharp Beak,Griseous Orb,Adamant Orb,Lustrous Orb,Poison Barb,Dragon Fang,Quick Claw,Flame Plate,Splash Plate,Zap Plate,Meadow Plate,Icicle Plate,Fist Plate,Toxic Plate,Earth Plate,Sky Plate,Mind Plate,Insect Plate,Stone Plate,Spooky Plate,Draco Plate,Dread Plate,Iron Plate,Pixie Plate,Hard Stone,Big Root,Life Orb,Red Apricorn,Blue Apricorn,Yellow Apricorn,Green Apricorn,Pink Apricorn,White Apricorn,Black Apricorn,Festival Ticket,Discount Coupon,Red Nectar,Yellow Nectar,Pink Nectar,Purple Nectar,Prism Scale,Bottle Cap,Gold Bottle Cap,Jaw Fossil,Sail Fossil,Pretty Wing,Shoal Salt,Shoal Shell,Red Shard,Blue Shard,Yellow Shard,Green Shard,Escape Rope,Sun Stone,Moon Stone,Fire Stone,Thunder Stone,Water Stone,Leaf Stone,Tiny Mushroom,Big Mushroom,Pearl,Big Pearl,Stardust,Star Piece,Nugget,Heart Scale,Honey,Growth Mulch,Damp Mulch,Stable Mulch,Gooey Mulch,Pass Orb,Balm Mushroom,Big Nugget,Pearl String,Comet Shard,Relic Copper,Relic Silver,Relic Gold,Relic Vase,Relic Band,Relic Statue,Relic Crown,Rich Mulch,Surprise Mulch,Boost Mulch,Amaze Mulch,Strange Souvenir,Ice Stone,Shiny Stone,Dusk Stone,Dawn Stone,Oval Stone,Odd Keystone,Root Fossil,Claw Fossil,Helix Fossil,Dome Fossil,Old Amber,Armor Fossil,Skull Fossil,Rare Bone,Cover Fossil,Plume Fossil,Black Flute,White Flute,Repel,Super Repel,Max Repel,Dire Hit 2,X Speed 2,X Sp. Atk 2,X Sp. Def 2,X Defense 2,X Attack 2,X Accuracy 2,X Speed 3,X Sp. Atk 3,X Sp. Def 3,X Defense 3,X Attack 3,X Accuracy 3,X Speed 6,X Sp. Atk 6,X Sp. Def 6,X Defense 6,X Attack 6,X Accuracy 6,Dire Hit 3,Guard Spec.,Dire Hit,X Attack,X Defense,X Speed,X Accuracy,X Sp. Atk,X Sp. Def,Adrenaline Orb,Blue Flute,Yellow Flute,Red Flute,Poké Doll,Fluffy Tail,Poké Toy,Park Ball,Sport Ball,Master Ball,Ultra Ball,Great Ball,Poké Ball,Safari Ball,Net Ball,Dive Ball,Nest Ball,Repeat Ball,Timer Ball,Luxury Ball,Premier Ball,Dusk Ball,Heal Ball,Quick Ball,Cherish Ball,Fast Ball,Level Ball,Lure Ball,Heavy Ball,Love Ball,Friend Ball,Moon Ball,Dream Ball,Beast Ball,Greet Mail,Favored Mail,RSVP Mail,Thanks Mail,Inquiry Mail,Like Mail,Reply Mail,Bridge Mail S,Bridge Mail D,Bridge Mail T,Bridge Mail V,Bridge Mail M,HM01,HM02,HM03,HM04,HM05,HM06,HM07,Razz Berry,Bluk Berry,Nanab Berry,Wepear Berry,Pinap Berry,Pomeg Berry,Kelpsy Berry,Qualot Berry,Hondew Berry,Grepa Berry,Tamato Berry,Cornn Berry,Magost Berry,Rabuta Berry,Nomel Berry,Spelon Berry,Pamtre Berry,Watmel Berry,Durin Berry,Belue Berry,Occa Berry,Passho Berry,Wacan Berry,Rindo Berry,Yache Berry,Chople Berry,Kebia Berry,Shuca Berry,Coba Berry,Payapa Berry,Tanga Berry,Charti Berry,Kasib Berry,Haban Berry,Colbur Berry,Babiri Berry,Chilan Berry,Roseli Berry,Kee Berry,Maranga Berry,Figy Berry,Wiki Berry,Mago Berry,Aguav Berry,Iapapa Berry,Liechi Berry,Ganlon Berry,Salac Berry,Petaya Berry,Apicot Berry,Lansat Berry,Starf Berry,Enigma Berry,Micle Berry,Custap Berry,Jaboca Berry,Rowap Berry,Leppa Berry,Oran Berry,Sitrus Berry,Cheri Berry,Chesto Berry,Pecha Berry,Rawst Berry,Aspear Berry,Persim Berry,Lum Berry,Exp. Share,Explorer Kit,Loot Sack,Rule Book,Poké Radar,Point Card,Journal,Seal Case,Fashion Case,Seal Bag,Pal Pad,Works Key,Old Charm,Galactic Key,Red Chain,Town Map,Vs. Seeker,Coin Case,Old Rod,Good Rod,Super Rod,Sprayduck,Poffin Case,Bike,Suite Key,Oak’s Letter,Lunar Wing,Member Card,Azure Flute,S.S. Ticket,Contest Pass,Magma Stone,Parcel,Coupon 1,Coupon 2,Coupon 3,Storage Key,Secret Potion,Vs. Recorder,Gracidea,Secret Key,Apricorn Box,Unown Report,Berry Pots,Dowsing Machine,Blue Card,Slowpoke Tail,Clear Bell,Card Key,Basement Key,Squirt Bottle,Red Scale,Lost Item,Pass,Machine Part,Silver Wing,Rainbow Wing,Mystery Egg,Photo Album,GB Sounds,Tidal Bell,Jade Orb,Lock Capsule,Enigma Stone,Liberty Pass,Prop Case,Dragon Skull,Light Stone,Dark Stone,Xtransceiver,???,Gram 1,Gram 2,Gram 3,Medal Box,DNA Splicers,Permit,Oval Charm,Shiny Charm,Plasma Card,Grubby Hanky,Colress Machine,Dropped Item,Reveal Glass,Holo Caster,Prof’s Letter,Roller Skates,Poké Flute,Sprinklotad,Power Plant Pass,Mega Ring,Intriguing Stone,Common Stone,Elevator Key,TMV Pass,Honor of Kalos,Adventure Rules,Lens Case,Makeup Bag,Travel Trunk,Looker Ticket,Mega Charm,Mega Glove,Mach Bike,Acro Bike,Wailmer Pail,Devon Parts,Soot Sack,Pokéblock Kit,Letter,Eon Ticket,Scanner,Go-Goggles,Meteorite,Key to Room 1,Key to Room 2,Key to Room 4,Key to Room 6,Devon Scope,Devon Scuba Gear,Contest Costume,Contest Costume,Magma Suit,Aqua Suit,Pair of Tickets,Mega Bracelet,Mega Pendant,Mega Glasses,Mega Anchor,Mega Stickpin,Mega Tiara,Mega Anklet,Prison Bottle,Mega Cuff,Key Stone,Meteorite Shard,Eon Flute,Z-Ring,Forage Bag,Fishing Rod,Professor’s Mask,Sparkling Stone,Zygarde Cube,Ride Pager,Sun Flute,Moon Flute,Enigmatic Card,TM01,TM02,TM03,TM04,TM05,TM06,TM07,TM08,TM09,TM10,TM11,TM12,TM13,TM14,TM15,TM16,TM17,TM18,TM19,TM20,TM21,TM22,TM23,TM24,TM25,TM26,TM27,TM28,TM29,TM30,TM31,TM32,TM33,TM34,TM35,TM36,TM37,TM38,TM39,TM40,TM41,TM42,TM43,TM44,TM45,TM46,TM47,TM48,TM49,TM50,TM51,TM52,TM53,TM54,TM55,TM56,TM57,TM58,TM59,TM60,TM61,TM62,TM63,TM64,TM65,TM66,TM67,TM68,TM69,TM70,TM71,TM72,TM73,TM74,TM75,TM76,TM77,TM78,TM79,TM80,TM81,TM82,TM83,TM84,TM85,TM86,TM87,TM88,TM89,TM90,TM91,TM92,TM93,TM94,TM95,TM96,TM97,TM98,TM99,TM100";
        public static string ItemName = ",特性胶囊,体力之羽,肌力之羽,抵抗之羽,智力之羽,精神之羽,瞬发之羽,ＨＰ增强剂,攻击增强剂,防御增强剂,速度增强剂,特攻增强剂,神奇糖果,ＰＰ提升剂,特防增强剂,ＰＰ极限提升剂,圣灰,飞云冰淇淋,ＰＰ单项小补剂,ＰＰ多项小补剂,ＰＰ单项全补剂,ＰＰ多项全补剂,心形甜点,伤药,树果汁,美味之水,劲爽汽水,元气粉,好伤药,果汁牛奶,哞哞鲜奶,元气根,厉害伤药,全满药,解毒药,灼伤药,解冻药,解眠药,解麻药,万灵药,万能粉,釜炎仙贝,森之羊羹,愤怒馒头,密阿雷格雷派饼,娑罗沙布蕾,大马拉萨达,活力碎片,活力块,复活草,全复药,朱红色宝珠,靛蓝色宝珠,一般Ｚ,火Ｚ,水Ｚ,电Ｚ,草Ｚ,冰Ｚ,格斗Ｚ,毒Ｚ,地面Ｚ,飞行Ｚ,超能力Ｚ,虫Ｚ,岩石Ｚ,幽灵Ｚ,龙Ｚ,恶Ｚ,钢Ｚ,妖精Ｚ,皮卡丘Ｚ,狙射树枭Ｚ,炽焰咆哮虎Ｚ,西狮海壬Ｚ,卡璞Ｚ,玛夏多Ｚ,阿罗雷Ｚ,卡比兽Ｚ,伊布Ｚ,梦幻Ｚ,智皮卡Ｚ,安抚之铃,讲究头带,金属粉,红色头巾,蓝色头巾,粉红头巾,绿色头巾,黄色头巾,速度粉,后攻之尾,红线,讲究围巾,美丽空壳,讲究眼镜,饱腹薰香,洁净薰香,灵界之布,标靶,洁净之符,心之水滴,深海鳞片,烟雾球,不变之石,幸运蛋,焦点镜,电气球,升级数据,剧毒宝珠,火焰宝珠,轻石,紧绑束带,部位护具,吉利拳,进化奇石,可疑补丁,战斗存储碟,飞翔存储碟,毒存储碟,大地存储碟,岩石存储碟,虫子存储碟,幽灵存储碟,钢铁存储碟,火焰存储碟,清水存储碟,青草存储碟,电子存储碟,精神存储碟,冰雪存储碟,龙存储碟,黑暗存储碟,妖精存储碟,强制锻炼器,大葱,大地膜,水流卡带,闪电卡带,火焰卡带,冰冻卡带,护具,电力增幅器,熔岩增幅器,锐利之爪,突击背心,泡沫奶油,香袋,防尘护目镜,耿鬼进化石,沙奈朵进化石,电龙进化石,妙蛙花进化石,喷火龙进化石Ｘ,水箭龟进化石,超梦进化石Ｘ,超梦进化石Ｙ,火焰鸡进化石,恰雷姆进化石,黑鲁加进化石,波士可多拉进化石,诅咒娃娃进化石,班基拉斯进化石,巨钳螳螂进化石,凯罗斯进化石,化石翼龙进化石,路卡利欧进化石,暴雪王进化石,袋兽进化石,暴鲤龙进化石,阿勃梭鲁进化石,喷火龙进化石Ｙ,胡地进化石,赫拉克罗斯进化石,大嘴娃进化石,雷电兽进化石,烈咬陆鲨进化石,拉帝亚斯进化石,拉帝欧斯进化石,巨沼怪进化石,蜥蜴王进化石,勾魂眼进化石,七夕青鸟进化石,艾路雷朵进化石,差不多娃娃进化石,巨金怪进化石,巨牙鲨进化石,呆壳兽进化石,大钢蛇进化石,大比鸟进化石,冰鬼护进化石,蒂安希进化石,喷火驼进化石,长耳兔进化石,暴飞龙进化石,大针蜂进化石,深海之牙,粗骨头,紧缠钩爪,黑色铁球,火之宝石,水之宝石,电之宝石,草之宝石,冰之宝石,格斗宝石,毒之宝石,地面宝石,飞行宝石,超能力宝石,虫之宝石,岩石宝石,幽灵宝石,龙之宝石,恶之宝石,钢之宝石,一般宝石,妖精宝石,白色香草,心灵香草,强力香草,气势披带,气球,红牌,电气种子,精神种子,薄雾种子,青草种子,球根,充电电池,逃脱按键,光苔,雪球,弱点保险,沙沙岩石,光之黏土,冰冷岩石,炽热岩石,潮湿岩石,凸凸头盔,贝壳之铃,力量护腕,力量腰带,力量镜,力量束带,力量护踝,力量负重,附着针,光粉,气势头带,吃剩的东西,悠闲薰香,广角镜,力量头带,博识眼镜,幸运薰香,王者之证,护符金币,龙之鳞片,锐利之牙,黑色污泥,银粉,柔软沙子,丝绸围巾,海潮薰香,达人带,对焦镜,奇异薰香,岩石薰香,涟漪薰香,花朵薰香,金属膜,奇迹种子,黑色眼镜,黑带,磁铁,神秘水滴,不融冰,诅咒之符,弯曲的汤匙,木炭,节拍器,锐利鸟嘴,白金宝珠,金刚宝珠,白玉宝珠,毒针,龙之牙,先制之爪,火球石板,水滴石板,雷电石板,碧绿石板,冰柱石板,拳头石板,剧毒石板,大地石板,蓝天石板,神奇石板,玉虫石板,岩石石板,妖怪石板,龙之石板,恶颜石板,钢铁石板,妖精石板,硬石头,大根茎,生命宝珠,红球果,蓝球果,黄球果,绿球果,粉球果,白球果,黑球果,圆庆票,折价券,朱红色花蜜,金黄色花蜜,桃粉色花蜜,兰紫色花蜜,美丽鳞片,银色王冠,金色王冠,颚之化石,鳍之化石,美丽之羽,浅滩海盐,浅滩贝壳,红色碎片,蓝色碎片,黄色碎片,绿色碎片,离洞绳,日之石,月之石,火之石,雷之石,水之石,叶之石,小蘑菇,大蘑菇,珍珠,大珍珠,星星沙子,星星碎片,金珠,心之鳞片,甜甜蜜,速速肥,湿湿肥,久久肥,粘粘肥,释出之玉,芳香蘑菇,巨大金珠,丸子珍珠,彗星碎片,古代铜币,古代银币,古代金币,古代之壶,古代手镯,古代石像,古代王冠,硕果肥,吃惊肥,劲劲肥,超效肥,神秘摆设,冰之石,光之石,暗之石,觉醒之石,浑圆之石,楔石,根状化石,爪子化石,贝壳化石,甲壳化石,秘密琥珀,盾甲化石,头盖化石,贵重骨头,背盖化石,羽毛化石,黑色玻璃哨,白色玻璃哨,除虫喷雾,白银喷雾,黄金喷雾,要害攻击２,速度强化２,特攻强化２,特防强化２,防御强化２,力量强化２,命中强化２,速度强化３,特攻强化３,特防强化３,防御强化３,力量强化３,命中强化３,速度强化６,特攻强化６,特防强化６,防御强化６,力量强化６,命中强化６,要害攻击３,能力防守,要害攻击,力量强化,防御强化,速度强化,命中强化,特攻强化,特防强化,胆怯球,蓝色玻璃哨,黄色玻璃哨,红色玻璃哨,皮皮玩偶,向尾喵的尾巴,宝可尾草,公园球,竞赛球,大师球,高级球,超级球,精灵球,狩猎球,捕网球,潜水球,巢穴球,重复球,计时球,豪华球,纪念球,黑暗球,治愈球,先机球,贵重球,速度球,等级球,诱饵球,沉重球,甜蜜球,友友球,月亮球,梦境球,究极球,初次邮件,喜爱邮件,邀请邮件,感谢邮件,询问邮件,推荐邮件,回复邮件,桥梁邮件Ｓ,桥梁邮件Ｈ,桥梁邮件Ｃ,桥梁邮件Ｖ,桥梁邮件Ｗ,秘传学习器０１,秘传学习器０２,秘传学习器０３,秘传学习器０４,秘传学习器０５,秘传学习器０６,秘传学习器０７,蔓莓果,墨莓果,蕉香果,西梨果,凰梨果,榴石果,藻根果,比巴果,哈密果,萄葡果,茄番果,玉黍果,岳竹果,茸丹果,檬柠果,刺角果,椰木果,瓜西果,金枕果,靛莓果,巧可果,千香果,烛木果,罗子果,番荔果,莲蒲果,通通果,腰木果,棱瓜果,福禄果,扁樱果,草蚕果,佛柑果,莓榴果,刺耳果,霹霹果,灯浆果,洛玫果,亚开果,香罗果,勿花果,异奇果,芒芒果,乐芭果,芭亚果,枝荔果,龙睛果,沙鳞果,龙火果,杏仔果,兰萨果,星桃果,谜芝果,奇秘果,释陀果,嘉珍果,雾莲果,苹野果,橙橙果,文柚果,樱子果,零余果,桃桃果,莓莓果,利木果,柿仔果,木子果,学习装置,探险套装,宝物袋,规则书,宝可追踪,点数卡,冒险笔记,贴纸盒,饰品盒,贴纸袋,朋友手册,发电厂钥匙,古代护符,银河队钥匙,红色锁链,城镇地图,对战搜寻器,代币盒,破旧钓竿,好钓竿,厉害钓竿,可达鸭喷壶,宝芬盒,自行车,房间钥匙,大木的信,新月之羽,会员卡,天界之笛,船票,华丽大赛参加证,火山镇石,包裹,兑换券１,兑换券２,兑换券３,仓库钥匙,秘传之药,对战记录器,葛拉西蒂亚花,秘密钥匙,球果盒,未知图腾笔记,树果种植盆,探宝器,蓝卡,美味尾巴,透明铃铛,钥匙卡,地下钥匙,杰尼龟喷壶,红色鳞片,遗失物,磁浮列车自由票,机械零件,银色之羽,虹色之羽,神奇蛋,相册,ＧＢ播放器,海声铃铛,草绿色宝珠,上锁的容器,谜之水晶,自由船票,物品箱,龙之骨,光明石,黑暗石,即时通讯器,神石,配送物品１,配送物品２,配送物品３,奖牌盒,基因之楔,许可证,圆形护符,闪耀护符,等离子卡,脏手帕,阿克罗玛机器,遗忘物,现形镜,全息影像通讯器,博士的信,轮滑鞋,宝可梦之笛,莲叶童子喷壶,发电厂通行证,超级环,似珍石,常见石,电梯钥匙,ＴＭＶ自由票,卡洛斯勋章,探险心得,隐形眼镜盒,化妆包,衣物箱,帅哥券,超级坠饰,超级手套,音速自行车,越野自行车,吼吼鲸喷壶,得文的物品,集灰袋,宝可方块套装,给大吾的信,无限船票,探测器,ＧＯＧＯ护目镜,陨石,１号客房的钥匙,２号客房的钥匙,４号客房的钥匙,６号客房的钥匙,得文侦测镜,得文潜水装备,演出礼服,演出礼裙,熔岩装,海洋装,双人票,超级手镯,超级吊坠,超级眼镜,超级船锚,超级领针,超级头冠,超级脚镯,惩戒之壶,超级护腕,钥石,陨石碎片,无限之笛,Ｚ手环,材料袋,钓竿,博士的面罩,光辉石,基格尔德多面体,骑行装置,太阳之笛,月亮之笛,奇异卡片,招式学习器０１,招式学习器０２,招式学习器０３,招式学习器０４,招式学习器０５,招式学习器０６,招式学习器０７,招式学习器０８,招式学习器０９,招式学习器１０,招式学习器１１,招式学习器１２,招式学习器１３,招式学习器１４,招式学习器１５,招式学习器１６,招式学习器１７,招式学习器１８,招式学习器１９,招式学习器２０,招式学习器２１,招式学习器２２,招式学习器２３,招式学习器２４,招式学习器２５,招式学习器２６,招式学习器２７,招式学习器２８,招式学习器２９,招式学习器３０,招式学习器３１,招式学习器３２,招式学习器３３,招式学习器３４,招式学习器３５,招式学习器３６,招式学习器３７,招式学习器３８,招式学习器３９,招式学习器４０,招式学习器４１,招式学习器４２,招式学习器４３,招式学习器４４,招式学习器４５,招式学习器４６,招式学习器４７,招式学习器４８,招式学习器４９,招式学习器５０,招式学习器５１,招式学习器５２,招式学习器５３,招式学习器５４,招式学习器５５,招式学习器５６,招式学习器５７,招式学习器５８,招式学习器５９,招式学习器６０,招式学习器６１,招式学习器６２,招式学习器６３,招式学习器６４,招式学习器６５,招式学习器６６,招式学习器６７,招式学习器６８,招式学习器６９,招式学习器７０,招式学习器７１,招式学习器７２,招式学习器７３,招式学习器７４,招式学习器７５,招式学习器７６,招式学习器７７,招式学习器７８,招式学习器７９,招式学习器８０,招式学习器８１,招式学习器８２,招式学习器８３,招式学习器８４,招式学习器８５,招式学习器８６,招式学习器８７,招式学习器８８,招式学习器８９,招式学习器９０,招式学习器９１,招式学习器９２,招式学习器９３,招式学习器９４,招式学习器９５,招式学习器９６,招式学习器９７,招式学习器９８,招式学习器９９,招式学习器１００�0�6";
        public static string MoveEngName = ",Pound,Karate Chop,Double Slap,Comet Punch,Mega Punch,Pay Day,Fire Punch,Ice Punch,Thunder Punch,Scratch,Vice Grip,Guillotine,Razor Wind,Swords Dance,Cut,Gust,Wing Attack,Whirlwind,Fly,Bind,Slam,Vine Whip,Stomp,Double Kick,Mega Kick,Jump Kick,Rolling Kick,Sand Attack,Headbutt,Horn Attack,Fury Attack,Horn Drill,Tackle,Body Slam,Wrap,Take Down,Thrash,Double-Edge,Tail Whip,Poison Sting,Twineedle,Pin Missile,Leer,Bite,Growl,Roar,Sing,Supersonic,Sonic Boom,Disable,Acid,Ember,Flamethrower,Mist,Water Gun,Hydro Pump,Surf,Ice Beam,Blizzard,Psybeam,Bubble Beam,Aurora Beam,Hyper Beam,Peck,Drill Peck,Submission,Low Kick,Counter,Seismic Toss,Strength,Absorb,Mega Drain,Leech Seed,Growth,Razor Leaf,Solar Beam,Poison Powder,Stun Spore,Sleep Powder,Petal Dance,String Shot,Dragon Rage,Fire Spin,Thunder Shock,Thunderbolt,Thunder Wave,Thunder,Rock Throw,Earthquake,Fissure,Dig,Toxic,Confusion,Psychic,Hypnosis,Meditate,Agility,Quick Attack,Rage,Teleport,Night Shade,Mimic,Screech,Double Team,Recover,Harden,Minimize,Smokescreen,Confuse Ray,Withdraw,Defense Curl,Barrier,Light Screen,Haze,Reflect,Focus Energy,Bide,Metronome,Mirror Move,Self-Destruct,Egg Bomb,Lick,Smog,Sludge,Bone Club,Fire Blast,Waterfall,Clamp,Swift,Skull Bash,Spike Cannon,Constrict,Amnesia,Kinesis,Soft-Boiled,High Jump Kick,Glare,Dream Eater,Poison Gas,Barrage,Leech Life,Lovely Kiss,Sky Attack,Transform,Bubble,Dizzy Punch,Spore,Flash,Psywave,Splash,Acid Armor,Crabhammer,Explosion,Fury Swipes,Bonemerang,Rest,Rock Slide,Hyper Fang,Sharpen,Conversion,Tri Attack,Super Fang,Slash,Substitute,Struggle,Sketch,Triple Kick,Thief,Spider Web,Mind Reader,Nightmare,Flame Wheel,Snore,Curse,Flail,Conversion 2,Aeroblast,Cotton Spore,Reversal,Spite,Powder Snow,Protect,Mach Punch,Scary Face,Feint Attack,Sweet Kiss,Belly Drum,Sludge Bomb,Mud-Slap,Octazooka,Spikes,Zap Cannon,Foresight,Destiny Bond,Perish Song,Icy Wind,Detect,Bone Rush,Lock-On,Outrage,Sandstorm,Giga Drain,Endure,Charm,Rollout,False Swipe,Swagger,Milk Drink,Spark,Fury Cutter,Steel Wing,Mean Look,Attract,Sleep Talk,Heal Bell,Return,Present,Frustration,Safeguard,Pain Split,Sacred Fire,Magnitude,Dynamic Punch,Megahorn,Dragon Breath,Baton Pass,Encore,Pursuit,Rapid Spin,Sweet Scent,Iron Tail,Metal Claw,Vital Throw,Morning Sun,Synthesis,Moonlight,Hidden Power,Cross Chop,Twister,Rain Dance,Sunny Day,Crunch,Mirror Coat,Psych Up,Extreme Speed,Ancient Power,Shadow Ball,Future Sight,Rock Smash,Whirlpool,Beat Up,Fake Out,Uproar,Stockpile,Spit Up,Swallow,Heat Wave,Hail,Torment,Flatter,Will-O-Wisp,Memento,Facade,Focus Punch,Smelling Salts,Follow Me,Nature Power,Charge,Taunt,Helping Hand,Trick,Role Play,Wish,Assist,Ingrain,Superpower,Magic Coat,Recycle,Revenge,Brick Break,Yawn,Knock Off,Endeavor,Eruption,Skill Swap,Imprison,Refresh,Grudge,Snatch,Secret Power,Dive,Arm Thrust,Camouflage,Tail Glow,Luster Purge,Mist Ball,Feather Dance,Teeter Dance,Blaze Kick,Mud Sport,Ice Ball,Needle Arm,Slack Off,Hyper Voice,Poison Fang,Crush Claw,Blast Burn,Hydro Cannon,Meteor Mash,Astonish,Weather Ball,Aromatherapy,Fake Tears,Air Cutter,Overheat,Odor Sleuth,Rock Tomb,Silver Wind,Metal Sound,Grass Whistle,Tickle,Cosmic Power,Water Spout,Signal Beam,Shadow Punch,Extrasensory,Sky Uppercut,Sand Tomb,Sheer Cold,Muddy Water,Bullet Seed,Aerial Ace,Icicle Spear,Iron Defense,Block,Howl,Dragon Claw,Frenzy Plant,Bulk Up,Bounce,Mud Shot,Poison Tail,Covet,Volt Tackle,Magical Leaf,Water Sport,Calm Mind,Leaf Blade,Dragon Dance,Rock Blast,Shock Wave,Water Pulse,Doom Desire,Psycho Boost,Roost,Gravity,Miracle Eye,Wake-Up Slap,Hammer Arm,Gyro Ball,Healing Wish,Brine,Natural Gift,Feint,Pluck,Tailwind,Acupressure,Metal Burst,U-turn,Close Combat,Payback,Assurance,Embargo,Fling,Psycho Shift,Trump Card,Heal Block,Wring Out,Power Trick,Gastro Acid,Lucky Chant,Me First,Copycat,Power Swap,Guard Swap,Punishment,Last Resort,Worry Seed,Sucker Punch,Toxic Spikes,Heart Swap,Aqua Ring,Magnet Rise,Flare Blitz,Force Palm,Aura Sphere,Rock Polish,Poison Jab,Dark Pulse,Night Slash,Aqua Tail,Seed Bomb,Air Slash,X-Scissor,Bug Buzz,Dragon Pulse,Dragon Rush,Power Gem,Drain Punch,Vacuum Wave,Focus Blast,Energy Ball,Brave Bird,Earth Power,Switcheroo,Giga Impact,Nasty Plot,Bullet Punch,Avalanche,Ice Shard,Shadow Claw,Thunder Fang,Ice Fang,Fire Fang,Shadow Sneak,Mud Bomb,Psycho Cut,Zen Headbutt,Mirror Shot,Flash Cannon,Rock Climb,Defog,Trick Room,Draco Meteor,Discharge,Lava Plume,Leaf Storm,Power Whip,Rock Wrecker,Cross Poison,Gunk Shot,Iron Head,Magnet Bomb,Stone Edge,Captivate,Stealth Rock,Grass Knot,Chatter,Judgment,Bug Bite,Charge Beam,Wood Hammer,Aqua Jet,Attack Order,Defend Order,Heal Order,Head Smash,Double Hit,Roar of Time,Spacial Rend,Lunar Dance,Crush Grip,Magma Storm,Dark Void,Seed Flare,Ominous Wind,Shadow Force,Hone Claws,Wide Guard,Guard Split,Power Split,Wonder Room,Psyshock,Venoshock,Autotomize,Rage Powder,Telekinesis,Magic Room,Smack Down,Storm Throw,Flame Burst,Sludge Wave,Quiver Dance,Heavy Slam,Synchronoise,Electro Ball,Soak,Flame Charge,Coil,Low Sweep,Acid Spray,Foul Play,Simple Beam,Entrainment,After You,Round,Echoed Voice,Chip Away,Clear Smog,Stored Power,Quick Guard,Ally Switch,Scald,Shell Smash,Heal Pulse,Hex,Sky Drop,Shift Gear,Circle Throw,Incinerate,Quash,Acrobatics,Reflect Type,Retaliate,Final Gambit,Bestow,Inferno,Water Pledge,Fire Pledge,Grass Pledge,Volt Switch,Struggle Bug,Bulldoze,Frost Breath,Dragon Tail,Work Up,Electroweb,Wild Charge,Drill Run,Dual Chop,Heart Stamp,Horn Leech,Sacred Sword,Razor Shell,Heat Crash,Leaf Tornado,Steamroller,Cotton Guard,Night Daze,Psystrike,Tail Slap,Hurricane,Head Charge,Gear Grind,Searing Shot,Techno Blast,Relic Song,Secret Sword,Glaciate,Bolt Strike,Blue Flare,Fiery Dance,Freeze Shock,Ice Burn,Snarl,Icicle Crash,V-create,Fusion Flare,Fusion Bolt,Flying Press,Mat Block,Belch,Rototiller,Sticky Web,Fell Stinger,Phantom Force,Trick-or-Treat,Noble Roar,Ion Deluge,Parabolic Charge,Forest's Curse,Petal Blizzard,Freeze-Dry,Disarming Voice,Parting Shot,Topsy-Turvy,Draining Kiss,Crafty Shield,Flower Shield,Grassy Terrain,Misty Terrain,Electrify,Play Rough,Fairy Wind,Moonblast,Boomburst,Fairy Lock,King's Shield,Play Nice,Confide,Diamond Storm,Steam Eruption,Hyperspace Hole,Water Shuriken,Mystical Fire,Spiky Shield,Aromatic Mist,Eerie Impulse,Venom Drench,Powder,Geomancy,Magnetic Flux,Happy Hour,Electric Terrain,Dazzling Gleam,Celebrate,Hold Hands,Baby-Doll Eyes,Nuzzle,Hold Back,Infestation,Power-Up Punch,Oblivion Wing,Thousand Arrows,Thousand Waves,Land's Wrath,Light of Ruin,Origin Pulse,Precipice Blades,Dragon Ascent,Hyperspace Fury,Breakneck Blitz,Breakneck Blitz,All-Out Pummeling,All-Out Pummeling,Supersonic Skystrike,Supersonic Skystrike,Acid Downpour,Acid Downpour,Tectonic Rage,Tectonic Rage,Continental Crush,Continental Crush,Savage Spin-Out,Savage Spin-Out,Never-Ending Nightmare,Never-Ending Nightmare,Corkscrew Crash,Corkscrew Crash,Inferno Overdrive,Inferno Overdrive,Hydro Vortex,Hydro Vortex,Bloom Doom,Bloom Doom,Gigavolt Havoc,Gigavolt Havoc,Shattered Psyche,Shattered Psyche,Subzero Slammer,Subzero Slammer,Devastating Drake,Devastating Drake,Black Hole Eclipse,Black Hole Eclipse,Twinkle Tackle,Twinkle Tackle,Catastropika,Shore Up,First Impression,Baneful Bunker,Spirit Shackle,Darkest Lariat,Sparkling Aria,Ice Hammer,Floral Healing,High Horsepower,Strength Sap,Solar Blade,Leafage,Spotlight,Toxic Thread,Laser Focus,Gear Up,Throat Chop,Pollen Puff,Anchor Shot,Psychic Terrain,Lunge,Fire Lash,Power Trip,Burn Up,Speed Swap,Smart Strike,Purify,Revelation Dance,Core Enforcer,Trop Kick,Instruct,Beak Blast,Clanging Scales,Dragon Hammer,Brutal Swing,Aurora Veil,Sinister Arrow Raid,Malicious Moonsault,Oceanic Operetta,Guardian of Alola,Soul-Stealing 7-Star Strike,Stoked Sparksurfer,Pulverizing Pancake,Extreme Evoboost,Genesis Supernova,Shell Trap,Fleur Cannon,Psychic Fangs,Stomping Tantrum,Shadow Bone,Accelerock,Liquidation,Prismatic Laser,Spectral Thief,Sunsteel Strike,Moongeist Beam,Tearful Look,Zing Zap,Nature's Madness,Multi-Attack,10,000,000 Volt Thunderbolt,Mind Blown,Plasma Fists,Photon Geyser,Light That Burns the Sky,Searing Sunraze Smash,Menacing Moonraze Maelstrom,Let's Snuggle Forever,Splintered Stormshards";
        public static string MoveName = ",拍击,空手劈,连环巴掌,连续拳,百万吨重拳,聚宝功,火焰拳,冰冻拳,雷电拳,抓,夹住,断头钳,旋风刀,剑舞,居合斩,起风,翅膀攻击,吹飞,飞翔,绑紧,摔打,藤鞭,踩踏,二连踢,百万吨重踢,飞踢,回旋踢,泼沙,头锤,角撞,乱击,角钻,撞击,泰山压顶,紧束,猛撞,大闹一番,舍身冲撞,摇尾巴,毒针,双针,飞弹针,瞪眼,咬住,叫声,吼叫,唱歌,超音波,音爆,定身法,溶解液,火花,喷射火焰,白雾,水枪,水炮,冲浪,冰冻光束,暴风雪,幻象光线,泡沫光线,极光束,破坏光线,啄,啄钻,地狱翻滚,踢倒,双倍奉还,地球上投,怪力,吸取,超级吸取,寄生种子,生长,飞叶快刀,日光束,毒粉,麻痹粉,催眠粉,花瓣舞,吐丝,龙之怒,火焰旋涡,电击,十万伏特,电磁波,打雷,落石,地震,地裂,挖洞,剧毒,念力,精神强念,催眠术,瑜伽姿势,高速移动,电光一闪,愤怒,瞬间移动,黑夜魔影,模仿,刺耳声,影子分身,自我再生,变硬,变小,烟幕,奇异之光,缩入壳中,变圆,屏障,光墙,黑雾,反射壁,聚气,忍耐,挥指,鹦鹉学舌,自爆,炸蛋,舌舔,浊雾,污泥攻击,骨棒,大字爆炎,攀瀑,贝壳夹击,高速星星,火箭头锤,尖刺加农炮,缠绕,瞬间失忆,折弯汤匙,生蛋,飞膝踢,大蛇瞪眼,食梦,毒瓦斯,投球,吸血,恶魔之吻,神鸟猛击,变身,泡沫,迷昏拳,蘑菇孢子,闪光,精神波,跃起,溶化,蟹钳锤,大爆炸,乱抓,骨头回力镖,睡觉,岩崩,必杀门牙,棱角化,纹理,三重攻击,愤怒门牙,劈开,替身,挣扎,写生,三连踢,小偷,蛛网,心之眼,恶梦,火焰轮,打鼾,诅咒,抓狂,纹理２,气旋攻击,棉孢子,起死回生,怨恨,细雪,守住,音速拳,鬼面,出奇一击,天使之吻,腹鼓,污泥炸弹,掷泥,章鱼桶炮,撒菱,电磁炮,识破,同命,灭亡之歌,冰冻之风,看穿,骨棒乱打,锁定,逆鳞,沙暴,终极吸取,挺住,撒娇,滚动,点到为止,虚张声势,喝牛奶,电光,连斩,钢翼,黑色目光,迷人,梦话,治愈铃声,报恩,礼物,迁怒,神秘守护,分担痛楚,神圣之火,震级,爆裂拳,超级角击,龙息,接棒,再来一次,追打,高速旋转,甜甜香气,铁尾,金属爪,借力摔,晨光,光合作用,月光,觉醒力量,十字劈,龙卷风,求雨,大晴天,咬碎,镜面反射,自我暗示,神速,原始之力,暗影球,预知未来,碎岩,潮旋,围攻,击掌奇袭,吵闹,蓄力,喷出,吞下,热风,冰雹,无理取闹,吹捧,鬼火,临别礼物,硬撑,真气拳,清醒,看我嘛,自然之力,充电,挑衅,帮助,戏法,扮演,祈愿,借助,扎根,蛮力,魔法反射,回收利用,报复,劈瓦,哈欠,拍落,蛮干,喷火,特性互换,封印,焕然一新,怨念,抢夺,秘密之力,潜水,猛推,保护色,萤火,洁净光芒,薄雾球,羽毛舞,摇晃舞,火焰踢,玩泥巴,冰球,尖刺臂,偷懒,巨声,剧毒牙,撕裂爪,爆炸烈焰,加农水炮,彗星拳,惊吓,气象球,芳香治疗,假哭,空气利刃,过热,气味侦测,岩石封锁,银色旋风,金属音,草笛,挠痒,宇宙力量,喷水,信号光束,暗影拳,神通力,冲天拳,流沙地狱,绝对零度,浊流,种子机关枪,燕返,冰锥,铁壁,挡路,长嚎,龙爪,疯狂植物,健美,弹跳,泥巴射击,毒尾,渴望,伏特攻击,魔法叶,玩水,冥想,叶刃,龙之舞,岩石爆击,电击波,水之波动,破灭之愿,精神突进,羽栖,重力,奇迹之眼,唤醒巴掌,臂锤,陀螺球,治愈之愿,盐水,自然之恩,佯攻,啄食,顺风,点穴,金属爆炸,急速折返,近身战,以牙还牙,恶意追击,查封,投掷,精神转移,王牌,回复封锁,绞紧,力量戏法,胃液,幸运咒语,抢先一步,仿效,力量互换,防守互换,惩罚,珍藏,烦恼种子,突袭,毒菱,心灵互换,水流环,电磁飘浮,闪焰冲锋,发劲,波导弹,岩石打磨,毒击,恶之波动,暗袭要害,水流尾,种子炸弹,空气斩,十字剪,虫鸣,龙之波动,龙之俯冲,力量宝石,吸取拳,真空波,真气弹,能量球,勇鸟猛攻,大地之力,掉包,终极冲击,诡计,子弹拳,雪崩,冰砾,暗影爪,雷电牙,冰冻牙,火焰牙,影子偷袭,泥巴炸弹,精神利刃,意念头锤,镜光射击,加农光炮,攀岩,清除浓雾,戏法空间,流星群,放电,喷烟,飞叶风暴,强力鞭打,岩石炮,十字毒刃,垃圾射击,铁头,磁铁炸弹,尖石攻击,诱惑,隐形岩,打草结,喋喋不休,制裁光砾,虫咬,充电光束,木槌,水流喷射,攻击指令,防御指令,回复指令,双刃头锤,二连击,时光咆哮,亚空裂斩,新月舞,捏碎,熔岩风暴,暗黑洞,种子闪光,奇异之风,暗影潜袭,磨爪,广域防守,防守平分,力量平分,奇妙空间,精神冲击,毒液冲击,身体轻量化,愤怒粉,意念移物,魔法空间,击落,山岚摔,烈焰溅射,污泥波,蝶舞,重磅冲撞,同步干扰,电球,浸水,蓄能焰袭,盘蜷,下盘踢,酸液炸弹,欺诈,单纯光束,找伙伴,您先请,轮唱,回声,逐步击破,清除之烟,辅助力量,快速防守,交换场地,热水,破壳,治愈波动,祸不单行,自由落体,换挡,巴投,烧尽,延后,杂技,镜面属性,报仇,搏命,传递礼物,炼狱,水之誓约,火之誓约,草之誓约,伏特替换,虫之抵抗,重踏,冰息,龙尾,自我激励,电网,疯狂伏特,直冲钻,二连劈,爱心印章,木角,圣剑,贝壳刃,高温重压,青草搅拌器,疯狂滚压,棉花防守,暗黑爆破,精神击破,扫尾拍打,暴风,爆炸头突击,齿轮飞盘,火焰弹,高科技光炮,古老之歌,神秘之剑,冰封世界,雷击,青焰,火之舞,冰冻伏特,极寒冷焰,大声咆哮,冰柱坠击,Ｖ热焰,交错火焰,交错闪电,飞身重压,掀榻榻米,打嗝,耕地,黏黏网,致命针刺,潜灵奇袭,万圣夜,战吼,等离子浴,抛物面充电,森林诅咒,落英缤纷,冷冻干燥,魅惑之声,抛下狠话,颠倒,吸取之吻,戏法防守,鲜花防守,青草场地,薄雾场地,输电,嬉闹,妖精之风,月亮之力,爆音波,妖精之锁,王者盾牌,和睦相处,密语,钻石风暴,蒸汽爆炸,异次元洞,飞水手里剑,魔法火焰,尖刺防守,芳香薄雾,怪异电波,毒液陷阱,粉尘,大地掌控,磁场操控,欢乐时光,电气场地,魔法闪耀,庆祝,牵手,圆瞳,蹭蹭脸颊,手下留情,死缠烂打,增强拳,死亡之翼,千箭齐发,千波激荡,大地神力,破灭之光,根源波动,断崖之剑,画龙点睛,异次元猛攻,究极无敌大冲撞,究极无敌大冲撞,全力无双激烈拳,全力无双激烈拳,极速俯冲轰烈撞,极速俯冲轰烈撞,强酸剧毒灭绝雨,强酸剧毒灭绝雨,地隆啸天大终结,地隆啸天大终结,毁天灭地巨岩坠,毁天灭地巨岩坠,绝对捕食回旋斩,绝对捕食回旋斩,无尽暗夜之诱惑,无尽暗夜之诱惑,超绝螺旋连击,超绝螺旋连击,超强极限爆焰弹,超强极限爆焰弹,超级水流大漩涡,超级水流大漩涡,绚烂缤纷花怒放,绚烂缤纷花怒放,终极伏特狂雷闪,终极伏特狂雷闪,至高精神破坏波,至高精神破坏波,激狂大地万里冰,激狂大地万里冰,究极巨龙震天地,究极巨龙震天地,黑洞吞噬万物灭,黑洞吞噬万物灭,可爱星星飞天撞,可爱星星飞天撞,皮卡皮卡必杀击,集沙,迎头一击,碉堡,缝影,ＤＤ金勾臂,泡影的咏叹调,冰锤,花疗,十万马力,吸取力量,日光刃,树叶,聚光灯,毒丝,磨砺,辅助齿轮,地狱突刺,花粉团,掷锚,精神场地,猛扑,火焰鞭,嚣张,燃尽,速度互换,修长之角,净化,觉醒之舞,核心惩罚者,热带踢,号令,鸟嘴加农炮,鳞片噪音,龙锤,狂舞挥打,极光幕,遮天蔽日暗影箭,极恶飞跃粉碎击,海神庄严交响乐,巨人卫士·阿罗拉,七星夺魂腿,驾雷驭电戏冲浪,认真起来大爆击,九彩升华齐聚顶,起源超新星大爆炸,陷阱甲壳,花朵加农炮,精神之牙,跺脚,暗影之骨,冲岩,水流裂破,棱镜镭射,暗影偷盗,流星闪冲,暗影之光,泪眼汪汪,麻麻刺刺,自然之怒,多属性攻击,千万伏特,惊爆大头,等离子闪电拳,光子喷涌,焚天灭世炽光爆,日光回旋下苍穹,月华飞溅落灵霄,亲密无间大乱揍,狼啸石牙飓风暴";
        public static string Pokedata = readToString("pokedata");
        public static string[] Naturedata = "勤奋,0,0,0\n怕寂寞,1,2,5\n勇敢,1,5,3\n固执,1,3,2\n顽皮,1,4,4\n大胆,2,1,1\n坦率,0,0,0\n悠闲,2,5,3\n淘气,2,3,2\n乐天,2,4,4\n胆小,5,1,1\n急躁,5,2,5\n认真,0,0,0\n爽朗,5,3,2\n天真,5,4,4\n内敛,3,1,1\n慢吞吞,3,2,5\n冷静,3,5,3\n害羞,0,0,0\n马虎,3,4,4\n温和,4,1,1\n温顺,4,2,5\n自大,4,5,3\n慎重,4,3,2\n浮躁,0,0,0".Split('\n');


    }



}
