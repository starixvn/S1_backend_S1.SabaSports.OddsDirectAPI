namespace S1.SabaSports.OddsDirectAPI.Constants;

public static class MatchPopularScore
{
    private static readonly Dictionary<string, double> Soccer = new()
    {
        { "83-3", 2.34676 }, // Manchester City - ENGLISH PREMIER LEAGUE
        { "8-3", 2.214104 }, // Liverpool - ENGLISH PREMIER LEAGUE
        { "6-3", 2.094063 }, // Arsenal - ENGLISH PREMIER LEAGUE
        { "5-3", 2.058341 }, // Manchester United - ENGLISH PREMIER LEAGUE
        { "9-3", 1.821845 }, // Chelsea - ENGLISH PREMIER LEAGUE
        { "159-3", 1.75597 }, // Tottenham Hotspur - ENGLISH PREMIER LEAGUE
        { "26-3", 1.693195 }, // Aston Villa - ENGLISH PREMIER LEAGUE
        { "39-3", 1.684181 }, // Newcastle United - ENGLISH PREMIER LEAGUE
        { "870-3", 1.648508 }, // West Ham United - ENGLISH PREMIER LEAGUE
        { "160-3", 1.456052 }, // Brentford - ENGLISH PREMIER LEAGUE
        { "25-3", 1.44278 }, // Brighton & Hove Albion - ENGLISH PREMIER LEAGUE
        { "866663-3", 1.431899 }, // AFC Bournemouth - ENGLISH PREMIER LEAGUE
        { "22785-43", 1.429262 }, // Real Madrid - SPAIN PRIMERA LALIGA
        { "94-3", 1.401909 }, // Crystal Palace - ENGLISH PREMIER LEAGUE
        { "55-3", 1.376752 }, // Nottingham Forest - ENGLISH PREMIER LEAGUE
        { "87-3", 1.359571 }, // Wolverhampton Wanderers - ENGLISH PREMIER LEAGUE
        { "22-43", 1.355274 }, // Barcelona - SPAIN PRIMERA LALIGA
        { "42-3", 1.337272 }, // Everton - ENGLISH PREMIER LEAGUE
        { "680-4", 1.308253 }, // Napoli - ITALY SERIE A
        { "1774-43", 1.302814 }, // Girona - SPAIN PRIMERA LALIGA
        { "194-4", 1.267855 }, // Juventus - ITALY SERIE A
        { "12-4", 1.242332 }, // Inter Milan - ITALY SERIE A
        { "14015-4", 1.208344 }, // AC Milan - ITALY SERIE A
        { "265-5", 1.206079 }, // Bayern Munchen - GERMANY-BUNDESLIGA I
        { "157-43", 1.193463 }, // Athletic Bilbao - SPAIN PRIMERA LALIGA
        { "88-4", 1.174824 }, // Bologna - ITALY SERIE A
        { "46-5", 1.124707 }, // Bayer 04 Leverkusen - GERMANY-BUNDESLIGA I
        { "10-3", 1.120594 }, // Fulham - ENGLISH PREMIER LEAGUE
        { "133-4", 1.119823 }, // AS Roma - ITALY SERIE A
        { "70-43", 1.11853 }, // Villarreal CF - SPAIN PRIMERA LALIGA
        { "84307-4", 1.101846 }, // Fiorentina - ITALY SERIE A
        { "496-4", 1.086793 }, // Genoa - ITALY SERIE A
        { "5392-4", 1.083008 }, // Monza - ITALY SERIE A
        { "102-4", 1.07446 }, // Empoli - ITALY SERIE A
        { "635-3", 1.070285 }, // Luton Town - ENGLISH PREMIER LEAGUE
        { "74-4", 1.069166 }, // Atalanta - ITALY SERIE A
        { "129-4", 1.063017 }, // Verona - ITALY SERIE A
        { "23-43", 1.061484 }, // Real Sociedad - SPAIN PRIMERA LALIGA
        { "106-4", 1.056449 }, // Torino - ITALY SERIE A
        { "105-4", 1.047267 }, // Udinese - ITALY SERIE A
        { "110-43", 1.046188 }, // Real Betis - SPAIN PRIMERA LALIGA
        { "243-4", 1.040122 }, // Lecce - ITALY SERIE A
        { "485-43", 1.036109 }, // Getafe CF - SPAIN PRIMERA LALIGA
        { "76-43", 1.02799 }, // Celta Vigo - SPAIN PRIMERA LALIGA
        { "45-4", 1.020076 }, // Lazio - ITALY SERIE A
        { "69-43", 1.016765 }, // Atletico de Madrid - SPAIN PRIMERA LALIGA
        { "38-43", 1.007387 }, // Sevilla - SPAIN PRIMERA LALIGA
        { "8790-43", 1.00596 }, // Rayo Vallecano - SPAIN PRIMERA LALIGA
        { "77-43", 1.003345 }, // RCD Mallorca - SPAIN PRIMERA LALIGA
        { "24-43", 0.995905 }, // Valencia CF - SPAIN PRIMERA LALIGA
        { "655-4", 0.993134 }, // Cagliari - ITALY SERIE A
        { "49-5", 0.965887 }, // Borussia Dortmund - GERMANY-BUNDESLIGA I
        { "64-3", 0.958842 }, // Sheffield United - ENGLISH PREMIER LEAGUE
        { "241-43", 0.946744 }, // Las Palmas - SPAIN PRIMERA LALIGA
        { "2000-4", 0.893269 }, // Frosinone - ITALY SERIE A
        { "92-3", 0.891268 }, // Burnley - ENGLISH PREMIER LEAGUE
        { "5292-5", 0.873924 }, // VfB Stuttgart - GERMANY-BUNDESLIGA I
        { "756-5", 0.85474 }, // TSG 1899 Hoffenheim - GERMANY-BUNDESLIGA I
        { "134-43", 0.853509 }, // CA Osasuna - SPAIN PRIMERA LALIGA
        { "76305-5", 0.850251 }, // RB Leipzig - GERMANY-BUNDESLIGA I
        { "498-4", 0.819778 }, // Salernitana - ITALY SERIE A
        { "8275-4", 0.798762 }, // Sassuolo - ITALY SERIE A
        { "99-43", 0.796667 }, // Deportivo Alaves - SPAIN PRIMERA LALIGA
        { "1548-5", 0.791307 }, // Augsburg - GERMANY-BUNDESLIGA I
        { "421-5", 0.79054 }, // Eintracht Frankfurt - GERMANY-BUNDESLIGA I
        { "1039-5", 0.750402 }, // FSV Mainz 05 - GERMANY-BUNDESLIGA I
        { "1158-5", 0.742143 }, // Werder Bremen - GERMANY-BUNDESLIGA I
        { "6386-5", 0.733608 }, // VfL Wolfsburg - GERMANY-BUNDESLIGA I
        { "148-43", 0.730345 }, // UD Almeria - SPAIN PRIMERA LALIGA
        { "54-5", 0.729439 }, // Borussia Monchengladbach - GERMANY-BUNDESLIGA I
        { "7681-8", 0.724305 }, // AS Monaco - FRANCE LIGUE 1
        { "89-5", 0.712146 }, // VfL Bochum - GERMANY-BUNDESLIGA I
        { "623-43", 0.710824 }, // Cadiz - SPAIN PRIMERA LALIGA
        { "3138-5", 0.702715 }, // SC Freiburg - GERMANY-BUNDESLIGA I
        { "266-8", 0.674843 },   // Paris Saint Germain - FRANCE LIGUE 1
        { "786-5", 0.656137 },   // Union Berlin - GERMANY-BUNDESLIGA I
        { "34656-43", 0.652307 }, // Granada CF - SPAIN PRIMERA LALIGA
        { "7537-8", 0.634615 },   // Olympique de Marseille - FRANCE LIGUE 1
        { "27242-5", 0.614305 },  // FC Heidenheim 1846 - GERMANY-BUNDESLIGA I
        { "3126-5", 0.609539 },   // FC Koln - GERMANY-BUNDESLIGA I
        { "8534-8", 0.595603 },   // Lille OSC - FRANCE LIGUE 1
        { "1159-8", 0.595385 },   // RC Lens - FRANCE LIGUE 1
        { "269892-8", 0.59297 },   // Stade Brestois - FRANCE LIGUE 1
        { "286-8", 0.570173 },     // Montpellier - FRANCE LIGUE 1
        { "22781-8", 0.564911 },   // Olympique Lyonnais - FRANCE LIGUE 1
        { "1543-5", 0.553356 },    // Darmstadt 98 - GERMANY-BUNDESLIGA I
        { "6837-8", 0.55174 },     // OGC Nice - FRANCE LIGUE 1
        { "1195-8", 0.547942 },    // Reims - FRANCE LIGUE 1
        { "291-8", 0.5366 },       // Toulouse - FRANCE LIGUE 1
        { "292-8", 0.506488 },     // RC Strasbourg - FRANCE LIGUE 1
        { "30340-8", 0.499708 },   // Nantes - FRANCE LIGUE 1
        { "3091-8", 0.49676 },      // Stade Rennais - FRANCE LIGUE 1
        { "1197-8", 0.452044 },    // Lorient - FRANCE LIGUE 1
        { "7673-8", 0.411558 },    // Le Havre - FRANCE LIGUE 1
        { "58-3", 0.383469 },      // Ipswich Town - ENGLISH PREMIER LEAGUE
        { "29-3", 0.358059 },      // Southampton - ENGLISH PREMIER LEAGUE
        { "68-4", 0.333952 },      // Parma - ITALY SERIE A
        { "284-8", 0.325027 },     // Metz - FRANCE LIGUE 1
        { "16164-8", 0.308788 },   // Clermont - FRANCE LIGUE 1
        { "78-43", 0.277592 },     // Real Valladolid - SPAIN PRIMERA LALIGA
        { "60-3", 0.235861 },      // Leicester City - ENGLISH PREMIER LEAGUE
        { "75-43", 0.222298 },     // RCD Espanyol - SPAIN PRIMERA LALIGA
        { "490-43", 0.217299 },    // Leganes - SPAIN PRIMERA LALIGA
        { "119-8", 0.217196 },     // AJ Auxerre - FRANCE LIGUE 1
        { "142-4", 0.198852 },     // Venezia - ITALY SERIE A
        { "1044-8", 0.188375 },    // AS Saint Etienne - FRANCE LIGUE 1
        { "1193-8", 0.176342 },    // Angers - FRANCE LIGUE 1
        { "73-4", 0.159127 },      // Como - ITALY SERIE A
        { "1135-5", 0.146496 },    // St. Pauli - GERMANY-BUNDESLIGA I
        { "1544-5", 0.110753 }     // Holstein Kiel - GERMANY-BUNDESLIGA I
    };

    private static readonly Dictionary<string, double> Basketball = new()
    {
        { "714227-56038", 0.136011 }, // Los Angeles Lakers - NBA
        { "1993-56038", 0.120731 }, // Golden State Warriors - NBA
        { "1992-56038", 0.118806 }, // L.A. Clippers - NBA
        { "1989-56038", 0.115082 }, // Phoenix Suns - NBA
        { "1990-56038", 0.111534 }, // Sacramento Kings - NBA
        { "1987-56038", 0.109198 }, // Denver Nuggets - NBA
        { "19441-56038", 0.105620 }, // Milwaukee Bucks - NBA
        { "1986-56038", 0.099792 }, // Portland Trail Blazers - NBA
        { "1988-56038", 0.099144 }, // Utah Jazz - NBA
        { "1973-56038", 0.096276 }, // Indiana Pacers - NBA
        { "1985-56038", 0.092034 }, // Minnesota Timberwolves - NBA
        { "1985-56054", 0.091969 }, // Minnesota Timberwolves - NBA Playoffs
        { "449466-56054", 0.091941 }, // Dallas Mavericks - NBA Playoffs
        { "30697-56038", 0.091394 }, // Oklahoma City Thunder - NBA
        { "1969-56038", 0.090513 }, // Boston Celtics - NBA
        { "449466-56038", 0.088634 }, // Dallas Mavericks - NBA
        { "1968-56038", 0.088554 }, // Philadelphia 76ers - NBA
        { "1983-56038", 0.087726 }, // Atlanta Hawks - NBA
        { "1977-56038", 0.078423 }, // Miami Heat - NBA
        { "1973-56054", 0.078297 }, // Indiana Pacers - NBA Playoffs
        { "1998-56038", 0.077965 }, // New Orleans Pelicans - NBA
        { "1996-56038", 0.076621 }, // Houston Rockets - NBA
        { "1971-56038", 0.076144 }, // Toronto Raptors - NBA
        { "1997-56038", 0.075538 }, // Memphis Grizzlies - NBA
        { "1967-56038", 0.075039 }, // New York Knicks - NBA
        { "8974-56038", 0.074617 }, // Cleveland Cavaliers - NBA
        { "1975-56038", 0.074028 }, // Chicago Bulls - NBA
        { "168769-56038", 0.073866 }, // Brooklyn Nets - NBA
        { "1994-56038", 0.073370 }, // San Antonio Spurs - NBA
        { "1978-56038", 0.071966 }, // Orlando Magic - NBA
        { "8977-56038", 0.071383 }, // Detroit Pistons - NBA
        { "1987-56054", 0.068726 }, // Denver Nuggets - NBA Playoffs
        { "1979-56038", 0.067138 }, // Washington Wizards - NBA
        { "268666-56038", 0.066930 }, // Charlotte Hornets - NBA
        { "1969-56054", 0.062024 }, // Boston Celtics - NBA Playoffs
        { "1967-56054", 0.056065 }, // New York Knicks - NBA Playoffs
        { "30697-56054", 0.049788 }, // Oklahoma City Thunder - NBA Playoffs
        { "8974-56054", 0.044433 }, // Cleveland Cavaliers - NBA Playoffs
        { "918747-55845", 0.044300 }, // Las Vegas Aces (W) - WNBA
        { "918754-55845", 0.043948 }, // Phoenix Mercury (W) - WNBA
        { "918758-55845", 0.042324 }, // Los Angeles Sparks (W) - WNBA
        { "22429-104910", 0.041678 }, // Busan KCC Egis - Korea KBL
        { "918756-55845", 0.041258 }, // Minnesota Lynx (W) - WNBA
        { "918748-55845", 0.041075 }, // Connecticut Sun (W) - WNBA
        { "788811-104910", 0.041047 }, // Suwon KT Sonicboom - Korea KBL
        { "918752-55845", 0.039789 }, // New York Liberty (W) - WNBA
        { "918757-55845", 0.039254 }, // Indiana Fever (W) - WNBA
        { "918751-55845", 0.039203 }, // Seattle Storm (W) - WNBA
        { "918753-55845", 0.038757 }, // Dallas Wings (W) - WNBA
        { "918750-55845", 0.036617 }, // Chicago Sky (W) - WNBA
        { "918749-55845", 0.036493 }, // Washington Mystics (W) - WNBA
        { "918755-55845", 0.036153 }, // Atlanta Dream (W) - WNBA
        { "1039585-104910", 0.028763 }, // Changwon Sakers - Korea KBL
        { "22425-104910", 0.027890 }, // Seoul SK Knights - Korea KBL
        { "428758-104910", 0.027578 }, // Ulsan Hyundai Mobis Phoebus - Korea KBL
        { "1992-56054", 0.026519 }, // L.A. Clippers - NBA Playoffs
        { "428769-104910", 0.025914 }, // Wonju DB Promy - Korea KBL
        { "714227-56054", 0.025455 }, // Los Angeles Lakers - NBA Playoffs
        { "141346-7507", 0.025428 }, // Guangdong Southern Tigers - China CBA
        { "1039586-104910", 0.025269 }, // Seoul Thunders - Korea KBL
        { "808735-63392", 0.023179 }, // Tasmania JackJumpers - Australia NBL
        { "1968-56054", 0.022977 }, // Philadelphia 76ers - NBA Playoffs
        { "1978-56054", 0.022802 }, // Orlando Magic - NBA Playoffs
        { "824648-104910", 0.022514 }, // Daegu KOGAS Pegasus - Korea KBL
        { "275024-63392", 0.021935 }, // Melbourne United - Australia NBL
        { "234749-7507", 0.021922 }, // Liaoning Flying Leopards - China CBA
        { "19441-56054", 0.021854 }, // Milwaukee Bucks - NBA Playoffs
        { "690174-7507", 0.021118 }, // Beijing Royal Fighters - China CBA
        { "690389-63381", 0.021045 }, // Franklin Bulls - New Zealand NBL
        { "1066861-104910", 0.020942 }, // Goyang Sono Skygunners - Korea KBL
        { "907128-7507", 0.020889 }, // Shanxi Loongs - China CBA
        { "259781-63381", 0.020871 }, // Canterbury Rams - New Zealand NBL
        { "141341-7507", 0.020749 }, // Shanghai Sharks - China CBA
        { "651902-144142", 0.020594 }, // Meralco Bolts - Philippines PBA Cup
        { "933683-7507", 0.020355 }, // Qingdao Eagles - China CBA
        { "141347-7507", 0.020149 }, // Zhejiang Golden Bulls - China CBA
        { "316392-63392", 0.020092 }, // Illawarra Hawks - Australia NBL
        { "33142-7507", 0.020034 }, // Xinjiang Flying Tigers - China CBA
        { "1066893-104910", 0.019972 }, // Anyang Red Boosters - Korea KBL
        { "855187-63381", 0.019965 }, // Taranaki Airs - New Zealand NBL
        { "73053-7507", 0.019798 }, // Jilin Northeast Tigers - China CBA
        { "622385-7507", 0.019432 }, // Guangzhou Loong Lions - China CBA
        { "427762-7507", 0.019303 }, // Nanjing Tongxi Monkey King - China CBA
        { "853591-63381", 0.019284 }, // Auckland Tuatara - New Zealand NBL
        { "252244-63381", 0.019201 }, // Otago Nuggets - New Zealand NBL
        { "77699-63381", 0.019129 }, // Wellington Saints - New Zealand NBL
        { "153755-144142", 0.019025 }, // San Miguel Beermen - Philippines PBA Cup
        { "295060-63381", 0.019021 }, // Hawkes Bay Hawks - New Zealand NBL
        { "141351-7507", 0.019012 }, // Jiangsu Dragons - China CBA
        { "424033-7507", 0.018876 }, // Shenzhen Leopards - China CBA
        { "1073696-7507", 0.018279 }, // Zhejiang Guangsha Lions - China CBA
        { "141348-7507", 0.018178 }, // Beijing Ducks - China CBA
        { "77700-63381", 0.017881 }, // Nelson Giants - New Zealand NBL
        { "633460-7507", 0.017666 }, // Tianjin Pioneers - China CBA
        { "19385-63392", 0.017641 }, // New Zealand Breakers - Australia NBL
        { "933682-7507", 0.017340 }, // Fujian Sturgeons - China CBA
        { "909007-63381", 0.017150 }, // Whai - New Zealand NBL
        { "1977-56054", 0.017038 }, // Miami Heat - NBA Playoffs
        { "1989-56054", 0.016978 }, // Phoenix Suns - NBA Playoffs
        { "77698-63381", 0.016632 }, // Manawatu Jets - New Zealand NBL
        { "19395-63392", 0.016470 }, // Perth Wildcats - Australia NBL
        { "141346-114609", 0.016440 }, // Guangdong Southern Tigers - China CBA Playoffs
        { "907012-7507", 0.016350 }, // Shandong Kirins - China CBA
        { "77548-63381", 0.016349 }, // Southland Sharks - New Zealand NBL
        { "1998-56054", 0.016085 }, // New Orleans Pelicans - NBA Playoffs
        { "235330-7507", 0.015879 }, // Sichuan Blue Whales - China CBA
        { "7804-144521", 0.015830 }, // Serbia - Olympics Paris 2024 - Basketball Men
        { "928-144521", 0.015677 }, // France - Olympics Paris 2024 - Basketball Men
        { "141347-114609", 0.015511 }, // Zhejiang Golden Bulls - China CBA Playoffs
        { "907707-7507", 0.015482 }, // Ningbo Rockets - China CBA
        { "19390-63392", 0.015449 }, // Sydney Kings - Australia NBL
        { "191-144521", 0.015178 }, // USA - Olympics Paris 2024 - Basketball Men
        { "234749-114609", 0.013724 }, // Liaoning Flying Leopards - China CBA Playoffs
        { "666460-144142", 0.013235 }, // Rain or Shine Elasto Painters - Philippines PBA Cup
        { "238-144521", 0.013128 }, // Germany - Olympics Paris 2024 - Basketball Men
        { "19383-63392", 0.012744 }, // Adelaide 36ers - Australia NBL
        { "33142-114609", 0.012568 }, // Xinjiang Flying Tigers - China CBA Playoffs
        { "578343-74379", 0.012389 }, // Satria Muda Pertamina - Indonesia Basketball League
        { "626326-144142", 0.012342 }, // Barangay Ginebra San Miguel - Philippines PBA Cup
        { "658-144522", 0.011655 }, // France (W) - Olympics Paris 2024 - Basketball Women
        { "653357-74379", 0.011430 }, // Pelita Jaya Basketball Club - Indonesia Basketball League
        { "667721-89068", 0.011343 }, // Rayos de Hermosillo - Mexico CIBACOPA
        { "3397-144521", 0.011298 }, // Australia - Olympics Paris 2024 - Basketball Men
        { "1135377-152812", 0.011120 }, // Phoenix Fuel Masters - Philippines PBA Governors Cup
        { "666460-152812", 0.011103 }, // Rain or Shine Elasto Painters - Philippines PBA Governors Cup
        { "940233-63392", 0.011051 }, // Brisbane Bullets - Australia NBL
        { "10023-144522", 0.011050 }, // Belgium (W) - Olympics Paris 2024 - Basketball Women
        { "17916-144522", 0.010981 }, // USA (W) - Olympics Paris 2024 - Basketball Women
        { "713450-152812", 0.010895 }, // Blackwater Bossing - Philippines PBA Governors Cup
        { "21730-104870", 0.010680 }, // Ryukyu Golden Kings - Japan B1.League
        { "706365-89068", 0.010673 }, // Astros de Jalisco - Mexico CIBACOPA
        { "807048-95272", 0.010631 }, // New Taipei Kings - Taiwan P.League+
        { "247-144522", 0.010608 }, // Australia (W) - Olympics Paris 2024 - Basketball Women
        { "666455-152812", 0.010603 }, // NLEX Road Warriors - Philippines PBA Governors Cup
        { "626336-63392", 0.010548 }, // South East Melbourne Phoenix - Australia NBL
        { "866368-152812", 0.010519 }, // Converge FiberXers - Philippines PBA Governors Cup
        { "141341-114609", 0.010508 }, // Shanghai Sharks - China CBA Playoffs
        { "1990-99232", 0.010472 }, // Sacramento Kings - NBA Play-In Tournament
        { "19393-63392", 0.010471 }, // Cairns Taipans - Australia NBL
        { "666458-152812", 0.010469 }, // NorthPort Batang Pier - Philippines PBA Governors Cup
        { "153755-152812", 0.010414 }, // San Miguel Beermen - Philippines PBA Governors Cup
        { "1066873-74379", 0.010296 }, // Prawira Harum Bandung - Indonesia Basketball League
        { "939088-74379", 0.010226 }, // Dewa United Banten - Indonesia Basketball League
        { "1103154-74379", 0.010100 }, // RANS Simba Bogor - Indonesia Basketball League
        { "713416-152812", 0.010065 }, // TNT Tropang Giga - Philippines PBA Governors Cup
        { "626326-152812", 0.009922 }, // Barangay Ginebra San Miguel - Philippines PBA Governors Cup
        { "803817-104911", 0.009821 }, // Woori Bank WooriWON (W) - Korea WKBL
        { "927719-95272", 0.009775 }, // Taoyuan Pauian Pilots - Taiwan P.League+
        { "626325-152812", 0.009760 }, // Terrafirma Dyip - Philippines PBA Governors Cup{ "666455-144142", 0.009754 },   // NLEX Road Warriors - Philippines PBA Cup
    };

    public static readonly Dictionary<int, Dictionary<string, double>> PopularScores = new Dictionary<int, Dictionary<string, double>>()
    {
        { 1, Soccer },
        { 5, Basketball }
    };
}
