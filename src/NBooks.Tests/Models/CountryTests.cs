//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using NUnit.Framework;

namespace NBooks.Tests.Models
{
	[TestFixture]
	public class CountryTests
	{
		[Test]
        public void TestPhilippineProvinces()
        {
            string states = @"Abra	ABR
Agusan del Norte	AGN
Agusan del Sur	AGS
Aklan	AKL
Albay	ALB
Antique	ANT
Apayao	APA
Aurora	AUR
Basilan	BAS
Bataan	BAN
Batanes	BTN
Batangas	BTG
Benguet	BEN
Biliran	BIL
Bohol	BOH
Bukidnon	BUK
Bulacan	BUL
Cagayan	CAG
Camarines Norte	CAN
Camarines Sur	CAS
Camiguin	CAM
Capiz	CAP
Catanduanes	CAT
Cavite	CAV
Cebu	CEB
Compostela Valley	COM
Cotabato	NCO
Davao del Norte	DAV
Davao del Sur	DAS
Davao Oriental	DAO
Eastern Samar	EAS
Guimaras	GUI
Ifugao	IFU
Ilocos Norte	ILN
Ilocos Sur	ILS
Iloilo	ILI
Isabela	ISA
Kalinga	KAL
Laguna	LAG
Lanao del Norte	LAN
Lanao del Sur	LAS
La Union	LUN
Leyte	LEY
Maguindanao	MAG
Marinduque	MAD
Masbate	MAS
Metropolitan Manila	MNL (2)
Misamis Occidental	MSC
Misamis Oriental	MSR
Mountain	MOU
Negros Occidental	NEC
Negros Oriental	NER
Northern Samar	NSA
Nueva Ecija	NUE
Nueva Vizcaya	NUV
Occidental Mindoro	MDC
Oriental Mindoro	MDR
Palawan	PLW
Pampanga	PAM
Pangasinan	PAN
Quezon	QUE
Quirino	QUI
Rizal	RIZ
Romblon	ROM
Samar	WSA
Sarangani	SAR
Siquijor	SIG
Sorsogon	SOR
South Cotabato	SCO
Southern Leyte	SLE
Sultan Kudarat	SUK
Sulu	SLU
Surigao del Norte	SUN
Surigao del Sur	SUR
Tarlac	TAR
Tawi-Tawi	TAW
Zambales	ZMB
Zamboanga del Norte	ZAN
Zamboanga del Sur	ZAS
Zamboanga-Sibugay	ZSI
";
            foreach (string s in states.Trim().Split('\n')) {
                string[] ss = s.Trim().Split('\t');
                Console.WriteLine("insert into states(country_id, long_name, short_name) values(172, '{0}', '{1}');", ss[0], ss[1]);
            }
        }

        [Test]
        public void TestCountries()
        {
            string countries = @"AF;Afghanistan
AL;Albania
DZ;Algeria
AS;American Samoa
AD;Andorra
AO;Angola
AI;Anguilla
AQ;Antarctica
AG;Antigua And Barbuda
AR;Argentina
AM;Armenia
AW;Aruba
AU;Australia
AT;Austria
AZ;Azerbaijan
BS;Bahamas
BH;Bahrain
BD;Bangladesh
BB;Barbados
BY;Belarus
BE;Belgium
BZ;Belize
BJ;Benin
BM;Bermuda
BT;Bhutan
BO;Bolivia
BA;Bosnia And Herzegovina
BW;Botswana
BV;Bouvet Island
BR;Brazil
IO;British Indian Ocean Territory
VG;British Virgin Islands
BN;Brunei Darussalam
BG;Bulgaria
BF;Burkina Faso
BI;Burundi
KH;Cambodia
CM;Cameroon
CA;Canada
CV;Cape Verde
KY;Cayman Islands
CF;Central African Republic
TD;Chad
CL;Chile
CN;China
CX;Christmas Island
CC;Cocos (Keeling) Islands
CO;Colombia
KM;Comoros
CG;Congo
CD;Congo, The Democratic Republic Of
CK;Cook Islands
CR;Costa Rica
HR;Croatia
CU;Cuba
CY;Cyprus
CZ;Czech Republic
DK;Denmark
DJ;Djibouti
DM;Dominica
DO;Dominican Republic
TP;East Timor
EC;Ecuador
EG;Egypt
SV;El Salvador
GQ;Equatorial Guinea
ER;Eritrea
EE;Estonia
ET;Ethiopia
FK;Falkland Islands (Malvinas)
FO;Faroe Islands
FJ;Fiji
FI;Finland
FR;France
GF;French Guiana
PF;French Polynesia
TF;French Southern Territories
GA;Gabon
GM;Gambia
GE;Georgia
DE;Germany
GH;Ghana
GI;Gibraltar
GR;Greece
GL;Greenland
GD;Grenada
GP;Guadeloupe
GU;Guam
GT;Guatemala
GN;Guinea
GW;Guinea-Bissau
GY;Guyana
HT;Haiti
HM;Heard Island And Mcdonald Islands
VA;Holy See (Vatican City State)
HN;Honduras
HK;Hong Kong
HU;Hungary
IS;Iceland
IN;India
ID;Indonesia
IR;Iran
IQ;Iraq
IE;Ireland
IL;Israel
IT;Italy
CI;Ivory Coast
JM;Jamaica
JP;Japan
JO;Jordan
KZ;Kazakhstan
KE;Kenya
KI;Kiribati
KP;Korea, Democratic Peoples Republic Of
KR;Korea, Republic Of
KW;Kuwait
KG;Kyrgyzstan
LA;Laos
LV;Latvia
LB;Lebanon
LS;Lesotho
LR;Liberia
LY;Libyan Arab Jamahiriya
LI;Liechtenstein
LT;Lithuania
LU;Luxembourg
MO;Macao
MK;Macedonia, Former Yugoslav Republic Of
MG;Madagascar
MW;Malawi
MY;Malaysia
MV;Maldives
ML;Mali
MT;Malta
MH;Marshall Islands
MQ;Martinique
MR;Mauritania
MU;Mauritius
YT;Mayotte
MX;Mexico
FM;Micronesia, Federated States Of
MD;Moldova
MC;Monaco
MN;Mongolia
ME;Montenegro
MS;Montserrat
MA;Morocco
MZ;Mozambique
MM;Myanmar
NA;Namibia
NR;Nauru
NP;Nepal
NL;Netherlands
AN;Netherlands Antilles
NC;New Caledonia
NZ;New Zealand
NI;Nicaragua
NE;Niger
NG;Nigeria
NU;Niue
NF;Norfolk Island
MP;Northern Mariana Islands
NO;Norway
OM;Oman
PK;Pakistan
PW;Palau
PS;Palestinian Territories
PA;Panama
PG;Papua New Guinea
PY;Paraguay
PE;Peru
PH;Philippines
PN;Pitcairn
PL;Poland
PT;Portugal
PR;Puerto Rico
QA;Qatar
RE;Reunion
RO;Romania
RU;Russian Federation
RW;Rwanda
SH;Saint Helena
KN;Saint Kitts And Nevis
LC;Saint Lucia
PM;Saint Pierre And Miquelon
VC;Saint Vincent And The Grenadines
WS;Samoa
SM;San Marino
ST;Sao Tome And Principe
SA;Saudi Arabia
SN;Senegal
RS;Serbia
SC;Seychelles
SL;Sierra Leone
SG;Singapore
SK;Slovakia
SI;Slovenia
SB;Solomon Islands
SO;Somalia
ZA;South Africa
GS;South Georgia And The South Sandwich Islands 
ES;Spain
LK;Sri Lanka
SD;Sudan
SR;Suriname
SJ;Svalbard And Jan Mayen
SZ;Swaziland
SE;Sweden
CH;Switzerland
SY;Syria
TW;Taiwan
TJ;Tajikistan
TZ;Tanzania
TH;Thailand
TL;Timor-Leste
TG;Togo
TK;Tokelau
TO;Tonga
TT;Trinidad And Tobago
TN;Tunisia
TR;Turkey
TM;Turkmenistan
TC;Turks And Caicos Islands
TV;Tuvalu
UG;Uganda
UA;Ukraine
AE;United Arab Emirates
UK;United Kingdom
US;United States
UY;Uruguay
UM;U.S. Minor Outlying Islands
VI;U.S. Virgin Islands
UZ;Uzbekistan
VU;Vanuatu
VE;Venezuela
VN;Viet Nam
WF;Wallis And Futuna
EH;Western Sahara
YE;Yemen
ZM;Zambia
ZW;Zimbabwe
";
            foreach (string s in countries.Trim().Split('\n')) {
                string[] ss = s.Split(';');
                if (ss.Length > 1) {
                    Console.WriteLine("insert into countries(short_name, long_name, inactive) values('{0}', '{1}', 0);", ss[0].Trim(), ss[1].Trim());
                } else {
                    Console.WriteLine("<<<<< " + s + " >>>>>");
                }
            }
        }
	}
}
