using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace BudgetPlaner
{
    public static class ProfilSpeicher
    {
        private static readonly string DateiPfad = "profile.json";
        private static readonly string LetztesProfilPfad = "lastUsedProfile.json";

        public static List<Profil> LadeProfile()
        {
            if (!File.Exists(DateiPfad))
                return new List<Profil>();

            var json = File.ReadAllText(DateiPfad);
            return JsonSerializer.Deserialize<List<Profil>>(json) ?? new List<Profil>();
        }

        public static void SpeichereProfile(List<Profil> profile)
        {
            var json = JsonSerializer.Serialize(profile);
            File.WriteAllText(DateiPfad, json);
        }

        public static void AktualisiereProfil(Profil aktualisiertesProfil)
        {
            var alleProfile = LadeProfile();

            var altesProfil = alleProfile.Find(p => p.Name == aktualisiertesProfil.Name);
            if (altesProfil != null)
            {
                alleProfile.Remove(altesProfil);
            }
            alleProfile.Add(aktualisiertesProfil);

            SpeichereProfile(alleProfile);
        }

        public static void SpeichereZuletztVerwendetesProfil(string profilName)
        {
            File.WriteAllText(LetztesProfilPfad, JsonSerializer.Serialize(profilName));
        }

        public static string LadeZuletztVerwendetesProfil()
        {
            if (!File.Exists(LetztesProfilPfad))
                return null;

            var json = File.ReadAllText(LetztesProfilPfad);
            return JsonSerializer.Deserialize<string>(json);
        }
    }
}
