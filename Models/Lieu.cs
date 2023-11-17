using System.ComponentModel.DataAnnotations;

namespace DouVoitOn.Models
{
    public class Lieu
    {

        [Key] public int Id { get; set; }
        public string Nom { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public Pays Pays { get; set; }
        public string? Ville { get; set; }
        public string? Adresse { get; set; }

        [DataType(DataType.MultilineText)]
        public string? Description { get; set; }
    }


    public enum Pays
    {
        Afghanistan,
        [Display(Name = "Åland Islands")]
        ÅlandIslands,
        Albania,
        Algeria,
        [Display(Name = "American Samoa")]
        AmericanSamoa,
        Andorra,
        Angola,
        Anguilla,
        Antarctica,
        [Display(Name = "Antigua and Barbuda")]
        AntiguaandBarbuda,
        Argentina,
        Armenia,
        Aruba,
        Australia,
        Austria,
        Azerbaijan,
        Bahamas,
        Bahrain,
        Bangladesh,
        Barbados,
        Belarus,
        Belgium,
        Belize,
        Benin,
        Bermuda,
        Bhutan,
        Bolivia,
        [Display(Name = "Bosnia and Herzegovina")]
        BosniaandHerzegovina,
        Botswana,
        [Display(Name = "Bouvet Island")]
        BouvetIsland,
        Brazil,
        [Display(Name = "British Indian Ocean Territory")]
        BritishIndianOceanTerritory,
        [Display(Name = "Brunei Darussalam")]
        BruneiDarussalam,
        Bulgaria,
        [Display(Name = "Burkina Faso")]
        BurkinaFaso,
        Burundi,
        Cambodia,
        Cameroon,
        Canada,
        [Display(Name = "Cape Verde")]
        CapeVerde,
        [Display(Name = "Cayman Islands")]
        CaymanIslands,
        [Display(Name = "Central African Republic")]
        CentralAfricanRepublic,
        Chad,
        Chile,
        China,
        [Display(Name = "Christmas Island")]
        ChristmasIsland,
        [Display(Name = "Cocos (Keeling) Islands")]
        CocosKeelingIslands,
        Colombia,
        Comoros,
        Congo,
        [Display(Name = "Congo, The Democratic Republic of The")]
        CongoTheDemocraticRepublicofThe,
        [Display(Name = "Cook Islands")]
        CookIslands,
        [Display(Name = "Costa Rica")]
        CostaRica,
        [Display(Name = "Cote D'ivoire")]
        CoteDivoire,
        Croatia,
        Cuba,
        Curaçao,
        Cyprus,
        [Display(Name = "Czech Republic")]
        CzechRepublic,
        Denmark,
        Djibouti,
        Dominica,
        [Display(Name = "Dominican Republic")]
        DominicanRepublic,
        Ecuador,
        Egypt,
        [Display(Name = "El Salvador")]
        ElSalvador,
        [Display(Name = "Equatorial Guinea")]
        EquatorialGuinea,
        Eritrea,
        Estonia,
        Ethiopia,
        [Display(Name = "Falkland Islands (Malvinas)")]
        FalklandIslandsMalvinas,
        [Display(Name = "Faroe Islands")]
        FaroeIslands,
        Fiji,
        Finland,
        France,
        [Display(Name = "French Guiana")]
        FrenchGuiana,
        [Display(Name = "French Polynesia")]
        FrenchPolynesia,
        [Display(Name = "French Southern Territories")]
        FrenchSouthernTerritories,
        Gabon,
        Gambia,
        Georgia,
        Germany,
        Ghana,
        Gibraltar,
        Greece,
        Greenland,
        Grenada,
        Guadeloupe,
        Guam,
        Guatemala,
        Guernsey,
        Guinea,
        [Display(Name = "Guinea-bissau")]
        Guineabissau,
        Guyana,
        Haiti,
        [Display(Name = "Heard Island and Mcdonald Islands")]
        HeardIslandandMcdonaldIslands,
        [Display(Name = "Holy See (Vatican City State)")]
        HolySeeVaticanCityState,
        Honduras,
        [Display(Name = "Hong Kong")]
        HongKong,
        Hungary,
        Iceland,
        India,
        Indonesia,
        [Display(Name = "Iran, Islamic Republic of")]
        IranIslamicRepublicof,
        Iraq,
        Ireland,
        [Display(Name = "Isle of Man")]
        IsleofMan,
        Israel,
        Italy,
        Jamaica,
        Japan,
        Jersey,
        Jordan,
        Kazakhstan,
        Kenya,
        Kiribati,
        [Display(Name = "Korea, Democratic People's Republic of")]
        KoreaDemocraticPeoplesRepublicof,
        [Display(Name = "Korea, Republic of")]
        KoreaRepublicof,
        Kuwait,
        Kyrgyzstan,
        [Display(Name = "Lao People's Democratic Republic")]
        LaoPeoplesDemocraticRepublic,
        Latvia,
        Lebanon,
        Lesotho,
        Liberia,
        [Display(Name = "Libyan Arab Jamahiriya")]
        LibyanArabJamahiriya,
        Liechtenstein,
        Lithuania,
        Luxembourg,
        Macao,
        [Display(Name = "Macedonia, The Former Yugoslav Republic of")]
        MacedoniaTheFormerYugoslavRepublicof,
        Madagascar,
        Malawi,
        Malaysia,
        Maldives,
        Mali,
        Malta,
        [Display(Name = "Marshall Islands")]
        MarshallIslands,
        Martinique,
        Mauritania,
        Mauritius,
        Mayotte,
        Mexico,
        [Display(Name = "Micronesia, Federated States of")]
        MicronesiaFederatedStatesof,
        [Display(Name = "Moldova, Republic of")]
        MoldovaRepublicof,
        Monaco,
        Mongolia,
        Montenegro,
        Montserrat,
        Morocco,
        Mozambique,
        Myanmar,
        Namibia,
        Nauru,
        Nepal,
        Netherlands,
        [Display(Name = "New Caledonia")]
        NewCaledonia,
        [Display(Name = "New Zealand")]
        NewZealand,
        Nicaragua,
        Niger,
        Nigeria,
        Niue,
        [Display(Name = "Norfolk Island")]
        NorfolkIsland,
        [Display(Name = "Northern Mariana Islands")]
        NorthernMarianaIslands,
        Norway,
        Oman,
        Pakistan,
        Palau,
        [Display(Name = "Palestinian Territory, Occupied")]
        PalestinianTerritoryOccupied,
        Panama,
        [Display(Name = "Papua New Guinea")]
        PapuaNewGuinea,
        Paraguay,
        Peru,
        Philippines,
        Pitcairn,
        Poland,
        Portugal,
        [Display(Name = "Puerto Rico")]
        PuertoRico,
        Qatar,
        Reunion,
        Romania,
        Russia,
        Rwanda,
        [Display(Name = "Saint Helena")]
        SaintHelena,
        [Display(Name = "Saint Kitts and Nevis")]
        SaintKittsandNevis,
        [Display(Name = "Saint Lucia")]
        SaintLucia,
        [Display(Name = "Saint Pierre and Miquelon")]
        SaintPierreandMiquelon,
        [Display(Name = "Saint Vincent and The Grenadines")]
        SaintVincentandTheGrenadines,
        Samoa,
        [Display(Name = "San Marino")]
        SanMarino,
        [Display(Name = "Sao Tome and Principe")]
        SaoTomeandPrincipe,
        [Display(Name = "Saudi Arabia")]
        SaudiArabia,
        Senegal,
        Serbia,
        Seychelles,
        [Display(Name = "Sierra Leone")]
        SierraLeone,
        Singapore,
        Slovakia,
        Slovenia,
        [Display(Name = "Solomon Islands")]
        SolomonIslands,
        Somalia,
        [Display(Name = "South Africa")]
        SouthAfrica,
        [Display(Name = "South Georgia and The South Sandwich Islands")]
        SouthGeorgiaandTheSouthSandwichIslands,
        Spain,
        [Display(Name = "Sri Lanka")]
        SriLanka,
        Sudan,
        Suriname,
        [Display(Name = "Svalbard and Jan Mayen")]
        SvalbardandJanMayen,
        Eswatini,
        Sweden,
        Switzerland,
        [Display(Name = "Syrian Arab Republic")]
        SyrianArabRepublic,
        [Display(Name = "Taiwan (ROC)")]
        TaiwanROC,
        Tajikistan,
        [Display(Name = "Tanzania, United Republic of")]
        TanzaniaUnitedRepublicof,
        Thailand,
        [Display(Name = "Timor-leste")]
        Timorleste,
        Togo,
        Tokelau,
        Tonga,
        [Display(Name = "Trinidad and Tobago")]
        TrinidadandTobago,
        Tunisia,
        Turkey,
        Turkmenistan,
        [Display(Name = "Turks and Caicos Islands")]
        TurksandCaicosIslands,
        Tuvalu,
        Uganda,
        Ukraine,
        [Display(Name = "United Arab Emirates")]
        UnitedArabEmirates,
        [Display(Name = "United Kingdom")]
        UnitedKingdom,
        [Display(Name = "United States")]
        UnitedStates,
        [Display(Name = "United States Minor Outlying Islands")]
        UnitedStatesMinorOutlyingIslands,
        Uruguay,
        Uzbekistan,
        Vanuatu,
        Venezuela,
        Vietnam,
        [Display(Name = "Virgin Islands, British")]
        VirginIslandsBritish,
        [Display(Name = "Virgin Islands, U.S.")]
        VirginIslandsUS,
        [Display(Name = "Wallis and Futuna")]
        WallisandFutuna,
        [Display(Name = "Western Sahara")]
        WesternSahara,
        Yemen,
        Zambia,
        Zimbabwe
    }
}
