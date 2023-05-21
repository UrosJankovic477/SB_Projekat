using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Linq;
using ZelenePovrsine.Entities;
using NHibernate;

namespace ZelenePovrsine
{
    public class ParkIdNotFoundException : Exception
    {
        int id;
        public ParkIdNotFoundException(int Id) : base()
        {
            id = Id;
        }
        public override string Message { get { return $"Park čiji je id {id} nije pronađen."; } }
    }
    public class RadnikIdNotFoundException : Exception
    {
        int id;
        public RadnikIdNotFoundException(int Id) : base()
        {
            id = Id;
        }
        public override string Message { get { return $"Radnik čiji je id {id} nije pronađen."; } }

    }
    public static class DTOManager
    {
        private static void ExceptionHandler(Exception ex)
        {
            System.Windows.Forms.MessageBox.Show(
                    ex.Message,
                    "Greška",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error
                    );
            var innerEx = ex.InnerException;
            if (innerEx != null)
            {
                System.Windows.Forms.MessageBox.Show(innerEx.Message);
            }
        }
        #region ZelenePovrsine
        public static IList<T> GetAllZelenaPovrsina<T>() where T : ZelenaPovrsinaView
        {
            ISession session = null;
            try
            {
                List<T> list = new List<T>();
                session = DataLayer.GetSession();

                IEnumerable<ZelenaPovrsina> data;
                if (typeof(T) == typeof(DrvoredView))
                {
                    data = from o in session.Query<Drvored>() select o;
                }
                else if (typeof(T) == typeof(ParkView))
                {
                    data = from o in session.Query<Park>() select o;
                }
                else
                {
                    data = from o in session.Query<Travnjak>() select o;
                }

                foreach (ZelenaPovrsina d in data)
                {
                    Type type = d.GetType();
                    Type[] types = new Type[] { type };
                    object[] args = new object[] { d };
                    list.Add(typeof(T).GetConstructor(types).Invoke(args) as T);
                }
                session.Close();
                session.Dispose();
                return list;
            }
            catch (Exception ex)
            {
                ExceptionHandler(ex);
                return null;

            }
            finally
            {
                if (session != null && session.IsOpen)
                {
                    session.Close();
                    session.Dispose();
                }
            }
        }
        public static void DeleteZelenaPovrsina(int zelenaPovrsinaId)
        {
            ISession session = null;
            try
            {
                session = DataLayer.GetSession();
                ZelenaPovrsina zelenaPovrsina = session.Load<ZelenaPovrsina>(zelenaPovrsinaId);
                session.Delete(zelenaPovrsina);
                session.Flush();
                session.Close();
                session.Dispose();
            }
            catch (Exception ex)
            {
                ExceptionHandler(ex);
            }
            finally
            {
                if (session != null && session.IsOpen)
                {
                    session.Close();
                    session.Dispose();
                }
            }
        }
        #region Park
        public static void SavePark(ParkView park)
        {
            ISession session = null;
            try
            {
                session = DataLayer.GetSession();
                Park newPark = new Park();
                newPark.Id = park.Id;
                newPark.UgrozenostOdZagadjenja = park.UgrozenostOdZagadjenja;
                newPark.Naziv = park.Naziv;
                newPark.Opstina = park.Opstina;
                newPark.Povrsina_hektari = park.Povrsina_hektari;

                session.Save(newPark);
                session.Flush();
                session.Close();
            }
            catch (Exception ex)
            {
                ExceptionHandler(ex);
            }
            finally
            {
                if (session != null && session.IsOpen)
                {
                    session.Close();
                    session.Dispose();
                }
            }
        }
        public static void UpdatePark(ParkView parkView)
        {
            ISession session = null;
            try
            {
                session = DataLayer.GetSession();
                Park park = session.Load<Park>(parkView.Id);
                if (park == null)
                {
                    throw new ParkIdNotFoundException(parkView.Id);
                }
                park.UgrozenostOdZagadjenja = parkView.UgrozenostOdZagadjenja;
                park.Opstina = parkView.Opstina;
                park.Naziv = parkView.Naziv;
                park.Povrsina_hektari = parkView.Povrsina_hektari;
                session.SaveOrUpdate(park);
                session.Flush();
                session.Close();
            }
            catch (Exception ex)
            {
                ExceptionHandler(ex);
            }
            finally
            {
                if (session != null && session.IsOpen)
                {
                    session.Close();
                    session.Dispose();
                }
            }
        }
        public static ParkView GetPark(int parkId)
        {
            ISession session = null;
            try
            {
                session = DataLayer.GetSession();
                Park park = session.Load<Park>(parkId);
                if (park == null)
                {
                    throw new ParkIdNotFoundException(parkId);
                }
                ParkView parkView = new ParkView(park.Id, park.UgrozenostOdZagadjenja,
                    park.Opstina, park.Naziv, park.Povrsina_hektari);
                session.Close();
                session.Dispose();
                return parkView;
            }
            catch (Exception ex)
            {
                ExceptionHandler(ex);
                return null;
            }
            finally
            {
                if (session != null && session.IsOpen)
                {
                    session.Close();
                    session.Dispose();
                }
            }
        }

        #endregion
        #region Drvored
        public static void SaveDrvored(DrvoredView drvoredView)
        {
            ISession session = null;
            try
            {
                session = DataLayer.GetSession();
                Drvored drvored = new Drvored();
                drvored.Id = drvoredView.Id;
                drvored.UgrozenostOdZagadjenja = drvoredView.UgrozenostOdZagadjenja;
                drvored.BrStabala = drvoredView.BrStabala;
                drvored.Opstina = drvoredView.Opstina;
                drvored.Ulica = drvoredView.Ulica;
                drvored.VrstaDrveta = drvoredView.VrstaDrveta;

                session.Save(drvored);
                session.Flush();
                session.Close();
            }
            catch (Exception ex)
            {
                ExceptionHandler(ex);
            }
            finally
            {
                if (session != null && session.IsOpen)
                {
                    session.Close();
                    session.Dispose();
                }
            }
        }
        public static void UpdateDrvored(DrvoredView drvoredView)
        {
            ISession session = null;
            try
            {
                session = DataLayer.GetSession();
                Drvored drvored = session.Load<Drvored>(drvoredView.Id);
                if (drvored == null)
                {
                    throw new ParkIdNotFoundException(drvoredView.Id);
                }
                drvored.UgrozenostOdZagadjenja = drvoredView.UgrozenostOdZagadjenja;
                drvored.Opstina = drvoredView.Opstina;
                drvored.Ulica = drvoredView.Ulica;
                drvored.VrstaDrveta = drvoredView.VrstaDrveta;
                drvored.BrStabala = drvoredView.BrStabala;

                session.SaveOrUpdate(drvored);
                session.Flush();
                session.Close();
            }
            catch (Exception ex)
            {
                ExceptionHandler(ex);
            }
            finally
            {
                if (session != null && session.IsOpen)
                {
                    session.Close();
                    session.Dispose();
                }
            }
        }
        #endregion
        #region Tracnjak
        public static void SaveTravnjak(TravnjakView travnjakView)
        {
            ISession session = null;
            try
            {
                session = DataLayer.GetSession();
                Travnjak tracnjak = new Travnjak();
                tracnjak.Id = travnjakView.Id;
                tracnjak.UgrozenostOdZagadjenja = travnjakView.UgrozenostOdZagadjenja;
                tracnjak.AdresaZgrade = travnjakView.AdresaZgrade;
                tracnjak.Opstina = travnjakView.Opstina;
                tracnjak.PovrsinaAri = travnjakView.PovrsinaAri;

                session.Save(tracnjak);
                session.Flush();
                session.Close();
            }
            catch (Exception ex)
            {
                ExceptionHandler(ex);
            }
            finally
            {
                if (session != null && session.IsOpen)
                {
                    session.Close();
                    session.Dispose();
                }
            }
        }
        public static void UpdateTravnjak(TravnjakView travnjakView)
        {
            ISession session = null;
            try
            {
                session = DataLayer.GetSession();
                Travnjak travnjak = session.Load<Travnjak>(travnjakView.Id);
                if (travnjak == null)
                {
                    throw new ParkIdNotFoundException(travnjakView.Id);
                }
                travnjak.UgrozenostOdZagadjenja = travnjakView.UgrozenostOdZagadjenja;
                travnjak.Opstina = travnjakView.Opstina;
                travnjak.AdresaZgrade = travnjakView.AdresaZgrade;
                travnjak.PovrsinaAri = travnjakView.PovrsinaAri;

                session.SaveOrUpdate(travnjak);
                session.Flush();
                session.Close();
            }
            catch (Exception ex)
            {
                ExceptionHandler(ex);
            }
            finally
            {
                if (session != null && session.IsOpen)
                {
                    session.Close();
                    session.Dispose();
                }
            }
        }
        #endregion
        #endregion
        #region Radnik
        public static void UpdateRadnik(RadnikView radnikView)
        {
            ISession session = null;
            try
            {
                session = DataLayer.GetSession();
                Radnik radnik = session.Load<Radnik>(radnikView.BrRK);
                if (radnik == null)
                {
                    throw new RadnikIdNotFoundException(radnikView.BrRK);
                }
                radnik.Mbr = radnikView.Mbr;
                radnik.Ime = radnikView.Ime;
                radnik.Prezime = radnikView.Prezime;
                radnik.ImeRoditelja = radnikView.ImeRoditelja;
                radnik.Adresa = radnikView.Adresa;
                radnik.DatumRodjenja = radnikView.DatumRodjenja;
                radnik.OdrzavaZelenila = radnikView.OdrzavaZelenila;
                radnik.OdrzavaHigijenu = radnikView.OdrzavaHigijenu;
                radnik.OdrzavaObjekte = radnikView.OdrzavaObjekte;
                radnik.StrucnaSprema = radnik.StrucnaSprema;
                session.SaveOrUpdate(radnik);
                session.Flush();
                session.Close();
                session.Dispose();
            }
            catch (Exception ex)
            {
                ExceptionHandler(ex);
            }
            finally
            {
                if (session != null && session.IsOpen)
                {
                    session.Close();
                    session.Dispose();
                }
            }
        }
        public static void DeleteRadnik(int RadnikId)
        {
            ISession session = null;
            try
            {
                session = DataLayer.GetSession();
                session.Delete(session.Load<Radnik>(RadnikId));
                session.Flush();
                session.Close();
                session.Dispose();
            }
            catch (Exception ex)
            {
                ExceptionHandler(ex);
            }
            finally
            {
                if (session != null && session.IsOpen)
                {
                    session.Close();
                    session.Dispose();
                }
            }
        }
        public static void AddRadnik(RadnikView radnikView)
        {
            ISession session = null;
            try
            {
                session = DataLayer.GetSession();
                Radnik radnik;
                radnik = new Radnik()
                {
                    Mbr = radnikView.Mbr,
                    Adresa = radnikView.Adresa,
                    DatumRodjenja = radnikView.DatumRodjenja,
                    Ime = radnikView.Ime,
                    ImeRoditelja = radnikView.ImeRoditelja,
                    Prezime = radnikView.Prezime,
                    StrucnaSprema = radnikView.StrucnaSprema,
                    OdrzavaHigijenu = radnikView.OdrzavaHigijenu,
                    OdrzavaZelenila = radnikView.OdrzavaZelenila,
                    OdrzavaObjekte = radnikView.OdrzavaObjekte
                };
                session.Save(radnik);
                session.Flush();
                session.Close();
                session.Dispose();

            }
            catch (Exception ex)
            {
                ExceptionHandler(ex);
            }
            finally
            {
                if (session != null && session.IsOpen)
                {
                    session.Close();
                    session.Dispose();
                }
            }

        }
        public static IList<RadnikView> GetRadnici()
        {
            List<RadnikView> radnici = new List<RadnikView>();
            ISession session = null;
            try
            {
                session = DataLayer.GetSession();
                IEnumerable<Radnik> data = session.Query<Radnik>();
                foreach (var radnik in data)
                {
                    radnici.Add(new RadnikView(radnik));
                }
                session.Close();
                session.Dispose();
                return radnici;
            }
            catch (Exception ex)
            {
                ExceptionHandler(ex);
                return null;
            }
            finally
            {
                if (session != null && session.IsOpen)
                {
                    session.Close();
                    session.Dispose();
                }
            }
        }
        public static RadnikView GetRadnik(int Id)
        {
            ISession session = null;
            try
            {

                session = DataLayer.GetSession();
                Radnik radnik = session.Load<Radnik>(Id);
                if (radnik == null)
                {
                    throw new RadnikIdNotFoundException(Id);
                }
                session.Close();
                session.Dispose();
                return new RadnikView(radnik);


                session.Close();
                session.Dispose();
                return null;



            }
            catch (System.Exception ex)
            {
                ExceptionHandler(ex);
                return null;
            }
            finally
            {
                if (session != null && session.IsOpen)
                {
                    session.Close();
                    session.Dispose();
                }
            }
        }
        public static IList<RadnikView> GetRadniciParka(int ParkId)
        {
            List<RadnikView> radnici = new List<RadnikView>();
            ISession session = null;
            try
            {
                session = DataLayer.GetSession();
                IEnumerable<RadnikPark> data = session.Query<RadnikPark>()
                    .Where(p => p.Id.Park.Id == ParkId);
                foreach (RadnikPark rp in data)
                {
                    RadnikView radnik = new RadnikView(
                        session.Query<Radnik>()
                        .Where(p => p.BrRK == rp.Id.Radnik.BrRK)
                        .Single());
                    radnik.DatumOd = rp.Id.DatumOd;
                    radnik.DatumDo = rp.DatumDo;
                    radnici.Add(radnik);
                }
                session.Close();
                session.Dispose();
                return radnici;
            }
            catch (Exception ex)
            {
                ExceptionHandler(ex);
                return null;
            }
            finally
            {
                if (session != null && session.IsOpen)
                {
                    session.Close();
                    session.Dispose();
                }
            }
        }
        public static void UnenrollRadnik(int RadnikId, int ParkId)
        {
            ISession session = null;
            try
            {
                session = DataLayer.GetSession();
                RadnikPark rp = session.Query<RadnikPark>()
                    .Where(p => p.Id.Radnik.BrRK == RadnikId
                    && p.Id.Park.Id == ParkId
                    && p.DatumDo == null).Single();
                if (rp == null)
                {
                    System.Windows.Forms.MessageBox.Show(
                        "Radnik nije aktivni član grupe.",
                        "Obaveštenje",
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Information);
                    return;
                }
                rp.DatumDo = DateTime.Now;
                session.SaveOrUpdate(rp);
                session.Flush();
                session.Close();
                session.Dispose();

            }
            catch (Exception ex)
            {
                ExceptionHandler(ex);
                return;
            }
            finally
            {
                if (session != null && session.IsOpen)
                {
                    session.Close();
                    session.Dispose();
                }
            }
        }
        public static void EnrollRadnik(int RadinkId, int ParkId)
        {
            ISession session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session.Query<RadnikPark>()
                    .Any(p => p.Id.Park.Id == ParkId
                    && p.Id.Radnik.BrRK == RadinkId
                    && p.DatumDo == null))
                {
                    System.Windows.Forms.MessageBox.Show(
                    "Radnik trenutno radi u drugom parku",
                    "Obaveštenje",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Information
                    );
                    session.Close();
                    session.Dispose();
                    return;
                }
                RadnikPark rp = new RadnikPark()
                {
                    Id = new RadnikParkId
                    {
                        Radnik = session.Load<Radnik>(RadinkId),
                        Park = session.Load<Park>(ParkId),
                        DatumOd = DateTime.Now,
                    },
                    DatumDo = null
                };
                session.Save(rp);
                session.Flush();
                session.Close();
                session.Dispose();
            }
            catch (Exception ex)
            {
                ExceptionHandler(ex);
            }
            finally
            {
                if (session != null && session.IsOpen)
                {
                    session.Close();
                    session.Dispose();
                }
            }
        }
        public static void EnrollSef(int SefId, int ParkId)
        {
            ISession session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session.Query<Radnik>()
                    .Any(p => p.BrRK == SefId))
                {
                    System.Windows.Forms.MessageBox.Show(
                    "Šef trenutno radi u drugom parku",
                    "Obaveštenje",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Information
                    );
                    session.Close();
                    session.Dispose();
                    return;
                }
                if (session.Query<SefPark>()
                    .Any(p => p.Id.Park.Id == ParkId
                    && p.DatumDo == null))
                {
                    System.Windows.Forms.MessageBox.Show(
                    "Park trenutno ima šefa",
                    "Obaveštenje",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Information
                    );
                    session.Close();
                    session.Dispose();
                    return;
                }
                SefPark sp = new SefPark()
                {
                    Id = new SefParkId
                    {
                        Sef = session.Load<Radnik>(SefId),
                        Park = session.Load<Park>(ParkId),
                        DatumOd = DateTime.Now,
                    },
                    DatumDo = null
                };
                session.Save(sp);
                session.Flush();
                session.Close();
                session.Dispose();
            }
            catch (Exception ex)
            {
                ExceptionHandler(ex);
            }
            finally
            {
                if (session != null && session.IsOpen)
                {
                    session.Close();
                    session.Dispose();
                }
            }
        }

        #endregion
        #region Sef
        public static IList<RadnikView> GetSefoviParka(int ParkId)
        {
            List<RadnikView> sefovi = new List<RadnikView>();
            ISession session = null;
            try
            {
                session = DataLayer.GetSession();
                IEnumerable<SefPark> data = session.Query<SefPark>()
                    .Where(p => p.Id.Park.Id == ParkId);
                foreach (var sp in data)
                {
                    RadnikView sef = new RadnikView(
                        session.Query<Radnik>()
                        .Where(p => p.BrRK == sp.Id.Sef.BrRK)
                        .Single()
                        );
                    sefovi.Add(sef);
                }
                session.Close();
                session.Dispose();
                return sefovi;
            }
            catch (Exception ex)
            {
                ExceptionHandler(ex);
                return null;
            }
            finally
            {
                if (session != null && session.IsOpen)
                {
                    session.Close();
                    session.Dispose();
                }
            }
        }
        public static void UnenrollSef(int SefId, int ParkId)
        {
            ISession session = null;
            try
            {
                session = DataLayer.GetSession();
                SefPark sp = session.Query<SefPark>()
                    .Where(p => p.Id.Sef.BrRK == SefId
                    && p.Id.Park.Id == ParkId
                    && p.DatumDo == null).Single();
                if (sp != null)
                {
                    System.Windows.Forms.MessageBox.Show(
                        "Radnik nije trenutno šef grupe.",
                        "Obaveštenje",
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler(ex);
            }
            finally
            {
                if (session != null && session.IsOpen)
                {
                    session.Close();
                    session.Dispose();
                }
            }
        }

        #endregion
        #region Objekat
        public static IList<DrvoView> GetDrvece(int ParkId)
        {
            List<DrvoView> drvece = new List<DrvoView>();
            ISession session = null;
            try
            {
                session = DataLayer.GetSession();
                IEnumerable<Drvo> data = session.Query<Drvo>()
                    .Where(p => p.Park.Id == ParkId);
                foreach (var drvo in data)
                {
                    drvece.Add(new DrvoView(drvo));
                }
                session.Close();
                session.Dispose();
                return drvece;
            }
            catch (Exception ex)
            {
                ExceptionHandler(ex);
                return drvece;
            }
            finally
            {
                if (session != null && session.IsOpen)
                {
                    session.Close();
                    session.Dispose();
                }
            }
        }
        public static IList<IgralisteView> GetIgralista(int ParkId)
        {
            List<IgralisteView> igralista = new List<IgralisteView>();
            ISession session = null;
            try
            {
                session = DataLayer.GetSession();
                IEnumerable<Igraliste> data = session.Query<Igraliste>()
                    .Where(p => p.Park.Id == ParkId);
                foreach (var igraliste in data)
                {
                    igralista.Add(new IgralisteView(igraliste));
                }
                session.Close();
                session.Dispose();
                return igralista;
            }
            catch (Exception ex)
            {
                ExceptionHandler(ex);
                return igralista;
            }
            finally
            {
                if (session != null && session.IsOpen)
                {
                    session.Close();
                    session.Dispose();
                }
            }
        }
        public static IList<SkulpturaSpomenikView> GetSkulptureSpomenike(int ParkId)
        {
            List<SkulpturaSpomenikView> objekti = new List<SkulpturaSpomenikView>();
            ISession session = null;
            try
            {
                session = DataLayer.GetSession();
                IEnumerable<Spomenik> spomenici = session.Query<Spomenik>()
                    .Where(p => p.Park.Id == ParkId)
                    .Fetch(p => p.ZasticeniObjekat);
                IEnumerable<Skulptura> skulpture = session.Query<Skulptura>()
                    .Where(p => p.Park.Id == ParkId)
                    .Fetch(p => p.ZasticeniObjekat);
                foreach (var spomenik in spomenici)
                {
                    objekti.Add(new SkulpturaSpomenikView(spomenik) 
                    {
                        objekat = new ZasticeniObjekatView(spomenik.ZasticeniObjekat)
                    });
                }
                foreach (var skulptura in skulpture)
                {
                    objekti.Add(new SkulpturaSpomenikView(skulptura)
                    {
                        objekat = new ZasticeniObjekatView(skulptura.ZasticeniObjekat)
                    });
                }
                session.Close();
                session.Dispose();
                return objekti;
            }
            catch (Exception ex)
            {
                ExceptionHandler(ex);
                return objekti;
            }
            finally
            {
                if (session != null && session.IsOpen)
                {
                    session.Close();
                    session.Dispose();
                }
            }
        }
        public static IList<OstaloView> GetOstalo(int ParkId)
        {
            List<OstaloView> objekti = new List<OstaloView>();
            ISession session = null;
            try
            {
                session = DataLayer.GetSession();
                IEnumerable<Klupa> klupe = session.Query<Klupa>()
                    .Where(p => p.Park.Id == ParkId);
                IEnumerable<Svetiljka> svetiljke = session.Query<Svetiljka>()
                    .Where(p => p.Park.Id == ParkId);
                IEnumerable<Fontana> fontane = session.Query<Fontana>()
                    .Where(p => p.Park.Id == ParkId);
                foreach (var klupa in klupe)
                {
                    objekti.Add(new OstaloView(klupa));
                }
                foreach (var svetiljka in svetiljke)
                {
                    objekti.Add(new OstaloView(svetiljka));
                }
                foreach (var fontana in fontane)
                {
                    objekti.Add(new OstaloView(fontana));
                }
                session.Close();
                session.Dispose();
                return objekti;
            }
            catch (Exception ex)
            {
                ExceptionHandler(ex);
                return objekti;
            }
            finally
            {
                if (session != null && session.IsOpen)
                {
                    session.Close();
                    session.Dispose();
                }
            }
        }
        public static void AddKlupa(int ParkId)
        {
            ISession session = null;
            try
            {
                session = DataLayer.GetSession();
                session.Save(new Klupa() { Park = session.Load<Park>(ParkId) });
                session.Flush();
                session.Close();
                session.Dispose();
            }
            catch (Exception ex)
            {
                ExceptionHandler(ex);
                return;
            }
            finally
            {
                if (session != null && session.IsOpen)
                {
                    session.Close();
                    session.Dispose();
                }
            }
        }
        public static void AddSvetiljka(int ParkId)
        {
            ISession session = null;
            try
            {
                session = DataLayer.GetSession();
                session.Save(new Svetiljka() { Park = session.Load<Park>(ParkId) });
                session.Flush();
                session.Close();
                session.Dispose();
            }
            catch (Exception ex)
            {
                ExceptionHandler(ex);
                return;
            }
            finally
            {
                if (session != null && session.IsOpen)
                {
                    session.Close();
                    session.Dispose();
                }
            }
        }
        public static void AddFontana(int ParkId)
        {
            ISession session = null;
            try
            {
                session = DataLayer.GetSession();
                session.Save(new Fontana() { Park = session.Load<Park>(ParkId) });
                session.Flush();
                session.Close();
                session.Dispose();
            }
            catch (Exception ex)
            {
                ExceptionHandler(ex);
                return;
            }
            finally
            {
                if (session != null && session.IsOpen)
                {
                    session.Close();
                    session.Dispose();
                }
            }
        }
        public static void AddSpomenik(int ParkId, ZasticeniObjekatView zasticeniObjekatView)
        {
            ISession session = null;
            try
            {
                session = DataLayer.GetSession();
                ZasticeniObjekat zasticeniObjekat = new ZasticeniObjekat()
                {
                    Opis = zasticeniObjekatView.Opis,
                    OdgovornaInstitucija = zasticeniObjekatView.Institucija,
                    DatumStavljanjaPodZastitu = zasticeniObjekatView.StavljenPodZastitu,
                    GodisnjiTroskovi = zasticeniObjekatView.GodTroskovi
                };
                var zo = session.Save(zasticeniObjekat);
                Spomenik spomenik = new Spomenik()
                {
                    Park = new Park() { Id = ParkId },
                    ZasticeniObjekat = new ZasticeniObjekat() { Id = (int)zo },
                };
                session.Save(spomenik);
                session.Flush();
                session.Close();
                session.Dispose();
            }
            catch (Exception ex)
            {
                ExceptionHandler(ex);
                return;
            }
            finally
            {
                if (session != null && session.IsOpen)
                {
                    session.Close();
                    session.Dispose();
                }
            }
        }
        public static void AddSkulptura(int ParkId, ZasticeniObjekatView zasticeniObjekatView)
        {
            ISession session = null;
            try
            {
                session = DataLayer.GetSession();
                ZasticeniObjekat zasticeniObjekat = new ZasticeniObjekat()
                {
                    Opis = zasticeniObjekatView.Opis,
                    OdgovornaInstitucija = zasticeniObjekatView.Institucija,
                    DatumStavljanjaPodZastitu = zasticeniObjekatView.StavljenPodZastitu,
                    GodisnjiTroskovi = zasticeniObjekatView.GodTroskovi
                };
                var zo = session.Save(zasticeniObjekat);
                Skulptura skulptura = new Skulptura()
                {
                    Park = new Park() { Id = ParkId },
                    ZasticeniObjekat = new ZasticeniObjekat() { Id = (int) zo },
                };
                session.Save(skulptura);
                session.Flush();
                session.Close();
                session.Dispose();
            }
            catch (Exception ex)
            {
                ExceptionHandler(ex);
                return;
            }
            finally
            {
                if (session != null && session.IsOpen)
                {
                    session.Close();
                    session.Dispose();
                }
            }
        }
        public static void AddDrvo(int ParkId, DrvoView drvoView, ZasticeniObjekatView? zasticeniObjekatView)
        {
            ISession session = null;
            try
            {
                session = DataLayer.GetSession();
                Park park = session.Load<Park>(ParkId);
                ZasticeniObjekat zasticeniObjekat = null;
                int zo;
                Drvo drvo = new Drvo()
                {
                    Park = park,
                    ObimDebla = drvoView.ObimDebla,
                    DatumSadjenja = drvoView.DatumSadjenja,
                    PovrsinaKrosnje = drvoView.PovrsinaKrosnje,
                    VisinaKrosnje = drvoView.VisinaKrosnje,
                    Vrsta = drvoView.Vrsta
                };
                if (zasticeniObjekatView != null)
                {
                    zasticeniObjekat = new ZasticeniObjekat()
                    {
                        Opis = zasticeniObjekatView.Opis,
                        DatumStavljanjaPodZastitu = zasticeniObjekatView.StavljenPodZastitu,
                        OdgovornaInstitucija = zasticeniObjekatView.Institucija,
                        GodisnjiTroskovi = zasticeniObjekatView.GodTroskovi
                    };
                    zo = (int)session.Save(zasticeniObjekat);
                    drvo.ZasticeniObjekat = new ZasticeniObjekat() { Id = zo };
                }
                
                session.Save(drvo);
                session.Flush();
                session.Close();
                session.Dispose();
            }
            catch (Exception ex)
            {
                ExceptionHandler(ex);
                return;
            }
            finally
            {
                if (session != null && session.IsOpen)
                {
                    session.Close();
                    session.Dispose();
                }
            }
        }
        public static void AddIgraliste(int ParkId, IgralisteView igralisteView)
        {
            ISession session = null;
            try
            {
                session = DataLayer.GetSession();
                Igraliste igraliste = new Igraliste()
                {
                    BrIgracaka = igralisteView.BrIgracaka,
                    GodineOd = igralisteView.GodineOd,
                    GodineDo = igralisteView.GodineDo,
                    ImaPesak = igralisteView.ImaPesak,
                    Park = new Park() { Id = ParkId }
                };
                session.Save(igraliste);
                session.Flush();
                session.Close();
                session.Dispose();
            }
            catch (Exception ex)
            {
                ExceptionHandler(ex);
                return;
            }
            finally
            {
                if (session != null && session.IsOpen)
                {
                    session.Close();
                    session.Dispose();
                }
            }
        }
        public static void DeleteObjekat(int Id)
        {
            ISession session = null;
            try
            {
                session = DataLayer.GetSession();
                Objekat objekat = session.Load<Objekat>(Id);
                session.Delete(objekat);
                session.Flush();
                session.Close();
                session.Dispose();
            }
            catch (Exception ex)
            {
                ExceptionHandler(ex);
                return;
            }
            finally
            {
                if (session != null && session.IsOpen)
                {
                    session.Close();
                    session.Dispose();
                }
            }
        }
        public static void DeleteZasticeniObjekat(int Id)
        {
            ISession session = null;
            try
            {
                session = DataLayer.GetSession();
                ZasticeniObjekat objekat = session.Load<ZasticeniObjekat>(Id);
                session.Delete(objekat);
                session.Flush();
                session.Close();
                session.Dispose();
            }
            catch (Exception ex)
            {
                ExceptionHandler(ex);
                return;
            }
            finally
            {
                if (session != null && session.IsOpen)
                {
                    session.Close();
                    session.Dispose();
                }
            }
        }
        public static IList<DrvoView> GetZasticenoDrvece()
        {
            List<DrvoView> drvece = new List<DrvoView>();
            ISession session = null;
            try
            {
                session = DataLayer.GetSession();
                var data = session.Query<Drvo>()
                    .Where(p => p.ZasticeniObjekat != null)
                    .Fetch(p => p.ZasticeniObjekat);
                foreach (var drvo in data)
                {
                    drvece.Add(new DrvoView(drvo)
                    {
                        objekat = new ZasticeniObjekatView(drvo.ZasticeniObjekat)
                    });
                }
                session.Close();
                session.Dispose();
                return drvece;
            }
            catch (Exception ex)
            {
                ExceptionHandler(ex);
                return drvece;
            }
            finally
            {
                if (session != null && session.IsOpen)
                {
                    session.Close();
                    session.Dispose();
                }
            }
        }
        
        #endregion
    }

}
