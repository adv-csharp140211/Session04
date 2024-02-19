namespace AppCodeFirst.Model;

public class Province
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int CountryId { get; set; }

    //Navigation Property
    public Country Country { get; set; }
}
