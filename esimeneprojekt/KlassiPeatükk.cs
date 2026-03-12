using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esimeneprojekt //nime ruum millises projktis või skoobis klass on
{
    //klassi anatoomia
    //A -- klassi enda nime ruum mis sisaldab kõik mis sisaldab kõike mis klassil ise vaja on
    //     A.1 klassi nimeruum vajab juurdepääsumodifikaatorit ,
    //     A.2 Sätestust et tegu on klassiga,
    //     A.3 ja ka klassi enda nime.
    //
    //B -- Klasssi konstruktor defineerib ära spetsiaalse meetodi mis ütleb ära kuida ssee klass instantseeritakse,sama moodi nagu
    //structil saab olla konstrutoreid mitu , erinevalt structist väärtusi peab andma kaasa.
    //
    //C -- Väljad mida konstrukto ootab, neile tuleb väärtus anda välja arvatud ühel juhul
    //
    //D -- Klassi omadused , nende kaudu saab kasutatavas koodis selle klassi tüüpi objekti andmeid kätte, adreseerides neid
    //punktiga erinevalt structist vajavad omadused objekti tekitamisel mingit väärtust väljaarvatud siis kui omaduse andmetüübi taga
    //on "?" mis ütleb et see omadus võib jääda nulliks

    // klassi omadusele saab anda vaikeväärtuse , vaikeväärtus on midagi mida saab anda kaasa selle objekti tekitamise hetkel kui ei ole sellele väljale väärtust antud (D.3) 

    //A.1    A.2    A.3
    public class KlassiPeatükk //A 
    {
        public KlassiPeatükk(string värvus, string materjal, double paksus)
        {
            Värvus = värvus;
            Materjal = materjal;
            Paksus = paksus;
        }
                         //     D.1  D.2
        public string? Värvus { get; set; }
        public string Materjal { get; set; }
        public double? Paksus { get; set; } = -1; // D.3
        //E -- klassi meetodid


        /// <summary>
        /// Returns a sentence containing info about this object 
        /// </summary>
        /// <returns>sentence</returns>
        public string GetInfo()
        {
            return $"This object is made of {Materjal} is {Paksus} thick , and has this color {Värvus}";
        }

        /// <summary>
        /// Methode that returns true if this materjal can be dremeld or nah
        /// if the dremel is longer than the materjal is thick then the materjal is not dremable and vice-versa
        /// </summary>
        /// <param name="FreesiPaksus">your dremel lenght</param>
        /// <returns>true or false</returns>
        public bool CanDremelHM(double FreesiPaksus)
        {
            if(FreesiPaksus < Paksus)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
