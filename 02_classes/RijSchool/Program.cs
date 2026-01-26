using System.Linq.Expressions;
using System.Net;
using System.Runtime.InteropServices;

namespace RijSchool;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }

    //x
    Auto auto1 = new Auto()
    {
        automaat = true,
        kenteken = "AA824H",
        kilometerStand = 20567,
        merk = "volkswagen"
    };

    Auto auto2 = new Auto()
    {
        automaat = false,
        kenteken = "KU786G",
        kilometerStand = 65739,
        merk = "volvo"
    };

    RijLeraar rijLeraar = new RijLeraar()
    {
        leeftijd = 30,
        naam = "John",
        zzp = false
    };

    LesUur lesUur = new LesUur()
    {
        auto = auto1,
        rijLeraar = rijLeraar,

        tijd = 1130
    };
}
//ik loop vast ik ga verder als het niet af is ben ik vergeten terug te komen