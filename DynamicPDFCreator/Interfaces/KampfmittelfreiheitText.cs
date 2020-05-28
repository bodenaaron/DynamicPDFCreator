using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPDFCreator.Interfaces
{
    class KampfmittelfreiheitText
    {

        public string getHTML(string SMNummer, Bearbeiter bearbeiter)
        {
            return $@"
                <p>Bestätigung der Kampfmittelfreiheit für die Durchführung einer geplanten Baumaßnahme: </p>
                <p>SM-Auftrag Nr.:<b>{SMNummer}</b></p>
                <p>Bitte geben Sie im Schriftwechsel immer die SM-Auftrag Nr. an.</p>
                <p>Sehr geehrte Damen und Herren,</p><p>
                die Landesbauordnung enthält entsprechend der vereinheitlichten Musterbauordnung 
                grundsätzliche Vorgaben, wonach durch Bauarbeiten jeder Art das Leben und die Gesundheit von Menschen 
                nicht gefährdet werden dürfen (§ 3 Abs.1 Musterbauordnung) und Baustellen so einzurichten sind, dass 
                durch bauliche Anlagen Gefahren nicht entstehen können (§ 11 Abs.1 Musterbauordnung).</p>
                
                <p>Damit wird bereits durch das öffentliche Baurecht (indirekt und doch eindeutig) vorgeschrieben,
                dass jeder Bauherr grundsätzlich sicherstellen muss, dass im Zuge der Bauarbeiten keine Kampfmittel (mehr)
                angetroffen werden können.</p>

                <p>Aufgrund dieser Vorgaben ergibt sich für die Deutsche Telekom Technik GmbH die Verpflichtung,
                bei Baumaßnahmen in Koordinierung beim Bauherrn die Kampfmittelfreiheit zu erfragen. Zur Bestätigung 
                können Sie das anhängende Muster, oder auch Ihr eigenes Schreiben verwenden.</p>

                <p>Wir bitten, die erforderliche Bestätigung möglichst kurzfristig an u. g. Postanschrift oder per Email zu senden.</p>

                <p> Mit freundlichen Grüßen<br />
                    {bearbeiter?.bearbeiterVorname} {bearbeiter?.bearbeiterName}<br />
                    {bearbeiter?.email} {bearbeiter?.telefon}<br />
                    Eictronic GmbH <br />
                    Gasse 25<br />
                    37339 Berlingerode<br />                    
                    Geschäftsführer: Jörg Boden

                </p>
                <br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />

            ";
        }
    }
}
