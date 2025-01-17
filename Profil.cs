using System.Collections.Generic;

namespace BudgetPlaner
{
    public class Profil
    {
        public string Name { get; set; }
        public decimal Gehalt { get; set; }
        public List<Rechnung> Rechnungen { get; set; }
        public Dictionary<string, decimal> Tagesausgaben { get; set; } = new Dictionary<string, decimal>();
    }
}
