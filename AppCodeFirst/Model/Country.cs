using System.Collections.ObjectModel;

namespace AppCodeFirst.Model;

public class Country
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string NameEn { get; set; }
    public string Code { get; set; }

    //public Collection<Province> Provinces { get; set; }
}
