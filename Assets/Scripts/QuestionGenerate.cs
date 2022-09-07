using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGenerate : MonoBehaviour
{

    public static string actualAnswer;
    public static bool displayingQuestion = false;
    public int questionNumber;


    // Update is called once per frame
    void Update()
    {
        if (displayingQuestion == false)
        {
            displayingQuestion = true;
            questionNumber = Random.Range(1, 101);

            if (questionNumber == 1)
            {
                QuestionDisplay.newQuestion = "Ljudi, pa je li to moguce?! Izgovorio je koji poznati komentator?";
                QuestionDisplay.newA = "Mladen Delic";
                QuestionDisplay.newB = "Drago Cosic";
                QuestionDisplay.newC = "Viki Ivanovic";
                QuestionDisplay.newD = "Bozo Susec";
                actualAnswer = "A";
            }

            if (questionNumber == 2)
            {
                QuestionDisplay.newQuestion = "U kojem gradu je rodjen Drazen Ladic?";
                QuestionDisplay.newA = "Zagreb";
                QuestionDisplay.newB = "Cakovec";
                QuestionDisplay.newC = "Varazdin";
                QuestionDisplay.newD = "Krapina";
                actualAnswer = "B";
            }

            if (questionNumber == 3)
            {
                QuestionDisplay.newQuestion = "Koja NBA fransiza je prva u povijesti potpisala tamnoputog igraca?";
                QuestionDisplay.newA = "Brooklyn Nets";
                QuestionDisplay.newB = "Philadelphia 76ers";
                QuestionDisplay.newC = "Boston Celtics";
                QuestionDisplay.newD = "Chicago Bulls";
                actualAnswer = "C";
            }

            if (questionNumber == 4)
            {
                QuestionDisplay.newQuestion = "Koliko minuta traje regularni dio utakmice u hokeju na ledu?";
                QuestionDisplay.newA = "30";
                QuestionDisplay.newB = "90";
                QuestionDisplay.newC = "45";
                QuestionDisplay.newD = "60";
                actualAnswer = "D";
            }

            if (questionNumber == 5)
            {
                QuestionDisplay.newQuestion = "U kojoj drzavi su odrzane prve azijske zimske olimpijske igre?";
                QuestionDisplay.newA = "Japan";
                QuestionDisplay.newB = "Juzna Koreja";
                QuestionDisplay.newC = "Kina";
                QuestionDisplay.newD = "Sjeverna Koreja";
                actualAnswer = "A";
            }

            if (questionNumber == 6)
            {
                QuestionDisplay.newQuestion = "Tko je prvi nosio hrvatsku zastavu na olimpijskim igrama 1992.?";
                QuestionDisplay.newA = "Drazen Petrovic";
                QuestionDisplay.newB = "Goran Ivanisevic";
                QuestionDisplay.newC = "Zoran Primorac";
                QuestionDisplay.newD = "Toni Kukoc";
                actualAnswer = "B";
            }

            if (questionNumber == 7)
            {
                QuestionDisplay.newQuestion = "Kako se zvao stadion na kojem je arsenal igrao do 7.5.2006.?";
                QuestionDisplay.newA = "Emirates";
                QuestionDisplay.newB = "Hillsborough Stadium";
                QuestionDisplay.newC = "Highbury";
                QuestionDisplay.newD = "DW Stadium";
                actualAnswer = "C";
            }

            if (questionNumber == 8)
            {
                QuestionDisplay.newQuestion = "Kojem je plemenu pripadao indijanski poglavica Bik Koji Sjedi?";
                QuestionDisplay.newA = "Cherokee";
                QuestionDisplay.newB = "Apache";
                QuestionDisplay.newC = "Cheyenne";
                QuestionDisplay.newD = "Sioux";
                actualAnswer = "D";
            }
            if (questionNumber == 9)
            {
                QuestionDisplay.newQuestion = "Koja je drzava okupirala Etiopsko kraljestvo 1935?";
                QuestionDisplay.newA = "Italija";
                QuestionDisplay.newB = "Njemacka";
                QuestionDisplay.newC = "Portugal";
                QuestionDisplay.newD = "Francuska";
                actualAnswer = "A";
            }

            if (questionNumber == 10)
            {
                QuestionDisplay.newQuestion = "Koje je godine Republika Hrvatska postala clanica Europske Unije?";
                QuestionDisplay.newA = "2012";
                QuestionDisplay.newB = "2013";
                QuestionDisplay.newC = "2011";
                QuestionDisplay.newD = "2014";
                actualAnswer = "B";
            }

            if (questionNumber == 11)
            {
                QuestionDisplay.newQuestion = "Koga je casopis Time 1938. izabrao kao osobu godine?";
                QuestionDisplay.newA = "Josif Staljin";
                QuestionDisplay.newB = "Winston Churchill";
                QuestionDisplay.newC = "Adolf Hitler";
                QuestionDisplay.newD = "Franklin D. Roosevelt";
                actualAnswer = "C";
            }

            if (questionNumber == 12)
            {
                QuestionDisplay.newQuestion = "U kojem stoljecu se vodio Cetvrti habsbursko-turski rat?";
                QuestionDisplay.newA = "18.";
                QuestionDisplay.newB = "15.";
                QuestionDisplay.newC = "17.";
                QuestionDisplay.newD = "16.";
                actualAnswer = "D";
            }

            if (questionNumber == 13)
            {
                QuestionDisplay.newQuestion = "Koja tvrtka je bila strateski partner Sisacke rafinerije?";
                QuestionDisplay.newA = "Shell";
                QuestionDisplay.newB = "BP";
                QuestionDisplay.newC = "ExxonMobil";
                QuestionDisplay.newD = "Chevron Texaco";
                actualAnswer = "A";
            }

            if (questionNumber == 14)
            {
                QuestionDisplay.newQuestion = "Koje godine je Vladimir Putin postao predsjednik Ruske Federacije?";
                QuestionDisplay.newA = "1999.";
                QuestionDisplay.newB = "2000.";
                QuestionDisplay.newC = "2001.";
                QuestionDisplay.newD = "2002.";
                actualAnswer = "B";
            }

            if (questionNumber == 15)
            {
                QuestionDisplay.newQuestion = "Kako se zvao najgori hrvatski knez ? ";
                QuestionDisplay.newA = "Ratimir";
                QuestionDisplay.newB = "Borna";
                QuestionDisplay.newC = "Domagoj";
                QuestionDisplay.newD = "Branimir";
                actualAnswer = "C";
            }

            if (questionNumber == 16)
            {
                QuestionDisplay.newQuestion = "Koji ruski car je osnovao Sankt Peterburg?";
                QuestionDisplay.newA = "Ivan Grozni";
                QuestionDisplay.newB = "Fjodor 3.";
                QuestionDisplay.newC = "Nikola";
                QuestionDisplay.newD = "Petar Veliki";
                actualAnswer = "D";
            }

            if (questionNumber == 17)
            {
                QuestionDisplay.newQuestion = "Kako se zvala najpoznatija cizma za mucenje?";
                QuestionDisplay.newA = "Spanjolska cizma";
                QuestionDisplay.newB = "Portugalska cizma";
                QuestionDisplay.newC = "Francuska cizma";
                QuestionDisplay.newD = "Belgijska cizma";
                actualAnswer = "A";
            }

            if (questionNumber == 18)
            {
                QuestionDisplay.newQuestion = "Koja rijeka protjece kroz glavni grad Ukrajine?";
                QuestionDisplay.newA = "Dunav";
                QuestionDisplay.newB = "Dnjepar";
                QuestionDisplay.newC = "Pripjat";
                QuestionDisplay.newD = "Desna";
                actualAnswer = "B";
            }

            if (questionNumber == 19)
            {
                QuestionDisplay.newQuestion = "Koja rijeka protjece kroz glavni grad Njemacke?";
                QuestionDisplay.newA = "Dunav";
                QuestionDisplay.newB = "Rajna";
                QuestionDisplay.newC = "Isar";
                QuestionDisplay.newD = "Spree";
                actualAnswer = "C";
            }

            if (questionNumber == 20)
            {
                QuestionDisplay.newQuestion = "Koja rijeka protjece kroz Munchen?";
                QuestionDisplay.newA = "Rajna";
                QuestionDisplay.newB = "Spree";
                QuestionDisplay.newC = "Dunav";
                QuestionDisplay.newD = "Isar";
                actualAnswer = "D";
            }

            if (questionNumber == 21)
            {
                QuestionDisplay.newQuestion = " Koja rijeka protjece kroz glavni grad Francuske?";
                QuestionDisplay.newA = "Seine";
                QuestionDisplay.newB = "Loire";
                QuestionDisplay.newC = "Rhone";
                QuestionDisplay.newD = "Rajna";
                actualAnswer = "A";
            }

            if (questionNumber == 22)
            {
                QuestionDisplay.newQuestion = "Koja rijeka protice kroz Zagreb?";
                QuestionDisplay.newA = "Drava";
                QuestionDisplay.newB = "Sava";
                QuestionDisplay.newC = "Dunav";
                QuestionDisplay.newD = "Ombla";
                actualAnswer = "B";
            }

            if (questionNumber == 23)
            {
                QuestionDisplay.newQuestion = "Koja rijeka protice Kroz London?";
                QuestionDisplay.newA = "Trent";
                QuestionDisplay.newB = "Tyne";
                QuestionDisplay.newC = "Temza";
                QuestionDisplay.newD = "Mersey";
                actualAnswer = "C";
            }

            if (questionNumber == 24)
            {
                QuestionDisplay.newQuestion = "U kojoj drzavi se nalazi najvise vulkana?";
                QuestionDisplay.newA = "Japan";
                QuestionDisplay.newB = "Rusija";
                QuestionDisplay.newC = "Cile";
                QuestionDisplay.newD = "Indonezija";
                actualAnswer = "D";
            }
            if (questionNumber == 25)
            {
                QuestionDisplay.newQuestion = "Koji proizvod  je izumio kemicar Norm Larsen?";
                QuestionDisplay.newA = "WD40";
                QuestionDisplay.newB = "Dinamit";
                QuestionDisplay.newC = "Aspirin";
                QuestionDisplay.newD = "Sumamed";
                actualAnswer = "A";
            }

            if (questionNumber == 26)
            {
                QuestionDisplay.newQuestion = "Kako se zove znanstvenik koji je 1801. godine otkrio ultraljubicasto zracenje?";
                QuestionDisplay.newA = "Carl Gauss";
                QuestionDisplay.newB = "Johann Wilhem Ritter";
                QuestionDisplay.newC = "Otto Hahn";
                QuestionDisplay.newD = "Robert Koch";
                actualAnswer = "B";
            }

            if (questionNumber == 27)
            {
                QuestionDisplay.newQuestion = "Iz koje pjesme dolaze stihovi: Stigla je sama sa ljetom, prisla i rekla hello?";
                QuestionDisplay.newA = "Ma daj obuci levisice";
                QuestionDisplay.newB = "Loli me voli";
                QuestionDisplay.newC = "Dzuli";
                QuestionDisplay.newD = "Opasna si kao droga";
                actualAnswer = "C";
            }

            if (questionNumber == 28)
            {
                QuestionDisplay.newQuestion = "Gdje je Arsen Dedic smjestio brod u imenu svoje prve zbirke pjesama?";
                QuestionDisplay.newA = "U more";
                QuestionDisplay.newB = "U rijeku";
                QuestionDisplay.newC = "U jezero";
                QuestionDisplay.newD = "U bocu";
                actualAnswer = "D";
            }
            if (questionNumber == 29)
            {
                QuestionDisplay.newQuestion = "Na kojem nasem otoku se Odisej zaljubio u Kalipso?";
                QuestionDisplay.newA = "Mljet";
                QuestionDisplay.newB = "Hvar";
                QuestionDisplay.newC = "Korcula";
                QuestionDisplay.newD = "Brac";
                actualAnswer = "A";
            }

            if (questionNumber == 30)
            {
                QuestionDisplay.newQuestion = "Majka Tereza je osim Albanskog imala i drzavljanstvo koje zemlje?";
                QuestionDisplay.newA = "Italije";
                QuestionDisplay.newB = "Indije";
                QuestionDisplay.newC = "Hrvatske";
                QuestionDisplay.newD = "Vatikana";
                actualAnswer = "B";
            }

            if (questionNumber == 31)
            {
                QuestionDisplay.newQuestion = "U kojem gradu je osnovan poljski sindikalni pokret Solidarnost 1980. godine?";
                QuestionDisplay.newA = "Szczecin";
                QuestionDisplay.newB = "Krakow";
                QuestionDisplay.newC = "Gdanjsk";
                QuestionDisplay.newD = "Varsava";
                actualAnswer = "C";
            }

            if (questionNumber == 32)
            {
                QuestionDisplay.newQuestion = "U kojem je gradu smjestena glavna tvornica i sjediste autokompanije Peugeot?";
                QuestionDisplay.newA = "Lille";
                QuestionDisplay.newB = "Paris";
                QuestionDisplay.newC = "Bordeaux";
                QuestionDisplay.newD = "Sochaux";
                actualAnswer = "D";
            }
            if (questionNumber == 29)
            {
                QuestionDisplay.newQuestion = "U kojem je gradu smjestena glavna tvornica i sjediste autokompanije Audi?";
                QuestionDisplay.newA = "Ingolstadt";
                QuestionDisplay.newB = "Munchen";
                QuestionDisplay.newC = "Frankfurt";
                QuestionDisplay.newD = "Darmstadt";
                actualAnswer = "A";
            }

            if (questionNumber == 30)
            {
                QuestionDisplay.newQuestion = "U kojem je gradu smjestena glavna tvornica i sjediste autokompanije BMW?";
                QuestionDisplay.newA = "Ingolstadt";
                QuestionDisplay.newB = "Munchen";
                QuestionDisplay.newC = "Stuttgart";
                QuestionDisplay.newD = "Dortmund";
                actualAnswer = "B";
            }

            if (questionNumber == 31)
            {
                QuestionDisplay.newQuestion = "U kojem je gradu smjestena glavna tvornica i sjediste autokompanije Mercedes Benz?";
                QuestionDisplay.newA = "Mannheim";
                QuestionDisplay.newB = "Berlin";
                QuestionDisplay.newC = "Stuttgart";
                QuestionDisplay.newD = "Ulm";
                actualAnswer = "C";
            }

            if (questionNumber == 32)
            {
                QuestionDisplay.newQuestion = "U kojem je gradu smjestena glavna tvornica i sjediste autokompanije Opel?";
                QuestionDisplay.newA = "Munchen";
                QuestionDisplay.newB = "Stuttgart";
                QuestionDisplay.newC = "Berlin";
                QuestionDisplay.newD = "Russelheim am Main";
                actualAnswer = "D";
            }
            if (questionNumber == 33)
            {
                QuestionDisplay.newQuestion = "U kojem je gradu smjestena glavna tvornica i sjediste autokompanije Porsche?";
                QuestionDisplay.newA = "Stuttgart";
                QuestionDisplay.newB = "Berlin";
                QuestionDisplay.newC = "Frankfurt";
                QuestionDisplay.newD = "Darmstadt";
                actualAnswer = "A";
            }

            if (questionNumber == 34)
            {
                QuestionDisplay.newQuestion = "U kojem je gradu smjestena glavna tvornica i sjediste autokompanije Volkswagen?";
                QuestionDisplay.newA = "Ingolstadt";
                QuestionDisplay.newB = "Wolfsburg";
                QuestionDisplay.newC = "Stuttgart";
                QuestionDisplay.newD = "Dortmund";
                actualAnswer = "B";
            }

            if (questionNumber == 35)
            {
                QuestionDisplay.newQuestion = "U kojem je gradu smjestena glavna tvornica i sjediste autokompanije Alfa Romeo?";
                QuestionDisplay.newA = "Rim";
                QuestionDisplay.newB = "Milano";
                QuestionDisplay.newC = "Torino";
                QuestionDisplay.newD = "Bolonja";
                actualAnswer = "C";
            }

            if (questionNumber == 36)
            {
                QuestionDisplay.newQuestion = "U kojem je gradu smjestena glavna tvornica i sjediste autokompanije Ferrari?";
                QuestionDisplay.newA = "Bolonja";
                QuestionDisplay.newB = "Torino";
                QuestionDisplay.newC = "Rim";
                QuestionDisplay.newD = "Maranello";
                actualAnswer = "D";
            }
            if (questionNumber == 37)
            {
                QuestionDisplay.newQuestion = "U kojem je gradu smjestena glavna tvornica i sjediste autokompanije Fiat?";
                QuestionDisplay.newA = "Torino";
                QuestionDisplay.newB = "Milano";
                QuestionDisplay.newC = "Venecija";
                QuestionDisplay.newD = "Napulj";
                actualAnswer = "A";
            }

            if (questionNumber == 38)
            {
                QuestionDisplay.newQuestion = "U kojem je gradu smjestena glavna tvornica i sjediste autokompanije Maserati?";
                QuestionDisplay.newA = "Rim";
                QuestionDisplay.newB = "Bolonja";
                QuestionDisplay.newC = "Verona";
                QuestionDisplay.newD = "Palermo";
                actualAnswer = "B";
            }

            if (questionNumber == 39)
            {
                QuestionDisplay.newQuestion = "U kojem je gradu smjestena glavna tvornica i sjediste autokompanije Honda?";
                QuestionDisplay.newA = "Kyoto";
                QuestionDisplay.newB = "Osaka";
                QuestionDisplay.newC = "Tokio";
                QuestionDisplay.newD = "Yokohama";
                actualAnswer = "C";
            }

            if (questionNumber == 40)
            {
                QuestionDisplay.newQuestion = "U kojem je gradu smjestena glavna tvornica i sjediste autokompanije Mazda?";
                QuestionDisplay.newA = "Kobe";
                QuestionDisplay.newB = "Sapporo";
                QuestionDisplay.newC = "Nagoja";
                QuestionDisplay.newD = "Fuchu";
                actualAnswer = "D";
            }
            if (questionNumber == 41)
            {
                QuestionDisplay.newQuestion = "U kojem je gradu smjestena glavna tvornica i sjediste autokompanije Mitsubishi?";
                QuestionDisplay.newA = "Tokio";
                QuestionDisplay.newB = "Osaka";
                QuestionDisplay.newC = "Yokohama";
                QuestionDisplay.newD = "Nagasaki";
                actualAnswer = "A";
            }

            if (questionNumber == 42)
            {
                QuestionDisplay.newQuestion = "U kojem je gradu smjestena glavna tvornica i sjediste autokompanije Nissan?";
                QuestionDisplay.newA = "Fuchu";
                QuestionDisplay.newB = "Yokohama";
                QuestionDisplay.newC = "Sapporo";
                QuestionDisplay.newD = "Chiba";
                actualAnswer = "B";
            }

            if (questionNumber == 43)
            {
                QuestionDisplay.newQuestion = "U kojem je gradu smjestena glavna tvornica i sjediste autokompanije Suzuki?";
                QuestionDisplay.newA = "Kyoto";
                QuestionDisplay.newB = "Osaka";
                QuestionDisplay.newC = "Hamamatsu";
                QuestionDisplay.newD = "Yokohama";
                actualAnswer = "C";
            }

            if (questionNumber == 44)
            {
                QuestionDisplay.newQuestion = "U kojem je gradu smjestena glavna tvornica i sjediste autokompanije Toyota?";
                QuestionDisplay.newA = "Kobe";
                QuestionDisplay.newB = "Sapporo";
                QuestionDisplay.newC = "Nagoja";
                QuestionDisplay.newD = "Toyota";
                actualAnswer = "D";
            }
            if (questionNumber == 45)
            {
                QuestionDisplay.newQuestion = "U kojem je gradu smjestena glavna tvornica i sjediste autokompanije Cadillac?";
                QuestionDisplay.newA = "Warren";
                QuestionDisplay.newB = "Detroit";
                QuestionDisplay.newC = "Austin";
                QuestionDisplay.newD = "Nashville";
                actualAnswer = "A";
            }

            if (questionNumber == 46)
            {
                QuestionDisplay.newQuestion = "U kojem je gradu smjestena glavna tvornica i sjediste autokompanije Jeep?";
                QuestionDisplay.newA = "New York";
                QuestionDisplay.newB = "Toledo";
                QuestionDisplay.newC = "Los Angeles";
                QuestionDisplay.newD = "San Francisco";
                actualAnswer = "B";
            }

            if (questionNumber == 47)
            {
                QuestionDisplay.newQuestion = "U kojem je gradu smjestena glavna tvornica i sjediste autokompanije Ford?";
                QuestionDisplay.newA = "Phoenix";
                QuestionDisplay.newB = "Boston";
                QuestionDisplay.newC = "Dearborn";
                QuestionDisplay.newD = "Indianapolis";
                actualAnswer = "C";
            }

            if (questionNumber == 48)
            {
                QuestionDisplay.newQuestion = "U kojem je gradu smjestena glavna tvornica i sjediste autokompanije Hyundai?";
                QuestionDisplay.newA = "Busan";
                QuestionDisplay.newB = "Daegu";
                QuestionDisplay.newC = "Incheon";
                QuestionDisplay.newD = "Seul";
                actualAnswer = "D";
            }
            if (questionNumber == 49)
            {
                QuestionDisplay.newQuestion = "U kojem je gradu smjestena glavna tvornica i sjediste autokompanije Kia?";
                QuestionDisplay.newA = "Seul";
                QuestionDisplay.newB = "Ulsan";
                QuestionDisplay.newC = "Kwangju";
                QuestionDisplay.newD = "Busan";
                actualAnswer = "A";
            }

            if (questionNumber == 50)
            {
                QuestionDisplay.newQuestion = "U kojem je gradu smjestena Crvena zastava industrijski gigant Jugoslavije?";
                QuestionDisplay.newA = "Beograd";
                QuestionDisplay.newB = "Kragujevac";
                QuestionDisplay.newC = "Cacak";
                QuestionDisplay.newD = "Novi Sad";
                actualAnswer = "B";
            }

            if (questionNumber == 51)
            {
                QuestionDisplay.newQuestion = "Koje godine se poceo proizvoditi legendarni Commodore 64?";
                QuestionDisplay.newA = "1980.";
                QuestionDisplay.newB = "1981.";
                QuestionDisplay.newC = "1982.";
                QuestionDisplay.newD = "1983.";
                actualAnswer = "C";
            }

            if (questionNumber == 52)
            {
                QuestionDisplay.newQuestion = "Koliki je zbroj svih znamenki na ruletu?";
                QuestionDisplay.newA = "333";
                QuestionDisplay.newB = "444";
                QuestionDisplay.newC = "555";
                QuestionDisplay.newD = "666";
                actualAnswer = "D";
            }
            if (questionNumber == 53)
            {
                QuestionDisplay.newQuestion = "Kako se zove sisavac koji ubija najvise ljudskih jedinki na crnom kontinentu?";
                QuestionDisplay.newA = "Nilski konj";
                QuestionDisplay.newB = "Komarac";
                QuestionDisplay.newC = "Krokodil";
                QuestionDisplay.newD = "Lav";
                actualAnswer = "A";
            }

            if (questionNumber == 54)
            {
                QuestionDisplay.newQuestion = "U kojem gradu su rodjena braca Zdravko i Zoran Mamic?";
                QuestionDisplay.newA = "Zagreb";
                QuestionDisplay.newB = "Bjelovar";
                QuestionDisplay.newC = "Daruvar";
                QuestionDisplay.newD = "Garesnica";
                actualAnswer = "B";
            }

            if (questionNumber == 55)
            {
                QuestionDisplay.newQuestion = "U kojoj londonskoj ulici na broju 10, zive britanski premijeri?";
                QuestionDisplay.newA = "Abbey Road";
                QuestionDisplay.newB = "Brick Lane";
                QuestionDisplay.newC = "Downing Street";
                QuestionDisplay.newD = "Oxford Street";
                actualAnswer = "C";
            }

            if (questionNumber == 56)
            {
                QuestionDisplay.newQuestion = "Jedna od najpoznatijih western serija se zvala Mala kuca u...?";
                QuestionDisplay.newA = "pennsylvaniji";
                QuestionDisplay.newB = "kaliforniji";
                QuestionDisplay.newC = "stepi";
                QuestionDisplay.newD = "preriji";
                actualAnswer = "D";
            }
            if (questionNumber == 57)
            {
                QuestionDisplay.newQuestion = "U kojem gradu je smjestena radnja popularne kriminalisticke serije The Wire?";
                QuestionDisplay.newA = "Baltimore";
                QuestionDisplay.newB = "New York";
                QuestionDisplay.newC = "Chicago";
                QuestionDisplay.newD = "Boston";
                actualAnswer = "A";
            }

            if (questionNumber == 58)
            {
                QuestionDisplay.newQuestion = "Sto je uzrok smrti Georgea Constanze u TV seriji Seinfeld?";
                QuestionDisplay.newA = "Predoziranje tabletama";
                QuestionDisplay.newB = "Lizanje koverti";
                QuestionDisplay.newC = "Trovanje alkoholom";
                QuestionDisplay.newD = "Prometna nesreca";
                actualAnswer = "B";
            }

            if (questionNumber == 59)
            {
                QuestionDisplay.newQuestion = "Kakvo je bice Shrek, zeleni lik iz istoimenog animiranog filma?";
                QuestionDisplay.newA = "Grifon";
                QuestionDisplay.newB = "Ork";
                QuestionDisplay.newC = "Ogar";
                QuestionDisplay.newD = "Vampir";
                actualAnswer = "C";
            }

            if (questionNumber == 60)
            {
                QuestionDisplay.newQuestion = "List koje biljke se nalazi na zastavi Kanade?";
                QuestionDisplay.newA = "Jasena";
                QuestionDisplay.newB = "Breze";
                QuestionDisplay.newC = "Hrasta";
                QuestionDisplay.newD = "Javora";
                actualAnswer = "D";
            }
            if (questionNumber == 61)
            {
                QuestionDisplay.newQuestion = "Koliko stihova ima haiku pjesma?";
                QuestionDisplay.newA = "Tri stiha";
                QuestionDisplay.newB = "Cetiri stiha";
                QuestionDisplay.newC = "pet stihova";
                QuestionDisplay.newD = "sedam stihova";
                actualAnswer = "A";
            }

            if (questionNumber == 62)
            {
                QuestionDisplay.newQuestion = "Sto je katoptrofobija?";
                QuestionDisplay.newA = "Strah od muha";
                QuestionDisplay.newB = "Strah od zrcala";
                QuestionDisplay.newC = "Strah od stepenica";
                QuestionDisplay.newD = "Strah od komaraca";
                actualAnswer = "B";
            }

            if (questionNumber == 63)
            {
                QuestionDisplay.newQuestion = "Na kojem otoku zivi najveci broj lemura?";
                QuestionDisplay.newA = "Kostarika";
                QuestionDisplay.newB = "Sumatra";
                QuestionDisplay.newC = "Madagaskar";
                QuestionDisplay.newD = "Kreta";
                actualAnswer = "C";
            }

            if (questionNumber == 64)
            {
                QuestionDisplay.newQuestion = "Mn je simbol kojeg kemijskog elementa?";
                QuestionDisplay.newA = "Magnezij";
                QuestionDisplay.newB = "Mendelevij";
                QuestionDisplay.newC = "Molibden";
                QuestionDisplay.newD = "Mangan";
                actualAnswer = "D";
            }
            if (questionNumber == 65)
            {
                QuestionDisplay.newQuestion = "Tko je redatelj poznatog filma Titanic?";
                QuestionDisplay.newA = "James Cameron";
                QuestionDisplay.newB = "Steven Spielberg";
                QuestionDisplay.newC = "Christopher Nolan";
                QuestionDisplay.newD = "Quentin Tarantino";
                actualAnswer = "A";
            }

            if (questionNumber == 66)
            {
                QuestionDisplay.newQuestion = "U kojem gradu je rodjena Ivana Brlic Mazuranic?";
                QuestionDisplay.newA = "Slavonski Brod";
                QuestionDisplay.newB = "Ogulin";
                QuestionDisplay.newC = "Karlovac";
                QuestionDisplay.newD = "Zagreb";
                actualAnswer = "B";
            }

            if (questionNumber == 67)
            {
                QuestionDisplay.newQuestion = "Koje je boje dim koji izlazi iz dimnjaka kada je izabran novi papa?";
                QuestionDisplay.newA = "Crni dim";
                QuestionDisplay.newB = "Sivi dim";
                QuestionDisplay.newC = "Bijeli dim";
                QuestionDisplay.newD = "Plavi dim";
                actualAnswer = "C";
            }

            if (questionNumber == 68)
            {
                QuestionDisplay.newQuestion = "Kako se zove znanost koja se bavi proucanjem tla, njegova sastava i oblika?";
                QuestionDisplay.newA = "Limnologija";
                QuestionDisplay.newB = "Tropologija";
                QuestionDisplay.newC = "Ampeloekologija";
                QuestionDisplay.newD = "Pedologija";
                actualAnswer = "D";
            }
            if (questionNumber == 69)
            {
                QuestionDisplay.newQuestion = "Kisinjev je glavni grad koje drzave?";
                QuestionDisplay.newA = "Moldavije";
                QuestionDisplay.newB = "Litve";
                QuestionDisplay.newC = "Latvije";
                QuestionDisplay.newD = "Bjelorusije";
                actualAnswer = "A";
            }

            if (questionNumber == 70)
            {
                QuestionDisplay.newQuestion = "Kako se zove najveca juznokorejska tehnoloska kompanija?";
                QuestionDisplay.newA = "Hyundai";
                QuestionDisplay.newB = "Samsung";
                QuestionDisplay.newC = "SK";
                QuestionDisplay.newD = "LG";
                actualAnswer = "B";
            }

            if (questionNumber == 71)
            {
                QuestionDisplay.newQuestion = "Koji je glavni grad Portugala?";
                QuestionDisplay.newA = "Braga";
                QuestionDisplay.newB = "Porto";
                QuestionDisplay.newC = "Lisabon";
                QuestionDisplay.newD = "Coimbra";
                actualAnswer = "C";
            }

            if (questionNumber == 72)
            {
                QuestionDisplay.newQuestion = "Koje je godine izasao film Kum?";
                QuestionDisplay.newA = "1973.";
                QuestionDisplay.newB = "1974.";
                QuestionDisplay.newC = "1971.";
                QuestionDisplay.newD = "1972.";
                actualAnswer = "D";
            }
            if (questionNumber == 73)
            {
                QuestionDisplay.newQuestion = "Koja drzava dominira u sinkroniziranom plivanju na olimpijskim igrama od 2000. godine?";
                QuestionDisplay.newA = "Rusija";
                QuestionDisplay.newB = "Kina";
                QuestionDisplay.newC = "SAD";
                QuestionDisplay.newD = "Japan";
                actualAnswer = "A";
            }

            if (questionNumber == 74)
            {
                QuestionDisplay.newQuestion = "Koji klub je osvojio FA kup 1986. godine?";
                QuestionDisplay.newA = "Everton";
                QuestionDisplay.newB = "Liverpool";
                QuestionDisplay.newC = "Southampton";
                QuestionDisplay.newD = "Watford";
                actualAnswer = "B";
            }

            if (questionNumber == 75)
            {
                QuestionDisplay.newQuestion = "Koji klub je osvojio prvenstvo Jugoslavije u nogometu 1982. godine?";
                QuestionDisplay.newA = "Hajduk";
                QuestionDisplay.newB = "Crvena zvezda";
                QuestionDisplay.newC = "Dinamo";
                QuestionDisplay.newD = "Partizan";
                actualAnswer = "C";
            }

            if (questionNumber == 76)
            {
                QuestionDisplay.newQuestion = "Koliko puta je Hajduk bio prvak Jugoslavije u nogometu?";
                QuestionDisplay.newA = "6";
                QuestionDisplay.newB = "4";
                QuestionDisplay.newC = "5";
                QuestionDisplay.newD = "7";
                actualAnswer = "D";
            }
            if (questionNumber == 77)
            {
                QuestionDisplay.newQuestion = "U kojoj se drzavi nalazi Machu Picchu?";
                QuestionDisplay.newA = "Peru";
                QuestionDisplay.newB = "Bolivija";
                QuestionDisplay.newC = "Venezuela";
                QuestionDisplay.newD = "Paragvaj";
                actualAnswer = "A";
            }
            if (questionNumber == 78)
            {
                QuestionDisplay.newQuestion = "Koliko drzava ima u juznoj americi?";
                QuestionDisplay.newA = "13";
                QuestionDisplay.newB = "12";
                QuestionDisplay.newC = "14";
                QuestionDisplay.newD = "11";
                actualAnswer = "B";
            }

            if (questionNumber == 79)
            {
                QuestionDisplay.newQuestion = "Koliko drzava ima u sjevernoj americi?";
                QuestionDisplay.newA = "5";
                QuestionDisplay.newB = "15";
                QuestionDisplay.newC = "23";
                QuestionDisplay.newD = "28";
                actualAnswer = "C";
            }

            if (questionNumber == 80)
            {
                QuestionDisplay.newQuestion = "Koliko drzava ima u Europi?";
                QuestionDisplay.newA = "42";
                QuestionDisplay.newB = "47";
                QuestionDisplay.newC = "46";
                QuestionDisplay.newD = "44";
                actualAnswer = "D";
            }
            if (questionNumber == 81)
            {
                QuestionDisplay.newQuestion = "Koliko drzava ima u Aziji?";
                QuestionDisplay.newA = "48";
                QuestionDisplay.newB = "47";
                QuestionDisplay.newC = "49";
                QuestionDisplay.newD = "46";
                actualAnswer = "A";
            }
            if (questionNumber == 82)
            {
                QuestionDisplay.newQuestion = "Koliko drzava ima u Africi?";
                QuestionDisplay.newA = "50";
                QuestionDisplay.newB = "54";
                QuestionDisplay.newC = "52";
                QuestionDisplay.newD = "56";
                actualAnswer = "B";
            }

            if (questionNumber == 83)
            {
                QuestionDisplay.newQuestion = "Koliko drzava ima u Oceaniji?";
                QuestionDisplay.newA = "12";
                QuestionDisplay.newB = "13";
                QuestionDisplay.newC = "14";
                QuestionDisplay.newD = "15";
                actualAnswer = "C";
            }

            if (questionNumber == 84)
            {
                QuestionDisplay.newQuestion = "Koji je glavni grad Australije?";
                QuestionDisplay.newA = "Sydney";
                QuestionDisplay.newB = "Brisbane";
                QuestionDisplay.newC = "Melbourne";
                QuestionDisplay.newD = "Canberra";
                actualAnswer = "D";
            }
            if (questionNumber == 85)
            {
                QuestionDisplay.newQuestion = "Koji oblik glazbene artikulacije se ne moze svirati na klaviru?";
                QuestionDisplay.newA = "Pizzicato";
                QuestionDisplay.newB = "Staccato";
                QuestionDisplay.newC = "Legato";
                QuestionDisplay.newD = "Sforzando";
                actualAnswer = "A";
            }
            if (questionNumber == 86)
            {
                QuestionDisplay.newQuestion = "U kojem gradu je rodjen Ludwig van Beethoven?";
                QuestionDisplay.newA = "Berlin";
                QuestionDisplay.newB = "Bonn";
                QuestionDisplay.newC = "Nurnberg";
                QuestionDisplay.newD = "Dresden";
                actualAnswer = "B";
            }

            if (questionNumber == 87)
            {
                QuestionDisplay.newQuestion = "Tko je skladao poznata Godisnja doba?";
                QuestionDisplay.newA = "Giuseppe Verdi";
                QuestionDisplay.newB = "Johan Sebastion Bach";
                QuestionDisplay.newC = "Antonio Vivaldi";
                QuestionDisplay.newD = "Franz Schubert";
                actualAnswer = "C";
            }

            if (questionNumber == 88)
            {
                QuestionDisplay.newQuestion = "U kojoj drzavi su rodjeni Mozart, Haydn i Strauss?";
                QuestionDisplay.newA = "Njemacka";
                QuestionDisplay.newB = "Svicarska";
                QuestionDisplay.newC = "Rusija";
                QuestionDisplay.newD = "Austrija";
                actualAnswer = "D";
            }
            if (questionNumber == 89)
            {
                QuestionDisplay.newQuestion = "Tko je napisao poznatog Orasara?";
                QuestionDisplay.newA = "Èajkovski";
                QuestionDisplay.newB = "Rubinstein";
                QuestionDisplay.newC = "Prokofiev";
                QuestionDisplay.newD = "Stravinski";
                actualAnswer = "A";
            }
            if (questionNumber == 90)
            {
                QuestionDisplay.newQuestion = "U kojoj drzavi je rodjen Frédéric Chopin?";
                QuestionDisplay.newA = "Francuska";
                QuestionDisplay.newB = "Poljska";
                QuestionDisplay.newC = "Njemacka";
                QuestionDisplay.newD = "Svicarska";
                actualAnswer = "B";
            }

            if (questionNumber == 91)
            {
                QuestionDisplay.newQuestion = "Tko se smatra najvecim graditeljem violina cija tajna izrade nije otkrivena?";
                QuestionDisplay.newA = "Verdi";
                QuestionDisplay.newB = "Paganini";
                QuestionDisplay.newC = "Stradivari";
                QuestionDisplay.newD = "Rhonheimer";
                actualAnswer = "C";
            }

            if (questionNumber == 92)
            {
                QuestionDisplay.newQuestion = "Kako se zove najnizi pjevacki glas u operi?";
                QuestionDisplay.newA = "Soprano";
                QuestionDisplay.newB = "Mezzo";
                QuestionDisplay.newC = "Contralto";
                QuestionDisplay.newD = "Bass";
                actualAnswer = "D";
            }
            if (questionNumber == 93)
            {
                QuestionDisplay.newQuestion = "Na kojem jeziku je napisana opera La Traviata?";
                QuestionDisplay.newA = "Talijanski";
                QuestionDisplay.newB = "Francuski";
                QuestionDisplay.newC = "Spanjolski";
                QuestionDisplay.newD = "Ruski";
                actualAnswer = "A";
            }
            if (questionNumber == 94)
            {
                QuestionDisplay.newQuestion = "U kojem gradu je rodjen Mozart?";
                QuestionDisplay.newA = "Bec";
                QuestionDisplay.newB = "Salzburg";
                QuestionDisplay.newC = "Graz";
                QuestionDisplay.newD = "Linz";
                actualAnswer = "B";
            }

            if (questionNumber == 95)
            {
                QuestionDisplay.newQuestion = "Koliko godina je imao Verdi kada je skladao Messa da Requiem?";
                QuestionDisplay.newA = "40";
                QuestionDisplay.newB = "20";
                QuestionDisplay.newC = "60";
                QuestionDisplay.newD = "30";
                actualAnswer = "C";
            }

            if (questionNumber == 96)
            {
                QuestionDisplay.newQuestion = "Koliko godina je imao Mozart kada je skladao svoju prvu simfoniju?";
                QuestionDisplay.newA = "5";
                QuestionDisplay.newB = "9";
                QuestionDisplay.newC = "13";
                QuestionDisplay.newD = "8";
                actualAnswer = "D";
            }
            if (questionNumber == 97)
            {
                QuestionDisplay.newQuestion = "Romula i Rema je odgojila koja zivotinja?";
                QuestionDisplay.newA = "Vucica";
                QuestionDisplay.newB = "Lisica";
                QuestionDisplay.newC = "Lavica";
                QuestionDisplay.newD = "Tigrica";
                actualAnswer = "A";
            }
            if (questionNumber == 98)
            {
                QuestionDisplay.newQuestion = "Koje je Mozartovo srednje ime?";
                QuestionDisplay.newA = "Ludwig";
                QuestionDisplay.newB = "Amadeus";
                QuestionDisplay.newC = "Josef";
                QuestionDisplay.newD = "Sebastian";
                actualAnswer = "B";
            }

            if (questionNumber == 99)
            {
                QuestionDisplay.newQuestion = "Koliko je osnovnih SI jedinica?";
                QuestionDisplay.newA = "6";
                QuestionDisplay.newB = "5";
                QuestionDisplay.newC = "7";
                QuestionDisplay.newD = "8";
                actualAnswer = "C";
            }

            if (questionNumber == 100)
            {
                QuestionDisplay.newQuestion = "Kako se zove svemirska misija koja je poslala prve ljude na Mjesec?";
                QuestionDisplay.newA = "Apollo 1";
                QuestionDisplay.newB = "Apollo 7";
                QuestionDisplay.newC = "Apollo 13";
                QuestionDisplay.newD = "Apollo 11";
                actualAnswer = "D";
            }







            QuestionDisplay.update = false;
        }
    }
}
