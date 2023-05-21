using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZelenePovrsine
{
    #region ZelenaPovrsina
    public class ZelenaPovrsinaView
    {
        public int Id;
        public string UgrozenostOdZagadjenja;
        public string Opstina;

        public ZelenaPovrsinaView() { }
        public ZelenaPovrsinaView(int Id, string UgrozenostOdZagadjenja, string Opstina)
        {
            string _ugrozenost = null;
            if (String.Compare(UgrozenostOdZagadjenja, "niska", true) == 0)
            {
                _ugrozenost = "niska";
            }
            else if (String.Compare(UgrozenostOdZagadjenja, "srednja", true) == 0)
            {
                _ugrozenost = "srednja";
            }
            else if (String.Compare(UgrozenostOdZagadjenja, "visoka", true) == 0)
            {
                _ugrozenost = "visoka";
            }
            this.Id = Id;
            this.UgrozenostOdZagadjenja = _ugrozenost;
            this.Opstina = Opstina;
        }
        public ZelenaPovrsinaView(Entities.ZelenaPovrsina zelenaPovrsina) : this(zelenaPovrsina.Id,
            zelenaPovrsina.UgrozenostOdZagadjenja,
            zelenaPovrsina.Opstina)
        {
            
        }
        
    }
    #endregion
    #region Park
    public class ParkView : ZelenaPovrsinaView
    {
        public string Naziv;
        public float Povrsina_hektari;
        public ParkView() : base() { }
        public ParkView(int Id, string UgrozenostOdZagadjenja, string Opstina,
            string Naziv, float Povrsina_hektari) : base(Id, UgrozenostOdZagadjenja, Opstina)
        {
            this.Naziv = Naziv;
            this.Povrsina_hektari = Povrsina_hektari;
        }
        public ParkView(Entities.Park park) : this(park.Id, park.UgrozenostOdZagadjenja,
            park.Opstina, park.Naziv, park.Povrsina_hektari)
        {

        }
    }
    #endregion
    #region Drvored
    public class DrvoredView : ZelenaPovrsinaView
    {
        public string Ulica;
        public string VrstaDrveta;
        public int BrStabala;
        public DrvoredView() : base() { }
        public DrvoredView(int Id, string UgrozenostOdZagadjenja, string Opstina,
           string Ulica, string VrstaDrveta, int BrStabala) : base(Id, UgrozenostOdZagadjenja, Opstina)
        {
            this.Ulica = Ulica;
            this.VrstaDrveta = VrstaDrveta;
            this.BrStabala = BrStabala;
        }
        public DrvoredView(Entities.Drvored drvored) : this(drvored.Id, drvored.UgrozenostOdZagadjenja,
            drvored.Opstina, drvored.Ulica, drvored.VrstaDrveta, drvored.BrStabala)
        {

        }

    }
    #endregion
    #region Travnjak
    public class TravnjakView : ZelenaPovrsinaView
    {
        public string AdresaZgrade;
        public float PovrsinaAri;
        public TravnjakView() : base() { }
        public TravnjakView(int Id, string UgrozenostOdZagadjenja, string Opstina,
            string AdresaZgrade, float PovrsinaAri) : base(Id, UgrozenostOdZagadjenja, Opstina)
        {
            this.AdresaZgrade = AdresaZgrade;
            this.PovrsinaAri = PovrsinaAri;
        }
        public TravnjakView(Entities.Travnjak travnjak) : this(travnjak.Id, travnjak.UgrozenostOdZagadjenja,
            travnjak.Opstina, travnjak.AdresaZgrade, travnjak.PovrsinaAri)
        {

        }
    }
    #endregion
    #region Objekat
    public class ObjekatView
    {
        public int Id;
        public ObjekatView() : base() { }
        public ObjekatView(int Id)
        {
            this.Id = Id;
        }
    }
    #endregion
    #region Drvo
    public class DrvoView : ObjekatView
    {
        public string Vrsta;
        public DateTime DatumSadjenja;
        public float VisinaKrosnje;
        public float PovrsinaKrosnje;
        public float ObimDebla;
        public ZasticeniObjekatView objekat;
        public DrvoView() : base() { }
        public DrvoView(int Id, string Vrsta, DateTime DatumSadjenja,
            float VisinaKrosnje, float PovrsinaKrosnje,float ObimDebla) : base(Id)
        {
            this.Vrsta = Vrsta;
            this.DatumSadjenja = DatumSadjenja;
            this.VisinaKrosnje = VisinaKrosnje;
            this.PovrsinaKrosnje= PovrsinaKrosnje;
            this.ObimDebla = ObimDebla;
        }
        public DrvoView(Entities.Drvo drvo) : this(
            drvo.Id,
            drvo.Vrsta,
            drvo.DatumSadjenja,
            drvo.VisinaKrosnje,
            drvo.PovrsinaKrosnje,
            drvo.ObimDebla)
        { }
    }
    #endregion
    #region Igraliste
    public class IgralisteView : ObjekatView
    {
        public int BrIgracaka;
        public int GodineOd;
        public int? GodineDo;
        public string ImaPesak;
        public IgralisteView() : base() { }
        public IgralisteView(int Id, int BrIgracaka, int GodineOd, int? GodineDo, string ImaPesak) : base(Id)
        {
            if (String.Compare(ImaPesak, "Da", true) == 0)
            {
                this.ImaPesak = "Da";
            }
            else if (String.Compare(ImaPesak, "Ne", true) == 0)
            {
                this.ImaPesak = "Ne";
            }
            else throw new Exception("Morate uneti \"Da\" ili \"Ne\" u polje \"Da li ima pesak\".");
            this.BrIgracaka = BrIgracaka;
            this.GodineOd = GodineOd;
            this.GodineDo = GodineDo;
        }
        public IgralisteView(Entities.Igraliste igraliste) : this(
            igraliste.Id,
            igraliste.BrIgracaka,
            igraliste.GodineOd,
            igraliste.GodineDo,
            igraliste.ImaPesak)
        { }
    }
    #endregion
    #region Skulptura i spomenik
    public class SkulpturaSpomenikView : ObjekatView
    {
        public ZasticeniObjekatView objekat;
        private string tip;
        public string Tip { get { return tip; } }
        public SkulpturaSpomenikView() : base() { }
        public SkulpturaSpomenikView(int Id) : base(Id) { }
        public SkulpturaSpomenikView(Entities.Skulptura skulptura) : base(skulptura.Id)
        {
            tip = "Skulptura";
        }
        public SkulpturaSpomenikView(Entities.Spomenik spomenik) : base(spomenik.Id)
        {
            tip = "Spomenik";
        }
    }
   
    #endregion
    #region Ostalo
    public class OstaloView : ObjekatView
    {
        protected string tip;
        public string Tip { get { return tip; }  }
        public OstaloView() : base() { }
        public OstaloView(int Id) : base(Id) { }
        public OstaloView(Entities.Klupa klupa) : base(klupa.Id)
        {
            tip = "Klupa";
        }
        public OstaloView(Entities.Svetiljka svetiljka) : base(svetiljka.Id)
        {
            tip = "Svetiljka";
        }
        public OstaloView(Entities.Fontana fontana) : base(fontana.Id)
        {
            tip = "Fontana";
        }
    }
    #endregion
    #region Zasticeni objekat
    public class ZasticeniObjekatView
    {
        public ObjekatView Objekat;
        public string Opis;
        public string Institucija;
        public DateTime StavljenPodZastitu;
        public int GodTroskovi;
        public ZasticeniObjekatView()
        {
            
        }
        public ZasticeniObjekatView(string Opis, string Institucija,
            DateTime StavljenPodZastitu, int GodTroskovi)
        {
            this.Opis = Opis;
            this.Institucija = Institucija;
            this.StavljenPodZastitu = StavljenPodZastitu;
            this.GodTroskovi = GodTroskovi;
        }
        public ZasticeniObjekatView(Entities.ZasticeniObjekat objekat) : this(
            objekat.Opis,
            objekat.OdgovornaInstitucija,
            objekat.DatumStavljanjaPodZastitu,
            objekat.GodisnjiTroskovi)
        { }
    }
    #endregion
    #region Radnik

    public class RadnikView
    {
        public int BrRK;
        public string Mbr;
        public string Adresa;
        public string StrucnaSprema;
        public DateTime DatumRodjenja;
        public string Ime;
        public string Prezime;
        public string ImeRoditelja;

        public DateTime DatumOd;
        public DateTime? DatumDo;
        public string PunoIme
        {
            get
            {
                return $"{Ime} {ImeRoditelja} {Prezime}";
            }
        }
        public int OdrzavaHigijenu;
        public int OdrzavaZelenila;
        public int OdrzavaObjekte;
        public IList<string> RadnikOdrzava { get
            {
                List<string> specijalizacije = new List<string>();
                if (OdrzavaZelenila != 0) specijalizacije.Add("Odrzava zelenila");
                if (OdrzavaHigijenu != 0) specijalizacije.Add("Odrzava higijenu");
                if (OdrzavaObjekte != 0) specijalizacije.Add("Odrzava objekte");
                return specijalizacije;
            } 
        }
        public RadnikView() : base() { }
        public RadnikView(int BrRK, string Mbr, string Adresa, string StrucnaSprema,
            DateTime DatumRodjenja, string Ime, string Prezime, string ImeRoditelja,
            bool OdrzavaZelenila, bool OdrzavaHigijenu, bool OdrzavaObjekte)
        {
            this.BrRK = BrRK;
            this.Mbr = Mbr;
            this.Adresa = Adresa;
            this.StrucnaSprema = StrucnaSprema;
            this.DatumRodjenja = DatumRodjenja;
            this.Ime = Ime;
            this.Prezime = Prezime;
            this.ImeRoditelja = ImeRoditelja;
            if (OdrzavaZelenila) this.OdrzavaZelenila = 1;
            if (OdrzavaHigijenu) this.OdrzavaHigijenu = 1;
            if (OdrzavaObjekte) this.OdrzavaObjekte = 1;
        }
        public RadnikView(Entities.Radnik radnik) : this(radnik.BrRK, radnik.Mbr,
            radnik.Adresa, radnik.StrucnaSprema, radnik.DatumRodjenja, radnik.Ime,
            radnik.Prezime, radnik.ImeRoditelja, radnik.OdrzavaZelenila == 1,
            radnik.OdrzavaHigijenu == 1, radnik.OdrzavaObjekte == 1)
        {

        }

    }
    #endregion
 
}
